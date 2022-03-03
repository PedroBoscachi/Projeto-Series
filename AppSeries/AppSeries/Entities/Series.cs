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
        }

        public void RemoveSeries()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            ListSeries.Remove(FindSerieById(id));
        }

        public void ShowSeries()
        {
            foreach(Serie s in ListSeries)
            {
                Console.WriteLine($"Id: {s.Id} - Name: {s.Name} - Launch Year: {s.Year} - Genrer: {s.MovieGenrer}");
            }
            Console.ReadLine();
        }

        public Serie FindSerieById(int id)
        {
            return ListSeries.Find(x => x.Id == id);
        }

        public void FindSeries()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            ShowSerie(FindSerieById(id));
            Console.ReadLine();
        }

        public void ShowSerie(Serie s)
        {
            Console.WriteLine($"Id: {s.Id} - Name: {s.Name} - Launch Year: {s.Year} - Genrer: {s.MovieGenrer}");
        }

        public void ChangeSerie()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("New name: ");
            string name = Console.ReadLine();
            Console.Write("New year: ");
            string year = Console.ReadLine();
            foreach (int i in Enum.GetValues(typeof(SeriesGenrer)))
                Console.WriteLine(i + "-" + Enum.GetName(typeof(SeriesGenrer), i));
            Console.Write("New genrer: ");
            int genrer = int.Parse(Console.ReadLine());
            foreach(Serie s in ListSeries)
            {
                if(s.Id == id)
                {
                    s.Name = name;
                    s.Year = year;
                    s.MovieGenrer = (SeriesGenrer)genrer;
                }
            }
        }
    }
}
