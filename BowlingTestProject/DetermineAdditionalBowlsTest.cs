using System;
using System.Collections.Generic;
using BowlingGame;
using BowlingGame.FrameModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingTestProject
{
    [TestClass]
    public class DetermineAdditionalBowlsTest
    {
        [TestMethod]
        public void Given_I_Have_a_list_of_10_frames_and_10th_frame_is_a_strike_I_will_get_back_2()
        {
            //given I have a a list of 10 frames
            FrameObject frame1 = new FrameObject();
            FrameObject frame2 = new FrameObject();
            FrameObject frame3 = new FrameObject();
            FrameObject frame4 = new FrameObject();
            FrameObject frame5 = new FrameObject();
            FrameObject frame6 = new FrameObject();
            FrameObject frame7 = new FrameObject();
            FrameObject frame8 = new FrameObject();
            FrameObject frame9 = new FrameObject();
            FrameObject frame10 = new FrameObject();
            //and the 10th frame is a strike
            frame10.wasStrike = true;
            //when I call the additional bowl calculator
            List<FrameObject> frameList = new List<FrameObject>() { frame1, frame2, frame3, frame4, frame5, frame6, frame7, frame8, frame9, frame10 };
            IDetermineAdditionalBowls determineAdditionalBowls = new DetermineAdditionalBowls();
            int bowls = determineAdditionalBowls.determineAdditionalBowls(frameList);
            //then I will get back a 2
            Assert.AreEqual(2, bowls);
        }

        [TestMethod]
        public void Given_I_Have_a_list_of_10_frames_and_10th_frame_is_a_spare_I_will_get_back_1()
        {
            //given I have a a list of 10 frames
            FrameObject frame1 = new FrameObject();
            FrameObject frame2 = new FrameObject();
            FrameObject frame3 = new FrameObject();
            FrameObject frame4 = new FrameObject();
            FrameObject frame5 = new FrameObject();
            FrameObject frame6 = new FrameObject();
            FrameObject frame7 = new FrameObject();
            FrameObject frame8 = new FrameObject();
            FrameObject frame9 = new FrameObject();
            FrameObject frame10 = new FrameObject();
            //and the 10th frame is a spare
            frame10.wasSpare = true;
            //when I call the additional bowl calculator
            List<FrameObject> frameList = new List<FrameObject>() { frame1, frame2, frame3, frame4, frame5, frame6, frame7, frame8, frame9, frame10 };
            IDetermineAdditionalBowls determineAdditionalBowls = new DetermineAdditionalBowls();
            int bowls = determineAdditionalBowls.determineAdditionalBowls(frameList);
            //then I will get back a 1
            Assert.AreEqual(1, bowls);
        }

        [TestMethod]
        public void Given_I_Have_a_list_of_10_frames_and_10th_frame_is_an_open_I_will_get_back_0()
        {
            //given I have a a list of 10 frames
            FrameObject frame1 = new FrameObject();
            FrameObject frame2 = new FrameObject();
            FrameObject frame3 = new FrameObject();
            FrameObject frame4 = new FrameObject();
            FrameObject frame5 = new FrameObject();
            FrameObject frame6 = new FrameObject();
            FrameObject frame7 = new FrameObject();
            FrameObject frame8 = new FrameObject();
            FrameObject frame9 = new FrameObject();
            FrameObject frame10 = new FrameObject();
            //when I call the additional bowl calculator
            List<FrameObject> frameList = new List<FrameObject>() { frame1, frame2, frame3, frame4, frame5, frame6, frame7, frame8, frame9, frame10 };
            IDetermineAdditionalBowls determineAdditionalBowls = new DetermineAdditionalBowls();
            int bowls = determineAdditionalBowls.determineAdditionalBowls(frameList);
            //then I will get back a 0
            Assert.AreEqual(0, bowls);
        }
    }
}
