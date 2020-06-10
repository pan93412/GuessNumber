using System;

namespace GuessNumber
{
    class RandomNumberGenerator
    {
        public Random random = new Random();
        public int end;

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
