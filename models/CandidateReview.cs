using System;
using System.Collections.Generic;
using System.Text;

namespace TalentBridge.models
{
    public class CandidateReview : BaseEntity
    {
        public int CandidateId { get; set; }
        public Candidate? Candidate { get; set; }

        public int MentorId { get; set; }
        public Mentor? Mentor { get; set; }

        public int TechnicalScore { get; set; }
        public int CommunicationScore { get; set; }
        public int PortfolioScore { get; set; }
        public double FinalScore { get; set; }
        public string? Feedback { get; set; }
        public DateTime ReviewedAt { get; set; } = DateTime.Now;
    }
}
