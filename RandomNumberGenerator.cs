using System;

namespace GuessNumber
{
    class RandomNumberGenerator
    {
        private Random random = new Random();
        private int end;

        public RandomNumberGenerator(int end = 0)
        {
            this.end = end;
        }

        public int Rand
        {
            get => random.Next(end);
        }
    }
}
