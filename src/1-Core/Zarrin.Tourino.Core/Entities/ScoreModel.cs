using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Core.Enums;

namespace Zarrin.Tourino.Core.Entities
{
    public class ScoreModel : SqlBaseAttributes<int>
    {
        public required UserModel Voter { get; set; }
        public required Score AmountScore { get; set; }
    }
}