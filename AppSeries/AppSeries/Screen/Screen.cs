using System;

namespace AppSeries.Screen
{
    public static class Screen
    {

        public static void ShowOptions()
        {
            Console.WriteLine("1-Register series");
            Console.WriteLine("2-Remove series");
            Console.WriteLine("3-List series");
            Console.WriteLine("4-Find series");
            Console.WriteLine("5-Change series");
            Console.WriteLine("6-End");
            Console.Write("-> ");
        }

    }
}
