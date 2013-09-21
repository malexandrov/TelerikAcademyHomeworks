using System;
using System.Collections.Generic;
using System.Text;

namespace _1.StringBuilderSubstring
{
    public static class SubstringExtension
    {
        public static StringBuilder Substring(this StringBuilder inputString, int startIndex, int length=0)
        {
            StringBuilder resultString = new StringBuilder();
            int inputLength = inputString.Length;
            int endIndex = startIndex + length;

             if (length < 0 ||
                 startIndex < 0 || 
                 startIndex > inputLength || 
                 startIndex + length > inputLength)
            {
                throw new ArgumentOutOfRangeException("Index out of range!!!");
            }
            // If length is 0 - return string from index to the end
            else if (length == 0)
            {
                for (int i = startIndex; i < inputLength; i++)
                {
                    resultString.Append(inputString[i]);
                }
            }
            else
                for (int i = startIndex; i < endIndex; i++)
                {
                    resultString.Append(inputString[i]);
                }

            return resultString;
        }
    }
}
