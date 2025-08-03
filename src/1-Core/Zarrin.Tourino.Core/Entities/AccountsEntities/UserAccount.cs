using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.DBContext;
using Zarrin.Tourino.Core.Entities.CommonEntities;
using Zarrin.Tourino.Core.Enums;

namespace Zarrin.Tourino.Core.Entities.AccountsEntities
{
    public class UserAccount : AccountBaseAttributes
    {
        public List<string>? IdentityDocumentsKeys { get; set; } //NoSql
        public List<string>? SocialMediaLinks { get; set; }
        public List<InterestsEntitie>? InterestsTours { get; set; }
        public List<InterestsEntitie>? InterestsTourLeaders { get; set; }
        public List<Tour>? Trips { get; set; }
        public Subscription Subscription { get; set; }
        public string? AboutMe { get; set; }
    }
}