using System.Collections.Generic;
using BowlingGame.FrameModel;

namespace BowlingTestProject
{
    public class CalculateStrikeScore : ICalculateStrikeScore
    {
        public List<FrameObject> CalculateFrameScore(List<FrameObject> frameList)
        {
            if (frameList.Count - 3 < 0)
            {
                int strikeScore = frameList[frameList.Count - 2].score + frameList[frameList.Count - 1].score;
                frameList[frameList.Count - 2].score = strikeScore;
                return frameList;
            }
            if (frameList[frameList.Count - 3].wasStrike && frameList[frameList.Count - 2].wasStrike)
            {
                int strikeScore1 = frameList[frameList.Count - 3].score + frameList[frameList.Count - 2].score + frameList[frameList.Count - 1].bowl1;
                frameList[frameList.Count - 3].score = strikeScore1;
                return frameList;
            }
            int strikeScore2 = frameList[frameList.Count - 2].score + frameList[frameList.Count - 1].score;
            frameList[frameList.Count - 2].score = strikeScore2;
            return frameList;
        }
    }
}