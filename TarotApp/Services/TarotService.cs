using System;
using System.Collections.Generic;
using TarotApp.Models;

namespace TarotApp.Services
{
    public class TarotService
    {
        private readonly List<TarotCard> _cards;
        private readonly Random _random;
        
        public string BackCardImage { get; } = "assets/verso.png";

        public TarotService()
        {
            _random = new Random();
            _cards = InitializeCards();
        }

        private List<TarotCard> InitializeCards()
        {
            var cards = new List<TarotCard>
            {
                new TarotCard(0, "The Fool", "assets/0.png"),
                new TarotCard(1, "The Magician", "assets/1.png"),
                new TarotCard(2, "The High Priestess", "assets/2.png"),
                new TarotCard(3, "The Empress", "assets/3.png"),
                new TarotCard(4, "The Emperor", "assets/4.png"),
                new TarotCard(5, "The Hierophant", "assets/5.png"),
                new TarotCard(6, "The Lovers", "assets/6.png"),
                new TarotCard(7, "The Chariot", "assets/7.png"),
                new TarotCard(8, "Justice", "assets/8.png"),
                new TarotCard(9, "The Hermit", "assets/9.png"),
                new TarotCard(10, "Wheel of Fortune", "assets/10.png"),
                new TarotCard(11, "Strength", "assets/11.png"),
                new TarotCard(12, "The Hanged Man", "assets/12.png"),
                new TarotCard(13, "Death", "assets/13.png"),
                new TarotCard(14, "Temperance", "assets/14.png"),
                new TarotCard(15, "The Devil", "assets/15.png"),
                new TarotCard(16, "The Tower", "assets/16.png"),
                new TarotCard(17, "The Star", "assets/17.png"),
                new TarotCard(18, "The Moon", "assets/18.png"),
                new TarotCard(19, "The Sun", "assets/19.png"),
                new TarotCard(20, "Judgement", "assets/20.png"),
                new TarotCard(21, "The World", "assets/21.png")
            };
            
            return cards;
        }

        public TarotCard DrawRandomCard()
        {
            int randomIndex = _random.Next(0, _cards.Count);
            return _cards[randomIndex];
        }
        
        public TarotCard GetBackCard()
        {
            return new TarotCard(-1, "Card Back", BackCardImage);
        }
    }
}

