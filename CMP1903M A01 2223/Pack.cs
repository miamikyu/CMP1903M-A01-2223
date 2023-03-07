using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        static List<Card> pack;
        static List<Card> fyPack; //fisher yates shuffle pack
     

        public Pack()
        {
            
            
        //nested for loop for each suit, each containing 13 cards
        
            pack= new List<Card>();
            for (int suit=1; suit<5; suit=suit+1)
            {
                for (int cardValue=1; cardValue<14; cardValue=cardValue+1)
                {
                    Card newCard=new Card(suit, cardValue);
                    pack.Add(newCard);
                }
            }
            
            //Initialise the card pack here 
            
        }

        public void showCards()
        {
            foreach (Card card in pack)
            {
                Console.WriteLine($"{card.Value}-{card.Suit}");
                
            }
        }

           
        //Class for creating the shuffle 
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1) //this will become the Fisher-Yates shuffle
            {
                fyPack = new List<Card>();
                Random rnd = new Random(); //used to create random numbers
                List<Card> pack = new List<Card>();
                int numElements = List<Card>.Count;
                while (numElements = !0)
                {
                    int fyRandomNumber = rnd.Next(0, 51); //creates a random number up to 52 to select from pack
                    //0 to 51 used for starting at element 0
                    tempVar = pack[fyRandomNumber];
                    fyPack.Add(tempVar);
                    pack.RemoveAt(fyRandomNumber);
                }
            }
            else
            {
                return true;
            }
            
          
        }
        public static Card deal()
        {
            return new Card(1, 2);
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            return new List<Card>();
            //Deals the number of cards specified by 'amount'
        }
    }
}
