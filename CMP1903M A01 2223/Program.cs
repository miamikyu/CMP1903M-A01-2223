﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing tests = new Testing();
            //tests.runTests();
            //Console.ReadLine();
            bool userContinue= true;
            while (userContinue == true)
            {
                Console.WriteLine("Enter what number shuffle you would like to do");
                Console.WriteLine("Enter 1 for Fisher Yates Shuffle");
                Console.WriteLine("Enter 2 for Riffle Shuffle");
                Console.WriteLine("Enter 3 for other options");
                Console.WriteLine(">>");

                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    Pack.shuffleCardPack(1);
                    userContinue = false;
                }
                else if (answer == "2")
                {
                    Pack.shuffleCardPack(2);
                    userContinue = false;
                }
                else if (answer == "3")
                {
                    Console.WriteLine("For other options:");
                    Console.WriteLine("Enter 1 to deal 1 card");
                    Console.WriteLine("Enter 2 to deal an amount of cards of your choosing");
                    Console.WriteLine(">>");
                    string nextAnswer = Console.ReadLine();
                    if (nextAnswer == "1")
                    {
                        Pack.deal();
                        Console.ReadLine();
                        userContinue = false;
                    }
                    else if (nextAnswer == "2")
                    {
                        Console.WriteLine("Enter the amount of cards you would like to deal");
                        Console.WriteLine(">>");
                        int numOfCardsDealt = Console.ReadLine();
                        Pack.dealCard(numOfCardsDealt);
                        userContinue = false;
                    }
                    else
                    {
                        Console.WriteLine("Answer not found");
                        userContinue = true;
                    }
                }
            }

                
               
                   
            
                
            
        }
    }
}
