using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zarrin.Tourino.Core.DBContext;
using Zarrin.Tourino.Core.Entities.CommonEntities;
using Zarrin.Tourino.Core.Enums;

namespace Zarrin.Tourino.Core.Entities
{
    public class TourLeaderModel : AccountBaseAttributes
    {
        public required List<ActivityArea> ActivityArea { get; set; }
        public required List<TourType> ActivityTours { get; set; }
        public required string Adress { get; set; }
        public TourLeaderAccountLevel LeaderAccountLevel { get; set; }
        public ExperienceLevel ExperienceLevel { get; set; }
        public double AverageScores { get; set; }
        public string? UserCommentsKey { get; set; } //NoSql
        public List<TourLeaderReport>? Reports { get; set; }
        public List<ScoreModel>? AllTourLeaderScores { get; set; }
        public List<TourLeaderHonors>? TourLeaderHonors { get; set; }
        public List<TourModel>? Tours { get; set; }
        public TourLeaderModel()
        {
            NewGuid();
        }
        public override void NewGuid()
        {
            using var db = new DbData();
            var tourLeaders = db.TourLeaders;

            while (true)
            {
                var newGuid = System.Guid.NewGuid();
                if (!tourLeaders.Any(t => t.Guid == newGuid))
                {
                    Guid = newGuid;
                    break;
                }
            }
        }
    }
}