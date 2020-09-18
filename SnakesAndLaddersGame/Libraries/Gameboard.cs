using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersGame.Libraries
{
    public class Gameboard
    {
        int[] SnakeHeads = { 16, 46, 49, 62, 64, 74, 89, 92, 95, 99 };
        int[] LadderFoots = { 2, 7, 8, 15, 21, 28, 36, 51, 71, 78, 87 };

        public int GameboardCells(int num)
        {
            Dictionary<int, int> cellStopAt = new Dictionary<int, int>();
            if (SnakeHeads.Contains(num))
            {
                cellStopAt[16] = 6;
                cellStopAt[46] = 25;
                cellStopAt[49] = 11;
                cellStopAt[62] = 19;
                cellStopAt[64] = 60;
                cellStopAt[74] = 53;
                cellStopAt[89] = 68;
                cellStopAt[92] = 88;
                cellStopAt[95] = 75;
                cellStopAt[99] = 80;
            }
            else if (LadderFoots.Contains(num))
            {
                cellStopAt[2] = 38;
                cellStopAt[7] = 14;
                cellStopAt[8] = 31;
                cellStopAt[15] = 26;
                cellStopAt[21] = 42;
                cellStopAt[28] = 84;
                cellStopAt[36] = 44;
                cellStopAt[51] = 67;
                cellStopAt[71] = 91;
                cellStopAt[78] = 98;
                cellStopAt[87] = 94;
            }
            else
            {
                cellStopAt[num] = num;
            }

            return cellStopAt[num];
        }
    }
}
