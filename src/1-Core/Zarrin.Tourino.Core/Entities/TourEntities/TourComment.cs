using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.Entities.CommonEntities;

namespace Zarrin.Tourino.Core.Entities.TourEntities
{
    public class TourComment : SqlBaseAttributes<int>, IGuid
    {
        public Guid Guid { get; set; } = System.Guid.NewGuid();
        public required AccountBaseAttributes CommentOwner { get; set; }
        public required DateTime MessageSendTime { get; set; }
        public required string Comment { get; set; }
        public List<TourComment>? SubComments { get; set; }
    }
}