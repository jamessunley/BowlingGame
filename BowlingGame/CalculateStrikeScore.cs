using System.Collections.Generic;
using BowlingGame.FrameModel;

namespace BowlingTestProject
{
    public class CalculateStrikeScore : ICalculateStrikeScore
    {
        public List<FrameObject> CalculateFrameScore(List<FrameObject> frameList)
        {
            if(frameList[0].wasStrike && frameList[1].wasStrike && frameList.Count >= 3)
            {
                int strikeScore1 = frameList[frameList.Count - 3].score + frameList[frameList.Count - 2].score + frameList[frameList.Count - 1].bowl1;
                frameList[frameList.Count - 3].score = strikeScore1;
                //frameList[frameList.Count - 3].score = 21;
                return frameList;
            }
            int strikeScore = frameList[frameList.Count - 2].score + frameList[frameList.Count - 1].score;
            frameList[frameList.Count - 2].score = strikeScore;
            return frameList;
        }
    }
}