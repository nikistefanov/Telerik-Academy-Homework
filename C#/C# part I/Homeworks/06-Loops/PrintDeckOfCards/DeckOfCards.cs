//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

class DeckOfCards
{
    static void Main()
    {
        //clubs = '\u2663';
        //diamonds = '\u2666';
        //hearts = '\u2665';
        //spades = '\u2660';
        char[] suits = { '\u2663', '\u2666', '\u2665', '\u2660' };
        char currentSuit;
        for (int face = 2; face < 15; face++)
        {
            for (int colour = 0; colour < 4; colour++)
            {
                currentSuit = suits[colour];
                switch (face)
                {
                    case 2: Console.Write("2 " + currentSuit + "\t"); break;
                    case 3: Console.Write("3 " + currentSuit + "\t"); break;
                    case 4: Console.Write("4 " + currentSuit + "\t"); break;
                    case 5: Console.Write("5 " + currentSuit + "\t"); break;
                    case 6: Console.Write("6 " + currentSuit + "\t"); break;
                    case 7: Console.Write("7 " + currentSuit + "\t"); break;
                    case 8: Console.Write("8 " + currentSuit + "\t"); break;
                    case 9: Console.Write("9 " + currentSuit + "\t"); break;
                    case 10: Console.Write("10" + currentSuit + "\t"); break;
                    case 11: Console.Write("J " + currentSuit + "\t"); break;
                    case 12: Console.Write("Q " + currentSuit + "\t"); break;
                    case 13: Console.Write("K " + currentSuit + "\t"); break;
                    case 14: Console.Write("A " + currentSuit + "\t"); break;
                }
            }
            Console.WriteLine();
        }


        //using arrays
        //string[] face = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Ace", "Jack", "Queen", "King"};
        //char[] suits = new char[] { '\u2663', '\u2666', '\u2665', '\u2660' };

        //for (int i = 0; i < face.Length; i++)
        //{
        //    for (int j = 0; j < suits.Length; j++)
        //    {
        //        Console.Write("{0}\t{1}\t", face[i], suits[j]);
        //    }
        //    Console.WriteLine();
        //}
    }
}
