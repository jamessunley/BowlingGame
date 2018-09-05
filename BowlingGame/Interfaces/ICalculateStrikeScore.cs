using System.Collections.Generic;
using BowlingGame.FrameModel;

namespace BowlingGame
{
    public interface ICalculateStrikeScore
    {
        List<FrameObject> CalculateFrameScore(List<FrameObject> frameList);
    }
}