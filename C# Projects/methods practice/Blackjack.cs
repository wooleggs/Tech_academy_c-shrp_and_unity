﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace methods_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            { 
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
       
        }
      
        }
        

    


