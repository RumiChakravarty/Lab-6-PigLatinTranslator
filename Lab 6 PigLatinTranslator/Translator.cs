using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_PigLatinTranslator
{
    public class Translator
    {
        public string Translate(string wordToTranslate)
        {

            char[] arrayName = wordToTranslate.ToCharArray();
            string dis = "";

                if(numberCheck(wordToTranslate))
                {
                    return wordToTranslate;
                }
                if (SpecialCharacter(wordToTranslate))
                {
                    return wordToTranslate;
                }

                if (VowelCheck(arrayName[0]))
                {
                    return wordToTranslate + "way";
                }
                else
                {
                    for (int i = 1; i < wordToTranslate.Length; i++)
                    {
                        if (VowelCheck(arrayName[i]))
                        {
                            dis = wordToTranslate.Substring(i) + wordToTranslate.Substring(0, i) + "ay";
                            break;
                        }
                        else
                        {
                            dis = wordToTranslate;
                        }
                    }
                }
            //[The same processs can be done using if elseif statement, but this is not reliable if we have a long word]
            //if (VowelCheck(arrayName[0]))
            //{
            //    return wordToTranslate + "way";
            //}

            //else if (VowelCheck(arrayName[1]))
            //    {
            //        dis = wordToTranslate.Substring(1) + wordToTranslate.First() + "ay";

            //    }
            //    else if (VowelCheck(arrayName[2]))
            //        {
            //            dis = wordToTranslate.Substring(2) + wordToTranslate.Substring(0,2) + "ay";

            //        }
            //        else if (VowelCheck(arrayName[3]))
            //            {
            //                dis = wordToTranslate.Substring(3) + wordToTranslate.Substring(0, 3) + "ay";

            //            }
            //            else
            //            {
            //                dis = wordToTranslate + "Rumi";
            //            }


            return dis;
        }
        
        //Method to check if it is a number
        private bool numberCheck(string numCheck)
        {
            string num = "0123456789";
            char[] numArray = num.ToCharArray();
            int indexOfNumber = numCheck.IndexOfAny(numArray);
            if(indexOfNumber == -1)
            {
                return false;
            }
            else
            {
               return true;
            }
           }

        //Method to check if it is Vowel or Consonants
       private bool VowelCheck(char letterCheck)
        {
            if (letterCheck.ToString().ToLower() == "a"|| letterCheck.ToString().ToLower() == "e" 
                || letterCheck.ToString().ToLower() == "i" || letterCheck.ToString().ToLower() == "o" 
                || letterCheck.ToString().ToLower() == "u")

                return true;
            else
                return false;
        }
        //Method to check if it has any special character
        private bool SpecialCharacter(string specialChar)
        {
            string spChar = "!@#$%^&*(){}[]:;";
            char[] specialHolder = spChar.ToCharArray();
            int ii = specialChar.IndexOfAny(specialHolder);
            if (ii == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
         

        }
    }
}
