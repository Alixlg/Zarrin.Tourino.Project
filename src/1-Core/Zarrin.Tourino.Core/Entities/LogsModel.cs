using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.DBContext;
using Zarrin.Tourino.Core.Entities.CommonEntities;
using Zarrin.Tourino.Core.Enums;
using Zarrin.Tourino.Core.Interfaces;

namespace Zarrin.Tourino.Core.Entities
{
    public class LogsModel : SqlBaseAttributes<int>, IObjectCreatedDate, IGuid
    {
        public Guid Guid { get; set; } = System.Guid.NewGuid();
        public DateTime ObjectCreatedDateTime { get; } = DateTime.Now;
        public required DateTime LogTime { get; set; }
        public required LogType LogType { get; set; }
        public required string LogTitle { get; set; }
        public required string LogMessage { get; set; }
        public IAccountBaseAttributes? Account { get; set; }
    }
}