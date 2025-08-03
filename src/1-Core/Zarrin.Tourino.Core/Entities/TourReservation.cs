using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;

namespace Zarrin.Tourino.Core.Entities
{
    public class TourReservation : SqlBaseAttributes<int>, IGuid, IObjectCreatedDate
    {
        public Guid Guid { get; set; } = System.Guid.NewGuid();
        public DateTime ObjectCreatedDateTime { get; } = DateTime.Now;
        public required string FullName { get; set; }
        public required ulong NationalCode { get; set; }
        public required ulong PhoneNumber { get; set; }
        public required DateOnly DateOfBirth { get; set; }
    }
}