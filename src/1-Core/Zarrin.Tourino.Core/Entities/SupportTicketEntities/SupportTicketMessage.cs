using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.DBContext;
using Zarrin.Tourino.Core.Entities.CommonEntities;

namespace Zarrin.Tourino.Core.Entities.SupportTicketEntities
{
    public class SupportTicketMessage : SqlBaseAttributes<int>, IGuid
    {
        public Guid Guid { get; set; } = System.Guid.NewGuid();
        public int MessageOwnerId { get; set; }
        public required AccountBaseAttributes MessageOwner { get; set; }
        public required DateTime MessageSendTime { get; set; }
        public required string Message { get; set; }
        public List<SupportTicketMessage>? SubMessages { get; set; }
    }
}