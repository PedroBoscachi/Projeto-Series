using System;
using AppSeries.Entities;
using AppSeries.Enums;
using AppSeries.Screen;

namespace AppSeries
{
    class Program
    {

        static Series series = new Series();

        static void Main(string[] args)
        {

            bool end = false;
            do
            {
                Screen.Screen.ShowOptions();
                int option = int.Parse(Console.ReadLine());
                if(option == 6)
                {
                    end = true;
                    break;
                }
                CallMethod(option);
                Console.Clear();
            } while (end == false);
        }

        static void CallMethod(int option)
        {
            switch(option)
            {
                case 1:
                    series.RegisterSeries();
                    break;
                case 2:
                    series.RemoveSeries();
                    break;
                case 3:
                    series.ShowSeries();
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
