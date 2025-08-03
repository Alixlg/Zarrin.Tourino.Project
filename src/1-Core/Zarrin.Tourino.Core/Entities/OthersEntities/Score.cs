using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Core.Entities.CommonEntities;
using Zarrin.Tourino.Core.Enums;

namespace Zarrin.Tourino.Core.Entities.OthersEntities
{
    public class Score : SqlBaseAttributes<int>
    {
        public required AccountBaseAttributes Voter { get; set; }
        public required Enums.Score AmountScore { get; set; }
    }
}