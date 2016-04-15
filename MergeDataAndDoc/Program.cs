using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeDataAndDoc
{
    class Program
    {
        static void Main (string[] args)
        {
            using (StreamReader sr = new StreamReader("data.txt")) 
            using (StreamWriter sw = new StreamWriter("result.txt")) 
            {
                comment(sr, sw);
            }

        }

        public static void comment(TextReader sr, TextWriter sw)
        {
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                sw.WriteLine("#" + line);
            }
        }


    }
 
}
