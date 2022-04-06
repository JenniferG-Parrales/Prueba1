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
                var root = weatherService.GetWeather(textBox1.Text);
                pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + root.weather[0].Icon + ".png";
                lblCondition.Text = root.weather[0].Main;
                lblDetails.Text = root.weather[0].Description;
                lblSunrise.Text = converttt(root.sys.Sunrise).ToShortTimeString();
                lblSunset.Text = converttt(root.sys.Sunset).ToShortTimeString();
                lblPessure.Text = root.main.Pressure.ToString();
                lblWind.Text = root.wind.Speed.ToString();
                lblTemp.Text = (root.main.Temp - 273).ToString() + " C°";
       
                lbl4MinTem.Text = (root.main.Temp_Max - 273).ToString() + "°C";
                lbl5MaxTem.Text = (root.main.Temp_Min - 273).ToString() + "°C";
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("La ciudad no fue encontrada.");
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

        private void lbl2MinimumTem_Click(object sender, EventArgs e)
        {

        }

        private void lbl4MinTem_Click(object sender, EventArgs e)
        {

        }

        private void lbl3MaximumTem_Click(object sender, EventArgs e)
        {

        }

        private void lbl5MaxTem_Click(object sender, EventArgs e)
        {

        }
    }
}
