using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ.RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game battlefield = new Game();
            battlefield.DisplayRules();
            Console.ReadLine();
        }
    }
}
