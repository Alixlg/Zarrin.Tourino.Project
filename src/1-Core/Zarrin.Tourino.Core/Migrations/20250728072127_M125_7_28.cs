using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zarrin.Tourino.Core.Migrations
{
    /// <inheritdoc />
    public partial class M125_7_28 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TourLeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ActivityTours = table.Column<string>(type: "TEXT", nullable: false),
                    Adress = table.Column<string>(type: "TEXT", nullable: false),
                    LeaderAccountLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    ExperienceLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 34, nullable: false),
                    IsApproved = table.Column<bool>(type: "INTEGER", nullable: true),
                    RejectionReason = table.Column<string>(type: "TEXT", nullable: true),
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    DateOfSingup = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsVisible = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<ulong>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    ProfileImageForeignKey = table.Column<string>(type: "TEXT", nullable: true),
                    NationalCode = table.Column<ulong>(type: "INTEGER", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourLeaders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityArea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Province = table.Column<int>(type: "INTEGER", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    District = table.Column<string>(type: "TEXT", nullable: false),
                    TourLeaderModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityArea_TourLeaders_TourLeaderModelId",
                        column: x => x.TourLeaderModelId,
                        principalTable: "TourLeaders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityArea_TourLeaderModelId",
                table: "ActivityArea",
                column: "TourLeaderModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityArea");

            migrationBuilder.DropTable(
                name: "TourLeaders");
        }
    }
}
