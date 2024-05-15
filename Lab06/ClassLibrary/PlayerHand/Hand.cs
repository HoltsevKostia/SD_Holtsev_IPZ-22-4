﻿using ClassLibrary.Cards;
using ClassLibrary.CoRValueHandling;

namespace ClassLibrary.PlayerHand
{
    public class Hand
    {
        private List<Card> cards;
        private CardValueCalculator calculator;

        public Hand()
        {
            cards = new List<Card>();
            calculator = new CardValueCalculator();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public int CalculateTotalValue()
        {
            return calculator.CalculateTotalValue(cards);
        }

        public override string ToString()
        {
            return string.Join(", ", cards);
        }
    }
}