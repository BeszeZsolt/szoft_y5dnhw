namespace HajosTeszt
{
    public partial class Form1 : Form
    {
        List<K�rd�s> �sszesK�rd�s;
        List<K�rd�s> Aktu�lisK�rd�sek;
        int Aktu�lisK�rd�s = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            �sszesK�rd�s = K�rd�sBet�lt�s();
            Aktu�lisK�rd�sek = new List<K�rd�s>();
            for (int i = 0; i < 7; i++)
            {
                Aktu�lisK�rd�sek.Add(�sszesK�rd�s[0]);
                �sszesK�rd�s.RemoveAt(0);

            }
            dataGridView1.DataSource = Aktu�lisK�rd�sek;
        }
        List<K�rd�s> K�rd�sBet�lt�s()
        {
            List<K�rd�s> k�rd�sek = new List<K�rd�s>();

            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] t�mb = sor.Split("\t");

                K�rd�s k = new K�rd�s();
                k.K�rd�sSz�veg = t�mb[1];
                k.V�lasz1 = t�mb[2];
                k.V�lasz2 = t�mb[3];
                k.V�lasz3 = t�mb[4];
                k.URL = t�mb[5];

                int helyesv�lasz = 0;
                int.TryParse(t�mb[6], out helyesv�lasz);
                k.HelyesV�lasz = helyesv�lasz;

                k�rd�sek.Add(k);
            }
            sr.Close();


            return k�rd�sek;
        }
    }
}