using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.DBContext;
using Zarrin.Tourino.Core.Enums;

namespace Zarrin.Tourino.Core.Entities
{
    public class TourModel : SqlBaseAttributes<int>, IGuid, IObjectCreatedDate
    {
        public Guid Guid { get; set; } = System.Guid.NewGuid();
        public DateTime ObjectCreatedDateTime { get; } = DateTime.Now;
        public required bool IsVisible { get; set; }
        public required bool IsPrivate { get; set; } 
        public required string PreviewImageForeignKey { get; set; } //NoSql
        public List<string>? ImagesForeignKeys { get; set; } //NoSql
        public required string TourName { get; set; }
        public required string TourDescription { get; set; }
        public required TourLeaderModel TourOwner { get; set; }
        public required int TourMaximumMembers { get; set; }
        public List<UserModel>? TourMembers { get; set; }
        public required string AccommodationType { get; set; }
        public required TourDifficulty TourDifficulty { get; set; }
        public required DateTime DepartureDateTime { get; set; }
        public required DateTime ReturnDateTime { get; set; }
        public required ulong PricePerPerson { get; set; }
        public required int MinAge { get; set; }
        public required int MaxAge { get; set; }
        public required string Origin { get; set; } //Type In Prop Avaz Mishavad va In Movaghati Ast
        public required string Destination { get; set; } //Type In Prop Avaz Mishavad va In Movaghati Ast
        public required string TourCountry { get; set; } //Type In Prop Avaz Mishavad va In Movaghati Ast
        public List<TourReport>? Reports { get; set; }
    }
}