using System.Collections.Generic;
using BowlingGame.FrameModel;

namespace BowlingGame
{
    public interface ICalculateSpareScore
    {
        List<FrameObject> CalculateFrameScore(List<FrameObject> frameList);
    }
}