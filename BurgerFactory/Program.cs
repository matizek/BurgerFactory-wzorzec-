using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFactory
{
    class Program
    {
        static void Main(string[] args)
        {
          FabrykaAbstrakcyjna polskafabryka = new PolskaFabryka();
          Klient klient1 = new Klient(polskafabryka);

          Console.ForegroundColor = ConsoleColor.Cyan;
          Console.WriteLine("Polska Fabryka");
          Console.WriteLine("-------------------------------------");

          Console.WriteLine(klient1.ToString());

          Console.WriteLine("-------------------------------------");
          Console.WriteLine();
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine("Niemiecka Fabryka");
          Console.WriteLine("-------------------------------------");

          FabrykaAbstrakcyjna niemieckafabryka = new NiemieckaFabryka();
          Klient klient2 = new Klient(niemieckafabryka);
          Console.WriteLine(klient2.ToString());
          Console.WriteLine("-------------------------------------");


          Console.ReadKey();
        }
    }
}
