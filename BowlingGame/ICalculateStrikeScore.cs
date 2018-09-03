using System.Collections.Generic;
using BowlingGame.FrameModel;

namespace BowlingTestProject
{
    public interface ICalculateStrikeScore
    {
        List<FrameObject> CalculateFrameScore(List<FrameObject> frameList);
    }
}