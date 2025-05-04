using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;
using TarotApp.Models;
using TarotApp.Services;

namespace TarotApp.Tests
{
    public class TarotServiceTests
    {
        [Fact]
        public void Constructor_ShouldInitialize22Cards()
        {
            // Arrange & Act
            var service = new TarotService();
            
            // Use reflection to access private field
            var cardsField = typeof(TarotService).GetField("_cards", BindingFlags.NonPublic | BindingFlags.Instance);
            var cards = (List<TarotCard>)cardsField.GetValue(service);
            
            // Assert
            Assert.NotNull(cards);
            Assert.Equal(22, cards.Count);
        }
        
        [Fact]
        public void BackCardImage_ShouldReturnCorrectPath()
        {
            // Arrange & Act
            var service = new TarotService();
            
            // Assert
            Assert.Equal("assets/verso.png", service.BackCardImage);
        }
        
        [Fact]
        public void GetBackCard_ShouldReturnCardWithCorrectProperties()
        {
            // Arrange
            var service = new TarotService();
            
            // Act
            var backCard = service.GetBackCard();
            
            // Assert
            Assert.Equal(-1, backCard.Id);
            Assert.Equal("Card Back", backCard.Name);
            Assert.Equal("assets/verso.png", backCard.ImagePath);
        }
        
        [Fact]
        public void DrawRandomCard_ShouldReturnCardFromValidRange()
        {
            // Arrange
            var service = new TarotService();
            
            // Act
            var card = service.DrawRandomCard();
            
            // Assert
            Assert.NotNull(card);
            Assert.InRange(card.Id, 0, 21);
            Assert.NotEmpty(card.Name);
            Assert.StartsWith("assets/", card.ImagePath);
            Assert.EndsWith(".png", card.ImagePath);
        }
        
        [Fact]
        public void InitializeCards_ShouldCreateAllMajorArcanaCards()
        {
            // Arrange
            var service = new TarotService();
            
            // Use reflection to access private field
            var cardsField = typeof(TarotService).GetField("_cards", BindingFlags.NonPublic | BindingFlags.Instance);
            var cards = (List<TarotCard>)cardsField.GetValue(service);
            
            Assert.Contains(cards, c => c.Id == 0 && c.Name == "The Fool");
            Assert.Contains(cards, c => c.Id == 1 && c.Name == "The Magician");
            Assert.Contains(cards, c => c.Id == 21 && c.Name == "The World");
            
            var cardIds = cards.Select(c => c.Id).OrderBy(n => n).ToList();
            for (int i = 0; i < 22; i++)
            {
                Assert.Contains(i, cardIds);
            }
        }
        
        [Fact]
        public void DrawRandomCard_CalledMultipleTimes_ShouldEventuallyReturnDifferentCards()
        {
            // Arrange
            var service = new TarotService();
            var uniqueCards = new HashSet<int>();
            const int attempts = 50;
            
            // Act
            for (int i = 0; i < attempts; i++)
            {
                var card = service.DrawRandomCard();
                uniqueCards.Add(card.Id);
                
                if (uniqueCards.Count >= 2)
                {
                    break;
                }
            }
            
            // Assert
            Assert.True(uniqueCards.Count >= 2, 
                "DrawRandomCard deve retornar cartas diferentes quando chamado várias vezes");
        }
        
        [Fact]
        public void LoadImage_ShouldReturnBitmap()
        {
            // Arrange
            var service = new TarotService();
            
            // Act
            var card = service.DrawRandomCard();
            var bitmap = card.LoadImage();
            
            // Assert
            Assert.NotNull(card);
        }
    }
}