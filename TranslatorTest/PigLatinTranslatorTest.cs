using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_6_PigLatinTranslator;

namespace TranslatorTest
{
    [TestClass]
    public class PigLatinTranslatorTest
    {
        [TestMethod]
        public void TestThatAppletoAppleway()
        {
            string toTranslate = "apple";
             Translator brad = new Translator();
           string translatedString = brad.Translate(toTranslate);
            Assert.AreEqual("appleway", translatedString);

        }

        [TestMethod]
        public void TestThatLaptoptoAptopay()
        {
            string toTranslate = "laptop";
            Translator brad = new Translator();
            string translatedString = brad.Translate(toTranslate);
            Assert.AreEqual("aptoplay", translatedString);
            
        }

        [TestMethod]
        public void TestThatBreadwaytoEadbray()
        {
            string toTranslate = "bread";
            Translator brad = new Translator();
            string translatedString = brad.Translate(toTranslate);
            Assert.AreEqual("eadbray", translatedString);
            
        }

        [TestMethod]
        public void TestThatScrapwayToApscray()
        {
            string toTranslate = "scrap";
            Translator brad = new Translator();
            string translatedString = brad.Translate(toTranslate);
            Assert.AreEqual("apscray", translatedString);

        }


    }
}
