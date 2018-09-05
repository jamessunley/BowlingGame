using System.Collections.Generic;
using BowlingGame.FrameModel;

namespace BowlingGame
{
    public class DetermineAdditionalBowls : IDetermineAdditionalBowls
    {
        public int determineAdditionalBowls(List<FrameObject> frameList)
        {
            if(frameList[9].wasStrike)
            {
                return 2;
            }
            if (frameList[9].wasSpare)
            {
                return 1;
            }
            return 0;
        }
    }
}