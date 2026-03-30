using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TalentBridge.models;

namespace TalentBridge.data.Configurations
{
    public class HeadhunterConfiguration : IEntityTypeConfiguration<Headhunter>
    {
        public void Configure(EntityTypeBuilder<Headhunter> builder)
        {
            builder.HasKey(h => h.Id);

            builder.Property(h => h.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(h => h.User)
                .WithOne(u => u.Headhunter)
                .HasForeignKey<Headhunter>(h => h.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
