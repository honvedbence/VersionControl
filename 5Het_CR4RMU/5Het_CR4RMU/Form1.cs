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
        }


        private void GetExchange()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };


            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            data
        }
    }
}
