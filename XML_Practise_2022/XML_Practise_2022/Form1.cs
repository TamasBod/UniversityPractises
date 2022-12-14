using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using XML_Practise_2022.Entities;
using XML_Practise_2022.MnbServiceReference;

namespace XML_Practise_2022
{
    public partial class Form1 : Form
    {
        BindingList<RateData> rates = new BindingList<RateData>();

        public Form1()
        {
            InitializeComponent();
            loadXml(getRates());
            dataGW1.DataSource = rates;

        }

        private void loadXml(string xmlstring)
        {
            //XmlDocument xml = new XmlDocument();
            //xml.LoadXml(xmlstring);

            //foreach (XmlElement element in xml.DocumentElement)
            //{

            //    var rate = new RateData();
            //    rates.Add(rate);


            //    rate.Date = DateTime.Parse(element.GetAttribute("date"));

            //    var childElement = (XmlElement)element.ChildNodes[0];
            //    rate.Currency = childElement.GetAttribute("curr");

            //    var unit = decimal.Parse(childElement.GetAttribute("unit"));
            //    var value = decimal.Parse(childElement.InnerText);
            //    if (unit != 0)
            //        rate.Value = value / unit;
            //}


            XmlDocument xml = new XmlDocument();
                xml.LoadXml(xmlstring);

                foreach (XmlElement item in xml.DocumentElement)
                {
                    RateData rate = new RateData();
                    rate.Date = DateTime.Parse(item.GetAttribute("date"));
                    var childElement = (XmlElement)item.ChildNodes[0];
                    rate.Currency = childElement.GetAttribute("curr");
                    decimal unit = decimal.Parse(childElement.GetAttribute("unit"));
                    rate.Value = decimal.Parse(childElement.InnerText);
                    if (unit != 0)
                    rate.Value = rate.Value / unit;

                    rates.Add(rate);
                }

                



        }

        private string getRates()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mnbService.GetExchangeRates(request);
            return response.GetExchangeRatesResult;
            //File.WriteAllText("Teszt.xml", result);
        }





    }
}
