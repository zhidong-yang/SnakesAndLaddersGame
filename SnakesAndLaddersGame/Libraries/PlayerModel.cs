using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersGame.Libraries
{
    public class PlayerModel
    {
        public string Name { get; set; }
        
        Random rdn = new Random();
        public int RollDice()
        {
            int output = 0;
            int num1 = rdn.Next(1, 7);
            int num2 = rdn.Next(1, 7);
            output += num1 + num2;

            while(num1 == num2) 
            {
                Console.WriteLine("You got another chance to roll the dice!");
                num1 = rdn.Next(1,7);
                num2 = rdn.Next(1,7);
                output += num1 + num2;
            }

            return output;
        }
       
    }
}
