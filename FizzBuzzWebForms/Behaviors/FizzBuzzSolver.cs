using System;

namespace FizzBuzzWebForms.Behaviors
{
    public class FizzBuzzSolver
    {
        public string Interpret(int input)
        {
            if(input < 1 || input > 100)
                throw new ArgumentException("Input is out of range.");

            if (input % 3 == 0 && input % 5 == 0)
                return "FizzBuzz";
            
            if (input % 3==0)
                return "Fizz";

            if (input % 5==0)
                return "Buzz";

            return input.ToString();
        }
    }
}