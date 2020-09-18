using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersGame.Libraries
{
    public class ClimbAndSlideDictionary
    {
        Dictionary<int, int> climbAndSlideTo = new Dictionary<int, int>();
        public int SnakeSlideTo(int num)
        {
            switch (num)
            {
                case (16):
                    return 6;
                    break;
                case (46):
                    return 25;
                    break;

                default:
                    break;
            }
        }
    }
}
