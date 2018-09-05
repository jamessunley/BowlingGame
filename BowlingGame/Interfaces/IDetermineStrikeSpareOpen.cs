using BowlingGame.FrameModel;

namespace BowlingGame
{
    public interface IDetermineStrikeSpareOpen
    {
        FrameObject CalculateFrameScore(FrameObject frame1);
    }
}