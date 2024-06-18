using CapitalPlacement.TalentManagement.Domain;

namespace CapitalPlacement.TalentManagement.Application.ViewModel
{
    public class CreateProgramRequest
    {
        public CreateProgramRequest() { 

            DropdownQuestions = new List<DropdownsTemplate>();
            MultiChoiceQuestions = new List<MultiChoiceQuestionTemplate>();
            ParagraphQuestions = new List<ParagraphQuestion>();
            YesNoQuestions = new List<YesNoQuestion>();
            DateQuestions = new List<DateQuestion>();
            NumericQuestions = new List<NumericQuestion>();
         }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public LabelInfo FirstName { get; set; } = new LabelInfo("First Name");
        public LabelInfo LastName { get; set; } = new LabelInfo("Last Name");
        public LabelInfo Email { get; set; } = new LabelInfo("Email");
        public ContactInfo Phone { get; set; } = new ContactInfo("Phone");
        public ContactInfo Nationality { get; set; } = new ContactInfo("Nationality");
        public ContactInfo CurrentResidence { get; set; } = new ContactInfo("Current Residence");
        public ContactInfo IdNumber { get; set; } = new ContactInfo("Id Number");
        public ContactInfo DateOfBirth { get; set; } = new ContactInfo("Date Of Birth");
        public ContactInfo Gender { get; set; } = new ContactInfo("Gender");
        public List<ParagraphQuestion> ParagraphQuestions { get; set; }
        public List<YesNoQuestion> YesNoQuestions { get; set; }
        public List<NumericQuestion> NumericQuestions { get; set; }
        public List<DateQuestion> DateQuestions { get; set; }
        public List<DropdownsTemplate> DropdownQuestions { get; set; }
        public List<MultiChoiceQuestionTemplate> MultiChoiceQuestions { get; set; }
    }
}
