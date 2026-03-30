using System;
using System.Collections.Generic;
using System.Text;

namespace TalentBridge.models
{
    public class Company : BaseEntity
    {
        public int UserId { get; set; }
        public User? User { get; set; }

        public string? CompanyName { get; set; }
        public string? Industry { get; set; }
        public string? Website { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public string? HRContactName { get; set; }
        public string? HRContactEmail { get; set; }

        public ICollection<Job> Jobs { get; set; } = new HashSet<Job>();
    }
}
