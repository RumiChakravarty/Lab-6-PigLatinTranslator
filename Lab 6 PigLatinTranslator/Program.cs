using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_6_PigLatinTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Translator pigLatin = new Translator();
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            string putAnotherLine;
            do
            {
                Console.Write("\nEnter a line to be translated: ");
                string lineToBeTranslated = Console.ReadLine();
                if(lineToBeTranslated == "")
                {
                    Console.WriteLine("Please enter your string: ");

                }
                string[] lineToConvert = lineToBeTranslated.Split(' ');
                Console.WriteLine();
                foreach (string word in lineToConvert)
                {
               
                    Console.Write(pigLatin.Translate(word) + " ");
                }
                Console.WriteLine("\n\nTranslate another line?(Y/N)");
                putAnotherLine = Console.ReadLine().ToLower().Trim();
            } while (putAnotherLine == "y");

            
            Console.WriteLine();
            //Console.WriteLine(pigLatin.Translate(line));

        }
    }
}
