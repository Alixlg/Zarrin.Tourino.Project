using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Core.Entities.CommonEntities;

namespace Zarrin.Tourino.Core.Entities.TourEntities
{
    public class CommentLike : SqlBaseAttributes<int>
    {
        public required AccountBaseAttributes LikeOwner { get; set; }
        public required string LikeOwnerGuid { get; set; }
    }
}