using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Core.Enums;

namespace Zarrin.Tourino.Core.Entities
{
    public class ActivityArea : SqlBaseAttributes<int>
    {
        public required IranianProvince Province { get; set; }
        public required string City { get; set; }
        public required string District { get; set; }
    }
}