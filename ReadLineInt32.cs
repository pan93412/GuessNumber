using System;

namespace GuessNumber
{
    class ReadLineInt32
    {
        public static int ReadLine(string prompt = "")
        {
            int returnVal = -1;

            try
            {
                if (prompt != "") Console.Write(prompt);
                var _tmp = Console.ReadLine();
                returnVal = Convert.ToInt32(_tmp);
            }
            catch (System.FormatException e) {
                Console.Error.WriteLine("\r\n" +
                    "位置: ReadLineInt32.cs > Convert.ToInt32\r\n" +
                    $"發生例外狀況: {e.Message}\r\n" +
                    "已啟用自動復原機制 - 程式將繼續運作，" +
                    "但可能發生例外行為。");
            }

            return returnVal;
        }
    }
}
