using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.DBContext;
using Zarrin.Tourino.Core.Entities.CommonEntities;
using Zarrin.Tourino.Core.Interfaces;

namespace Zarrin.Tourino.Core.Entities
{
    public class TicketMessageModel : SqlBaseAttributes<int>, IGuid
    {
        public Guid Guid { get; set; } = System.Guid.NewGuid();
        public required IAccountBaseAttributes MessageOwner { get; set; }
        public required DateTime MessageSendTime { get; set; }
        public required string Messages { get; set; }
        public List<TicketMessageModel>? SubMessages { get; set; }
    }
}