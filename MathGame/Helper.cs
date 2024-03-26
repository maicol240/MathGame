using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    static class Helper 
    {

        /// <summary>
        /// Contantains menus and Write(Desired Color)Method
        /// </summary>
        public static void DisplayMenu()  //Menu
        {
            Console.WriteLine(" -----Menu------");
            Console.Write("|"); Console.Write("1)Add"); Console.WriteLine("\t    \t|");
            Console.Write("|"); Console.Write("2)Substract"); Console.WriteLine("\t|");
            Console.Write("|"); Console.Write("3)Multiply"); Console.WriteLine("\t|");
            Console.Write("|"); Console.Write("4)Division"); Console.WriteLine("\t|");
            Console.Write("|"); Console.Write("5)Random"); Console.WriteLine("\t|");
            Console.Write("|"); Console.Write("6)DisplayScores"); Console.WriteLine("|");
            Console.Write("|"); Console.Write("7)Exit"); Console.WriteLine("\t\t|");
            Console.WriteLine(" ---------------");
            Console.WriteLine();

            Console.Write("Choice: ");

        }

     


        public static string WelcomeMessage()
        {
            //- - - - - WELCOME Message and Ask For Name-----
            Console.Write("Welcome Player Whats Your Name: ");
            string? name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Helper.Write("Please Player enter Your Name: ",ConsoleColor.Red);
                name = Console.ReadLine();
            }
            return name;

        }  //Welcomes the Player and Ask For name

        public static int MenuInputValid(string? choice)
        {



            while (true)
            {
                if (!string.IsNullOrEmpty(choice) && int.TryParse(choice, out int number) && number <= 7 && number > 0)
                {
                    return number;

                }
                else
                Console.WriteLine();
                Helper.Write($"{choice} is not a valid Option enter a different Value: ",ConsoleColor.Red);
                choice = Console.ReadLine(); 

            }
         
           


         }


        public static void Write(string message,ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ForegroundColor = ConsoleColor.White;


        }   /// Change Foreground color to desired Color after executing returns the foreground to white. Does not Skip
        public static void WriteLine(string message,ConsoleColor color) 
            {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
            } /// Change Foreground color to desired Color after executing returns the foreground to white. Skips Line

        







    }





}

