using System;
using System.Collections.Generic;
using System.Text;
using TalentBridge.enums;

namespace TalentBridge.models
{
    public class Job : BaseEntity
    {
        public int CompanyId { get; set; }
        public Company? Company { get; set; }

        public int RequiredTrackId { get; set; }
        public Track? RequiredTrack { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal Salary { get; set; }
        public string? Location { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public string? ExperienceLevel { get; set; }
        public int MinYearsExperience { get; set; }
        public DateTime Deadline { get; set; } 
        public bool IsActive { get; set; }

        public ICollection<Application> Applications { get; set; } = new List<Application>();
        public ICollection<CandidateMatch> Matches { get; set; } = new List<CandidateMatch>();
    }
}
