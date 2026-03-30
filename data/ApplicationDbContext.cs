using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TalentBridge.models;

namespace TalentBridge.data
{
    internal class ApplicationDbContext : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Candidate> Candidates { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<Headhunter> Headhunters { get; set; }
        DbSet<Mentor> Mentors { get; set; }
        DbSet<Application> Applications { get; set; }
        DbSet<CandidateReview> CandidateReviews { get; set; }
        DbSet<CandidateMatch> CandidateMatches { get; set; }
        DbSet<Job> Jobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = "Data Source=.;Database=TalentBridgeDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            optionsBuilder.UseSqlServer(connectionString);
        }

        override protected void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
