using BowlingGame.FrameModel;

namespace BowlingGame
{
    public class CalculateFrame : ICalculateFrame
    {
        public FrameObject CalculateFrameScore(FrameObject frame)
        {
            if (frame.bowl1 == 10)
            {
                frame = new FrameObject { score = frame.bowl1 + frame.bowl2, wasSpare = false, wasStrike = true };
                return frame;
            }
            else if (frame.bowl2 + frame.bowl1 == 10)
            {
                frame = new FrameObject { score = frame.bowl1 + frame.bowl2, wasSpare = true, wasStrike = false };
                return frame;
            }
            frame = new FrameObject { score = frame.bowl1 + frame.bowl2, wasSpare = false, wasStrike = false };
            return frame;
        }
    }
}