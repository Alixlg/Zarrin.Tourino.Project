using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.Entities.OthersEntities;
using Zarrin.Tourino.Core.Entities.SupportTicketEntities;
using Zarrin.Tourino.Core.Enums;

namespace Zarrin.Tourino.Core.Entities.CommonEntities
{
    public abstract class AccountBaseAttributes : SqlBaseAttributes<int>, IObjectCreatedDate, IGuid
    {
        public Guid Guid { get; set; } = System.Guid.NewGuid();
        public required DateTime DateOfSingup { get; set; }
        public required bool IsVisible { get; set; }
        public required AccountRole AccountRole { get; set; }
        public required ulong PhoneNumber { get; set; }
        public required string FullName { get; set; }
        public required string UserName { get; set; }
        public required string PassWord { get; set; }
        public required string LastIp { get; set; }
        public string? Email { get; set; }
        public required AccountStatus Status { get; set; }
        public AccountGender Gender { get; set; } = AccountGender.Unknown;
        public int ProfileImageId { get; set; } //NoSql
        public List<ActivityLogs>? Logs { get; set; }
        public List<SupportTicket>? Tickets { get; set; }
        public ulong NationalCode { get; set; }
        public int Age { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public DateTime ObjectCreatedDateTime { get; } = DateTime.Now;
    }
}