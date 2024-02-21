using EvaluationSampleCode;

namespace PratiqueWithCodeUnitTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        private HtmlFormatHelper helper;
        [TestInitialize]
        public void TestInitialize()
        {
            // Arrange
            helper = new HtmlFormatHelper();
        }
        [TestMethod]
        [DataRow("Hello")]
        public void GetStrongFormat_WhenContentIsHello_ShouldReturnBoldHello(string text)
        {
            // Act
            var result = helper.GetStrongFormat(text);
            // Assert
            Assert.AreEqual($"<strong>{text}</strong>", result);
        }
        [TestMethod]
        [DataRow("Hello")]
        public void GetItalicFormat_WhenContentIsHello_ShouldReturnItalicHello(string text)
        {
            // Act
            var result = helper.GetItalicFormat(text);
            // Assert
            Assert.AreEqual($"<i>{text}</i>", result);
        }
        [TestMethod]
        public void GetFormattedListElements_WhenListIsEmpty_ShouldReturnEmptyList()
        {
            // Act
            var result = helper.GetFormattedListElements(new List<string>());
            // Assert
            Assert.AreEqual("<ul></ul>", result);
        }
        [TestMethod]
        [DataRow("Hello")]
        public void GetFormattedListElements_WhenListHasOneElement_ShouldReturnListWithOneElement(string text)
        {
            // Arrange
            var list = new List<string> { text };
            // Act
            var result = helper.GetFormattedListElements(list);
            // Assert
            Assert.AreEqual(
                $"<ul>" +
                    $"<li>{text}</li>" +
                $"</ul>",
            result);
        }
        [TestMethod]
        [DataRow("Hello", "World")]
        public void GetFormattedListElements_WhenListHasTwoElements_ShouldReturnListWithTwoElements(string text1, string text2)
        {
            // Arrange
            var list = new List<string> { text1, text2 };
            // Act
            var result = helper.GetFormattedListElements(list);
            // Assert
            Assert.AreEqual(
                $"<ul>" +
                    $"<li>{text1}</li>" +
                    $"<li>{text2}</li>" +
                $"</ul>",
            result);
        }
        [TestMethod]
        [DataRow("NodeJs", "Angular", "Figma", "NestJs", "Javascript")]
        public void GetFormattedListElements_WhenListHasManyElements_ShouldReturnListWithFiveElements(string text1, string text2, string text3, string text4, string text5)
        {
            // Arrange
            var list = new List<string> { text1, text2, text3, text4, text5 };
            // Act
            var result = helper.GetFormattedListElements(list);
            // Assert
            Assert.AreEqual(
                $"<ul>" +
                    $"<li>{text1}</li>" +
                    $"<li>{text2}</li>" +
                    $"<li>{text3}</li>" +
                    $"<li>{text4}</li>" +
                    $"<li>{text5}</li>" +
                $"</ul>",
            result);
        }
    }
}