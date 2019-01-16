using System;
using Xunit;
using FizzBuzz20190116;

namespace FizzBuzz20190116.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Get_Returns_1_For_1()
        {
            // Arrange
            FizzBuzz underTest = new FizzBuzz();

            // Act
            string result = underTest.Get(1);

            // Assert
            Assert.Equal("1", result);
        }
    }
}
