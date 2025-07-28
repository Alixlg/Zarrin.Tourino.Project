using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zarrin.Tourino.Core.Entities;

namespace Zarrin.Tourino.Core.DBContext
{
    public class DbData : DbContext
    {
        public DbSet<AdminModel> Admins { get; set; }
        public DbSet<TourLeaderModel> TourLeaders { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<TourModel> Tours { get; set; }
        public DbSet<TourLeaderReport> TourLeaderReports { get; set; }
        public DbSet<TourLeaderVerification> TourLeaderVerificationList { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = "./DbFiles/DataBase.sqlite";
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}