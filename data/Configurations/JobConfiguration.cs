using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TalentBridge.models;

namespace TalentBridge.data.Configurations
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasKey(j => j.Id);

            builder.Property(j => j.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(j => j.Salary)
                .HasColumnType("decimal(18,2)");

            builder.Property(j => j.Location)
                .HasMaxLength(100);

            builder.HasOne(j => j.Company)
                .WithMany(c => c.Jobs)
                .HasForeignKey(j => j.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(j => j.RequiredTrack)
                .WithMany(t => t.Jobs)
                .HasForeignKey(j => j.RequiredTrackId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
