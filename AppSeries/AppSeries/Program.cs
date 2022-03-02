using System;
using AppSeries.Entities;
using AppSeries.Enums;
using AppSeries.Screen;

namespace AppSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Series series = new Series();
            Screen.Screen.ShowOptions();
        }
    }
}
