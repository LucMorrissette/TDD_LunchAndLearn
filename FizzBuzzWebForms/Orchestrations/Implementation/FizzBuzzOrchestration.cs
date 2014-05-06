using System.Collections.Generic;
using FizzBuzzWebForms.Behaviors;
using FizzBuzzWebForms.Models;
using FizzBuzzWebForms.Services;

namespace FizzBuzzWebForms.Orchestrations.Implementation
{
   
    class FizzBuzzOrchestration : IFizzBuzzOrchestration
    {
        private readonly IFizzBuzzSolver _fizzBuzzSolver;
        private readonly IWebHookService _webHookService;

        public FizzBuzzOrchestration(IFizzBuzzSolver fizzBuzzSolver, IWebHookService webHookService)
        {
            _fizzBuzzSolver = fizzBuzzSolver;
            _webHookService = webHookService;
        }


        public List<Turn> GenerateAnswers(int upper)
        {
            var answers = new List<Turn>();

            for (var i = 1; i <= upper; i++)
                answers.Add(_fizzBuzzSolver.Solve(i));

            _webHookService.Send(answers);

            return answers;
        }
    }
}