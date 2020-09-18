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
        public int[] RollDice()
        {
            int[] output = new int[2];
            output[0] = rdn.Next(1, 7);
            output[1] = rdn.Next(1, 7);

            return output;
        }
    }
}
