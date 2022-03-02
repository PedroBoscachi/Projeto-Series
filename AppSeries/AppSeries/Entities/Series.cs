using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSeries.Enums;
using System.Globalization;

namespace AppSeries.Entities
{
    class Series
    {
        List<Serie> ListSeries;

        public Series()
        {
            ListSeries = new List<Serie>();
        }

        private void AddSeries(Serie serie)
        {
            ListSeries.Add(serie);
        }

        public void RegisterSeries()
        {
            Console.Write("Serie's name: ");
            string name = Console.ReadLine();
            Console.Write("Launch year: ");
            string launchYear = Console.ReadLine();
            Console.WriteLine("Series genrer:");
            foreach (int i in Enum.GetValues(typeof(SeriesGenrer)))
                Console.WriteLine(i + "-" + Enum.GetName(typeof(SeriesGenrer), i));
            Console.Write("Genrer: ");
            string seriesGenrer = Console.ReadLine();
        }

        public void RemoveSeries(Serie serie)
        {
            ListSeries.Remove(serie);
        }

        //public Serie FindSerieById()
        //{

        //}
    }
}
