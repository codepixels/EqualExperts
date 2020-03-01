using NUnit.Framework;

namespace FizzBuzz.EqualExperts.Tests
{
    public class FizzBuzzTests
    {
        [TestCase(0, 0, "0")]
        [TestCase(1, 1, "1")]
        [TestCase(1, 2, "1 2")]
        [TestCase(1, 20, "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz")]
        public void Run_GivenARangeOfIntegers_ShouldReturnExpectedResult(int startRange, int endRange, string expectedResult)
        {
            // Arrange System Under Test (sut)
            FizzBuzz sut = new FizzBuzz();

            // Act
            var result = sut.Run(startRange, endRange);

            // Assert
            Assert.That(result.Equals(expectedResult));
        }

        [TestCase(8, 7, "7 8")]
        [TestCase(100, 95, "buzz fizz 97 98 fizz buzz")]
        [TestCase(20, 1, "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz")]
        public void Run_GivenARangeOfIntegersInAnyOrder_ShouldReturnExpectedResult(int startRange, int endRange, string expectedResult)
        {
            FizzBuzz sut = new FizzBuzz();
            var result = sut.Run(startRange, endRange);
            Assert.That(result.Equals(expectedResult));
        }

        [TestCase(-4, -1, "-4 fizz -2 -1")]
        [TestCase(-2, -6, "fizz buzz -4 fizz -2")]
        [TestCase(-5, 5, "buzz -4 fizz -2 -1 0 1 2 fizz 4 buzz")]
        [TestCase(3, -9, "fizz -8 -7 fizz buzz -4 fizz -2 -1 0 1 2 fizz")]
        public void Run_GivenARangeOfPositiveAndNegativeIntegersInAnyOrder_ShouldReturnExpectedResult(int startRange, int endRange, string expectedResult)
        {
            FizzBuzz sut = new FizzBuzz();
            var result = sut.Run(startRange, endRange);
            Assert.That(result.Equals(expectedResult));
        }

        [TestCase(3, 3, "fizz")]
        [TestCase(6, 9, "fizz 7 8 fizz")]
        [TestCase(-3, 3, "fizz -2 -1 0 1 2 fizz")]
        public void Run_GivenARangeOfIntegers_ShouldReturnFizzForMultiplesOfThree(int startRange, int endRange, string expectedResult)
        {
            FizzBuzz sut = new FizzBuzz();
            var result = sut.Run(startRange, endRange);
            Assert.That(result.Equals(expectedResult));
        }

        [TestCase(5, 5, "buzz")]
        [TestCase(1, 5, "1 2 fizz 4 buzz")]
        [TestCase(-10, 5, "buzz fizz -8 -7 fizz buzz -4 fizz -2 -1 0 1 2 fizz 4 buzz")]
        public void Run_GivenARangeOfIntegers_ShouldReturnBuzzForMultiplesOfFive(int startRange, int endRange, string expectedResult)
        {
            FizzBuzz sut = new FizzBuzz();
            var result = sut.Run(startRange, endRange);
            Assert.That(result.Equals(expectedResult));
        }

        [TestCase(15, 15, "fizzbuzz")]
        [TestCase(15, 30, "fizzbuzz 16 17 fizz 19 buzz fizz 22 23 fizz buzz 26 fizz 28 29 fizzbuzz")]
        [TestCase(-45, -30, "fizzbuzz -44 -43 fizz -41 buzz fizz -38 -37 fizz buzz -34 fizz -32 -31 fizzbuzz")]
        public void Run_GivenARangeOfIntegers_ShouldReturnFizzBuzzForMultiplesOfFifteen(int startRange, int endRange, string expectedResult)
        {
            FizzBuzz sut = new FizzBuzz();
            var result = sut.Run(startRange, endRange);
            Assert.That(result.Equals(expectedResult));
        }
    }
}
