using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Entities;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.Enums;

namespace Zarrin.Tourino.Core.Entities.CommonEntities
{
    public abstract class AccountBaseAttributes : SqlBaseAttributes<int>, IGuid, IObjectCreatedDate
    {
        public Guid Guid { get; set; }
        public required DateTime DateOfSingup { get; set; }
        public required bool IsVisible { get; set; }
        public required string UserName { get; set; }
        public required string FullName { get; set; }
        public required ulong PhoneNumber { get; set; }
        public required AccountStatus Status { get; set; }
        public AccountGender Gender { get; set; } = AccountGender.Unknown;
        public string? ProfileImageForeignKey { get; set; } //NoSql
        public ulong NationalCode { get; set; }
        public int Age { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public DateTime ObjectCreatedDateTime { get; } = DateTime.Now;
        public virtual void NewGuid() { }
    }
}