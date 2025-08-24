using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhonePadTest.Utils;

namespace PhonePadTest.Tests
{
    [TestClass]
    public class ConversionTests
    {
        [TestMethod]
        public void OldPhonePad_sample_one() //given sample
        {
            // Arrange
            var input = "33#";
            var expected = "E";

            // Act
            string actual = Conversion.OldPhonePad(input);

            // Assert
            Assert.AreEqual(expected, actual, "Output is not correct");
        }

        [TestMethod]
        public void OldPhonePad_sample_two() //given sample
        {
            // Arrange
            var input = "227*#";
            var expected = "B";

            // Act
            string actual = Conversion.OldPhonePad(input);

            // Assert
            Assert.AreEqual(expected, actual, "Output is not correct");
        }

        [TestMethod]
        public void OldPhonePad_sample_three() //given sample
        {
            // Arrange
            var input = "4433555 555666#";
            var expected = "HELLO";

            // Act
            string actual = Conversion.OldPhonePad(input);

            // Assert
            Assert.AreEqual(expected, actual, "Output is not correct");
        }

        [TestMethod]
        public void OldPhonePad_sample_five() //given sample
        {
            // Arrange
            var input = "8 88777444666*664#";
            var expected = "TURING";

            // Act
            string actual = Conversion.OldPhonePad(input);

            // Assert
            Assert.AreEqual(expected, actual, "Output is not correct");
        }

        [TestMethod]
        public void OldPhonePad_3_letters() //new sample
        {
            // Arrange
            var input = "222";
            var expected = "C";

            // Act
            string actual = Conversion.OldPhonePad(input);

            // Assert
            Assert.AreEqual(expected, actual, "Output is not correct");
        }

        [TestMethod]
        public void OldPhonePad_6_letters() //new sample
        {
            // Arrange
            var input = "222222";
            var expected = "C";

            // Act
            string actual = Conversion.OldPhonePad(input);

            // Assert
            Assert.AreEqual(expected, actual, "Output is not correct");
        }

        [TestMethod]
        public void OldPhonePad_7_letters() //new sample
        {
            // Arrange
            var input = "2222222";
            var expected = "A";

            // Act
            string actual = Conversion.OldPhonePad(input);

            // Assert
            Assert.AreEqual(expected, actual, "Output is not correct");
        }
    }
}
