using FizzBuzzWebForms.Behaviors;
using FizzBuzzWebForms.Models;
using FizzBuzzWebForms.Orchestrations;
using FizzBuzzWebForms.Services;
using FizzBuzzWebForms.Orchestrations.Implementation;
using Moq;
using NUnit.Framework;
using Ninject;

namespace FizzBuzzWebForms.Tests.Orchestrations
{
    [TestFixture]
    public class FizzBuzzOrchestrationTests
    {
        private IFizzBuzzOrchestration _fizzBuzzOrchestration;
        private StandardKernel ContextKernel;
        private Mock<IFizzBuzzSolver> _mockFizzBuzzSolver;
        private Mock<IWebHookService> _mockWebHookService;

        [SetUp]
        public void Init()
        {
            _mockFizzBuzzSolver = new Mock<IFizzBuzzSolver>();
            _mockFizzBuzzSolver.Setup(s => s.Solve(It.IsAny<int>())).Returns(new Turn());

            _mockWebHookService = new Mock<IWebHookService>();
            _mockWebHookService.Setup(wh => wh.Send(It.IsAny<string>())).Returns("Whatever");

            ContextKernel = new StandardKernel();
            ContextKernel.Bind<IFizzBuzzSolver>().ToMethod(m => _mockFizzBuzzSolver.Object);
            ContextKernel.Bind<IWebHookService>().ToMethod(m => _mockWebHookService.Object);
            ContextKernel.Bind<IFizzBuzzOrchestration>().To<FizzBuzzOrchestration>();

            _fizzBuzzOrchestration = ContextKernel.Get<IFizzBuzzOrchestration>();
        }

        [TestCase(12)]
        [TestCase(33)]
        [TestCase(68)]
        [TestCase(99)]
        [TestCase(100)]
        public void GivenUpperExpectSolverToExecuteSameAmountOfTimes(int upper)
        {
            _fizzBuzzOrchestration.GenerateAnswers(upper);
            _mockFizzBuzzSolver.Verify(s => s.Solve(It.IsAny<int>()), Times.Exactly(upper));
        }

        [Test]
        public void GivenValidInputExpectWebhookSendToExecuteOnce()
        {
            _fizzBuzzOrchestration.GenerateAnswers(33);
            _mockWebHookService.Verify(w => w.Send(It.IsAny<string>()), Times.Once);
        }
    }
}
