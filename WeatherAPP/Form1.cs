using AppCore.Interface;
using Domain.Entities.Weather;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAPP
{
    public partial class Form1 : Form
    {
        IWeatherService weatherService;
        public Form1(IWeatherService  weatherService)
        {
            this.weatherService = weatherService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

           
            Root x = weatherService.GetWeather(textBox1.Text);
            
            lblCondition.Text = x.weather[0].Main;
            lblDetails.Text = x.weather[0].Description;
            lblSunrise.Text = converttt(x.sys.Sunrise).ToShortTimeString();
            lblSunset.Text = converttt(x.sys.Sunset).ToShortTimeString();
            lblPessure.Text = x.main.Preasure.ToString();
            lblWind.Text = x.wind.Speed.ToString();
            pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + x.weather[0].Icon + ".png";

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Esta ciudad no fue encontrada.");
            }



        }
        DateTime converttt(long x)
        {
            DateTime time = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            time = time.AddSeconds(x).ToLocalTime();
            return time;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCondition_Click(object sender, EventArgs e)
        {

        }
    }
}
