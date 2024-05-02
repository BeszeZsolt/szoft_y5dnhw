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

            Color c = Color.White;

            Pen toll = new Pen(c, 1);
            Brush brush = new SolidBrush(c);
            //g.DrawLine(toll, 10, 10, 10, 10);


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
        }
    }
}