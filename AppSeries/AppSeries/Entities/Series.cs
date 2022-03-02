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

        private bool CheckIfSeriesAlreadyExist(int id)
        {
            //foreach(Serie serie in ListSeries)
            //{
            //    if(serie.Equals(id) == true)
            //    {
            //        return false;
            //    }
            //}
            //return true;

            bool exist = ListSeries.Any(l => l.Id == id);
            if(exist)
            {
                return true;
            }
            return false;
        }

        public void RegisterSeries()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Serie's name: ");
            string name = Console.ReadLine();
            Console.Write("Launch year: ");
            string launchYear = Console.ReadLine();
            Console.WriteLine("Series genrer:");
            foreach (int i in Enum.GetValues(typeof(SeriesGenrer)))
                Console.WriteLine(i + "-" + Enum.GetName(typeof(SeriesGenrer), i));
            Console.Write("Genrer: ");
            int genrer = int.Parse(Console.ReadLine());
            if(CheckIfSeriesAlreadyExist(id) == true)
            {
                Console.WriteLine("The series already exists");
                
            }
            else
            {
                AddSeries(new Serie(id, name, (SeriesGenrer)genrer, launchYear));
            }
            Console.WriteLine("Done!");
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
