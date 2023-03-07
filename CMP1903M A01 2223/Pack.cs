using System;
using System.Collections.Generic;
using System.Globalization;
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
                Console.Write($"{card.Value}-{card.Suit}, ");
                
            }
        }

           
        //Class for creating the shuffle 
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1) //this will become the Fisher-Yates shuffle
            {
                Random rnd = new Random(); //used to create random numbers
                List<Card> fyPack = new List<Card>();
                int numElements = pack.Count;
                Card tempVar;
                while (numElements != 0)
                {
                    int fyRandomNumber = rnd.Next(0, pack.Count-1); //creates a random number up to 52 to select from pack
                    //0 to 51 used for starting at element 0
                    tempVar = pack[fyRandomNumber];
                    fyPack.Add(tempVar);
                    pack.RemoveAt(fyRandomNumber);
                    numElements --;
                }
                pack = fyPack;
            }
            else if (typeOfShuffle == 2) //riffle shuffle time 
            {
                //creates lists for the shuffled list and the two halves of the original list 
                List<Card> rsPack = new List<Card>();
                List<Card> rsHalfPack1 = new List<Card>();
                List<Card> rsHalfPack2 = new List<Card>();
                //halfs the pack list into two lists 
                int midPoint = pack.Count / 2;
                //getting the max number 
                int numElements = pack.Count;
                //this gets the first half of pack into a new list 
                for (int i = 0; i=midPoint-1; i++)
                {
                    rsHalfPack1.Add(pack[i]);
                }
                //thsi gets the second half of pack into a list 
                for (int k=midPoint; k=numElements; k++)
                {
                    rsHalfPack2.Add(pack[midPoint]);
                }
                //this joins them both together 
                for (int j = 0; j=numElements; j++)
                {
                    rsPack.Add(rsHalfPack1[j]);
                    rsPack.Add(rsHalfPack2[j]);
                }
                pack = rsPack;

            }
            return true;
            
          
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
