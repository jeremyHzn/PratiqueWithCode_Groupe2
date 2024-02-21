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
        public void Parse_WhenIsNullOrWhiteSpace_ShouldThrowArgumentException()
        {
            // Act
            Action act = () => PhoneNumber.Parse("");
            // Assert
            Assert.ThrowsException<ArgumentException>(act);
        }
        [TestMethod]
        public void Parse_WhenLengthIsNot10_ShouldThrowArgumentException()
        {
            // Act
            Action act = () => PhoneNumber.Parse("065383547");
            // Assert
            Assert.ThrowsException<ArgumentException>(act);
        }
        [TestMethod]
        [DataRow("0653835472")]
        [DataRow("0653835473")]
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