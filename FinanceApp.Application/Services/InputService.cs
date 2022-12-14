using FinanceApp.Application.DataModels;
using FinanceApp.Application.DTOs.Request;
using FinanceApp.Application.DTOs.Response;
using FinanceApp.Application.Enum;
using FinanceApp.Application.Profiles;
using FinanceApp.Application.RepositoriesContracts;
using FinanceApp.Application.Services.Interfaces;

namespace FinanceApp.Application.Services
{
    internal class InputService : IInputService
    {
        private readonly IProfitInputRepository _profitInputRepository;
        private readonly IExpenseInputRepository _expenseInputRepository;
        private readonly IUserProfileRepository _userProfileRepository;

        public InputService(IProfitInputRepository profitInputRepository, IExpenseInputRepository expenseInputRepository, IUserProfileRepository userProfileRepository)
        {
            _profitInputRepository = profitInputRepository;
            _expenseInputRepository = expenseInputRepository;
            _userProfileRepository = userProfileRepository;
        }

        public Task<CreateInputResponse> ProcessInput(CreateInputRequest request)
        {
            return request.Type == InputType.Expense ? 
                ProcessExpenseInput(request) :
                ProcessProfitInput(request);
        }

        internal Task<CreateInputResponse> ProcessExpenseInput(CreateInputRequest request)
        {
            var expenseInput = ExpenseInputProfile.MapFrom(request);
        }
        internal Task<CreateInputResponse> ProcessProfitInput(CreateInputRequest request)
        {
            var profitInput = ProfitInputProfile.MapFrom(request);
        }
    }
}
