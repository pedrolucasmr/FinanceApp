using FinanceApp.Application.DTOs.Request;
using FinanceApp.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Application.Services.Interfaces
{
    internal interface IInputService
    {
        Task<CreateInputResponse> ProcessInput(CreateInputRequest request);
    }
}
