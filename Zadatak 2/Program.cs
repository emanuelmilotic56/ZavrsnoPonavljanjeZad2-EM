using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int UneseneSekunde, minute, sekunde;

            Console.WriteLine("Unesi broj sekundi:");

             UneseneSekunde = Convert.ToInt32(Console.ReadLine());

            minute = UneseneSekunde / 60;

            sekunde = UneseneSekunde % 60;

            Console.WriteLine("Broj minuta =" + minute);



            Console.WriteLine("Broj sekunda =" + sekunde);

            Console.ReadKey();
            
            
            
        }
    }
}
