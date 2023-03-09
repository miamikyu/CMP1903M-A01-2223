using System;
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
            Pack pack = new Pack();
            //Testing tests = new Testing();
            //tests.runTests();
            //Console.ReadLine();
            bool userContinue= true;
            while (userContinue == true)
            {
                Console.WriteLine("Enter what number shuffle you would like to do");
                Console.WriteLine("Enter 1 for Fisher Yates Shuffle");
                Console.WriteLine("Enter 2 for Riffle Shuffle");
                Console.WriteLine("Enter 3 for no shuffle");


                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    Pack.shuffleCardPack(1);
                    userContinue = false;
                    pack.showCards();
                }
                else if (answer == "2")
                {
                    Pack.shuffleCardPack(2);
                    userContinue = false;
                    pack.showCards();
                }
                else if (answer == "3")
                {
                    Pack.shuffleCardPack(3);
                    userContinue = false;
                    pack.showCards();

                }
            }
            Console.WriteLine("\nEnter 1 to deal 1 card");
            Console.WriteLine("Enter 2 to deal an amount of cards of your choosing");

            string nextAnswer = Console.ReadLine();
            if (nextAnswer == "1")
            {
                Card card = Pack.deal();
                Console.Write(card.ToString());
            }
            else if (nextAnswer == "2")
            {
                Console.WriteLine("Enter the amount of cards you would like to deal");

                //takes the input as an int
                int numOfCardsDealt = Int32.Parse(Console.ReadLine());
                List<Card> cardsToDeal = Pack.dealCard(numOfCardsDealt);
                pack.showCards(cardsToDeal);
            }
            else
            {
                Console.WriteLine("Answer not found");
            }
        Console.ReadLine();
        }
    }
}
