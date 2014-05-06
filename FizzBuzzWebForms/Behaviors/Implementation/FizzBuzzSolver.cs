using System;
using FizzBuzzWebForms.Models;

namespace FizzBuzzWebForms.Behaviors.Implementation
{
    public class FizzBuzzSolver : IFizzBuzzSolver
    {
        public Turn Solve(int input)
        {
            var answer = string.Empty;
            
            if (input < 1 || input > 100)
                throw new ArgumentException("Input is out of range.");

            if (input % 3 == 0)
                answer = "Fizz";

            if (input % 5 == 0)
                answer = "Buzz";

            if (input % 3 == 0 && input % 5 == 0)
                answer = "FizzBuzz";

            if (String.IsNullOrEmpty(answer))
                answer = input.ToString();

            return new Turn(){Question = input, Answer = answer};
        }
    }
}