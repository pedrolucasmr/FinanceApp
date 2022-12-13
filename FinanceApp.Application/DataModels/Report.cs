using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Application.DataModels;

internal class Report
{
    public int Id { get; set; }
    public DateTime ReportInitialDate { get; set; }
    public DateTime ReportFinalDate { get; set; }
    public decimal TotalProfit { get; set; }
    public decimal TotalExpenses { get; set; }
    public decimal Balance { get; set; }
    public List<ExpenseInput> Expenses { get; set; }
    public List<ProfitInput> Profits { get; set; }
}
