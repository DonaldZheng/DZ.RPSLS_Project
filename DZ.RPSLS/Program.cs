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
            Battlefield battlefield = new Battlefield();
            battlefield.DisplayRules();
            Console.ReadLine();
        }
    }
}
