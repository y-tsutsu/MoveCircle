using System.Diagnostics;

namespace MoveCircle
{
    public partial class MainForm : Form
    {
        private Bitmap? canvas;

        private readonly string correctText = "荻";

        private readonly string mistakeText = "萩";

        private Ball[]? balls;

        private string[]? texts;

        private readonly Brush[] ballColors = [Brushes.LightPink, Brushes.LightBlue, Brushes.LightGray, Brushes.LightCoral, Brushes.LightGreen];

        private string? fontName;

        private double nowTime = 0;

        private readonly int ballCount = 5;

        private int randomResult = 0;

        private const int BallOffset = 10;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DrawCircleSelectPictureBox();
            DrawMainPictureBox(Brushes.Gray, correctText);
            Debug.Assert(canvas is not null);
            textHunt.Text = correctText;
            fontName = textHunt.Font.Name;
            balls = new Ball[ballCount];
            texts = new string[ballCount];
            for (int i = 0; i < ballCount; i++)
            {
                texts[i] = mistakeText;
            }
            randomResult = new Random().Next(ballCount);
            texts[randomResult] = correctText;
            for (int i = 0; i < ballCount; i++)
            {
                balls[i] = new Ball(mainPictureBox, canvas, ballColors[i], texts[i], fontName);
            }
            foreach (var ball in balls)
            {
                ball.PutCircle(new Random().Next(mainPictureBox.Width), new Random().Next(mainPictureBox.Height));
            }
            nowTime = 0;
            timer.Start();
        }

        private void SelectPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            int selectCircle = (e.X - BallOffset) / selectPictureBox.Height;
            if (selectCircle == randomResult)
            {
                timer.Stop();
                DrawMainPictureBox(Brushes.Red, "〇");
            }
            else
            {
                if (balls == null) return;
                foreach (var ball in balls)
                {
                    ball.Pitch /= 2;
                }
                nowTime += 10;
                DrawMainPictureBox(Brushes.Red, correctText);
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            canvas = null;
            MainForm_Load(sender, e);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (balls == null) return;
            foreach (var ball in balls)
            {
                ball.Move();
            }
            nowTime += 0.02;
            textTimer.Text = nowTime.ToString("0.00");
        }

        private void DrawCircleSelectPictureBox()
        {
            var height = selectPictureBox.Height;
            var width = selectPictureBox.Width;
            var selectCanvas = new Bitmap(width, height);
            using (var g = Graphics.FromImage(selectCanvas))
            {
                for (int i = 0; i < ballCount; i++)
                {
                    g.FillEllipse(ballColors[i], i * height + BallOffset, 0, height, height);
                }
            }
            selectPictureBox.Image = selectCanvas;
        }

        private void DrawMainPictureBox(Brush color, string text)
        {
            canvas ??= new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
            using (var g = Graphics.FromImage(canvas))
            {
                g.DrawString(text, new Font(textHunt.Font.FontFamily, mainPictureBox.Height / 2),
                             color, mainPictureBox.Width / 4, 0);
            }
            mainPictureBox.Image = canvas;
        }
    }
}
