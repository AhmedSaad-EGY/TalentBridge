using System;
using System.Collections.Generic;
using System.Text;

namespace TalentBridge.models
{
    public class CandidateMatch : BaseEntity
    {
        public int CandidateId { get; set; }
        public Candidate? Candidate { get; set; }

        public int JobId { get; set; }
        public Job? Job { get; set; }

        public int HeadhunterId { get; set; }
        public Headhunter? Headhunter { get; set; }

        public double MatchScore { get; set; }
        public string? Notes { get; set; }
    }
}
