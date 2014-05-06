using System.Collections.Generic;
using FizzBuzzWebForms.Models;

namespace FizzBuzzWebForms.Orchestrations
{
    public interface IFizzBuzzOrchestration
    {
        List<Turn> GenerateAnswers(int upper);
    }
}
