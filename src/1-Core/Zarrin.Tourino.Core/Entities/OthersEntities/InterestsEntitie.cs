using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;

namespace Zarrin.Tourino.Core.Entities.OthersEntities
{
    public class InterestsEntitie<T> : SqlBaseAttributes<int> where T : struct
    {
        public T EntitieId { get; set; }
    }
}