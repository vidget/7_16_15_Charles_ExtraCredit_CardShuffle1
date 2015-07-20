﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Gregory Scott Norris - ExperienceIT 7-16-15
//Exercise 1: Shuffle Cards
//Write a program to create a standard 52 card deck and then deal a random hand to a player. Once a card is dealt then it can't be used again.


namespace _7_16_15_ExperIT_Charles_ExtraCredit_1
{
    class Program
    {
        static void Main(string[] args)
        {
            

           // List<string> userHand = new List<string>();//userhand holds the string of the card number & suit drawn by the user
            List<Hand> gameUser = new List<Hand>();//not really used in this program, but will be used in the multiplayer version. 

            int tempCard;//holds the drawn card
            int numberOfDraws = 0;//user input number of cards to draw
            bool isCardGone = true;//determines if a card is available or already taken from the deck







            Hand player1 = new Hand();//creates a HAND class called player1 and puts it into the LIST GAMEUSER
            Hand player2 = new Hand();
            Hand player3 = new Hand();
            Hand player4 = new Hand();


            gameUser.Add(player1);//using a list isn't necessary here, but will be when I modify for multiplayer
            gameUser.Add(player2);
            gameUser.Add(player3);


           

            Console.WriteLine("\n How many cards would you like to draw?");//prompts user for number of cards to draw
            Console.Write(" >");//user prompt

            numberOfDraws = int.Parse(Console.ReadLine());//parses in the user input for number of draws
            Console.Clear();







            for (int i = 0; i < numberOfDraws; i++)//loops through the selecting cards, adding to hand and removing from the deck
            {

                do//This will loop until the random number generates an available card.
                {
                    tempCard = gameUser[0].drawCard(); //drawCard Method generates a random number between 1&52
                    isCardGone = gameUser[0].checkIfAvailableCard(tempCard);//sends deck & drawn card to method to check if card drawn is still in deck, returns true if card has already been drawn
                } while (isCardGone == true); ////check that card hasn't been drawn yet

                gameUser[0].addCardtoHand(tempCard);//add the card to the userHand
                gameUser[0].removeCard(tempCard);//remove card from the deck


                
                

            }
            gameUser[0].displayHand();//display the users hand.



            Console.ReadLine();
        }

    }
}
