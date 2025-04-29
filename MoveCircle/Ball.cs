using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveCircle
{
    internal class Ball(PictureBox pb, Bitmap cv, Brush cl, string st, string fn)
    {
        private const int radius = 40;

        private readonly string text = st;

        private readonly string fontName = fn;

        private readonly Brush brushColor = cl;

        private readonly PictureBox pictureBox = pb;

        private readonly Bitmap canvas = cv;

        private Point position = new(0, 0);

        private Point previous = new(0, 0);

        private Point direction = new(1, 1);

        public int Pitch { get; set; } = radius / 2;

        public void PutCircle(int x, int y)
        {
            position.X = x;
            position.Y = y;
            using (var g = Graphics.FromImage(canvas))
            {
                g.FillEllipse(brushColor, x, y, radius * 2, radius * 2);
                g.DrawString(text, new Font(fontName, radius), Brushes.Black, x + 4, y + 4, new StringFormat());
            }
            pictureBox.Image = canvas;
        }

        private void DeleteCircle()
        {
            previous = (previous == new Point(0, 0)) ? position : previous;
            using (var g = Graphics.FromImage(canvas))
            {
                g.FillEllipse(Brushes.White, previous.X, previous.Y, radius * 2, radius * 2);
            }
            pictureBox.Image = canvas;
        }

        public void Move()
        {
            DeleteCircle();
            var x = position.X + Pitch * direction.X;
            var y = position.Y + Pitch * direction.Y;
            if (x >= pictureBox?.Width - radius * 2)
            {
                direction.X = -1;
            }
            if (x <= 0)
            {
                direction.X = 1;
            }
            if (y >= pictureBox?.Height - radius * 2)
            {
                direction.Y = -1;
            }
            if (y <= 0)
            {
                direction.Y = 1;
            }
            position.X = x + direction.X;
            position.Y = y + direction.Y;
            PutCircle(position.X, position.Y);
            previous = position;
        }
    }
}
