using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.TalentManagement.Domain
{
    public class DropdownsTemplate: BaseQuestion
    {
        public DropdownsTemplate() {
            Type = Enums.QuestionType.DropDown;
        }

        public HashSet<string> Choice { get; set; }

        public bool EnableOtherOption { get; set; }
    }
}
