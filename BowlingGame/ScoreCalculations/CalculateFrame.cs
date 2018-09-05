using BowlingGame.FrameModel;

namespace BowlingGame
{
    public class CalculateFrame : ICalculateFrame
    {
        public FrameObject CalculateFrameScore(FrameObject frame)
        {
            frame.score = frame.bowl1 + frame.bowl2;
            return frame;
        }
    }
}