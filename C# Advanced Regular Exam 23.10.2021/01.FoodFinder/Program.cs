using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>(Console.ReadLine().ToCharArray());
            Stack<char> consonants = new Stack<char>(Console.ReadLine().ToCharArray());
            Dictionary<char, int> pear = new Dictionary<char, int>();
            pear.Add('p', 0);
            pear.Add('e', 0);
            pear.Add('a', 0);
            pear.Add('r', 0);
            Dictionary<char, int> flour = new Dictionary<char, int>();
            flour.Add('f', 0);
            flour.Add('l', 0);
            flour.Add('o', 0);
            flour.Add('u', 0);
            flour.Add('r', 0);
            Dictionary<char, int> pork = new Dictionary<char, int>();
            pork.Add('p', 0);
            pork.Add('o', 0);
            pork.Add('r', 0);
            pork.Add('k', 0);
            Dictionary<char, int> olive = new Dictionary<char, int>();
            olive.Add('o', 0);
            olive.Add('l', 0);
            olive.Add('i', 0);
            olive.Add('v', 0);
            olive.Add('e', 0);
            int numberOfWordsFound = 0;
            while (consonants.Count > 0)
            {
                char currentVowel = vowels.Peek();
                char currentConsonant = consonants.Pop();
                ChekWord(currentVowel, pear);
                ChekWord(currentConsonant, pear);
                ChekWord(currentVowel, flour);
                ChekWord(currentConsonant, flour);
                ChekWord(currentVowel, pork);
                ChekWord(currentConsonant, pork);
                ChekWord(currentVowel, olive);
                ChekWord(currentConsonant, olive);
                vowels.Enqueue(vowels.Dequeue());
            }
            if (pear.Sum(x => x.Value) == pear.Count)
            {
                numberOfWordsFound++;
            }
            if (flour.Sum(x => x.Value) == flour.Count)
            {
                numberOfWordsFound++;
            }
            if (pork.Sum(x => x.Value) == pork.Count)
            {
                numberOfWordsFound++;
            }
            if (olive.Sum(x => x.Value) == olive.Count)
            {
                numberOfWordsFound++;
            }

            Console.WriteLine($"Words found: {numberOfWordsFound}");
            if (pear.Sum(x => x.Value) == pear.Count)
            {
                Console.WriteLine("pear");
            }
            if (flour.Sum(x => x.Value) == flour.Count)
            {
                Console.WriteLine("flour");
            }
            if (pork.Sum(x => x.Value) == pork.Count)
            {
                Console.WriteLine("pork");
            }
            if (olive.Sum(x => x.Value) == olive.Count)
            {
                Console.WriteLine("olive");
            }
        }

        private static void ChekWord(char target, Dictionary<char, int> word)
        {
            if (word.ContainsKey(target) && word[target] == 0)
            {
                word[target]++;
            }
        }
    }
}
