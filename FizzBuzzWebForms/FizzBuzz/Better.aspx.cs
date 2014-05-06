using System;
using FizzBuzzWebForms.Orchestrations;
using Ninject;
using Newtonsoft.Json;

namespace FizzBuzzWebForms.FizzBuzz
{
    public partial class Better : System.Web.UI.Page
    {
        [Inject]
        public IFizzBuzzOrchestration _FizzBuzzOrchestration { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var results = _FizzBuzzOrchestration.GenerateAnswers(100);
            model.Text = JsonConvert.SerializeObject(results);
        }
    }
}