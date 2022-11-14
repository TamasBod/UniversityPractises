using System.IO;
using System.Text;

namespace LINQ_Practise
{
    public partial class Form1 : Form
    {
        private List<Country> _countries = new List<Country>();
        private List<Ramen> _ramens = new List<Ramen>();
        public Form1()
        {
            InitializeComponent();
            Loaddata("ramen.csv");
            AddCountry("ramen.csv");
        }

        private void Loaddata(string filename)
        {
            using (StreamReader sr = new StreamReader(filename, Encoding.Default))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');

                    var countryName = line[2];
                    AddCountry(countryName);
                }
            }
        }


        private void AddCountry(string countryName)
        {
            var currentCountry = (from c in _countries
                                  where c.Name.Equals(countryName)
                                  select c).FirstOrDefault();
            if (currentCountry == null)
            {
                currentCountry = new Country()
                {
                    ID = _countries.Count + 1,
                    Name = countryName
                };
                _countries.Add(currentCountry);
            }
        }

       
    }
}