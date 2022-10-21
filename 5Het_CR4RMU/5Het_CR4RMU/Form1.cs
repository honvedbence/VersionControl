using _5Het_CR4RMU.Entities;
using _5Het_CR4RMU.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _5Het_CR4RMU
{
    public partial class Form1 : Form
    {


        BindingList<RateData> Rates = new BindingList<RateData>();
        

        public Form1()
        {
            InitializeComponent();
            GetExchange();
            dataGridView1.DataSource = Rates;
            ProcessData();
        }


        private string GetExchange()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };


            var response = mnbService.GetExchangeRates(request);

            string result = response.GetExchangeRatesResult;

            return result;
        }

        private void ProcessData()
        {
            var xml = new XmlDocument();
            xml.LoadXml(GetExchange());

            foreach (XmlElement element in xml.DocumentElement)
            {
                
                var rate = new RateData();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                var childElement = (XmlElement)element.ChildNodes[0];
                rate.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
