using BowlingGame.FrameModel;

namespace BowlingGame
{
    public class DetermineStrikeSpareOpen : IDetermineStrikeSpareOpen
    {
        public FrameObject CalculateFrameScore(FrameObject frame)
        {
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