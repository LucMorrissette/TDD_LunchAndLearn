using FizzBuzzWebForms.Models;

namespace FizzBuzzWebForms.Behaviors
{
    public interface IFizzBuzzSolver
    {
        Turn Solve(int input);
    }
}