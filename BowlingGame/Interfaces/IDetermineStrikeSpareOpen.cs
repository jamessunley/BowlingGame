using BowlingGame.FrameModel;

namespace BowlingGame
{
    public interface IDetermineStrikeSpareOpen
    {
        string CalculateFrameScore(FrameObject frame1);
    }
}