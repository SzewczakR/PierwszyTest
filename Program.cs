using System;
using System.Linq;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kraje = {"USA", "usa", "UK", "uk", "Poland" };
            var kr = kraje.Distinct(StringComparer.OrdinalIgnoreCase);

            foreach(var vvv in kr)
            {
                Console.WriteLine(vvv);
            }
        }
    }
}
