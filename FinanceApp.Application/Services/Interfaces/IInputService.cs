using FinanceApp.Application.DTOs.Request;
using FinanceApp.Application.DTOs.Response;

namespace FinanceApp.Application.Services.Interfaces
{
    internal interface IInputService
    {
        Task<CreateInputResponse> ProcessInput(CreateInputRequest request);
    }
}
