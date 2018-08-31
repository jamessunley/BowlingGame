using System.Collections.Generic;
using BowlingGame.FrameModel;

namespace BowlingGame
{
    public class CalculateScore : ICalculateScore
    {
        public int CalculateTotalScore(List<FrameObject> frames)
        {
            int total = 0;
            foreach(var frame in frames)
            {
                total += frame.score;
            }
            return total;
        }
    }
}