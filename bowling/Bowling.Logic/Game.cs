using System;

namespace Bowling.Logic
{
    public class Game
    {
        private const int MAX_FRAMES = 10;

        private int score = 0;
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public void ThrowBall(int pins)
        {
            this.rolls[currentRoll++] = pins;
        }

        public int CalculateScore()
        {
            int score = 0;
            int startOfFrame = 0;

            for (int frame = 0; frame < MAX_FRAMES; frame++)
            {
                if (IsStrike(startOfFrame))
                {
                    score += 10 + rolls[startOfFrame + 1] + rolls[startOfFrame + 2];
                    startOfFrame += 1;
                }
                else if (IsSpare(startOfFrame))
                {
                    score += 10 + rolls[startOfFrame + 2];
                    startOfFrame += 2;
                }
                else
                {
                    score += rolls[startOfFrame] + rolls[startOfFrame + 1];
                    startOfFrame += 2;
                }
            }

            return score;
        }

        private bool IsStrike(int startOfFrame) => rolls[startOfFrame] == 10;
        private bool IsSpare(int startOfFrame) => rolls[startOfFrame] + rolls[startOfFrame + 1] == 10;
    }
}