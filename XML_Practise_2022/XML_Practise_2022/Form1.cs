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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using XML_Practise_2022.Entities;
using XML_Practise_2022.MnbServiceReference;

namespace XML_Practise_2022
{
    public partial class Form1 : Form
    {
        BindingList<RateData> rates = new BindingList<RateData>();
        BindingList<string> currencies = new BindingList<string>();  

        public Form1()
        {
            InitializeComponent();
            LoadCurrencyxml(getcurrencies());
            RefreshData();
            cmbValuta.DataSource = currencies;
            
        }
        
        private void RefreshData()
        {
            if (cmbValuta.SelectedItem == null) return;

            rates.Clear();
            loadXml(getRates());
            dataGW1.DataSource = rates;
            Chart();
        }

        private void Chart()
        {
            chartRateData.DataSource = rates;
            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;

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
            GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody();




            request.currencyNames = cmbValuta.SelectedItem.ToString();
            request.startDate = dateTimePickerFrom.Value.ToString("yyyy-MM-dd"); //"2020-01-01",
            request.endDate = dateTimePicker2To.Value.ToString("yyyy-MM-dd"); //"2020-06-30"
            

            var response = mnbService.GetExchangeRates(request);
            return response.GetExchangeRatesResult;

            //File.WriteAllText("Teszt.xml", result);
        }


        private string getcurrencies()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            GetCurrenciesRequestBody req = new GetCurrenciesRequestBody();
            var response = mnbService.GetCurrencies(req);

            //string result = response.GetCurrenciesResult;
            //File.WriteAllText("currecncy.xml", result);

            return response.GetCurrenciesResult;
        }

        private void LoadCurrencyxml(string xmlstring)
        {
            currencies.Clear();

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlstring);
            foreach (XmlElement item in xml.DocumentElement.ChildNodes[0])
            {
                string s = item.InnerText;
                currencies.Add(s);
            }
        }


        private void Refresh(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
