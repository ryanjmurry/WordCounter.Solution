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
            RepeatCounter newRepeatCounter = new RepeatCounter("can");

            //Act
            string result = newRepeatCounter.GetTargetWord();

            //Assert
            Assert.AreEqual("can", result);
        }
    }
}

        //Old Tests
//         [TestMethod]
//         public void GetSetTargetWord_GetsAndSetsTargetWord_String()
//         {
//             //Arrange
//             RepeatCounter newObject = new RepeatCounter();
//             newObject.SetTargetWord("can");
//
//             //Act
//             string result = newObject.GetTargetWord();
//
//             //Assert
//             Assert.AreEqual("can", result);
//         }
//
//         [TestMethod]
//         public void CheckTargetWordForPunctuation_ChecksTargetWordForPunctuation_True()
//         {
//             //Arrange
//             RepeatCounter newObject = new RepeatCounter();
//             newObject.SetTargetWord("can");
//
//             //Act
//             bool result = newObject.CheckTargetWordForPunctuation();
//
//             //Assert
//             Assert.AreEqual(true, result);
//         }
//
//         [TestMethod]
//         public void CheckTargetWordForPunctuation_ChecksTargetWordForPunctuation_False()
//         {
//             //Arrange
//             RepeatCounter newObject = new RepeatCounter();
//             newObject.SetTargetWord("c@n");
//
//             //Act
//             bool result = newObject.CheckTargetWordForPunctuation();
//
//             //Assert
//             Assert.AreEqual(false, result);
//         }
//
//         [TestMethod]
//         public void SetTargetWord_SetsTargetWordToLowerCase_String()
//         {
//             //Arrange
//             RepeatCounter newObject = new RepeatCounter();
//             newObject.SetTargetWord("CAN");
//
//             //Act
//             string result = newObject.GetTargetWord();
//
//             //Assert
//             Assert.AreEqual("can", result);
//         }
//
//         [TestMethod]
//         public void GetSetSearchPhrase_GetsAndSetsSearchPhrase_String()
//         {
//             //Arrange
//             RepeatCounter newObject = new RepeatCounter();
//             newObject.SetSearchPhrase("i can open the can of tuna.");
//
//             //Act
//             string result = newObject.GetSearchPhrase();
//
//             //Assert
//             Assert.AreEqual("i can open the can of tuna.", result);
//         }
//
//         [TestMethod]
//         public void SetSearchPhraseToLower_SetsSearchPhraseToLowerCase_String()
//         {
//             //Arrange
//             RepeatCounter newObject = new RepeatCounter();
//             newObject.SetSearchPhrase("I CAN OPEN THE CAN OF TUNA.");
//
//             //Act
//             newObject.SetSearchPhraseToLower();
//             string result = newObject.GetSearchPhrase();
//
//             //Assert
//             Assert.AreEqual("i can open the can of tuna.", result);
//         }
//
//         [TestMethod]
//         public void GetSetSearchList_GetsAndSetsSearchListFromSearchPhrase_List()
//         {
//             //Arrange
//             RepeatCounter newObject = new RepeatCounter();
//             newObject.SetSearchList("i can open the can of tuna.");
//
//             //Act
//             List<string> expected = new List<string>() { "i", "can", "open", "the", "can", "of", "tuna." };
//             List<string> result = newObject.GetSearchList();
//
//             //Assert
//             CollectionAssert.AreEqual(expected, result);
//         }
//
//         [TestMethod]
//         public void SetArrayEnd_SetsIndexAtEndOfArrayToSearchAt_Int()
//         {
//             //Arrange
//             RepeatCounter newObject = new RepeatCounter();
//
//             //Act
//             newObject.SetArrayEnd("'can'");
//             int result = newObject.GetArrayEnd();
//
//             //Assert
//             Assert.AreEqual(4, result);
//         }
//
//         //------------Buggy Edge Case Tests-----------------//
//
//         // [TestMethod]
//         // public void GetSetCleanSearchList_GetsAndSetsCleanSearchListFromSearchList_List()
//         // {
//         //     //Arrange
//         //     RepeatCounter newObject = new RepeatCounter();
//         //     newObject.SetSearchList("'can'");
//         //
//         //     //Act
//         //     newObject.SetCleanSearchList();
//         //     List<string> expected = new List<string>() { "can" };
//         //     List<string> result = newObject.GetSearchList();
//         //     foreach(string word in expected)
//         //     {
//         //         Console.WriteLine(word);
//         //     }
//         //     Console.WriteLine("");
//         //     foreach(string word in result)
//         //     {
//         //         Console.WriteLine(word);
//         //     }
//         //     Console.WriteLine(newObject.GetArrayStart());
//         //     Console.WriteLine(newObject.GetArrayEnd());
//         //
//         //
//         //     CollectionAssert.AreEqual(expected, result);
//         // }
//
//         //------------End of Buggy Edge Case Tests-----------------//
//
//         [TestMethod]
//         public void IncrementMatches_IncrementNumberOfMatches_Int()
//         {
//             //Arrange
//             RepeatCounter newObject = new RepeatCounter();
//
//             //Act
//             newObject.IncrementMatches();
//             int result = newObject.GetMatches();
//
//             //Assert
//             Assert.AreEqual(1, result);
//         }
//
//         [TestMethod]
//         public void SetGetMatches_SetAndGetNumberOfMatches_Int()
//         {
//             //Arrange
//             RepeatCounter newObject = new RepeatCounter();
//             newObject.SetTargetWord("can");
//             newObject.SetSearchList("I can open a can of tuna.");
//
//             //Act
//             newObject.SetMatches();
//             int result = newObject.GetMatches();
//
//             //Assert
//             Assert.AreEqual(2, result);
//         }
//
//         [TestMethod]
//         public void NumberOfMatches_NumberOfMatchesInSearchList_Int()
//         {
//             //Arrange
//             RepeatCounter newObject = new RepeatCounter();
//
//             //Act
//             int result = newObject.NumberOfMatches("CAN", "I CAN OPEN A CAN OF TUNA");
//
//             //Assert
//             Assert.AreEqual(2, result);
//         }
//
//         [TestMethod]
//         public void NumberOfMatches_NumberOfMatchesInSearchListWithPunctuation_Int()
//         {
//             //Arrange
//             RepeatCounter newObject = new RepeatCounter();
//
//             //Act
//             int result = newObject.NumberOfMatches("CAN", "I 'CAN' OPEN A CAN OF TUNA.");
//
//             //Assert
//             Assert.AreEqual(1, result);
//         }
//     }
// }
