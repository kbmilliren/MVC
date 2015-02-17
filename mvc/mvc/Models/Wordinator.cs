using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class Wordinator
    {
        public string text { get; set; }
        private string[] words { get; set; }

        public Wordinator(string text)
        {
            this.text = text;

            var tempText = text.Replace('\n', ' ');
            tempText = tempText.Replace('.', ' ');
            words = tempText.Split(' ');

            words = words.Where(m => m != " " && m != "").ToArray();
        }

        public string findLongestWord()
        {
            string longestWord = "";

            foreach(var word in words)
            {
                if (word.Length > longestWord.Length)
                    longestWord = word;
            }
            return longestWord;
        }

        public int countAlice() 
        
        {
            int appearances = 0;

            foreach (var word in words)
            {
                if (word.ToLower().Contains("alice") )
                    appearances++;
            }
            return appearances;
        }
        
        public Dictionary<string, int> WordFrequency()
        {
            var frequencies = new Dictionary<string, int>();
            foreach(var word in words)
            {
                if (frequencies.Keys.Contains(word))
                    frequencies[word]++;
                else
                    frequencies[word] = 1;
            }
            return frequencies;
        }


       public bool palindrome(string text)
        {
             return new string(text.Reverse().ToArray()) == text;
        }



        /*public string filterLongestWord(string text, int i)
        {
            string longWords = "";
            var word = 0;
            foreach (var wor in text)
            {
                if ( > i)
                    longWords = wor;
            }
            return longWords;
        }*/
    }

}
