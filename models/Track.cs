using System;
using System.Collections.Generic;
using System.Text;

namespace TalentBridge.models
{
    public class Track : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public ICollection<User> Users { get; set; } = new HashSet<User>();
        public ICollection<Job> Jobs { get; set; } = new HashSet<Job>();
    }
}
