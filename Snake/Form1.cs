namespace Snake
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;
        int Lszám = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lszám++;

            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;

            KígyóElem ke = new KígyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }
            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}