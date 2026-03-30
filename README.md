# TalentBridge

TalentBridge is a console-based Recruitment Management System built using C#, Entity Framework Core, and LINQ.

The system simulates a real-world hiring platform where candidates, mentors, headhunters, and companies interact through jobs, applications, reviews, matching, and a points-based system.

---

## Features

- User Authentication and Role Management
- Candidate, Company, Mentor, and Headhunter Roles
- Profile Management
- Job Posting and Management
- Candidate Applications
- Mentor Reviews
- Candidate Matching System
- Points and Rewards System
- Search, Filter, and Sorting with LINQ
- EF Core Relationships and Configurations
- Seed Data and Migrations
- Soft Delete Support

---

## Technologies Used

- C#
- .NET
- Entity Framework Core
- LINQ
- SQL Server
- Console Application

---

## Project Structure

```text
RecruitmentSystem
│
├── Data
│   ├── ApplicationDbContext.cs
│   ├── Configurations
│   
├── Models
│
├── Enums
│
├── Migrations
│
├── Program.cs

Roles
Candidate
Complete profile
Upload CV
Browse jobs
Apply to jobs
View mentor reviews
Company
Post jobs
Manage jobs
Review applications
Accept or reject candidates
Mentor
Review candidates
Add scores and feedback
Headhunter
Match candidates with jobs
Track successful matches
Database Entities
User
Track
Candidate
Company
Job
Application
Mentor
CandidateReview
Headhunter
CandidateMatch
PointTransaction
Getting Started
1. Clone Repository
git clone https://github.com/your-username/TalentBridge.git
2. Open Project

Open the solution using Visual Studio.

3. Install Packages
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
4. Create Migration
Add-Migration InitialCreate
5. Update Database
Update-Database
6. Run Project

Run the project from Visual Studio.

Future Improvements
Password Hashing
Notifications System
Saved Jobs
Interview Scheduling
Dashboard Reports
Export Data to PDF or Excel
Unit Testing
API Version of the System
Author

Ahmed Mohammed

Backend Developer | .NET Developer
