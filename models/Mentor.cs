using System;
using System.Collections.Generic;
using System.Text;

namespace TalentBridge.models
{
    public class Mentor : BaseEntity
    {
        public int UserId { get; set; }
        public User? User { get; set; }

        public string? FullName { get; set; }
        public string? Specialization { get; set; }
        public int ExperienceYears { get; set; }
        public string? CompanyName { get; set; }
        public string? Bio { get; set; }

        public ICollection<CandidateReview> Reviews { get; set; } = new HashSet<CandidateReview>();
    }
}
