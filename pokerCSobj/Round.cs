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
            int first = 0, second = 0, third = 0;
            for (int i = 0; i < nr_p; i++)
            {
                if (first < players[i].sum) first = players[i].sum;
            }
            for (int i = 0; i < nr_p; i++)
            {
                if (first == players[i].sum) players[i].score += 2;
                if (second < players[i].sum && first > players[i].sum) second = players[i].sum;
            }
            for(int i = 0; i < nr_p; i++)
            {
                if (second == players[i].sum) players[i].score += 1;
                if (third < players[i].sum && first > players[i].sum) third = players[i].sum;
            }
            for(int i = 0; i < nr_p; i++)
            {
                if (third > players[i].sum) players[i].score -= 1;
            }
        }
    }
}