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
        static void Main(string[] args)
        {
            string inputFileName = "defaultInput.txt";
            string outputFileName = "defaultOutput.txt";

            Console.WriteLine("test");
            if (args.Length == 2)
            {
                inputFileName = args[0];
                outputFileName = args[1];
            }

            using (StreamReader inputFile = new StreamReader(inputFileName)) //read file

            using(StreamWriter outputFile = new StreamWriter(outputFileName)) //write file
            {
                char[] delimiterChars = { ' ', ',', '.', ':', '\t' };


                string line; //test
                while((line = inputFile.ReadLine()) != null) //依序讀入每一行
                {
                    int count = 0;
                    string[] words = line.Split(delimiterChars);

                    string outputLine =  words[count]+"先生   ,";
                    count++;

                    string outputLine1 =  "身分證號碼為: "+ words[count] ;
                    count++;

                    string outputLine2 =  "為本校專任教師，聘期 "+words[count] ;

                    Console.WriteLine("Write line: " + outputLine+outputLine1+outputLine2);
                    outputFile.WriteLine(outputLine+outputLine1+outputLine2);
                }
            }

            Console.ReadLine();
        }
    }
 
}
