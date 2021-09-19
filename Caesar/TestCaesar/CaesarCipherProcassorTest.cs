using Caesar.Core;
using NUnit.Framework;

namespace TestCaesar
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("YZa", 3, "BCd")]
        [TestCase("hfjdk", 0, "hfjdk")]
        [TestCase("eFg", 2, "gHi")]
        public void CesarEncryptionProcessorTest_Positive(string input, int key, string expected)
        {
            var processor = new CaesarCipherProcessor();

            var result = processor.Encrypt(input, key);
            Assert.AreEqual(expected, result);
        }

        //[TestCase("BCd", 3, "YZa")]
        [TestCase("hfjdk", 0, "hfjdk")]
        [TestCase("gHi", 2, "eFg")]
        public void CesarDecryptionProcessorTest_Positive(string input, int key, string expected)
        {
            var processor = new CaesarCipherProcessor();

            var result = processor.Decrypt(input, key);
            Assert.AreEqual(expected, result);
        }
    }
}