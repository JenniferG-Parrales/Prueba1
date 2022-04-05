using AppCore.Interface;
using AppCore.Services;
using Autofac;
using Domain.Interface;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAPP
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var builder = new ContainerBuilder();
            builder.RegisterType<JsonWeatherRepository>().As<IModel>();
            builder.RegisterType<WatherService>().As<IWeatherService>();
            var container = builder.Build();
            Application.Run(new Form1(container.Resolve<IWeatherService>()));
        }
    }
}
