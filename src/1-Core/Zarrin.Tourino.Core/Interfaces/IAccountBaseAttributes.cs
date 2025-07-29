using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zarrin.Tourino.Common.Core.Interfaces;
using Zarrin.Tourino.Core.Entities;
using Zarrin.Tourino.Core.Enums;

namespace Zarrin.Tourino.Core.Interfaces
{
    public interface IAccountBaseAttributes : IGuid
    {
        DateTime DateOfSingup { get; set; }
        bool IsVisible { get; set; }
        string UserName { get; set; }
        string Email { get; set; }
        string PassWord { get; set; }
        string Token { get; set; }
        string FullName { get; set; }
        string Ip { get; set; }
        ulong PhoneNumber { get; set; }
        AccountStatus Status { get; set; }
        AccountGender Gender { get; set; }
        string ProfileImageForeignKey { get; set; } //NoSql
        List<LogsModel> Logs { get; set; }
        List<TicketModel> Tickets { get; set; }
        ulong NationalCode { get; set; }
        int Age { get; set; }
        DateOnly DateOfBirth { get; set; }
        DateTime ObjectCreatedDateTime { get; }
    }
}