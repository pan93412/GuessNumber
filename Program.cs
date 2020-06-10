using System;
using static GuessNumber.ReadLineInt32;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int end, randomNum, input,
                min = 0, max, times = 0;

            Console.WriteLine("猜數字 C# v1.1");
            end = max = 1000; // ReadLine("> 請輸入最大數字: ");

            var _rand = new RandomNumberGenerator(end);
            randomNum = _rand.Rand;

            while (true)
            {
                input = ReadLine($"\r\n> 輸入數字 ({min}-{max}): ");
                if (input <= min || input >= max)
                {
                    Console.WriteLine("  * Are you kidding me?");
                }
                else if (input > randomNum)
                {
                    Console.WriteLine("  * 比較大。");
                    max = input;
                }
                else if (input < randomNum)
                {
                    Console.WriteLine("  * 比較小。");
                    min = input;
                }
                else
                {
                    break;
                }
                times++;
            }

            Console.WriteLine($"  ! 恭喜您在猜了 {times} 次後成功答對!!");
        }
    }
}
