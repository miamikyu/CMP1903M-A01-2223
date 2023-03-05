using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //sets the private fields and public properties of the class

        private int cardValue
        public int Value 
        private int suit 
        public int Suit

        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value {
            get{
                return Value;
            } 
            set{
                if(value<15){
                    Value=value;
                }else{
                    //Error
                }
            } 
        }
        //using the getter and setter for validation and to change numerical value to a string
        public int Suit {
            get{
                return Suit;
            } 
            set{
                if(value==1){
                    Suit="Hearts";
                }else if(value==2){
                    Suit="Diamonds";
                }else if(value==3){
                    Suit="Clubs";
                }else if(value==4){
                    Suit="Spades";
                }else{
                    //Error
                }
            } 
        }
    }
}
