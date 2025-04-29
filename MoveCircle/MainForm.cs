namespace MoveCircle
{
    public partial class MainForm : Form
    {
        private Bitmap? canvas;

        private string correnctText = "荻";

        private Ball balls;

        private string fontName;

        private double nowTime = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DrawCircleSelectPictureBox();
            DrawMainPictureBox(Brushes.Gray, correnctText);
            textHunt.Text = correnctText;
            fontName = textHunt.Font.Name;
            balls = new Ball(mainPictureBox, canvas, Brushes.LightBlue, correnctText, fontName);
            balls.PutCircle(100, 100);
            nowTime = 0;
            timer.Start();
        }

        private void selectPictureBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void restartButton_Click(object sender, EventArgs e)
        {

        }

        private void mainPictureBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            balls.Move();
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
                g.FillEllipse(Brushes.LightBlue, 0, 0, height, height);
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
