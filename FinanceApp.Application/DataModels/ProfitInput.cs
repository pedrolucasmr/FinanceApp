using FinanceApp.Application.Enum;

namespace FinanceApp.Application.DataModels;

internal class ProfitInput : Input
{
    public ProfitType Type {get;set;}
    public bool IsRecurrent { get; set; }
    public int? RecurrenceTimeInDays { get; set; }
    public string Source { get; set; }
}
