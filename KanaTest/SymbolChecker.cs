using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace KanaTest
{
    public static class SymbolChecker
    {
        static Random rng = new Random();
        static Dictionary<string, string> Symbols;
        static Dictionary<string, string> Kana;
        static Dictionary<string, string> Kanji;
        static SymbolChecker()
        {
            Kana = new Dictionary<string, string>();
            UpdateDictionary();
        }
        public static void UpdateDictionary()
        {
            string[] pairs = File.ReadAllLines("KanaDictionary.txt");
            foreach (string pair in pairs)
            {
                string[] keyAndValue = pair.Split(" ");
                if (keyAndValue[0] != "" && !Kana.ContainsKey(keyAndValue[0])) Kana.Add(keyAndValue[0], keyAndValue[1]);
            }
            Symbols = Kana;
        }
        public static void Change()
        {
            throw new NotImplementedException();
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
            return Symbols.ElementAt(rng.Next(0, Symbols.Count)).Key;
        }
    }
}
