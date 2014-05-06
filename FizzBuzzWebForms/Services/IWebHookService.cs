using System.Net.Http;
using System.Threading.Tasks;

namespace FizzBuzzWebForms.Services
{
    public interface IWebHookService
    {
        string Send(dynamic whatever);
    }
}
