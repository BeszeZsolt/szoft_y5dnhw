namespace SzamoloGomb
{
    public partial class Form1 : Form
    {
        int méret = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    Szamolo b = new Szamolo();
                    b.Left = oszlop * méret;
                    b.Top = sor * méret;
                    Controls.Add(b);
                }
            }
        }
    }
}