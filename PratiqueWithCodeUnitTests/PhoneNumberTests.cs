using EvaluationSampleCode;

namespace PratiqueWithCodeUnitTests
{
    [TestClass]
    public class PhoneNumberTests
    {
        private string _number;
        [TestInitialize]
        public void TestInitialize()
        {
            // Arrange
            _number = "0653835472";

        }
        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        public void Parse_WhenIsNullOrWhiteSpace_ShouldThrowArgumentException(string data)
        {
            // Act
            Action act = () => PhoneNumber.Parse(data);
            // Assert
            Assert.ThrowsException<ArgumentException>(act);
        }
        [TestMethod]
        [DataRow("0")]
        [DataRow("99999999999999999999999999999")]
        public void Parse_WhenLengthIsNot10_ShouldThrowArgumentException(string number)
        {
            // Act
            Action act = () => PhoneNumber.Parse(number);
            // Assert
            Assert.ThrowsException<ArgumentException>(act);
        }
        [TestMethod]
        [DataRow("0100000000")]
        [DataRow("0999999999")]
        public void Parse_WhenNumberIsValide_ShouldReturnPhoneNumber(string number)
        {
            // Act
            var result = PhoneNumber.Parse(number);
            // Assert
            Assert.AreEqual(number.Substring(0, 3), result.Area);
            Assert.AreEqual(number.Substring(3, 3), result.Major);
            Assert.AreEqual(number.Substring(6), result.Minor);
        }
        [TestMethod]
        public void ToString_WhenPhoneNumberIsValide_ShouldReturnFormattedPhoneNumber()
        {
            // Arrange
            var phoneNumber = PhoneNumber.Parse(_number);
            // Act
            var result = phoneNumber.ToString();
            // Assert
            Assert.AreEqual($"({phoneNumber.Area}){phoneNumber.Major}-{phoneNumber.Minor}", result);
        }

    }
}