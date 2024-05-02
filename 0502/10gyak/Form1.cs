using _10gyak.Models;

namespace _10gyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            g.Clear(Color.Black);

            Pen pen = new Pen(Color.AntiqueWhite, 1);
            Brush brush = new SolidBrush(Color.White);


            hajosContext context = new hajosContext();

            var stars = (from s in context.StarData select new { s.Hip, s.X, s.Y, s.Magnitude }).ToList();
            float nagyítás = 300;
            int cx = ClientRectangle.Width / 2;
            int cy = ClientRectangle.Height / 2;

            foreach (var s in stars)
            {
                if (s.Magnitude > 6) continue;
                if (Math.Sqrt(Math.Pow(s.X, 2) + Math.Pow(s.Y, 2)) > 1) continue;
                float x = ((float)s.X * nagyítás + cx);
                float y = ((float)s.Y * nagyítás + cy);
                double size = 20*Math.Pow(10, s.Magnitude / -2.5);

                g.FillEllipse(brush, x, y, (float)size, (float)size);
            }

            var lines = context.ConstellationLines.ToList();

            foreach (var l in lines)
            {

                var star1 = (from s in stars where s.Hip == l.Star1 select s).FirstOrDefault();
                var star2 = (from s in stars where s.Hip == l.Star2 select s).FirstOrDefault();

                if (star1==null || star2==null) continue;
                if ((Math.Sqrt(Math.Pow(star1.X, 2) + Math.Pow(star1.Y, 2)) > 1) &
                    (Math.Sqrt(Math.Pow(star2.X, 2) + Math.Pow(star2.Y, 2)) > 1)) continue;
                float star1x = ((float)star1.X * nagyítás + cx);
                float star1y = ((float)star1.Y * nagyítás + cy);
                float star2x = ((float)star2.X * nagyítás + cx);
                float star2y = ((float)star2.Y * nagyítás + cy);


                g.DrawLine(pen, star1x, star1y, star2x, star2y);
            }
        }
    }
}