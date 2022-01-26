using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Object
{
    class CSelect
    {
       private string[] sentence = new string[] {"The quick brown", "fox jumps over", "the lazy dog."};

        public void runSelect()
        {
            IEnumerable<string[]> words1 = sentence.Select(w => w.Split(' '));
            
            foreach (string[] segment in words1)
                foreach (string word in segment)
                    Console.WriteLine(word);
        }

        public void runSelectMany()
        {
            IEnumerable<string[]> words2 = (IEnumerable<string[]>)sentence.SelectMany(w => w.Split(' '));
            
            //foreach (string word in words2)
            //    Console.WriteLine(word);

        }

    }
}
