using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame.FrameModel
{
    public class FrameObject
    {
        public int bowl1 { get; set; }
        public int bowl2 { get; set; }
        public int score { get; set; }
        public bool wasStrike { get; set; } = false;
        public bool wasSpare { get; set; } = false;
    }
}
