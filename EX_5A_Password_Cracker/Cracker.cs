using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_5A_Password_Cracker
{
    //
    //  Kurt Woodward
    //  ISTA 421 EX 5A
    //  Password Cracker
    //
    class Cracker
    {
        public static char[] Rainbow { get; set; }

        public static void PopulateRainbow()
        {
            char[] rainbow = new char[94];
            //string r = "";    //test print of rainbow table to confirm it has all printable characters on keyboard

            // populate char array to use as a rainbow table
            for (int i = 33; i <= 126; i++)
            {
                rainbow[i-33] = Convert.ToChar(i);
                //r += rainbow[i - 33];     
            }
            Rainbow = (char[])rainbow.Clone();
            //Console.WriteLine(r);
        }

        // This method can brute force a password one letter at a time. Need to modify it to only exit once the whole password matches.

        public static void SingleThreadCracker()
        {
            char[] pwToCrack = Program.Password;
            char[] crackedPW = new char[pwToCrack.Length];
            string cpwd = "";
            for (int i = 0; i < pwToCrack.Length; i++)
            {
                Console.WriteLine(pwToCrack[i]);
                foreach (char r in Rainbow)
                {
                    Console.WriteLine($"{r} tested against {pwToCrack[i]}");

                    if (pwToCrack[i] == r)
                    {
                        cpwd += r;
                        //break;
                    }
                    //Console.WriteLine(crackedPW);
                }
            }

            Console.WriteLine($"Password is {Convert.ToString(cpwd)}");
        }


        //public static bool SingleThreadCracker()
        //{

        //    //char[] pwToCrack = (char[])Program.Password.Clone();
        //    char[] pwToCrack = Program.Password;
        //    //char[] crackedPW = new char[pwToCrack.Length];
        //    char[] crackedPW = { 'H' };
        //    //string cpw = "";
        //    StringBuilder cpwd = new StringBuilder();
        //    bool cracked = false;

        //    for (int j = 0; j < Input.pwd.Length; j++)
        //    {
        //        for (int i = j; i < Input.pwd.Length; i++)
        //        {

        //            cpwd.Append(Rainbow[i]);
        //            if (cpwd == Input.pwd)
        //            {
        //                Console.WriteLine(cpwd);
        //                return true;
        //            }
        //        }
        //        if (cpwd == Input.pwd)
        //        {
        //            Console.WriteLine(cpwd);
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }


        //    //do
        //    //{
        //    //    for (int i = 0; i < Rainbow.Length; i++)
        //    //    {

        //    //        while (cracked == false)
        //    //        {
        //    //            for (int c = 0; c < crackedPW.Length; c++)
        //    //            {
        //    //                crackedPW[c] = Rainbow[i];
        //    //                //Console.WriteLine($"{crackedPW[0]} / {crackedPW[1]} / {crackedPW[2]}");
        //    //                cpwd.Append(Rainbow[i]);
        //    //                Console.WriteLine(cpwd.ToString());
        //    //                if (0 == String.Compare(cpwd.ToString(), Input.pwd.ToString()))
        //    //                {
        //    //                    cracked = true;
        //    //                    break;
        //    //                }
        //    //            }
        //    //            //cracked = pwToCrack.SequenceEqual(crackedPW);
        //    //            //cracked = cpwd.ToString() == Input.pwd.ToString();
        //    //        }
        //    //    }
        //    //        //else
        //    //        //{
        //    //        //    Console.WriteLine(sb.ToString());
        //    //        //    return;
        //    //        //}
        //    //}
        //    //while (cracked == false);

        //    //Console.WriteLine(Input.pwd.ToString() + " " + cpwd);
        //    //foreach (char c in crackedPW)
        //    //{
        //    //    Console.WriteLine(c);
        //    //    cpw += c;
        //    //}




    }

}

