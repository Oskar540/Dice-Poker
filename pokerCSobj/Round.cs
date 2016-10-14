using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokerCSobj
{
    public class Round
    {
        public int nr_p;

        public Round()
        {
            Console.WriteLine("Podaj liczbe graczy:");
            nr_p = Int32.Parse(Console.ReadLine());
            Player[] players = new Player[nr_p];
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player();
            }
        }
    }
}