using System.Collections.Generic;
using BowlingGame.FrameModel;

namespace BowlingGame
{
    public class CalculateSpareScore : ICalculateSpareScore
    {
        List<FrameObject> ICalculateSpareScore.CalculateFrameScore(List<FrameObject> frameList)
        {
            int spareScore = frameList[frameList.Count -2].score + frameList[frameList.Count - 1].bowl1;
            frameList[frameList.Count - 2].score = spareScore;
            return frameList;
        }
    }
}