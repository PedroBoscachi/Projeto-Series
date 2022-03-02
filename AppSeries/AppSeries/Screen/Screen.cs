using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSeries.Screen
{
    class Screen
    {
        public void ShowScreen()
        {
            bool choice = true;

            do
            {
                ShowOptions();
                int option = int.Parse(Console.ReadLine());
                CallMethod(option);
            } while (choice = true);
        }

        public void ShowOptions()
        {
            Console.WriteLine("1-Register series");
            Console.WriteLine("2-Remove series");
            Console.WriteLine("3-List series");
            Console.WriteLine("4-Find series");
            Console.WriteLine("5-Change series");
            Console.WriteLine("6-End");
        }

        public void CallMethod(int option)
        {

        }
    }
}
