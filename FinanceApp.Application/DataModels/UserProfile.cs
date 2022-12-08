using FinanceApp.Application.Enum;

namespace FinanceApp.Application.DataModels;

internal class UserProfile
{
    public Guid Id { get; set; }
    public List<PurchaseCategory> ShouldAvoidPurhases { get; set; }
    public decimal EstimatedIncome { get; set; }
    public decimal AverageMonthlyExpenses { get; set; }
}
