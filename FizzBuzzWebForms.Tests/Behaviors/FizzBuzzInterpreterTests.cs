using System;
using FizzBuzzWebForms.Behaviors;
using NUnit.Framework;

namespace FizzBuzzWebForms.Tests.Behaviors
{
    [TestFixture]
    public class FizzBuzzInterpreterTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Input is out of range.")]
        public void Given101ExpectException()
        {
            var interpreter = new FizzBuzzInterpreter();
            var actual = interpreter.Interpret(101);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Input is out of range.")]
        public void GivenZeroExpectException()
        {
            var interpreter = new FizzBuzzInterpreter();
            var actual = interpreter.Interpret(0);
        }

        [Test]
        public void Given1Expect1()
        {
            var interpreter = new FizzBuzzInterpreter();
            var expected = "1";
            var actual = interpreter.Interpret(1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given2Expect2()
        {
            var interpreter = new FizzBuzzInterpreter();
            var expected = "2";
            var actual = interpreter.Interpret(2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given3ExpectFizz()
        {
            var interpreter = new FizzBuzzInterpreter();
            var expected = "Fizz";
            var actual = interpreter.Interpret(3);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given5ExpectBuzz()
        {
            var interpreter = new FizzBuzzInterpreter();
            var expected = "Buzz";
            var actual = interpreter.Interpret(5);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given15ExpectFizzBuzz()
        {
            var interpreter = new FizzBuzzInterpreter();
            var expected = "FizzBuzz";
            var actual = interpreter.Interpret(15);
            Assert.AreEqual(expected, actual);
        }



    }
}
