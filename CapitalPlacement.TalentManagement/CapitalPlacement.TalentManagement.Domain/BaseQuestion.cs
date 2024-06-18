using CapitalPlacement.TalentManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.TalentManagement.Domain
{
    public abstract class BaseQuestion
    {
        public QuestionType Type { get; set; }
        public string? Question { get; set; }
    }
}
