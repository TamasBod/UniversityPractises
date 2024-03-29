using System.IO;
using System.Text;

namespace LINQ_Practise
{
    public partial class Form1 : Form
    {
        private List<Country> countries = new List<Country>();
        private List<Ramen> ramens = new List<Ramen>();

        public Form1()
        {
            InitializeComponent();
            LoadData("ramen.csv");
            AddCountry("ramen.csv");
            listCountries.DisplayMember = "Name";
            GetCountries();
        }

        private void LoadData(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName, Encoding.Default))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');

                    var countryName = line[2];
                    var country = AddCountry(countryName);

                    var ramen = new Ramen()
                    {
                        ID = ramens.Count + 1,
                        Brand = line[0],
                        Name = line[1],
                        CountryFK = country.ID,
                        Country = country,
                        Stars = Convert.ToDouble(line[3])
                    };
                    ramens.Add(ramen);
                }
            }
        }

        private Country AddCountry(string countryName)
        {
            var currentCountry = (from c in countries
                                  where c.Name.Equals(countryName)
                                  select c).FirstOrDefault();
            if (currentCountry == null)
            {
                currentCountry = new Country()
                {
                    ID = countries.Count + 1,
                    Name = countryName
                };
                countries.Add(currentCountry);
            }

            return currentCountry;
        }
        private void GetCountries()
        {
            var countriesList = from c in countries
                                where c.Name.Contains(txtCountryFilter.Text)
                                orderby c.Name
                                select c;
            listCountries.DataSource = countriesList.ToList();
        }
        private void txtCountryFilter_TextChanged(object sender, EventArgs e)
        {
            GetCountries();
        }
        private void listCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            var country = (Country)((ListBox)sender).SelectedItem;
            if (country == null)
                return;

            var countryRamens = from r in ramens
                                where r.CountryFK == country.ID
                                select r;

            var groupedRamens = from r in countryRamens
                                group r.Stars by r.Brand into g
                                select new
                                {
                                    BrandName = g.Key,
                                    AverageRating = Math.Round(g.Average(), 2)
                                };

            var orderedGroups = from g in groupedRamens
                                orderby g.AverageRating descending
                                select g;

            dgwRamen.DataSource = orderedGroups.ToList();
        }


    }
}