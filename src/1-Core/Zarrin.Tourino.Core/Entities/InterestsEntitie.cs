using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;

namespace Zarrin.Tourino.Core.Entities
{
    public class InterestsEntitie : SqlBaseAttributes<int>, IGuid
    {
        public Guid Guid { get; set; } = System.Guid.NewGuid();
        public Guid EntitieGuid { get; set; }
    }
}