using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_22;

namespace task_22_Tests
{
    /// <summary>
    /// class that checks creatunf prhonema
    /// </summary>
    [TestClass]
    public class CreatingPhonemaTest
    {       
        /// <summary>
        /// Test for Vowels Letters
        /// </summary>
        [TestMethod]
        public void ChangingVowelsLetters_Test()
        {
            string inputword = "ёлка";
            string expectedword = "йолка";
            Assert.AreEqual(expectedword, new Phonema().ChangingVowelsLetters(inputword).ToString());
        }

        /// <summary>
        /// Test for Voicing Consonants
        /// </summary>
        [TestMethod]
        public void VoicingConsonants_Test()
        {
            string inputword = "сде+лать";
            string expectedword = "здэлат";
            Assert.AreEqual(expectedword, new Phonema().ChangingVowelsLetters(inputword).ToString());
        }

        /// <summary>
        /// Test for Stunning Consonants
        /// </summary>
        [TestMethod]
        public void StunningConsonants_Test()
        {
            string inputword = "ду+б";
            string expectedword = "дуп";
            Assert.AreEqual(expectedword, new Phonema().ChangingVowelsLetters(inputword).ToString());
        }

        /// <summary>
        /// Test for Soft and Hard Mark
        /// </summary>
        [TestMethod]
        public void SoftHardMar_Test()
        {
            string inputword = "сде+лать";
            string expectedword = "здэлат'";
            Assert.AreEqual(expectedword, new Phonema().ChangingVowelsLetters(inputword).ToString());
        }
    }
}
