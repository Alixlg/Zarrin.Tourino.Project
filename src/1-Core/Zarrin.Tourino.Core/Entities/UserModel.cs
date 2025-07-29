using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.DBContext;
using Zarrin.Tourino.Core.Entities.CommonEntities;
using Zarrin.Tourino.Core.Enums;

namespace Zarrin.Tourino.Core.Entities
{
    public class UserModel : AccountBaseAttributes
    {
        public List<string>? IdentityDocumentsKey { get; set; } //NoSql
        public List<string>? SocialMediaLinks { get; set; }
        public List<TourModel>? InterestsTours { get; set; }
        public List<TourLeaderModel>? InterestsTourLeaders { get; set; }
        public List<TourModel>? Trips { get; set; }
        public Subscription Subscription { get; set; }
        public string? AboutMe { get; set; }
    }
}