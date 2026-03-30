using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TalentBridge.models;

namespace TalentBridge.data.Configurations
{
    public class MentorConfiguration : IEntityTypeConfiguration<Mentor>
    {
        public void Configure(EntityTypeBuilder<Mentor> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(m => m.User)
                .WithOne(u => u.Mentor)
                .HasForeignKey<Mentor>(m => m.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
