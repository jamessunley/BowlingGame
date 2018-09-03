using System;
using BowlingGame;
using BowlingGame.FrameModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingTestProject
{
    [TestClass]
    public class CalculateFrameScoreTest
    {
        
        [TestMethod]
        public void Given_I_Have_a_frame_with_a_score_of_1_and_a_score_of_0_then_i_will_get_back_a_score_of_1_with_both_bool_being_false()
        {
            //given i have a frame
            FrameObject frame;
            frame = new FrameObject { bowl1 = 1, bowl2 = 0 };
            //when the frame score is calculated
            ICalculateFrame calculateFrame = new CalculateFrame();
            frame = calculateFrame.CalculateFrameScore(frame);
            //then i will get back a score of 1
            Assert.AreEqual(1, frame.score);
            //and the strike bool being false
            Assert.AreEqual(false, frame.wasStrike);
            //and the spare bool being false
            Assert.AreEqual(false, frame.wasSpare);
        }

        [TestMethod]
        public void Given_I_Have_a_frame_with_a_score_of_0_and_a_score_of_1_then_i_will_get_back_a_score_of_1_with_both_bool_being_false()
        {
            //given i have a frame
            FrameObject frame;
            frame = new FrameObject { bowl1 = 0, bowl2 = 1 };
            //when the frame score is calculated
            ICalculateFrame calculateFrame = new CalculateFrame();
            frame = calculateFrame.CalculateFrameScore(frame);
            //then i will get back a score of 1
            Assert.AreEqual(1, frame.score);
            //and the strike bool being false
            Assert.AreEqual(false, frame.wasStrike);
            //and the spare bool being false
            Assert.AreEqual(false, frame.wasSpare);
        }

        [TestMethod]
        public void Given_I_Have_a_frame_with_a_score_of_1_and_a_score_of_1_then_i_will_get_back_a_score_of_2_with_both_bool_being_false()
        {
            //given i have a frame
            FrameObject frame;
            frame = new FrameObject { bowl1 = 1, bowl2 = 1 };
            //when the frame score is calculated
            ICalculateFrame calculateFrame = new CalculateFrame();
            frame = calculateFrame.CalculateFrameScore(frame);
            //then i will get back a score of 1
            Assert.AreEqual(2, frame.score);
            //and the strike bool being false
            Assert.AreEqual(false, frame.wasStrike);
            //and the spare bool being false
            Assert.AreEqual(false, frame.wasSpare);
        }

        [TestMethod]
        public void Given_I_Have_a_frame_with_a_score_of_5_and_a_score_of_4_then_i_will_get_back_a_score_of_9_with_both_bool_being_false()
        {
            //given i have a frame
            FrameObject frame;
            frame = new FrameObject { bowl1 = 5, bowl2 = 4 };
            //when the frame score is calculated
            ICalculateFrame calculateFrame = new CalculateFrame();
            frame = calculateFrame.CalculateFrameScore(frame);
            //then i will get back a score of 9
            Assert.AreEqual(9, frame.score);
            //and the strike bool being false
            Assert.AreEqual(false, frame.wasStrike);
            //and the spare bool being false
            Assert.AreEqual(false, frame.wasSpare);
        }

        [TestMethod]
        public void Given_I_Have_a_frame_with_a_score_of_9_and_a_score_of_0_then_i_will_get_back_a_score_of_9_with_both_bool_being_false()
        {
            //given i have a frame
            FrameObject frame;
            frame = new FrameObject { bowl1 = 9, bowl2 = 0 };
            //when the frame score is calculated
            ICalculateFrame calculateFrame = new CalculateFrame();
            frame = calculateFrame.CalculateFrameScore(frame);
            //then i will get back a score of 9
            Assert.AreEqual(9, frame.score);
            //and the strike bool being false
            Assert.AreEqual(false, frame.wasStrike);
            //and the spare bool being false
            Assert.AreEqual(false, frame.wasSpare);
        }

        [TestMethod]
        public void Given_I_Have_a_frame_with_a_score_of_1_and_a_score_of_8_then_i_will_get_back_a_score_of_9_with_both_bool_being_false()
        {
            //given i have a frame
            FrameObject frame;
            frame = new FrameObject { bowl1 = 1, bowl2 = 8 };
            //when the frame score is calculated
            ICalculateFrame calculateFrame = new CalculateFrame();
            frame = calculateFrame.CalculateFrameScore(frame);
            //then i will get back a score of 9
            Assert.AreEqual(9, frame.score);
            //and the strike bool being false
            Assert.AreEqual(false, frame.wasStrike);
            //and the spare bool being false
            Assert.AreEqual(false, frame.wasSpare);
        }

        [TestMethod]
        public void Given_I_Have_a_frame_with_a_score_of_0_and_a_score_of_10_then_i_will_get_back_a_score_of_10_with_both_bool_being_false()
        {
            //given i have a frame
            FrameObject frame;
            frame = new FrameObject { bowl1 = 0, bowl2 = 10 };
            //when the frame score is calculated
            ICalculateFrame calculateFrame = new CalculateFrame();
            frame = calculateFrame.CalculateFrameScore(frame);
            //then i will get back a score of 10
            Assert.AreEqual(10, frame.score);
            //and the strike bool being false
            Assert.AreEqual(false, frame.wasStrike);
            //and the spare bool being false
            Assert.AreEqual(true, frame.wasSpare);
        }

        [TestMethod]
        public void Given_I_Have_a_frame_with_a_score_of_9_and_a_score_of_1_then_i_will_get_back_a_score_of_10_with_both_bool_being_false()
        {
            //given i have a frame
            FrameObject frame;
            frame = new FrameObject { bowl1 = 9, bowl2 = 1 };
            //when the frame score is calculated
            ICalculateFrame calculateFrame = new CalculateFrame();
            frame = calculateFrame.CalculateFrameScore(frame);
            //then i will get back a score of 10
            Assert.AreEqual(10, frame.score);
            //and the strike bool being false
            Assert.AreEqual(false, frame.wasStrike);
            //and the spare bool being false
            Assert.AreEqual(true, frame.wasSpare);
        }

        [TestMethod]
        public void Given_I_Have_a_frame_with_a_score_of_5_and_a_score_of_5_then_i_will_get_back_a_score_of_10_with_both_bool_being_false()
        {
            //given i have a frame
            FrameObject frame;
            frame = new FrameObject { bowl1 = 5, bowl2 = 5 };
            //when the frame score is calculated
            ICalculateFrame calculateFrame = new CalculateFrame();
            frame = calculateFrame.CalculateFrameScore(frame);
            //then i will get back a score of 10
            Assert.AreEqual(10, frame.score);
            //and the strike bool being false
            Assert.AreEqual(false, frame.wasStrike);
            //and the spare bool being false
            Assert.AreEqual(true, frame.wasSpare);
        }

        [TestMethod]
        public void Given_I_Have_a_frame_with_a_score_of_1_and_a_score_of_9_then_i_will_get_back_a_score_of_10_with_both_bool_being_false()
        {
            //given i have a frame
            FrameObject frame;
            frame = new FrameObject { bowl1 = 1, bowl2 = 9 };
            //when the frame score is calculated
            ICalculateFrame calculateFrame = new CalculateFrame();
            frame = calculateFrame.CalculateFrameScore(frame);
            //then i will get back a score of 10
            Assert.AreEqual(10, frame.score);
            //and the strike bool being false
            Assert.AreEqual(false, frame.wasStrike);
            //and the spare bool being false
            Assert.AreEqual(true, frame.wasSpare);
        }

        [TestMethod]
        public void Given_I_Have_a_frame_with_a_score_of_10_and_a_score_of_0_then_i_will_get_back_a_score_of_10_with_both_bool_being_false()
        {
            //given i have a frame
            FrameObject frame;
            frame = new FrameObject { bowl1 = 10, bowl2 = 0 };
            //when the frame score is calculated
            ICalculateFrame calculateFrame = new CalculateFrame();
            frame = calculateFrame.CalculateFrameScore(frame);
            //then i will get back a score of 10
            Assert.AreEqual(10, frame.score);
            //and the strike bool being false
            Assert.AreEqual(true, frame.wasStrike);
            //and the spare bool being false
            Assert.AreEqual(false, frame.wasSpare);
        }

    }
}
