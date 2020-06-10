using System;

namespace GuessNumber
{
    class ReadLineInt32
    {
        public static int ReadLine(string prompt = "")
        {
            if (prompt != "") Console.Write(prompt);
            var _tmp = Console.ReadLine();
            return Convert.ToInt32(_tmp);
        }
    }
}
