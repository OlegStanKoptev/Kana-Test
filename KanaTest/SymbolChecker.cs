using System;
using System.Collections.Generic;
using System.Linq;

namespace KanaTest
{
    public static class SymbolChecker
    {
        static Dictionary<string, string> Symbols = new Dictionary<string, string>();
        public static void UseKana()
        {
            Symbols = new Dictionary<string, string>();
            Symbols.Add("あ", "a");
            Symbols.Add("い", "i");
            Symbols.Add("う", "u");
            Symbols.Add("え", "e");
            Symbols.Add("お", "o");
            Symbols.Add("か", "ka");
            Symbols.Add("き", "ki");
            Symbols.Add("く", "ku");
            Symbols.Add("け", "ke");
            Symbols.Add("こ", "ko");
            Symbols.Add("さ", "sa");
            Symbols.Add("し", "shi");
            Symbols.Add("す", "su");
            Symbols.Add("せ", "se");
            Symbols.Add("そ", "so");
            Symbols.Add("た", "ta");
            Symbols.Add("ち", "chi");
            Symbols.Add("つ", "tsu");
            Symbols.Add("て", "te");
            Symbols.Add("と", "to");
        }
        public static void UseNumbers()
        {
            Symbols = new Dictionary<string, string>();
            Symbols.Add("1", "one");
            Symbols.Add("2", "two");
            Symbols.Add("3", "three");
            Symbols.Add("4", "four");
            Symbols.Add("5", "five");
            Symbols.Add("6", "six");
            Symbols.Add("7", "seven");
            Symbols.Add("8", "eight");
            Symbols.Add("9", "nine");
            Symbols.Add("10", "ten");
            Symbols.Add("11", "eleven");
            Symbols.Add("12", "twelve");
            Symbols.Add("13", "thirteen");
            Symbols.Add("14", "fourteen");
            Symbols.Add("15", "fifteen");
            Symbols.Add("16", "sixteen");
            Symbols.Add("17", "seventeen");
            Symbols.Add("18", "eighteen");
            Symbols.Add("19", "nineteen");
            Symbols.Add("20", "twenty");
        }
        public static void Change()
        {
            if (Symbols.ContainsKey("1")) UseKana();
            else UseNumbers();
        }
        public static int NeededLength(string symbol)
        {
            return Symbols[symbol].Length;
        }
        public static bool CheckInput(string symbol, string input)
        {
            if (Symbols[symbol] == input.ToLower()) return true;
            return false;
        }
        public static string NewSymbol()
        {
            Random rng = new Random();
            return Symbols.ElementAt(rng.Next(0, Symbols.Count)).Key;
        }
    }
}
