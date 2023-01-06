using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackjackObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackClassLibrary;

namespace BlackjackObjects.Tests
{
    [TestClass()]
    public class BlackjackHandTests
    {
        [TestMethod()]
        public void AddCardTest()
        {
            var obj = new BlackjackHand();
            //Add code here to unit test the AddCard method of the BlackjackHand class
            obj.AddCard(new BlackjackCard(Card.CardFace.A, Card.CardSuit.Clubs));
            obj.AddCard(new BlackjackCard(Card.CardFace.Eight, Card.CardSuit.Clubs));
            if (obj.Score != 19)
            {
                Assert.Fail();
            }
        }
    }
}