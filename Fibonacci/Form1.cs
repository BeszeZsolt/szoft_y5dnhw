namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> lista = new List<Sor>();

            for (int i = 0; i < 10; i++)
            {

                Button button = new Button();
                button.Text = Fibonacci(i).ToString();
                button.Top = i * 20;
                Controls.Add(button);

                Sor újsor = new Sor();
                újsor.Érték = Fibonacci(i);
                újsor.Sorszám = i;
                lista.Add(újsor);
            }
            dataGridView1.DataSource = lista;
        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}