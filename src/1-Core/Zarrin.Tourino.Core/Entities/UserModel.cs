using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.DBContext;
using Zarrin.Tourino.Core.Entities.CommonEntities;

namespace Zarrin.Tourino.Core.Entities
{
    public class UserModel : AccountBaseAttributes
    {
        public UserModel()
        {
            NewGuid();
        }
        public override void NewGuid()
        {
            using var db = new DbData();
            var users = db.Users;

            while (true)
            {
                var newGuid = System.Guid.NewGuid();
                if (!users.Any(t => t.Guid == newGuid))
                {
                    Guid = newGuid;
                    break;
                }
            }
        }
    }
}