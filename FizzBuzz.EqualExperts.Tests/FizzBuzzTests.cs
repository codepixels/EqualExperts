using NUnit.Framework;

namespace FizzBuzz.EqualExperts.Tests
{
    public class FizzBuzzTests
    {
        [TestCase(0, 0, "0")]
        [TestCase(1, 1, "1")]
        [TestCase(1, 2, "1 2")]
        [TestCase(1, 20, "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz")]
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
        [TestCase(20, 1, "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz")]
        public void Run_GivenARangeOfIntegersInAnyOrder_ShouldReturnExpectedResult(int startRange, int endRange, string expectedResult)
        {
            FizzBuzz sut = new FizzBuzz();
            var result = sut.Run(startRange, endRange);
            Assert.That(result.Equals(expectedResult));
        }

        [TestCase(-4, -1, "-4 lucky -2 -1")]
        [TestCase(-2, -6, "fizz buzz -4 lucky -2")]
        [TestCase(-5, 5, "buzz -4 lucky -2 -1 0 1 2 lucky 4 buzz")]
        [TestCase(3, -9, "fizz -8 -7 fizz buzz -4 lucky -2 -1 0 1 2 lucky")]
        public void Run_GivenARangeOfPositiveAndNegativeIntegersInAnyOrder_ShouldReturnExpectedResult(int startRange, int endRange, string expectedResult)
        {
            FizzBuzz sut = new FizzBuzz();
            var result = sut.Run(startRange, endRange);
            Assert.That(result.Equals(expectedResult));
        }

        [TestCase(6, 6, "fizz")]
        [TestCase(6, 9, "fizz 7 8 fizz")]
        [TestCase(-6, 6, "fizz buzz -4 lucky -2 -1 0 1 2 lucky 4 buzz fizz")]
        public void Run_GivenARangeOfIntegers_ShouldReturnFizzForMultiplesOfThree(int startRange, int endRange, string expectedResult)
        {
            FizzBuzz sut = new FizzBuzz();
            var result = sut.Run(startRange, endRange);
            Assert.That(result.Equals(expectedResult));
        }

        [TestCase(5, 5, "buzz")]
        [TestCase(1, 5, "1 2 lucky 4 buzz")]
        [TestCase(-10, 5, "buzz fizz -8 -7 fizz buzz -4 lucky -2 -1 0 1 2 lucky 4 buzz")]
        public void Run_GivenARangeOfIntegers_ShouldReturnBuzzForMultiplesOfFive(int startRange, int endRange, string expectedResult)
        {
            FizzBuzz sut = new FizzBuzz();
            var result = sut.Run(startRange, endRange);
            Assert.That(result.Equals(expectedResult));
        }

        [TestCase(15, 15, "fizzbuzz")]
        [TestCase(15, 30, "fizzbuzz 16 17 fizz 19 buzz fizz 22 lucky fizz buzz 26 fizz 28 29 lucky")]
        [TestCase(-45, -30, "fizzbuzz -44 lucky fizz -41 buzz lucky lucky lucky lucky lucky lucky lucky lucky lucky lucky")]
        public void Run_GivenARangeOfIntegers_ShouldReturnFizzBuzzForMultiplesOfFifteen(int startRange, int endRange, string expectedResult)
        {
            FizzBuzz sut = new FizzBuzz();
            var result = sut.Run(startRange, endRange);
            Assert.That(result.Equals(expectedResult));
        }

        [TestCase(3, 3, "lucky")]
        [TestCase(1, 20, "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz")]
        [TestCase(-3, 3, "lucky -2 -1 0 1 2 lucky")]
        [TestCase(29, 41, "29 lucky lucky lucky lucky lucky lucky lucky lucky lucky lucky buzz 41")]
        public void Run_GivenARangeOfIntegers_ShouldReturnLuckyForNumbersContainingThree(int startRange, int endRange, string expectedResult)
        {
            FizzBuzz sut = new FizzBuzz();
            var result = sut.Run(startRange, endRange);
            Assert.That(result.Equals(expectedResult));
        }
    }
}
