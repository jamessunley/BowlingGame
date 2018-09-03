using System;
using System.Collections.Generic;
using BowlingGame;
using BowlingGame.FrameModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingTestProject
{
    [TestClass]
    public class CalculateSpareValueTests
    {
        [TestMethod]
        public void Given_I_have_a_list_of_frames_where_the_first_frame_is_a_spare_and_the_second_frame_first_bowl_is_1_I_will_get_back_a_list_of_frames_the_score_of_the_spare_is_11()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            //and the first frame total score is 10
            frame1.score = 10;
            //and the spare bool for the 1st frame is true
            frame1.wasSpare = true;
            //and the second frame first bowl score is 1
            frame2.bowl1 = 1;
            //and the strike bool for the 2nd frame is false
            frame2.wasStrike = false;
            //when the update frame score is calculated
            frameList.Add(frame1);
            frameList.Add(frame2);
            ICalculateSpareScore calculateUpdatedFrame = new CalculateSpareScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 11
            Assert.AreEqual(11, frame1.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_where_the_first_frame_is_a_spare_and_the_second_frame_first_bowl_is_5_I_will_get_back_a_list_of_frames_the_score_of_the_spare_is_15()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            //and the first frame total score is 10
            frame1.score = 10;
            //and the spare bool for the 1st frame is true
            frame1.wasSpare = true;
            //and the second frame first bowl score is 5
            frame2.bowl1 = 5;
            //and the strike bool for the 2nd frame is false
            frame2.wasStrike = false;
            //when the update frame score is calculated
            frameList.Add(frame1);
            frameList.Add(frame2);
            ICalculateSpareScore calculateUpdatedFrame = new CalculateSpareScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 15
            Assert.AreEqual(15, frame1.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_where_the_first_frame_is_a_spare_and_the_second_frame_first_bowl_is_0_I_will_get_back_a_list_of_frames_the_score_of_the_spare_is_10()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            //and the first frame total score is 10
            frame1.score = 10;
            //and the spare bool for the 1st frame is true
            frame1.wasSpare = true;
            //and the second frame first bowl score is 5
            frame2.bowl1 = 0;
            //and the strike bool for the 2nd frame is false
            frame2.wasStrike = false;
            //when the update frame score is calculated
            frameList.Add(frame1);
            frameList.Add(frame2);
            ICalculateSpareScore calculateUpdatedFrame = new CalculateSpareScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 10
            Assert.AreEqual(10, frame1.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_where_the_first_frame_is_a_spare_and_the_second_frame_first_bowl_is_9_I_will_get_back_a_list_of_frames_the_score_of_the_spare_is_19()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            //and the first frame total score is 10
            frame1.score = 10;
            //and the spare bool for the 1st frame is true
            frame1.wasSpare = true;
            //and the second frame first bowl score is 9
            frame2.bowl1 = 9;
            //and the strike bool for the 2nd frame is false
            frame2.wasStrike = false;
            //when the update frame score is calculated
            frameList.Add(frame1);
            frameList.Add(frame2);
            ICalculateSpareScore calculateUpdatedFrame = new CalculateSpareScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 19
            Assert.AreEqual(19, frame1.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_where_the_first_frame_is_a_spare_and_the_second_frame_first_bowl_is_10_I_will_get_back_a_list_of_frames_the_score_of_the_spare_is_20()
        {
            //given I have a list of frames
            List<FrameObject> frameList = new List<FrameObject>();
            FrameObject frame1;
            FrameObject frame2;
            frame1 = new FrameObject();
            frame2 = new FrameObject();
            //and the first frame total score is 10
            frame1.score = 10;
            //and the spare bool for the 1st frame is true
            frame1.wasSpare = true;
            //and the second frame first bowl score is 10
            frame2.bowl1 = 10;
            //and the strike bool for the 2nd frame is false
            frame2.wasStrike = true;
            //when the update frame score is calculated
            frameList.Add(frame1);
            frameList.Add(frame2);
            ICalculateSpareScore calculateUpdatedFrame = new CalculateSpareScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 20
            Assert.AreEqual(20, frame1.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_where_the_second_frame_is_a_spare_and_the_third_frame_first_bowl_is_1_I_will_get_back_a_list_of_frames_the_score_of_the_spare_is_11()
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
            //and the spare bool for the 2nd frame is true
            frame2.wasSpare = true;
            //and the third frame first bowl score is 1
            frame3.bowl1 = 1;
            //and the strike bool for the 3rd frame is false
            frame3.wasStrike = false;
            //when the update frame score is calculated
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            ICalculateSpareScore calculateUpdatedFrame = new CalculateSpareScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 11
            Assert.AreEqual(11, frame2.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_where_the_second_frame_is_a_spare_and_the_third_frame_first_bowl_is_5_I_will_get_back_a_list_of_frames_the_score_of_the_spare_is_15()
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
            //and the spare bool for the 2nd frame is true
            frame2.wasSpare = true;
            //and the third frame first bowl score is 5
            frame3.bowl1 = 5;
            //and the strike bool for the 3rd frame is false
            frame3.wasStrike = false;
            //when the update frame score is calculated
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            ICalculateSpareScore calculateUpdatedFrame = new CalculateSpareScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 15
            Assert.AreEqual(15, frame2.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_where_the_second_frame_is_a_spare_and_the_third_frame_first_bowl_is_0_I_will_get_back_a_list_of_frames_the_score_of_the_spare_is_10()
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
            //and the spare bool for the 2nd frame is true
            frame2.wasSpare = true;
            //and the third frame first bowl score is 0
            frame3.bowl1 = 0;
            //and the strike bool for the 3rd frame is false
            frame3.wasStrike = false;
            //when the update frame score is calculated
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            ICalculateSpareScore calculateUpdatedFrame = new CalculateSpareScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 10
            Assert.AreEqual(10, frame2.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_where_the_second_frame_is_a_spare_and_the_third_frame_first_bowl_is_10_I_will_get_back_a_list_of_frames_the_score_of_the_spare_is_20()
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
            //and the spare bool for the 2nd frame is true
            frame2.wasSpare = true;
            //and the third frame first bowl score is 10
            frame3.bowl1 = 10;
            //and the strike bool for the 3rd frame is false
            frame3.wasStrike = true;
            //when the update frame score is calculated
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            ICalculateSpareScore calculateUpdatedFrame = new CalculateSpareScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 20
            Assert.AreEqual(20, frame2.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_where_the_third_frame_is_a_spare_and_the_fourth_frame_first_bowl_is_1_I_will_get_back_a_list_of_frames_the_score_of_the_spare_is_11()
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
            //and the spare bool for the 3rd frame is true
            frame3.wasSpare = true;
            //and the fourth frame first bowl score is 1
            frame4.bowl1 = 1;
            //and the strike bool for the 3rd frame is false
            frame4.wasStrike = false;
            //when the update frame score is calculated
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            frameList.Add(frame4);
            ICalculateSpareScore calculateUpdatedFrame = new CalculateSpareScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 11
            Assert.AreEqual(11, frame3.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_where_the_third_frame_is_a_spare_and_the_fourth_frame_first_bowl_is_5_I_will_get_back_a_list_of_frames_the_score_of_the_spare_is_15()
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
            //and the spare bool for the 3rd frame is true
            frame3.wasSpare = true;
            //and the fourth frame first bowl score is 5
            frame4.bowl1 = 5;
            //and the strike bool for the 3rd frame is false
            frame4.wasStrike = false;
            //when the update frame score is calculated
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            frameList.Add(frame4);
            ICalculateSpareScore calculateUpdatedFrame = new CalculateSpareScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 15
            Assert.AreEqual(15, frame3.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_where_the_third_frame_is_a_spare_and_the_fourth_frame_first_bowl_is_0_I_will_get_back_a_list_of_frames_the_score_of_the_spare_is_10()
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
            //and the spare bool for the 3rd frame is true
            frame3.wasSpare = true;
            //and the fourth frame first bowl score is 0
            frame4.bowl1 = 0;
            //and the strike bool for the 3rd frame is false
            frame4.wasStrike = false;
            //when the update frame score is calculated
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            frameList.Add(frame4);
            ICalculateSpareScore calculateUpdatedFrame = new CalculateSpareScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 10
            Assert.AreEqual(10, frame3.score);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_frames_where_the_third_frame_is_a_spare_and_the_fourth_frame_first_bowl_is_10_I_will_get_back_a_list_of_frames_the_score_of_the_spare_is_20()
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
            //and the spare bool for the 3rd frame is true
            frame3.wasSpare = true;
            //and the fourth frame first bowl score is 10
            frame4.bowl1 = 10;
            //and the strike bool for the 3rd frame is false
            frame4.wasStrike = true;
            //when the update frame score is calculated
            frameList.Add(frame1);
            frameList.Add(frame2);
            frameList.Add(frame3);
            frameList.Add(frame4);
            ICalculateSpareScore calculateUpdatedFrame = new CalculateSpareScore();
            frameList = calculateUpdatedFrame.CalculateFrameScore(frameList);
            //then the first frame total score will be 20
            Assert.AreEqual(20, frame3.score);
        }
    }
}
