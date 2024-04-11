using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace _0411
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = countryList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var reader = new StreamReader("european_countries.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var x = csv.GetRecords<CountryData>();
                foreach (var item in x)
                {
                    countryList.Add(item);
                }
            }
        }
    }
}