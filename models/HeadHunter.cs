using System;
using System.Collections.Generic;
using System.Text;

namespace TalentBridge.models
{
    public class Headhunter : BaseEntity
    {
        public int UserId { get; set; }
        public User? User { get; set; }

        public string? FullName { get; set; }
        public string? AgencyName { get; set; }
        public int ExperienceYears { get; set; }
        public double SuccessRate { get; set; }

        public ICollection<CandidateMatch> Matches { get; set; } = new HashSet<CandidateMatch>();
    }
}
