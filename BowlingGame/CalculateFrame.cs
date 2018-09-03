using BowlingGame.FrameModel;

namespace BowlingGame
{
    public class CalculateFrame : ICalculateFrame
    {
        public FrameObject CalculateFrameScore(FrameObject frame)
        {
            frame.score = frame.bowl1 + frame.bowl2;

            if (frame.bowl1 == 10)
            {
                frame.wasStrike = true;
                return frame;
            }

            if (frame.score == 10)
            {
                frame.wasSpare = true;
                return frame;
            }

            return frame;
        }
    }
}