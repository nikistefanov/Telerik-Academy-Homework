namespace Santase.Tests
{
    using System;
    using NUnit.Framework;
    using Santase.Logic;
    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTests
    {
        private Deck deck;

        [SetUp]
        public void Init()
        {
            deck = new Deck();
        }

        [TearDown]
        public void CleanUp()
        {
            deck = null;
        }

        [Test]
        public void ListOfCardsShouldHaveValidLengthWhenDeckIsCreated()
        {
            Assert.AreEqual(24, deck.CardsLeft);
        }

        [Test]
        public void ChangeTrumpCardShouldSucceedWhenProvidedValidData()
        {
            var card = new Card(CardSuit.Heart, CardType.Queen);
            deck.ChangeTrumpCard(card);
            Assert.AreSame(card, deck.GetTrumpCard);
        }

        [Test]
        public void ChangeTrumpCardShouldThrowArgumentNullExceptionWhenProvidedNullData()
        {
            Assert.Throws(typeof(ArgumentNullException), () => deck.ChangeTrumpCard(null));
        }

        [TestCase(0, Result = 24)]
        [TestCase(5, Result = 19)]
        [TestCase(10, Result = 14)]
        [TestCase(24, Result = 0)]
        [TestCase(25, ExpectedException= typeof(InternalGameException))]
        public int GetNextCardShouldProperlyUpdateListOfCards(int count)
        {
            Card card;
            for (int i = 0; i < count; i++)
            {
                card = deck.GetNextCard();
            }
            return deck.CardsLeft;
        }
    }
}
