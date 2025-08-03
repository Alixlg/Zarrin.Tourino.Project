using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zarrin.Tourino.Core.Entities;
using Zarrin.Tourino.Core.Entities.AccountsEntities;

namespace Zarrin.Tourino.Core.DBContext
{
    public class DbData : DbContext
    {
        public DbSet<AdminAccount> Admins { get; set; }
        public DbSet<TourLeaderAccount> TourLeaders { get; set; }
        public DbSet<UserAccount> Users { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourLeaderReport> TourLeaderReports { get; set; }
        public DbSet<TourLeaderVerification> TourLeaderVerificationList { get; set; }
        public DbSet<ActivitieLogs> ActivitieLogs { get; set; }
        public DbSet<SupportTicket> SupportTickets { get; set; }
        public DbSet<SupportTicketMessage> SupportTicketMessages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = "./DbFiles/DataBase.sqlite";
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}