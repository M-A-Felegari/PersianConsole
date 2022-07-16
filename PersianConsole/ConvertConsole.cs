using System.Text;

namespace PersianConsole
{
    public static class ConvertConsole
    {
        /// <summary>
        /// To enable the console feature to display Persian(non English) texts
        /// </summary>
        public static void Enable()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = Encoding.GetEncoding(0x04e8);
        }

        /// <summary>
        /// To Disable the console feature to display Persian(non English) texts
        /// <b>you can't see non English text</b>
        /// </summary>
        public static void Disable()
        {
            Console.OutputEncoding = Encoding.Default;
        }

        /// <summary>
        /// This method is used to convert your text into Persian
        /// <b>just for right align languages</b>
        /// </summary>
        /// <param name="text">this is text what you want to convert</param>
        public static string ConvertString(string text)
        {
            char[] chars = text.ToCharArray();
            string reversedString = string.Empty;
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                reversedString += chars[i];
            }
            return reversedString;
        }

        /// <summary>
        /// This method is used to convert your list items into Persian
        /// <b>just for right align languages</b>        
        ///  </summary>
        /// <param name="list">this is list what you want to convert</param>
        /// <returns></returns>
        public static List<string> ConvertList(IEnumerable<string> list)
        {
            List<string> resultList = new List<string>(); //this list items are reversed
            foreach (string item in resultList)
            {
                resultList.Add(ConvertString(item)); //to reverse list items
            }
            return resultList;
        }
    }
}