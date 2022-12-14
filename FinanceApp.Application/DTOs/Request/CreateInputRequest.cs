using FinanceApp.Application.Enum;

namespace FinanceApp.Application.DTOs.Request
{
    internal record CreateInputRequest
    {
        public InputType Type { get; set; }
        public string? Label { get; set; }
        public string? Description { get; set; }
        public decimal Value { get; set; }
        public Expense? Expense { get; set; }
        public Profit? Profit { get; set; }
    }

    internal record Expense
    {
        public ExpenseType Type { get; set; }
        public PurchaseCategory? PurchaseCategory { get; set; }
        public bool IsRecurrent { get; set; }
        public int? RecurrenceTimeInDays { get; set; }
        public string? Source { get; set; }
    }

    internal record Profit
    {
        public ProfitType Type { get; set; }
        public bool IsRecurrent { get; set; }
        public int? RecurrenceTimeInDays { get; set; }
        public string Source { get; set; }
    }
}
