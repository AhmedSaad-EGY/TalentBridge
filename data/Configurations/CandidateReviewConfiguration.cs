using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TalentBridge.models;

namespace TalentBridge.data.Configurations
{
    public class CandidateReviewConfiguration : IEntityTypeConfiguration<CandidateReview>
    {
        public void Configure(EntityTypeBuilder<CandidateReview> builder)
        {
            builder.HasKey(r => r.Id);

            builder.HasOne(r => r.Candidate)
                .WithMany(c => c.Reviews)
                .HasForeignKey(r => r.CandidateId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(r => r.Mentor)
                .WithMany(m => m.Reviews)
                .HasForeignKey(r => r.MentorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
