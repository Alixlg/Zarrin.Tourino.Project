using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zarrin.Tourino.Common.Core.Entities
{
    public abstract class SqlBaseAttributes<T> where T : struct
    {
        public T Id { get; set; }
    }
}