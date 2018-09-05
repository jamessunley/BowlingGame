using System.Collections.Generic;
using BowlingGame.FrameModel;

namespace BowlingGame
{
    public interface IDetermineAdditionalBowls
    {
        int determineAdditionalBowls(List<FrameObject> frameList);
    }
}