using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TalentBridge.models;

namespace TalentBridge.data.Configurations
{
    public class CandidateMatchConfiguration : IEntityTypeConfiguration<CandidateMatch>
    {
        public void Configure(EntityTypeBuilder<CandidateMatch> builder)
        {
            builder.HasKey(m => m.Id);

            builder.HasOne(m => m.Candidate)
                .WithMany(c => c.Matches)
                .HasForeignKey(m => m.CandidateId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.Job)
                .WithMany(j => j.Matches)
                .HasForeignKey(m => m.JobId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.Headhunter)
                .WithMany(h => h.Matches)
                .HasForeignKey(m => m.HeadhunterId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
