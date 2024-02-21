using EvaluationSampleCode;

namespace PratiqueWithCodeUnitTests
{
    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations _mathOperations;

        [TestInitialize]
        public void TestInitialize()
        {
            // Arrange
            _mathOperations = new MathOperations();
        }
        [TestMethod]
        [DataRow(1, 2)]
        public void Subtract_WhenFirstNumberIsLowerThanSecondNumber_ShouldThrowArgumentException(int numberOne, int numberTwo)
        {
            // Act
            Action act = () => _mathOperations.Subtract(numberOne, numberTwo);
            // Assert
            Assert.ThrowsException<ArgumentException>(act);
        }
        [TestMethod]
        [DataRow(1200, 1)]
        public void Subtract_WhenFirstNumberIsHigherOrEqualTo1200_ShouldThrowArgumentException(int numberOne, int numberTwo)
        {
            // Act
            Action act = () => _mathOperations.Subtract(numberOne, numberTwo);
            // Assert
            Assert.ThrowsException<ArgumentException>(act);
        }
        [TestMethod]
        [DataRow(2, 1)]
        public void Subtract_WhenFirstNumberIs2AndSecondNumberIs1_ShouldReturn1(int numberOne, int numberTwo)
        {
            // Act
            var result = _mathOperations.Subtract(numberOne, numberTwo);
            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        [DataRow(-1)]
        public void GetColorFromOddsNumber_WhenNumberIsNegative_ShouldThrowArgumentException(int number)
        {
            // Act
            Action act = () => _mathOperations.GetColorFromOddsNumber(number);
            // Assert
            Assert.ThrowsException<ArgumentException>(act);
        }
        [TestMethod]
        [DataRow(1)]
        public void GetColorFromOddsNumber_WhenNumberIs1_ShouldReturnBlue(int number)
        {
            // Act
            var result = _mathOperations.GetColorFromOddsNumber(number);
            // Assert
            Assert.AreEqual("Blue", result);
        }
        [TestMethod]
        [DataRow(2)]
        public void GetColorFromOddsNumber_WhenNumberIs2_ShouldReturnRed(int number)
        {
            // Act
            var result = _mathOperations.GetColorFromOddsNumber(number);
            // Assert
            Assert.AreEqual("Red", result);
        }
    }
}