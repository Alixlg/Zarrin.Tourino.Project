using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.DBContext;

namespace Zarrin.Tourino.Core.Entities
{
    public class TourLeaderReport : SqlBaseAttributes<int>, IGuid, IObjectCreatedDate
    {
        public Guid Guid { get; set; }
        public DateTime ObjectCreatedDateTime { get; } = DateTime.Now;
        public TourLeaderReport()
        {
            NewGuid();
        }
        public void NewGuid()
        {
            using var db = new DbData();
            var reports = db.TourLeaderReports;

            while (true)
            {
                var newGuid = System.Guid.NewGuid();
                if (!reports.Any(t => t.Guid == newGuid))
                {
                    Guid = newGuid;
                    break;
                }
            }
        }
    }
}