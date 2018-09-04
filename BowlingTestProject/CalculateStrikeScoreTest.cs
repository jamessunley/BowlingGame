using System;
using System.Collections.Generic;
using BowlingGame.FrameModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingTestProject
{
    [TestClass]
    public class CalculateStrikeScoreTest
    {
        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_second_frame_has_a_score_of_1_then_strike_total_is_11()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            //and the first frame total score is 10
            frame1.score = 10;
            //and the strike bool for the first frame is true
            frame1.wasStrike = true;
            //and the second frame total score is 1
            frame2.score = 1;
            //and the second frame strike bool is false
            frame2.wasStrike = false;
            //and the second frame spare bool is false
            frame2.wasSpare = false;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 11
            Assert.AreEqual(11, frame1.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_second_frame_has_a_score_of_5_then_strike_total_is_15()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            //and the first frame total score is 10
            frame1.score = 10;
            //and the strike bool for the first frame is true
            frame1.wasStrike = true;
            //and the second frame total score is 5
            frame2.score = 5;
            //and the second frame strike bool is false
            frame2.wasStrike = false;
            //and the second frame spare bool is false
            frame2.wasSpare = false;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 15
            Assert.AreEqual(15, frame1.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_second_frame_has_a_score_of_0_then_strike_total_is_10()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            //and the first frame total score is 10
            frame1.score = 10;
            //and the strike bool for the first frame is true
            frame1.wasStrike = true;
            //and the second frame total score is 0
            frame2.score = 0;
            //and the second frame strike bool is false
            frame2.wasStrike = false;
            //and the second frame spare bool is false
            frame2.wasSpare = false;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 10
            Assert.AreEqual(10, frame1.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_second_frame_has_a_score_of_10_and_is_a_spare_then_strike_total_is_20()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            //and the first frame total score is 10
            frame1.score = 10;
            //and the strike bool for the first frame is true
            frame1.wasStrike = true;
            //and the second frame total score is 10
            frame2.score = 10;
            //and the second frame strike bool is false
            frame2.wasStrike = false;
            //and the second frame spare bool is true
            frame2.wasSpare = true;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 20
            Assert.AreEqual(20, frame1.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_second_frame_has_a_score_of_10_and_is_a_strike_then_strike_total_is_20()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            //and the first frame total score is 10
            frame1.score = 10;
            //and the strike bool for the first frame is true
            frame1.wasStrike = true;
            //and the second frame total score is 10
            frame2.score = 10;
            //and the second frame strike bool is true
            frame2.wasStrike = true;
            //and the second frame spare bool is false
            frame2.wasSpare = false;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 20
            Assert.AreEqual(20, frame1.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_third_frame_has_a_score_of_1_then_strike_total_is_11()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            //and the second frame total score is 10
            frame2.score = 10;
            //and the strike bool for the second frame is true
            frame2.wasStrike = true;
            //and the third frame total score is 1
            frame3.score = 1;
            //and the third frame strike bool is false
            frame3.wasStrike = false;
            //and the third frame spare bool is false
            frame3.wasSpare = false;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the second frame total score will be 11
            Assert.AreEqual(11, frame2.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_third_frame_has_a_score_of_5_then_strike_total_is_15()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            //and the second frame total score is 10
            frame2.score = 10;
            //and the strike bool for the second frame is true
            frame2.wasStrike = true;
            //and the third frame total score is 5
            frame3.score = 5;
            //and the third frame strike bool is false
            frame3.wasStrike = false;
            //and the third frame spare bool is false
            frame3.wasSpare = false;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the second frame total score will be 15
            Assert.AreEqual(15, frame2.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_third_frame_has_a_score_of_0_then_strike_total_is_10()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            //and the second frame total score is 10
            frame2.score = 10;
            //and the strike bool for the second frame is true
            frame2.wasStrike = true;
            //and the third frame total score is 0
            frame3.score = 0;
            //and the third frame strike bool is false
            frame3.wasStrike = false;
            //and the third frame spare bool is false
            frame3.wasSpare = false;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the second frame total score will be 10
            Assert.AreEqual(10, frame2.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_third_frame_has_a_score_of_10_and_it_is_a_spare_then_strike_total_is_20()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            //and the second frame total score is 10
            frame2.score = 10;
            //and the strike bool for the second frame is true
            frame2.wasStrike = true;
            //and the third frame total score is 0
            frame3.score = 10;
            //and the third frame strike bool is false
            frame3.wasStrike = false;
            //and the third frame spare bool is true
            frame3.wasSpare = true;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the second frame total score will be 20
            Assert.AreEqual(20, frame2.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_third_frame_has_a_score_of_10_and_it_is_a_strike_then_strike_total_is_20()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            //and the second frame total score is 10
            frame2.score = 10;
            //and the strike bool for the second frame is true
            frame2.wasStrike = true;
            //and the third frame total score is 10
            frame3.score = 10;
            //and the third frame strike bool is true
            frame3.wasStrike = true;
            //and the third frame spare bool is false
            frame3.wasSpare = false;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the second frame total score will be 20
            Assert.AreEqual(20, frame2.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_second_frame_is_a_strike_and_third_frame_first_bowl_is_a_1_then_first_strike_total_is_21()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            //and the first frame total score is 10
            frame1.score = 10;
            //and the strike bool for the first frame is true
            frame1.wasStrike = true;
            //and the second frame total score is 10
            frame2.score = 10;
            //and the strike bool for the second frame is true
            frame2.wasStrike = true;
            //and the third frame total score is 1
            frame3.bowl1 = 1;
            //and the third frame strike bool is false
            frame3.wasStrike = false;
            //and the third frame spare bool is false
            frame3.wasSpare = false;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the second frame total score will be 21
            Assert.AreEqual(21, frame1.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_second_frame_is_a_strike_and_third_frame_first_bowl_is_a_5_then_first_strike_total_is_25()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            //and the first frame total score is 10
            frame1.score = 10;
            //and the strike bool for the first frame is true
            frame1.wasStrike = true;
            //and the second frame total score is 10
            frame2.score = 10;
            //and the strike bool for the second frame is true
            frame2.wasStrike = true;
            //and the third frame total score is 1
            frame3.bowl1 = 5;
            //and the third frame strike bool is false
            frame3.wasStrike = false;
            //and the third frame spare bool is false
            frame3.wasSpare = false;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the second frame total score will be 25
            Assert.AreEqual(25, frame1.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_fourth_frame_has_a_score_of_1_then_strike_total_is_11()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            FrameObject frame4;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            frame4 = new FrameObject();
            //and the third frame total score is 10
            frame3.score = 10;
            //and the strike bool for the third frame is true
            frame3.wasStrike = true;
            //and the fourth frame total score is 1
            frame4.score = 1;
            //and the fourth frame strike bool is false
            frame4.wasStrike = false;
            //and the fourth frame spare bool is false
            frame4.wasSpare = false;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            frameList.Add(frame4);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the second frame total score will be 11
            Assert.AreEqual(11, frame3.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_fourth_frame_has_a_score_of_5_then_strike_total_is_15()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            FrameObject frame4;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            frame4 = new FrameObject();
            //and the third frame total score is 10
            frame3.score = 10;
            //and the strike bool for the third frame is true
            frame3.wasStrike = true;
            //and the fourth frame total score is 5
            frame4.score = 5;
            //and the fourth frame strike bool is false
            frame4.wasStrike = false;
            //and the fourth frame spare bool is false
            frame4.wasSpare = false;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            frameList.Add(frame4);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the second frame total score will be 15
            Assert.AreEqual(15, frame3.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_fourth_frame_has_a_score_of_0_then_strike_total_is_10()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            FrameObject frame4;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            frame4 = new FrameObject();
            //and the third frame total score is 10
            frame3.score = 10;
            //and the strike bool for the third frame is true
            frame3.wasStrike = true;
            //and the fourth frame total score is 0
            frame4.score = 0;
            //and the fourth frame strike bool is false
            frame4.wasStrike = false;
            //and the fourth frame spare bool is false
            frame4.wasSpare = false;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            frameList.Add(frame4);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the second frame total score will be 10
            Assert.AreEqual(10, frame3.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_fourth_frame_has_a_score_of_10_and_is_a_spare_then_strike_total_is_20()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            FrameObject frame4;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            frame4 = new FrameObject();
            //and the third frame total score is 10
            frame3.score = 10;
            //and the strike bool for the third frame is true
            frame3.wasStrike = true;
            //and the fourth frame total score is 10
            frame4.score = 10;
            //and the fourth frame strike bool is false
            frame4.wasStrike = false;
            //and the fourth frame spare bool is false
            frame4.wasSpare = true;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            frameList.Add(frame4);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the second frame total score will be 20
            Assert.AreEqual(20, frame3.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_fourth_frame_has_a_score_of_10_and_is_a_strike_then_strike_total_is_20()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            FrameObject frame4;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            frame4 = new FrameObject();
            //and the third frame total score is 10
            frame3.score = 10;
            //and the strike bool for the third frame is true
            frame3.wasStrike = true;
            //and the fourth frame total score is 10
            frame4.score = 10;
            //and the fourth frame strike bool is false
            frame4.wasStrike = true;
            //and the fourth frame spare bool is false
            frame4.wasSpare = false;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            frameList.Add(frame4);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the second frame total score will be 20
            Assert.AreEqual(20, frame3.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_and_one_is_a_strike_and_the_third_frame_is_a_strike_and_fourth_frame_first_bowl_is_a_1_then_first_strike_total_is_21()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            FrameObject frame3;
            FrameObject frame4;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            frame3 = new FrameObject();
            frame4 = new FrameObject();
            //and the second frame total score is 10
            frame2.score = 10;
            //and the strike bool for the second frame is true
            frame2.wasStrike = true;
            //and the third frame total score is 10
            frame3.score = 10;
            //and the strike bool for the third frame is true
            frame3.wasStrike = true;
            //and the fourth frame bowl1 score is 1
            frame4.bowl1 = 1;
            //and the fourth frame strike bool is false
            frame4.wasStrike = false;
            //and the fourth frame spare bool is false
            frame4.wasSpare = false;
            //when the update strike score is called
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            frameList.Add(frame4);
            ICalculateStrikeScore calculateUpdatedFrame = new CalculateStrikeScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the second frame total score will be 21
            Assert.AreEqual(21, frame2.score);
        }
    }
}
