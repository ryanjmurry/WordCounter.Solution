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
    }
}
