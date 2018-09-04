using System.Collections.Generic;
using BowlingGame.FrameModel;

namespace BowlingGame
{
    public interface ICalculateScore
    {
        int CalculateTotalScore(List<FrameObject> frame);
    }
}