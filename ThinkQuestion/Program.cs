using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>()
            {
                "java", "jjava" , "vaj",  "aavj",  "j",  "vjaa",  "dan",  "and", "ddan"

            };
            SortClass sortClass = new SortClass(words);
            sortClass.SortList();
        }
    }
}
