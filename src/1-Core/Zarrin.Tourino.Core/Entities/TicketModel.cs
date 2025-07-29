using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.DBContext;
using Zarrin.Tourino.Core.Entities.CommonEntities;
using Zarrin.Tourino.Core.Enums;

namespace Zarrin.Tourino.Core.Entities
{
    public class TicketModel : SqlBaseAttributes<int>, IGuid, IObjectCreatedDate
    {
        public Guid Guid { get; set; }
        public DateTime ObjectCreatedDateTime { get; } = DateTime.Now;
        public List<AdminModel>? Responders { get; set; }
        public required DateTime OpenTicketTime { get; set; }
        public required DateTime LastTicketUpdateTime { get; set; }
        public required List<AccountBaseAttributes>? Referrers { get; set; }
        public required TicketType TicketType { get; set; }
        public required string TicketTitle { get; set; }
        public required string TicketFirstMessage { get; set; }
        public TicketStatus TicketStatus { get; set; }
        public TicketPriority TicketPriority { get; set; }
        public List<TicketMessageModel>? TicketMessages { get; set; }
        public TicketModel()
        {
            NewGuid();
        }
        public void NewGuid()
        {
            using var db = new DbData();
            var tickets = db.Tickets;

            while (true)
            {
                var newGuid = System.Guid.NewGuid();
                if (!tickets.Any(t => t.Guid == newGuid))
                {
                    Guid = newGuid;
                    break;
                }
            }
        }
    }
}