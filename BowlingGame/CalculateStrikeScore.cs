using System.Collections.Generic;
using BowlingGame.FrameModel;

namespace BowlingTestProject
{
    public class CalculateStrikeScore : ICalculateStrikeScore
    {
        public List<FrameObject> CalculateFrameScore(List<FrameObject> frameList)
        {
            int strikeScore = frameList[frameList.Count - 2].score + frameList[frameList.Count - 1].score;
            frameList[frameList.Count - 2].score = strikeScore;
            return frameList;
        }
    }
}