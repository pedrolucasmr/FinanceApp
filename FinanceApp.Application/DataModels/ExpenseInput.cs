using FinanceApp.Application.Enum;

namespace FinanceApp.Application.DataModels;

internal class ExpenseInput : Input
{
    public ExpenseType Type { get; set; }
    public PurchaseCategory? PurchaseCategory { get; set; }
    public bool IsRecurrent { get; set; }
    public int? RecurrenceTimeInDays { get; set; }
    public string Source { get; set; }
}
