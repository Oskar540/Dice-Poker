using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokerCSobj
{
    public class Player
    {
        public int score, sum;
        public Dice[] dices;

        public Player()
        {
            
            Console.WriteLine("Gracz nr x");
            score = 0;
            dices = new Dice[5];
            for (int i = 0; i < dices.Length; i++) dices[i] = new Dice();
            for (int i = 0; i < dices.Length; i++) sum += dices[i].vault;
            Console.WriteLine("Suma gracza: {0}", sum);
        } 
    }
}