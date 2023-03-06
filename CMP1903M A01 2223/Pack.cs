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

           

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            return true;
            //Shuffles the pack based on the type of shuffle
            // Test
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
