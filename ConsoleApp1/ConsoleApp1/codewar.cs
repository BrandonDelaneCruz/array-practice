using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Printer
    {
        public static string PrinterError(String s)
        {
            int value = 'a';
            char[] listOfChar = new char[13];

            for (int i = 0; i < listOfChar.Length; i++)
            {
                listOfChar[i] = (char)value++;
            }

            int numberOfErrors = 0;

            char[] stringArray = s.ToCharArray();

            for (int i = 0; i < stringArray.Length; i++)
            {
                for (int j = 0; i < listOfChar.Length; i++)
                {
                    if (stringArray[i] != listOfChar[j])
                    {
                        numberOfErrors++;
                    }
                }
            }

            return $"{numberOfErrors}/{s.Length}";
        }

        // s = "bbcxa"
        public static string PrintError2(String s)
        {
            #region setup
            int value = 'a';
            char[] listOfChar = new char[13];

            for (int i = 0; i < listOfChar.Length; i++)
            {
                listOfChar[i] = (char)value++;
            }

            int numberOfErrors = 0;

            char[] stringArray = s.ToCharArray();
            #endregion

            for (int i = 0; i < stringArray.Length; i++)
            {
                bool correctChar = false;

                for (int j = 0; j < listOfChar.Length; j++)
                {
                    var stringArrayi = stringArray[i];
                    var listOfCharj = listOfChar[j];

                    if (stringArrayi == listOfCharj)
                    {
                        correctChar = true;
                        break;
                    }

                }

                if (!correctChar)
                {
                    numberOfErrors++;
                }
            }

            return $"{numberOfErrors}/{s.Length}";
        }
    }
} 
