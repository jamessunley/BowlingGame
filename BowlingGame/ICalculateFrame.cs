using BowlingGame.FrameModel;

namespace BowlingGame
{
    public interface ICalculateFrame
    {
        FrameObject CalculateFrameScore(FrameObject frame);
    }
}