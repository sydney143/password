using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Text;

namespace password
{
class Program{
 
        private const string CapitalLetters = "QWINSITMEYOPJENTK";
        private const string SmallLetters = "qwertyuioplkndhgs";
        private const string Digits ="0123645789";
        private const string SpecialCharacters = "!@#$%^&*<>?/*=+";
        private const string AllChars = CapitalLetters+SmallLetters+Digits+SpecialCharacters;
        private static Random rnd =new Random();


        public static void Main()
        {
           StringBuilder password = new StringBuilder();
           for(int i = 1; i<=2; i++)
           {
               char capitalLetters = GenerateChar(CapitalLetters);
               InsertAtRandomPositions(password,capitalLetters);
            
           }
           for(int i =1; i< 2; i++) 
           {
               char smallLetters = GenerateChar(SmallLetters);
                InsertAtRandomPositions(password,smallLetters);
           }
           char digit = GenerateChar(Digits);
                InsertAtRandomPositions(password,digit);

                for (int i =1; i<=3; i++)
                {
                    char specialCharacters = GenerateChar( SpecialCharacters);
                InsertAtRandomPositions(password, specialCharacters);
        
                }
                int count = rnd.Next(8);
                for(int i =1; i<=count; i++)
                {
                    char SpecialCharacters = GenerateChar(AllChars);
                    InsertAtRandomPositions(password,SpecialCharacters);
                }
           Console.WriteLine("Your Password is ");     
           Console.WriteLine(password);
        }
    private static void InsertAtRandomPositions(StringBuilder password, char character)
    {
        int randomPostion = rnd.Next (password.Length+1);
        password.Insert( randomPostion, character);
    }

    private static char GenerateChar (string availableChars)
    {
        int randomIndex = rnd.Next(availableChars.Length);
        char randomChar = availableChars[randomIndex];
        return randomChar;
    }
}
}

