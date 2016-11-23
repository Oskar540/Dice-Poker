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
            Console.WriteLine("Enter the number of players");
            nr_p = Int32.Parse(Console.ReadLine());
            Player[] players = new Player[nr_p];
            for (int i = 0, j = 1; i < players.Length; i++)
            {
                players[i] = new Player(j);
                j++;
            }
        }
        public void win()
        {
            int ctrl = 5;
            for (int i = 0; i < nr_p; i++)
            {
                if(ctrl < players[i].sum)
                {

                }
            }
        }
    }
}