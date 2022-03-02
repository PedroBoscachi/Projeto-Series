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
                CallMethod(option);
                Console.ReadLine();
            } while (end = false);
        }

        static void CallMethod(int option)
        {
            switch(option)
            {
                case 1:
                    series.RegisterSeries();
                    break;
                case 2:
                    break;
                case 3:
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
