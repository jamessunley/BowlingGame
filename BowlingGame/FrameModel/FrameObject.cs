using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame.FrameModel
{
    public class FrameObject
    {
        public int score { get; set; }
        public bool wasStrike { get; set; }
        public bool wasSpare { get; set; }
    }
}
