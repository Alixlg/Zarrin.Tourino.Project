using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zarrin.Tourino.Core.Migrations
{
    /// <inheritdoc />
    public partial class M125_7_29 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    OpenTicketTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastTicketUpdateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TicketType = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketTitle = table.Column<string>(type: "TEXT", nullable: false),
                    TicketFirstMessage = table.Column<string>(type: "TEXT", nullable: false),
                    TicketStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketPriority = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountBaseAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    DateOfSingup = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsVisible = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PassWord = table.Column<string>(type: "TEXT", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Ip = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<ulong>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    ProfileImageForeignKey = table.Column<string>(type: "TEXT", nullable: true),
                    NationalCode = table.Column<ulong>(type: "INTEGER", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 34, nullable: false),
                    AdminRole = table.Column<int>(type: "INTEGER", nullable: true),
                    TicketModelId = table.Column<int>(type: "INTEGER", nullable: true),
                    AverageScores = table.Column<double>(type: "REAL", nullable: true),
                    UserCommentsKey = table.Column<string>(type: "TEXT", nullable: true),
                    TourLeaderHonors = table.Column<string>(type: "TEXT", nullable: true),
                    Subscription = table.Column<int>(type: "INTEGER", nullable: true),
                    TourLeaderModelId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserModelId = table.Column<int>(type: "INTEGER", nullable: true),
                    ActivityTours = table.Column<string>(type: "TEXT", nullable: true),
                    Adress = table.Column<string>(type: "TEXT", nullable: true),
                    LeaderAccountLevel = table.Column<int>(type: "INTEGER", nullable: true),
                    ExperienceLevel = table.Column<int>(type: "INTEGER", nullable: true),
                    IsApproved = table.Column<bool>(type: "INTEGER", nullable: true),
                    RejectionReason = table.Column<string>(type: "TEXT", nullable: true),
                    IdentityDocumentsKey = table.Column<string>(type: "TEXT", nullable: true),
                    UserModel_IdentityDocumentsKey = table.Column<string>(type: "TEXT", nullable: true),
                    SocialMediaLinks = table.Column<string>(type: "TEXT", nullable: true),
                    UserModel_Subscription = table.Column<int>(type: "INTEGER", nullable: true),
                    AboutMe = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountBaseAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountBaseAttributes_AccountBaseAttributes_TourLeaderModelId",
                        column: x => x.TourLeaderModelId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountBaseAttributes_AccountBaseAttributes_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountBaseAttributes_Tickets_TicketModelId",
                        column: x => x.TicketModelId,
                        principalTable: "Tickets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AccountBaseAttributesTicketModel",
                columns: table => new
                {
                    ReferrersId = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountBaseAttributesTicketModel", x => new { x.ReferrersId, x.TicketsId });
                    table.ForeignKey(
                        name: "FK_AccountBaseAttributesTicketModel_AccountBaseAttributes_ReferrersId",
                        column: x => x.ReferrersId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountBaseAttributesTicketModel_Tickets_TicketsId",
                        column: x => x.TicketsId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    TourLeaderModelId = table.Column<int>(type: "INTEGER", nullable: true),
                    TourLeaderVerificationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityArea_AccountBaseAttributes_TourLeaderModelId",
                        column: x => x.TourLeaderModelId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActivityArea_AccountBaseAttributes_TourLeaderVerificationId",
                        column: x => x.TourLeaderVerificationId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    LogTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LogType = table.Column<int>(type: "INTEGER", nullable: false),
                    LogTitle = table.Column<string>(type: "TEXT", nullable: false),
                    LogMessage = table.Column<string>(type: "TEXT", nullable: false),
                    AccountId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logs_AccountBaseAttributes_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
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
                        name: "FK_ScoreModel_AccountBaseAttributes_TourLeaderModelId",
                        column: x => x.TourLeaderModelId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ScoreModel_AccountBaseAttributes_VoterId",
                        column: x => x.VoterId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    MessageOwnerId = table.Column<int>(type: "INTEGER", nullable: false),
                    MessageSendTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Messages = table.Column<string>(type: "TEXT", nullable: false),
                    TicketMessageModelId = table.Column<int>(type: "INTEGER", nullable: true),
                    TicketModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketMessages_AccountBaseAttributes_MessageOwnerId",
                        column: x => x.MessageOwnerId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketMessages_TicketMessages_TicketMessageModelId",
                        column: x => x.TicketMessageModelId,
                        principalTable: "TicketMessages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TicketMessages_Tickets_TicketModelId",
                        column: x => x.TicketModelId,
                        principalTable: "Tickets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TourLeaderReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    TourLeaderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReporterId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReporteTitle = table.Column<string>(type: "TEXT", nullable: false),
                    ReporteText = table.Column<string>(type: "TEXT", nullable: false),
                    AdminResponse = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourLeaderReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourLeaderReports_AccountBaseAttributes_ReporterId",
                        column: x => x.ReporterId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourLeaderReports_AccountBaseAttributes_TourLeaderId",
                        column: x => x.TourLeaderId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    TourLeaderModelId = table.Column<int>(type: "INTEGER", nullable: true),
                    TourLeaderModelId1 = table.Column<int>(type: "INTEGER", nullable: true),
                    UserModelId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserModelId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_AccountBaseAttributes_TourLeaderModelId",
                        column: x => x.TourLeaderModelId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tours_AccountBaseAttributes_TourLeaderModelId1",
                        column: x => x.TourLeaderModelId1,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tours_AccountBaseAttributes_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tours_AccountBaseAttributes_UserModelId1",
                        column: x => x.UserModelId1,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TourReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    TargetTourId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReporterId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReporteTitle = table.Column<string>(type: "TEXT", nullable: false),
                    ReporteText = table.Column<string>(type: "TEXT", nullable: false),
                    AdminResponse = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourReport_AccountBaseAttributes_ReporterId",
                        column: x => x.ReporterId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourReport_Tours_TargetTourId",
                        column: x => x.TargetTourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountBaseAttributes_TicketModelId",
                table: "AccountBaseAttributes",
                column: "TicketModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountBaseAttributes_TourLeaderModelId",
                table: "AccountBaseAttributes",
                column: "TourLeaderModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountBaseAttributes_UserModelId",
                table: "AccountBaseAttributes",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountBaseAttributesTicketModel_TicketsId",
                table: "AccountBaseAttributesTicketModel",
                column: "TicketsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityArea_TourLeaderModelId",
                table: "ActivityArea",
                column: "TourLeaderModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityArea_TourLeaderVerificationId",
                table: "ActivityArea",
                column: "TourLeaderVerificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_AccountId",
                table: "Logs",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreModel_TourLeaderModelId",
                table: "ScoreModel",
                column: "TourLeaderModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreModel_VoterId",
                table: "ScoreModel",
                column: "VoterId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketMessages_MessageOwnerId",
                table: "TicketMessages",
                column: "MessageOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketMessages_TicketMessageModelId",
                table: "TicketMessages",
                column: "TicketMessageModelId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketMessages_TicketModelId",
                table: "TicketMessages",
                column: "TicketModelId");

            migrationBuilder.CreateIndex(
                name: "IX_TourLeaderReports_ReporterId",
                table: "TourLeaderReports",
                column: "ReporterId");

            migrationBuilder.CreateIndex(
                name: "IX_TourLeaderReports_TourLeaderId",
                table: "TourLeaderReports",
                column: "TourLeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_TourReport_ReporterId",
                table: "TourReport",
                column: "ReporterId");

            migrationBuilder.CreateIndex(
                name: "IX_TourReport_TargetTourId",
                table: "TourReport",
                column: "TargetTourId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TourLeaderModelId",
                table: "Tours",
                column: "TourLeaderModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TourLeaderModelId1",
                table: "Tours",
                column: "TourLeaderModelId1");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_UserModelId",
                table: "Tours",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_UserModelId1",
                table: "Tours",
                column: "UserModelId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountBaseAttributesTicketModel");

            migrationBuilder.DropTable(
                name: "ActivityArea");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "ScoreModel");

            migrationBuilder.DropTable(
                name: "TicketMessages");

            migrationBuilder.DropTable(
                name: "TourLeaderReports");

            migrationBuilder.DropTable(
                name: "TourReport");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "AccountBaseAttributes");

            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
