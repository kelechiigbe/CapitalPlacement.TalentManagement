using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.TalentManagement.Domain
{
    public class MultiChoiceQuestionTemplate: DropdownsTemplate
    {
        public MultiChoiceQuestionTemplate() {

            Type = Enums.QuestionType.MultipleChoice;
        }

        public int MaxChoiceAllowed { get; set; }
    }
}
