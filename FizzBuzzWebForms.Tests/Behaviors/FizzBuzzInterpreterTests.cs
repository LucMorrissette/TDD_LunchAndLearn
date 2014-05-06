using System;
using FizzBuzzWebForms.Behaviors.Implementation;
using NUnit.Framework;

namespace FizzBuzzWebForms.Tests.Behaviors
{
    [TestFixture]
    public class FizzBuzzSolverTests
    {
        private FizzBuzzSolver solver;
        
        [SetUp]
        public void Init()
        {
            solver = new FizzBuzzSolver();
        }
        
        
        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Input is out of range.")]
        public void Given101ExpectException()
        {
            solver.Solve(101);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Input is out of range.")]
        public void GivenZeroExpectException()
        {
            solver.Solve(0);
        }

        [Test]
        public void Given1Expect1()
        {
            var expected = "1";
            var actual = solver.Solve(1).Answer;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given2Expect2()
        {
            var expected = "2";
            var actual = solver.Solve(2).Answer;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        [TestCase(21)]
        [TestCase(33)]
        [TestCase(63)]
        public void GivenDivisibleby3AndNot5ExpectFizz(int input)
        {
            var expected = "Fizz";
            var actual = solver.Solve(input).Answer;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        [TestCase(50)]
        [TestCase(55)]
        [TestCase(100)]
        public void GivenDivisibleBy5AndNot3ExpectBuzz(int input)
        {
            var expected = "Buzz";
            var actual = solver.Solve(input).Answer;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(01 * 03 * 05)]
        [TestCase(02 * 03 * 05)]
        [TestCase(03 * 03 * 05)]
        [TestCase(04 * 03 * 05)]
        [TestCase(05 * 03 * 05)]
        public void GiveDivisibleByBoth5and3ExpectFizzBuzz(int input)
        {
            var expected = "FizzBuzz";
            var actual = solver.Solve(input).Answer;
            Assert.AreEqual(expected, actual);
        }

       


    }
}
