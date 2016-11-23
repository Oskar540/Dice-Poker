using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokerCSobj
{
    public class Player
    {
        public int score, sum, nr;
        public Dice[] dices;

        public Player(int number)
        {
            score = 0;
            nr = number;
            Console.WriteLine("Player number: {0}", nr);
            score = 0;
            dices = new Dice[5];
            for (int i = 0; i < dices.Length; i++) dices[i] = new Dice();
            Console.WriteLine("The sum of the player: {0}", sum = Sum());
            if (chose() == true)
            {
                Console.WriteLine("How many?");
                int test = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < test; i++)
                {
                    reroll();
                }
                Console.WriteLine("Suma gracza: {0}", sum = Sum());
                Console.ReadKey();
            }
            Console.Clear();
        }
        public bool chose()
        {
            Console.WriteLine("[Y] / [N]");
            char chs = char.Parse(Console.ReadLine());
            if (chs == 'Y' || chs == 'y') return true;
            else if (chs == 'N' || chs == 'n') return false;
            else return false;
        }
        public void reroll()
        {
            Console.WriteLine("Which dice?");
            dices[Int32.Parse(Console.ReadLine()) - 1] = new Dice();
            Console.WriteLine();
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < dices.Length; i++) sum += dices[i].vault;
            return sum;
        }
    }
}