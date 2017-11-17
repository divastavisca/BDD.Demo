using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Game
    {
        public int TotalScore { get; private set; }
        public bool IsFinished { get; private set; }

        public Game()
        {
            TotalScore = 0;
            IsFinished = false;
        }
        public void Score(int v)
        {
            if (!IsFinished)
            {
                if (v >= 0)
                {
                    TotalScore += v;
                }
                if (v == -1)
                {
                    IsFinished = true;
                }
            }
        }
    }
}
