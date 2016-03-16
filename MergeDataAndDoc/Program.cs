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

                    string outputLine =  words[count]+"先生,";
                    count++;
                    string outputLine1 = words[count] + "身分證";
                    count++;
                    string outputLine2 = words[count] + "年數";

                    Console.WriteLine("Write line: " + outputLine);
                    outputFile.WriteLine(outputLine);
                }
            }

            Console.ReadLine();
        }
    }
 
}
