namespace Pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int m = 40;
            int szint = 10;
            for (int sor = 0; sor < szint; sor++)
            {
                for (int oszlop = 0; oszlop < sor+1; oszlop++)
                {
                    Button button = new Button();
                    Controls.Add(button);
                    button.Left = oszlop*m+(szint-sor+1)*m/2;
                    button.Top = sor*m;
                    button.Height = m;
                    button.Width = m;
                    int x = Faktori�lis(sor)/(Faktori�lis(oszlop)*Faktori�lis(sor-oszlop));
                    button.Text = x.ToString();
                }
            }
        }

        int Faktori�lis(int n)
        {
            if (n == 0) return 1;
            return n * Faktori�lis(n - 1);
        }
    }
}