using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Core.DBContext;
using Zarrin.Tourino.Core.Entities.CommonEntities;

namespace Zarrin.Tourino.Core.Entities
{
    public class TourLeaderVerification : TourLeaderBaseAttributes
    {
        public bool IsApproved { get; set; }
        public string? RejectionReason { get; set; }
        public List<string>? IdentityDocumentsKey { get; set; } //NoSql
    }
}