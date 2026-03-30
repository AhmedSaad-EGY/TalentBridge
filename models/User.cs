using System;
using System.Collections.Generic;
using System.Text;
using TalentBridge.enums;

namespace TalentBridge.models
{
    public class User : BaseEntity
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public int Points { get; set; }

        public UserRole Role { get; set; }

        public int TrackId { get; set; }
        public Track? Track { get; set; }

        public Candidate? Candidate { get; set; }
        public Mentor? Mentor { get; set; }
        public Company? Company { get; set; }
        public Headhunter? Headhunter { get; set; } 
        public ICollection<PointTransaction> PointTransactions { get; set; } = new HashSet<PointTransaction>();
    }
}
