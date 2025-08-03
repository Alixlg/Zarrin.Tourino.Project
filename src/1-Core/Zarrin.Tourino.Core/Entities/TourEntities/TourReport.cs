using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.Entities.CommonEntities;

namespace Zarrin.Tourino.Core.Entities.TourEntities
{
    public class TourReport : SqlBaseAttributes<int>, IGuid, IObjectCreatedDate
    {
        public Guid Guid { get; set; } = System.Guid.NewGuid();
        public DateTime ObjectCreatedDateTime { get; } = DateTime.Now;
        public required Tour TargetTour { get; set; }
        public required AccountBaseAttributes Reporter { get; set; }
        public required string ReporteTitle { get; set; }
        public required string ReporteText { get; set; }
        public string? AdminResponse { get; set; }
    }
}