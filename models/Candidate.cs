using System;
using System.Collections.Generic;
using System.Text;

namespace TalentBridge.models
{
    public class Candidate : BaseEntity
    {
        public int UserId { get; set; }
        public User? User { get; set; }

        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? University { get; set; }
        public int GraduationYear { get; set; }
        public int YearsOfExperience { get; set; }
        public string? CurrentPosition { get; set; }
        public string? CVFilePath { get; set; }
        public string? GitHubUrl { get; set; }
        public string? LinkedInUrl { get; set; }
        public string? Bio { get; set; }
        public string? Skills { get; set; }
        public bool IsAvailableForWork { get; set; } = false;

        public ICollection<Application> Applications { get; set; } = new List<Application>();
        public ICollection<CandidateReview> Reviews { get; set; } = new List<CandidateReview>();
        public ICollection<CandidateMatch> Matches { get; set; } = new List<CandidateMatch>();
    }
}
