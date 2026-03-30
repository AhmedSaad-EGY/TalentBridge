using System;
using System.Collections.Generic;
using System.Text;
using TalentBridge.enums;

namespace TalentBridge.models
{
    public class Application : BaseEntity
    {
        public int CandidateId { get; set; }
        public Candidate? Candidate { get; set; }

        public int JobId { get; set; }
        public Job? Job { get; set; }

        public DateTime AppliedAt { get; set; } = DateTime.Now;
        public ApplicationStatus Status { get; set; }
        public string? Notes { get; set; }
    }
}
