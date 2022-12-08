#nullable disable
using FinanceApp.Application.Enum;

namespace FinanceApp.Application.DataModels;

internal abstract class Input
{
    public Guid Id { get; set; }
    public InputType Type { get; set; }
    public DateTime CreateAt { get; set; }
    public string Label { get; set; }
    public string Description { get; set; }
    public decimal Value { get; set; }
}
