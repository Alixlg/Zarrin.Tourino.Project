using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zarrin.Tourino.Core.Migrations
{
    /// <inheritdoc />
    public partial class M225_7_28 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AverageScores",
                table: "TourLeaders",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "IdentityDocumentsKey",
                table: "TourLeaders",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TourLeaderHonors",
                table: "TourLeaders",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCommentsKey",
                table: "TourLeaders",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TourLeaderReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    TourLeaderModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourLeaderReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourLeaderReports_TourLeaders_TourLeaderModelId",
                        column: x => x.TourLeaderModelId,
                        principalTable: "TourLeaders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    TourLeaderModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_TourLeaders_TourLeaderModelId",
                        column: x => x.TourLeaderModelId,
                        principalTable: "TourLeaders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScoreModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VoterId = table.Column<int>(type: "INTEGER", nullable: false),
                    AmountScore = table.Column<int>(type: "INTEGER", nullable: false),
                    TourLeaderModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScoreModel_TourLeaders_TourLeaderModelId",
                        column: x => x.TourLeaderModelId,
                        principalTable: "TourLeaders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ScoreModel_Users_VoterId",
                        column: x => x.VoterId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScoreModel_TourLeaderModelId",
                table: "ScoreModel",
                column: "TourLeaderModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreModel_VoterId",
                table: "ScoreModel",
                column: "VoterId");

            migrationBuilder.CreateIndex(
                name: "IX_TourLeaderReports_TourLeaderModelId",
                table: "TourLeaderReports",
                column: "TourLeaderModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TourLeaderModelId",
                table: "Tours",
                column: "TourLeaderModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "ScoreModel");

            migrationBuilder.DropTable(
                name: "TourLeaderReports");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "AverageScores",
                table: "TourLeaders");

            migrationBuilder.DropColumn(
                name: "IdentityDocumentsKey",
                table: "TourLeaders");

            migrationBuilder.DropColumn(
                name: "TourLeaderHonors",
                table: "TourLeaders");

            migrationBuilder.DropColumn(
                name: "UserCommentsKey",
                table: "TourLeaders");
        }
    }
}
