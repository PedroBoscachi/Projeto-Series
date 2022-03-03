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
                try 
                { 
                    Screen.Screen.ShowOptions();
                    int option = int.Parse(Console.ReadLine());
                    if (option == 6)
                    {
                        end = true;
                        break;
                    }
                    CallMethod(option);
                    Console.Clear();
                }catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
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
                    series.FindSeries();
                    break;
                case 5:
                    series.ChangeSerie();
                    break;
                case 6:
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
