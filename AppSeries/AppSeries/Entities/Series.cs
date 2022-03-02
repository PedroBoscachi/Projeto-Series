using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSeries.Enums;

namespace AppSeries.Entities
{
    class Series
    {
        List<Serie> ListSeries;

        public Series()
        {
            ListSeries = new List<Serie>();
        }

        public void AddSeries(Serie serie)
        {
            ListSeries.Add(serie);
        }

        public void RegisterSeries()
        {
            Console.Write("Serie's name: ");
            string name = Console.ReadLine();
            Console.Write("Launch year: ");
            DateTime launchYear = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Series genrer:");
            foreach (int i in Enum.GetValues(typeof(SeriesGenrer)))
                Console.WriteLine(i);
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
