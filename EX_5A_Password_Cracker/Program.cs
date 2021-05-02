using System;

namespace EX_5A_Password_Cracker
{
    //
    //  Kurt Woodward
    //  ISTA 421 EX 5A
    //  Password Cracker
    //
    class Program
    {
        public static char[] Password { get; set; }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a password to crack:");
            string input = Console.ReadLine();
            char[] password = Input.GetInput(input);
            
            Password = password;

            Cracker.PopulateRainbow();
            Cracker.SingleThreadCracker();
        }
    }
}
