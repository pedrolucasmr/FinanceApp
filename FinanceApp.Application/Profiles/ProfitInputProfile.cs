using FinanceApp.Application.DataModels;
using FinanceApp.Application.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Application.Profiles
{
    internal static class ProfitInputProfile
    {
        internal static ProfitInput MapFrom(CreateInputRequest request)
        {
            return new ProfitInput();
        }
    }
}
