using System;
using System.Collections.Generic;
using BowlingGame;
using BowlingGame.FrameModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingTestProject
{
    [TestClass]
    public class CalculateTotalScoreTest
    {
        [TestMethod]
        public void Given_I_Have_a_list_of_1_frame_then_i_will_get_back_8()
        {
            //given i have a list of 1 frame
            List<FrameObject> frame = new List<FrameObject>();
            //and the frame values are 8
            frame.Add(new FrameObject { score = 8 });
            //when i call the calculate score method
            ICalculateScore calculateScore = new CalculateScore();
            int total = calculateScore.CalculateTotalScore(frame);
            //then i will get back the total score that is 8
            Assert.AreEqual(8, total);
        }

        [TestMethod]
        public void Given_I_Have_a_list_of_2_frames_then_i_will_get_back_17()
        {
            //given i have a list of 2 frame
            List<FrameObject> frame = new List<FrameObject>();
            //and the frame values are 8 9 
            frame.Add(new FrameObject { score = 8 });
            frame.Add(new FrameObject { score = 9 });
            //when i call the calculate score method
            ICalculateScore calculateScore = new CalculateScore();
            int total = calculateScore.CalculateTotalScore(frame);
            //then i will get back the total score that is 17
            Assert.AreEqual(17, total);
        }

        [TestMethod]
        public void Given_I_Have_a_list_of_3_frames_then_i_will_get_back_19()
        {
            //given i have a list of 3 frame
            List<FrameObject> frame = new List<FrameObject>();
            //and the frame values are 8 9 2
            frame.Add(new FrameObject { score = 8 });
            frame.Add(new FrameObject { score = 9 });
            frame.Add(new FrameObject { score = 2 });
            //when i call the calculate score method
            ICalculateScore calculateScore = new CalculateScore();
            int total = calculateScore.CalculateTotalScore(frame);
            //then i will get back the total score that is 19
            Assert.AreEqual(19, total);
        }

        [TestMethod]
        public void Given_I_Have_a_list_of_3_frames_then_i_will_get_back_17()
        {
            //given i have a list of 3 frame
            List<FrameObject> frame = new List<FrameObject>();
            //and the frame values are 8 9 0
            frame.Add(new FrameObject { score = 8 });
            frame.Add(new FrameObject { score = 9 });
            frame.Add(new FrameObject { score = 0 });
            //when i call the calculate score method
            ICalculateScore calculateScore = new CalculateScore();
            int total = calculateScore.CalculateTotalScore(frame);
            //then i will get back the total score that is 17
            Assert.AreEqual(17, total);
        }

        [TestMethod]
        public void Given_I_Have_a_list_of_3_frames_then_i_will_get_back_28()
        {
            //given i have a list of 3 frame
            List<FrameObject> frame = new List<FrameObject>();
            //and the frame values are 8 9 0
            frame.Add(new FrameObject { score = 19 });
            frame.Add(new FrameObject { score = 9 });
            frame.Add(new FrameObject { score = 0 });
            //when i call the calculate score method
            ICalculateScore calculateScore = new CalculateScore();
            int total = calculateScore.CalculateTotalScore(frame);
            //then i will get back the total score that is 28
            Assert.AreEqual(28, total);
        }

        [TestMethod]
        public void Given_I_Have_a_list_of_10_frames_then_i_will_get_back_300()
        {
            //given i have a list of 10 frame
            List<FrameObject> frame = new List<FrameObject>();
            //and the frame values are all 30
            frame.Add(new FrameObject { score = 30 });
            frame.Add(new FrameObject { score = 30 });
            frame.Add(new FrameObject { score = 30 });
            frame.Add(new FrameObject { score = 30 });
            frame.Add(new FrameObject { score = 30 });
            frame.Add(new FrameObject { score = 30 });
            frame.Add(new FrameObject { score = 30 });
            frame.Add(new FrameObject { score = 30 });
            frame.Add(new FrameObject { score = 30 });
            frame.Add(new FrameObject { score = 30 });
            //when i call the calculate score method
            ICalculateScore calculateScore = new CalculateScore();
            int total = calculateScore.CalculateTotalScore(frame);
            //then i will get back the total score that is 300
            Assert.AreEqual(300, total);
        }

        [TestMethod]
        public void Given_I_Have_a_list_of_10_frames_then_i_will_get_back_0()
        {
            //given i have a list of 10 frame
            List<FrameObject> frame = new List<FrameObject>();
            //and the frame values are all 0
            frame.Add(new FrameObject { score = 0 });
            frame.Add(new FrameObject { score = 0 });
            frame.Add(new FrameObject { score = 0 });
            frame.Add(new FrameObject { score = 0 });
            frame.Add(new FrameObject { score = 0 });
            frame.Add(new FrameObject { score = 0 });
            frame.Add(new FrameObject { score = 0 });
            frame.Add(new FrameObject { score = 0 });
            frame.Add(new FrameObject { score = 0 });
            frame.Add(new FrameObject { score = 0 });
            //when i call the calculate score method
            ICalculateScore calculateScore = new CalculateScore();
            int total = calculateScore.CalculateTotalScore(frame);
            //then i will get back the total score that is 0
            Assert.AreEqual(0, total);
        }
    }
}
