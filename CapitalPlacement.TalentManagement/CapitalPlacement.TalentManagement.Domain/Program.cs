namespace CapitalPlacement.TalentManagement.Domain
{
    public class Program: BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public LabelInfoMetaData FirstName { get; set; } = new LabelInfoMetaData("First Name");
        public LabelInfoMetaData LastName { get; set; } = new LabelInfoMetaData("Last Name");
        public LabelInfoMetaData Email { get; set; } = new LabelInfoMetaData("Email");
        public ContactInfoMetaData Phone { get; set; } = new ContactInfoMetaData("Phone");
        public ContactInfoMetaData Nationality { get; set; } = new ContactInfoMetaData("Nationality");
        public ContactInfoMetaData CurrentResidence { get; set; } = new ContactInfoMetaData("Current Residence");
        public ContactInfoMetaData IdNumber { get; set; } = new ContactInfoMetaData("Id Number");
        public ContactInfoMetaData DateOfBirth { get; set; } = new ContactInfoMetaData("Date Of Birth");
        public ContactInfoMetaData Gender { get; set; } = new ContactInfoMetaData("Gender");
        public List<ParagraphQuestion>? ParagraphQuestions { get; set; }
        public List<YesNoQuestion>? YesNoQuestions { get; set; }
        public List<NumericQuestion>? NumericQuestions { get; set; }
        public List<DateQuestion>? DateQuestions { get; set; }
        public List<DropdownsTemplate>? DropdownQuestions { get; set; }
        public List<MultiChoiceQuestionTemplate>? MultiChoiceQuestions { get; set; }
    }
}