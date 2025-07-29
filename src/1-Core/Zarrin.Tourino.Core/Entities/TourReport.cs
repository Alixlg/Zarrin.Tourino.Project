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
    public class TourReport : SqlBaseAttributes<int>, IGuid, IObjectCreatedDate
    {
        public Guid Guid { get; set; }
        public DateTime ObjectCreatedDateTime { get; } = DateTime.Now;
        public required TourModel TargetTour { get; set; }
        public required AccountBaseAttributes Reporter { get; set; }
        public required string ReporteTitle { get; set; }
        public required string ReporteText { get; set; }
        public string? AdminResponse { get; set; }
        public TourReport()
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