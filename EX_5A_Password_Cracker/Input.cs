using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_5A_Password_Cracker
{
    class Input
    {
        public static StringBuilder pwd = new StringBuilder();
        public static char[] GetInput(string input)
        {
            //string output = "";
            int counter = -1;
            int pwLength = input.Trim().Length;
            char[] pwArray = new char[pwLength];

            //string rawInput = input;

            foreach (char c in input)
            {
                counter++;
                if (c >= 33 && c <= 126 )
                {
                    //output += c.ToString();
                    pwArray[counter] = Convert.ToChar(c);
                    pwd.Append(c);
                }
            }

            //Console.WriteLine($"{output}, {counter}");
            return pwArray;
        }
    }
}
