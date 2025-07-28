using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.DBContext;

namespace Zarrin.Tourino.Core.Entities
{
    public class TourModel : SqlBaseAttributes<int>, IGuid, IObjectCreatedDate
    {
        public Guid Guid { get; set; }
        public DateTime ObjectCreatedDateTime { get; } = DateTime.Now;
        
        public TourModel()
        {
            NewGuid();
        }
        public void NewGuid()
        {
            using var db = new DbData();
            var tours = db.Tours;

            while (true)
            {
                var newGuid = System.Guid.NewGuid();
                if (!tours.Any(t => t.Guid == newGuid))
                {
                    Guid = newGuid;
                    break;
                }
            }
        }
    }
}