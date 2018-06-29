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
        public void DoIPass_TestToSeeIfThisWorks_True()
        {
            RepeatCounter newObject = new RepeatCounter();
            Assert.AreEqual(true, newObject.DoIPass());
        }
    }
}
