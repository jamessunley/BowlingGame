using BowlingGame.FrameModel;

namespace BowlingGame
{
    public class DetermineStrikeSpareOpen : IDetermineStrikeSpareOpen
    {
        public string CalculateFrameScore(FrameObject frame1)
        {
            if (frame1.wasSpare)
            {
                return "Spare";
            }else if(frame1.wasStrike)
            {
                return "Strike";
            }
            return "Open";
        }
    }
}