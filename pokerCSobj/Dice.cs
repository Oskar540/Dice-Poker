using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokerCSobj
{
    public class Dice
    {
        public int vault;
        Random rnd = new Random();

        public Dice()
        {
            vault = rnd.Next(1, 7);
            System.Threading.Thread.Sleep(10);
            Console.Write("[ {0} ]", vault);
        }
    }
}
