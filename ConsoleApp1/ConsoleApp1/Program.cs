using System;
using MyClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Tank tank1 = new Tank("T-34");
            Tank tank2 = new Tank("Pantera");

            Console.WriteLine(tank1.GetTankStatus());
            Console.WriteLine(tank2.GetTankStatus());
            string battleResult = tank1 * tank2;
            Console.WriteLine(battleResult);
        }
    }
}
