using Zarrin.Tourino.Core.DBContext;
using Zarrin.Tourino.Core.Entities;
using Zarrin.Tourino.Core.Entities.AccountsEntities;
using Zarrin.Tourino.Core.Entities.CommonEntities;
using Zarrin.Tourino.Core.Entities.SupportTicketEntities;
using Zarrin.Tourino.Core.Enums;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();
        builder.Services.AddDbContext<DbData>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();

        Test(new TourLeaderAccount
        {
            DateOfSingup = DateTime.UtcNow,
            IsVisible = true,
            UserName = "tourleader123",
            Email = "email@example.com",
            PassWord = "securepassword",
            Token = "generated-token",
            FullName = "John Doe",
            LastIp = "192.168.1.1",
            PhoneNumber = 1234567890,
            Status = AccountStatus.Active,
            ActivityArea = [],
            ActivityTours = [],
            Adress = "1234 Street Name, City"
        });


        app.MapGet("api/v1/entitie/test", () =>
        {
            return Test(new TourLeaderAccount
            {
                DateOfSingup = DateTime.UtcNow,
                IsVisible = true,
                UserName = "tourleader123",
                Email = "email@example.com",
                PassWord = "securepassword",
                Token = "generated-token",
                FullName = "John Doe",
                LastIp = "192.168.1.1",
                PhoneNumber = 1234567890,
                Status = AccountStatus.Active,
                ActivityArea = [],
                ActivityTours = [],
                Adress = "1234 Street Name, City"
            });
        });

        app.Run();
    }
    public static SupportTicket Test(TourLeaderAccount t)
    {
        var ticket = new SupportTicket
        {
            OpenTicketTime = DateTime.UtcNow,
            LastTicketUpdateTime = DateTime.UtcNow,
            Referrers = [t],
            TicketType = SupportTicketType.ManagementUnit,
            TicketTitle = "Login Error",
            TicketFirstMessage = "User cannot log in using email."
        };
        return ticket;
    }
}