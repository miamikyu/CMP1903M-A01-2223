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
        //ask richard wtf is going on 
        //erm variables maybe not seen across classes oops
        
            for (int y=1; y<5; y=y+1)
            {
                for (int i=1; i<14; i=i+1)
                {
                    Card new_card=new Card();
                    pack.Add(new_card)
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
