﻿using CapitalPlacement.TalentManagement.Domain.Enums;
using CapitalPlacement.TalentManagement.Domain;

namespace CapitalPlacement.TalentManagement.Application.ViewModel
{
    public class ApplicationResponse
    {
        public Guid Id { get; set; } = Guid.NewGuid(); 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Nationality { get; set; }
        public string CurrentResidence { get; set; }
        public string IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
