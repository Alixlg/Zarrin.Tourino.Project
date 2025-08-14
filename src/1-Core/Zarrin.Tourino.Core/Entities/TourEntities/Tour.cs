using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.DBContext;
using Zarrin.Tourino.Core.Entities.AccountsEntities;
using Zarrin.Tourino.Core.Enums;

namespace Zarrin.Tourino.Core.Entities.TourEntities
{
    public class Tour : SqlBaseAttributes<int>, IGuid, IObjectCreatedDate
    {
        public Guid Guid { get; set; } = System.Guid.NewGuid();
        public DateTime ObjectCreatedDateTime { get; } = DateTime.Now;
        public required bool IsVisible { get; set; }
        public required bool IsPrivate { get; set; }
        public required int PreviewImageId { get; set; } //NoSql
        public List<int>? ImageIds { get; set; } //NoSql
        public bool IsVip { get; set; }
        public required string TourName { get; set; }
        public required string TourDescription { get; set; }
        public int TourOwnerId { get; set; }
        public required TourLeaderAccount TourOwner { get; set; }
        public required int TourMaximumMembers { get; set; }
        public List<UserAccount>? TourUserMembers { get; set; }
        public List<TourReservation>? TourNotUserMembers { get; set; }
        public required string AccommodationType { get; set; }
        public required TourDifficulty TourDifficulty { get; set; }
        public required DateTime DepartureDateTime { get; set; }
        public required DateTime ReturnDateTime { get; set; }
        public required ulong PricePerPerson { get; set; }
        public required int MinAge { get; set; }
        public required int MaxAge { get; set; }
        public required string Origin { get; set; }
        public required string Destination { get; set; }
        public required string TourCountry { get; set; }
        public List<TourReport>? Reports { get; set; }
        public List<string>? Attributes { get; set; }
        public List<TourComment>? Comments { get; set; }
    }
}