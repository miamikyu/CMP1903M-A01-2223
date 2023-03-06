using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    enum suitEnum
    {
        Hearts=1,
        Diamonds=2,
        Clubs=3,
        Spades=4,
    }
    public class Card
    {
        //Base for the Card class.
        //sets the private fields and public properties of the class
        //fucking semi colons
        private int cardValue;
        private int suit;
        public Card(int ccardValue, int cardSuit)
        {
            cardValue = ccardValue;
            suit = cardSuit;
        }

        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value 
        {
            get{
                return cardValue;
            } 
            set{
                if(value<15){
                    cardValue=value;
                }else{
                    Console.WriteLine("Error");
                    //Error
                }
            } 
        }
        //using the getter and setter for validation and to change numerical value to a string
        public int Suit 
        {
            get{
                return suit;
            } 
            set{
                if(value==1){
                    suit=(int)suitEnum.Hearts;
                }else if(value==2){
                    suit= (int)suitEnum.Diamonds;
                }else if(value==3){
                    suit=(int)suitEnum.Clubs;
                }else if(value==4){
                    suit=(int)suitEnum.Spades;
                }
                else{
                    Console.WriteLine("Error"); 
                    //Error
                }
            } 
        }
    }
}
