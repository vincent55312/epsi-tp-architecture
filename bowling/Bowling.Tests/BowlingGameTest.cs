using Bowling.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bowling.Tests
{
    [TestClass]
    public class BowlingGameTest
    {
        private Game game;

        [TestInitialize]
        public void Setup()
        {
            this.game = new Game();
        }

        [TestMethod]
        public void Should_PlayOnlyZeros()
        {
            PlayGame(20, 0);
            Assert.AreEqual(0, this.game.CalculateScore());
        }

        [TestMethod]
        public void Should_PlayOnlyOnes()
        {
            PlayGame(20, 1);
            Assert.AreEqual(20, this.game.CalculateScore());
        }

        [TestMethod]
        public void Should_PlayASpare()
        {
            PlayASpare();
            this.game.ThrowBall(3);
            PlayGame(17, 0);
            Assert.AreEqual(16, this.game.CalculateScore());
        }

        [TestMethod]
        public void Should_PlayAStrike()
        {
            PlayAStrike();
            this.game.ThrowBall(4);
            this.game.ThrowBall(3);
            PlayGame(16, 0);
            Assert.AreEqual(24, this.game.CalculateScore());
        }

        private void PlayGame(int throws, int pins)
        {
            for (int rolls = 0; rolls < throws; rolls++)
                this.game.ThrowBall(pins);
        }

        private void PlayASpare()
        {
            this.game.ThrowBall(5);
            this.game.ThrowBall(5);
        }

        private void PlayAStrike()
        {
            this.game.ThrowBall(10);
        }
    }
}
