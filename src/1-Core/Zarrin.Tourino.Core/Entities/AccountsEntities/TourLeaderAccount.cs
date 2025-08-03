using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zarrin.Tourino.Core.DBContext;
using Zarrin.Tourino.Core.Entities.CommonEntities;
using Zarrin.Tourino.Core.Entities.OthersEntities;
using Zarrin.Tourino.Core.Entities.TourEntities;
using Zarrin.Tourino.Core.Enums;

namespace Zarrin.Tourino.Core.Entities.AccountsEntities
{
    public class TourLeaderAccount : AccountBaseAttributes
    {
        public required List<ActivityArea> ActivityArea { get; set; }
        public required List<TourType> ActivityTours { get; set; }
        public required string Adress { get; set; }
        public TourLeaderAccountLevel LeaderAccountLevel { get; set; }
        public ExperienceLevel ExperienceLevel { get; set; }
        public double AverageScores { get; set; }
        public string? UserCommentsKey { get; set; } //NoSql
        public List<TourLeaderReport>? Reports { get; set; }
        public List<OthersEntities.Score>? AllTourLeaderScores { get; set; }
        public List<TourLeaderHonors>? TourLeaderHonors { get; set; }
        public List<Tour>? Tours { get; set; }
        public List<InterestsEntitie>? InterestsTours { get; set; }
        public List<InterestsEntitie>? InterestsTourLeaders { get; set; }
        public Subscription Subscription { get; set; }
    }
}