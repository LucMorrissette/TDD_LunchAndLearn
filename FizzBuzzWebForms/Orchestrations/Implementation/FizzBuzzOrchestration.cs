using System;
using System.Collections.Generic;
using FizzBuzzWebForms.Behaviors;
using FizzBuzzWebForms.Models;
using FizzBuzzWebForms.Services;
using Newtonsoft.Json;

namespace FizzBuzzWebForms.Orchestrations.Implementation
{
   
    public class FizzBuzzOrchestration : IFizzBuzzOrchestration
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

            _webHookService.Send(JsonConvert.SerializeObject(answers));

            return answers;
        }
    }
}