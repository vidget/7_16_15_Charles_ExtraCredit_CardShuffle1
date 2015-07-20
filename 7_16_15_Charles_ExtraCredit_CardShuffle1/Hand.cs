using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_16_15_ExperIT_Charles_ExtraCredit_1
{
    //Gregory Scott Norris - ExperienceIT 7-16-15
    //Hand Class, holds cards and parameters for 5 cards

    class Hand
    {
        List<string> userHand = new List<string>();

        //create a INT array that holds a deck of 52 cards (1 = card in deck, 0 = card already drawn)
       
        int[] deck = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                           1, 1, 1, 1, 1, 1, 1, 1, 1, 1,1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 
                           1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        //currently not needed for single user, but will use when multiplayer
        public string card1 { get; set; }
        public string card2 { get; set; }
        public string card3 { get; set; }
        public string card4 { get; set; }
        public string card5 { get; set; }

        public int cardValue1 { get; set; }
        public int cardValue2 { get; set; }
        public int cardValue3 { get; set; }
        public int cardValue4 { get; set; }
        public int cardValue5 { get; set; }

        //creates a dictionary that holds 52 card strings with unicode card symbol \u0003 = Hearts \u0004 = Diamonds \u0005 = Clubs \u0006 = Spades
        Dictionary<int, string> cards = new Dictionary<int, string>()
            { 
                { 0,"A\u0006"},
                { 1,"2\u0006"},
                { 2,"3\u0006"},
                { 3,"4\u0006"},
                { 4,"5\u0006"},
                { 5,"6\u0006"},
                { 6,"7\u0006"},
                { 7,"8\u0006"},
                { 8,"9\u0006"},
                { 9,"10\u0006"},
                { 10,"J\u0006"},
                { 11,"Q\u0006"},
                { 12,"K\u0006"},
                { 13,"A\u0005"},
                { 14,"2\u0005"},
                { 15,"3\u0005"},
                { 16,"4\u0005"},
                { 17,"5\u0005"},
                { 18,"6\u0005"},
                { 19,"7\u0005"},
                { 20,"8\u0005"},
                { 21,"9\u0005"},
                { 22,"10\u0005"},
                { 23,"J\u0005"},
                { 24,"Q\u0005"},
                { 25,"K\u0005"},
                { 26,"A\u0003"},
                { 27,"2\u0003"},
                { 28,"3\u0003"},
                { 29,"4\u0003"},
                { 30,"5\u0003"},
                { 31,"6\u0003"},
                { 32,"7\u0003"},
                { 33,"8\u0003"},
                { 34,"9\u0003"},
                { 35,"10\u0003"},
                { 36,"J\u0003"},
                { 37,"Q\u0003"},
                { 38,"K\u0003"},
                { 39,"A\u0004"},
                { 40,"2\u0004"},
                { 41,"3\u0004"},
                { 42,"4\u0004"},
                { 43,"5\u0004"},
                { 44,"6\u0004"},
                { 45,"7\u0004"},
                { 46,"8\u0004"},
                { 47,"9\u0004"},
                { 48,"10\u0004"},
                { 49,"J\u0004"},
                { 50,"Q\u0004"},
                { 51,"K\u0004"},
            };

        public Hand()
        {
            card1 = "";
            card2 = "";
            card3 = "";
            card4 = "";
            card5 = "";

            cardValue1 = 0;
            cardValue2 = 0;
            cardValue3 = 0;
            cardValue4 = 0;
            cardValue5 = 0;
        }


        public void addCardtoHand(int cardNumber)// List<string> userHand)
        {
            userHand.Add(cards[cardNumber]);
        }



        public int drawCard()
        {
            //generates a random number between 0-51
            Random random = new Random();
            int randomNumber = random.Next(0, 52);
            return randomNumber;

        }

        public void removeCard(int userCard)//removes the card the user drew from the deck by setting the value of the deck array from 1 to 0
        {
            deck[userCard] = 0;
        }

        public void displayHand()//(List<string> userHand)//displays all the strings stored in the userHand list
        {
            Console.WriteLine("\n Your Hand:\n");

            for (int i = 0; i < userHand.Count; i++)
            {
                Console.Write(" " + userHand[i]);
            }
            Console.WriteLine();


        }

        public bool checkIfAvailableCard(int tempCard)//checks to see if the deck array contains a 1 or 0 taken or not, returns a BOOL
        {
            if (deck[tempCard] == 1)
                return false;//card is taken
            else
                return true;// not taken
        }

    }
}