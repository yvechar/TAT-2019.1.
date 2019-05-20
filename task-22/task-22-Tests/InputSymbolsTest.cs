using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_22;

namespace task_22_Tests
{
    /// <summary>
    /// class that checks input symbols
    /// </summary>
    [TestClass]
    public class InputSymbolsTest
    { 
        /// <summary>
        /// word must contain +,ё 
        /// </summary>
        [TestMethod]
        public void Phonema_Containsstress()
        {
            string inputword = "молоко+";
            string expectedword = "молоко";
            Phonema phonema = new Phonema(inputword);
            Assert.AreEqual(expectedword, inputword);
        }

        [TestMethod]
        public void Phonema_Containsstressletter()
        {
            string inputword = "ёлка";
            string expectedword = "ёлка";
            Phonema phonema = new Phonema(inputword);
            Assert.AreEqual(expectedword, inputword);
        }

        /// <summary>
        /// word must contain only russion letters
        /// </summary>
        [TestMethod]
        public void SetWord_Containsrussionletters()
        {
            string inputword = "mолоко";
            Assert.ThrowsException<ArgumentOutOfRangeException>
             (
                () => new Phonema().SetWord(inputword)   
             );
        }

        /// <summary>
        /// word must not be a null
        /// </summary>
        [TestMethod]
        public void SetWord_null()
        {
            string inputword = null;
            Assert.ThrowsException<NullReferenceException>
             (
                () => new Phonema().SetWord(inputword)
             );
        }
    }
}
