using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;

        public Pack()
        {
            
            
        //nested for loop for each suit, each containing 13 cards
        //may have fixed this using the variable names from card.cs
        //think scope is still wrong though

            for (int suit=1; suit<5; suit=suit+1)
            {
                for (int cardValue=1; cardValue<14; cardValue=cardValue+1)
                {
                    Card newCard=new Card();
                    pack.Add(newCard)
                }
            }
        
            //Initialise the card pack here 
            
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            // Test
        }
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
    }
}
