using Lab10App;

namespace Lab10App.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMultiplication()
        {
            // Arrange (Підготовка)
            var calc = new Calculator();

            // Act (Дія)
            var result = calc.Multiply(5, 4);

            // Assert (Перевірка)
            Assert.Equal(20, result);
        }
    }
}