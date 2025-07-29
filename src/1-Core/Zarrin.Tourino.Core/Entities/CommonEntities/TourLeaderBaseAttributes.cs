using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Core.DBContext;
using Zarrin.Tourino.Core.Enums;

namespace Zarrin.Tourino.Core.Entities.CommonEntities
{
    public abstract class TourLeaderBaseAttributes : AccountBaseAttributes
    {
        public required List<ActivityArea> ActivityArea { get; set; }
        public required List<TourType> ActivityTours { get; set; }
        public required string Adress { get; set; }
        public TourLeaderAccountLevel LeaderAccountLevel { get; set; }
        public ExperienceLevel ExperienceLevel { get; set; }
    }
}