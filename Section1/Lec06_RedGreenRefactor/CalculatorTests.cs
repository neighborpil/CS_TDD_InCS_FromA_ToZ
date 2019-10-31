using NUnit.Framework;

namespace Lec06_RedGreenRefactor
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddNumbers_ValidValues_ReturnsCorrectResult()
        {
            var sut = new Calculator();
            int result = sut.AddNumbers(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }
    }
}