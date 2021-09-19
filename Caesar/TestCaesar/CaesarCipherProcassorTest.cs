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

        [TestCase("xyZ", 3, "abC")]
        [TestCase("BCd", 23, "YZa")]
        [TestCase("hfjdk", 0, "hfjdk")]
        [TestCase("gHi", 24, "eFg")]
        public void CesarEncryptionProcessorTest_Positive(string input, int key, string expected)
        {
            var processor = new CaesarCipherProcessor();

            var result = processor.Encrypt(input, key);
            Assert.AreEqual(expected, result);
        }

        [TestCase("CDE", 5, "XYZ")]
        [TestCase("hfjdk", 0, "hfjdk")]
        [TestCase("gHi", 2, "eFg")]
        [TestCase("eFg", 24, "gHi")]

        public void CesarDecryptionProcessorTest_Positive(string input, int key, string expected)
        {
            var processor = new CaesarCipherProcessor();

            var result = processor.Decrypt(input, key);
            Assert.AreEqual(expected, result);
        }
    }
}