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
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            FrameObject frame4;
            FrameObject frame5;
            FrameObject frame6;
            FrameObject frame7;
            FrameObject frame8;
            FrameObject frame9;
            FrameObject frame10;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            frame4 = new FrameObject();
            frame5 = new FrameObject();
            frame6 = new FrameObject();
            frame7 = new FrameObject();
            frame8 = new FrameObject();
            frame9 = new FrameObject();
            frame10 = new FrameObject();
            //and the 10th frame is a strike
            frame10.wasStrike = true;
            //when I call the additional bowl calculator
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            frameList.Add(frame4);
            frameList.Add(frame5);
            frameList.Add(frame6);
            frameList.Add(frame7);
            frameList.Add(frame8);
            frameList.Add(frame9);
            frameList.Add(frame10);
            IDetermineAdditionalBowls determineAdditionalBowls = new DetermineAdditionalBowls();
            int bowls = determineAdditionalBowls.determineAdditionalBowls(frameList);
            //then I will get back a 2
            Assert.AreEqual(2, bowls);
        }

        [TestMethod]
        public void Given_I_Have_a_list_of_10_frames_and_10th_frame_is_a_spare_I_will_get_back_1()
        {
            //given I have a a list of 10 frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            FrameObject frame4;
            FrameObject frame5;
            FrameObject frame6;
            FrameObject frame7;
            FrameObject frame8;
            FrameObject frame9;
            FrameObject frame10;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            frame4 = new FrameObject();
            frame5 = new FrameObject();
            frame6 = new FrameObject();
            frame7 = new FrameObject();
            frame8 = new FrameObject();
            frame9 = new FrameObject();
            frame10 = new FrameObject();
            //and the 10th frame is a spare
            frame10.wasSpare = true;
            //when I call the additional bowl calculator
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            frameList.Add(frame4);
            frameList.Add(frame5);
            frameList.Add(frame6);
            frameList.Add(frame7);
            frameList.Add(frame8);
            frameList.Add(frame9);
            frameList.Add(frame10);
            IDetermineAdditionalBowls determineAdditionalBowls = new DetermineAdditionalBowls();
            int bowls = determineAdditionalBowls.determineAdditionalBowls(frameList);
            //then I will get back a 1
            Assert.AreEqual(1, bowls);
        }

        [TestMethod]
        public void Given_I_Have_a_list_of_10_frames_and_10th_frame_is_an_open_I_will_get_back_0()
        {
            //given I have a a list of 10 frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            FrameObject frame4;
            FrameObject frame5;
            FrameObject frame6;
            FrameObject frame7;
            FrameObject frame8;
            FrameObject frame9;
            FrameObject frame10;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            frame4 = new FrameObject();
            frame5 = new FrameObject();
            frame6 = new FrameObject();
            frame7 = new FrameObject();
            frame8 = new FrameObject();
            frame9 = new FrameObject();
            frame10 = new FrameObject();
            //when I call the additional bowl calculator
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            frameList.Add(frame4);
            frameList.Add(frame5);
            frameList.Add(frame6);
            frameList.Add(frame7);
            frameList.Add(frame8);
            frameList.Add(frame9);
            frameList.Add(frame10);
            IDetermineAdditionalBowls determineAdditionalBowls = new DetermineAdditionalBowls();
            int bowls = determineAdditionalBowls.determineAdditionalBowls(frameList);
            //then I will get back a 0
            Assert.AreEqual(0, bowls);
        }
    }
}
