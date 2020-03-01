using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkQuestion
{
    class SortClass
    {
        public List<string> WordList;
        public SortClass(List<string>words)
        {
            this.WordList = words;
        }

        public void SortList()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            WordList.Sort();
            foreach (string word in WordList)
            {
                char[] cArr = word.ToCharArray();
                Array.Sort(cArr);
                string newWord = new string(cArr);
                if (dict.ContainsKey(newWord))
                    dict[newWord]++;
                else
                    dict.Add(newWord, 1);
            }
            foreach (KeyValuePair<string,int> pair in dict)
            {
                Console.WriteLine($"word: {pair.Key}  repeats: {pair.Value}");
            }
        }

    }
}
