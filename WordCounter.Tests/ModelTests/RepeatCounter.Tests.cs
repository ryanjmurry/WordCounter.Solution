using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter;
namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void GetSetTargetWord_GetsAndSetsTargetWord_String()
        {
            //Arrange
            RepeatCounter newObject = new RepeatCounter();
            newObject.SetTargetWord("can");

            //Act
            string result = newObject.GetTargetWord();

            //Assert
            Assert.AreEqual("can", result);
        }

        [TestMethod]
        public void CheckTargetWordForPunctuation_ChecksTargetWordForPunctuation_True()
        {
            //Arrange
            RepeatCounter newObject = new RepeatCounter();
            newObject.SetTargetWord("can");

            //Act
            bool result = newObject.CheckTargetWordForPunctuation();

            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CheckTargetWordForPunctuation_ChecksTargetWordForPunctuation_False()
        {
            //Arrange
            RepeatCounter newObject = new RepeatCounter();
            newObject.SetTargetWord("c@n");

            //Act
            bool result = newObject.CheckTargetWordForPunctuation();

            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void SetTargetWordToLower_SetsTargetWordToLowerCase_String()
        {
            //Arrange
            RepeatCounter newObject = new RepeatCounter();
            newObject.SetTargetWord("CAN");

            //Act
            newObject.SetTargetWordToLower();
            string result = newObject.GetTargetWord();

            //Assert
            Assert.AreEqual("can", result);
        }

        [TestMethod]
        public void GetSetSearchPhrase_GetsAndSetsSearchPhrase_String()
        {
            //Arrange
            RepeatCounter newObject = new RepeatCounter();
            newObject.SetSearchPhrase("I can open the can of tuna.");

            //Act
            string result = newObject.GetSearchPhrase();

            //Assert
            Assert.AreEqual("I can open the can of tuna.", result);
        }

        [TestMethod]
        public void SetSearchPhraseToLower_SetsSearchPhraseToLowerCase_String()
        {
            //Arrange
            RepeatCounter newObject = new RepeatCounter();
            newObject.SetSearchPhrase("I CAN OPEN THE CAN OF TUNA.");

            //Act
            newObject.SetSearchPhraseToLower();
            string result = newObject.GetSearchPhrase();

            //Assert
            Assert.AreEqual("i can open the can of tuna.", result);
        }

        [TestMethod]
        public void GetSetSearchList_GetsAndSetsSearchListFromSearchPhrase_List()
        {
            //Arrange
            RepeatCounter newObject = new RepeatCounter();
            newObject.SetSearchPhrase("I can open the can of tuna.");

            //Act
            List<string> expected = new List<string>() { "i", "can", "open", "the", "can", "of", "tuna." };
            newObject.SetSearchList();
            List<string> result = newObject.GetSearchList();

            //Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
