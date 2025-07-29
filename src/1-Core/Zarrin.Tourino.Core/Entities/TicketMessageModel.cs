using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.DBContext;
using Zarrin.Tourino.Core.Entities.CommonEntities;

namespace Zarrin.Tourino.Core.Entities
{
    public class TicketMessageModel : SqlBaseAttributes<int>, IGuid
    {
        public Guid Guid { get; set; }
        public required AccountBaseAttributes MessageOwner { get; set; }
        public required DateTime MessageSendTime { get; set; }
        public required string Messages { get; set; }
        public List<TicketMessageModel>? SubMessages { get; set; }
        public TicketMessageModel()
        {
            NewGuid();
        }
        public void NewGuid()
        {
            using var db = new DbData();
            var messages = db.TicketMessages;

            while (true)
            {
                var newGuid = System.Guid.NewGuid();
                if (!messages.Any(t => t.Guid == newGuid))
                {
                    Guid = newGuid;
                    break;
                }
            }
        }
    }
}