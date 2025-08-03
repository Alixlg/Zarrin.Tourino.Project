using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zarrin.Tourino.Core.Migrations
{
    /// <inheritdoc />
    public partial class M125_08_03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupportTickets",
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
                    table.PrimaryKey("PK_SupportTickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TourLeaderVerificationList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    TourLeaderGuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    IsApproved = table.Column<bool>(type: "INTEGER", nullable: true),
                    RejectionReason = table.Column<string>(type: "TEXT", nullable: true),
                    IdentityDocumentsKeys = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourLeaderVerificationList", x => x.Id);
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
                    PhoneNumber = table.Column<ulong>(type: "INTEGER", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    PassWord = table.Column<string>(type: "TEXT", nullable: false),
                    Ip = table.Column<string>(type: "TEXT", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    ProfileImageForeignKey = table.Column<string>(type: "TEXT", nullable: true),
                    NationalCode = table.Column<ulong>(type: "INTEGER", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 21, nullable: false),
                    AdminRole = table.Column<int>(type: "INTEGER", nullable: true),
                    AdminPermissions = table.Column<string>(type: "TEXT", nullable: true),
                    SupportTicketId = table.Column<int>(type: "INTEGER", nullable: true),
                    ActivityTours = table.Column<string>(type: "TEXT", nullable: true),
                    Adress = table.Column<string>(type: "TEXT", nullable: true),
                    LeaderAccountLevel = table.Column<int>(type: "INTEGER", nullable: true),
                    ExperienceLevel = table.Column<int>(type: "INTEGER", nullable: true),
                    AverageScores = table.Column<double>(type: "REAL", nullable: true),
                    UserCommentsKey = table.Column<string>(type: "TEXT", nullable: true),
                    TourLeaderHonors = table.Column<string>(type: "TEXT", nullable: true),
                    TourLeaderAccount_Subscription = table.Column<int>(type: "INTEGER", nullable: true),
                    IdentityDocumentsKeys = table.Column<string>(type: "TEXT", nullable: true),
                    SocialMediaLinks = table.Column<string>(type: "TEXT", nullable: true),
                    UserHonors = table.Column<string>(type: "TEXT", nullable: true),
                    Subscription = table.Column<int>(type: "INTEGER", nullable: true),
                    AboutMe = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountBaseAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountBaseAttributes_SupportTickets_SupportTicketId",
                        column: x => x.SupportTicketId,
                        principalTable: "SupportTickets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AccountBaseAttributesSupportTicket",
                columns: table => new
                {
                    ReferrersId = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountBaseAttributesSupportTicket", x => new { x.ReferrersId, x.TicketsId });
                    table.ForeignKey(
                        name: "FK_AccountBaseAttributesSupportTicket_AccountBaseAttributes_ReferrersId",
                        column: x => x.ReferrersId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountBaseAttributesSupportTicket_SupportTickets_TicketsId",
                        column: x => x.TicketsId,
                        principalTable: "SupportTickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivitieLogs",
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
                    table.PrimaryKey("PK_ActivitieLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivitieLogs_AccountBaseAttributes_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
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
                    TourLeaderAccountId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityArea_AccountBaseAttributes_TourLeaderAccountId",
                        column: x => x.TourLeaderAccountId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InterestsEntitie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    EntitieGuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    TourLeaderAccountId = table.Column<int>(type: "INTEGER", nullable: true),
                    TourLeaderAccountId1 = table.Column<int>(type: "INTEGER", nullable: true),
                    UserAccountId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserAccountId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestsEntitie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterestsEntitie_AccountBaseAttributes_TourLeaderAccountId",
                        column: x => x.TourLeaderAccountId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InterestsEntitie_AccountBaseAttributes_TourLeaderAccountId1",
                        column: x => x.TourLeaderAccountId1,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InterestsEntitie_AccountBaseAttributes_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InterestsEntitie_AccountBaseAttributes_UserAccountId1",
                        column: x => x.UserAccountId1,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VoterId = table.Column<int>(type: "INTEGER", nullable: false),
                    AmountScore = table.Column<int>(type: "INTEGER", nullable: false),
                    TourLeaderAccountId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Score_AccountBaseAttributes_TourLeaderAccountId",
                        column: x => x.TourLeaderAccountId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Score_AccountBaseAttributes_VoterId",
                        column: x => x.VoterId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupportTicketMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    MessageOwnerId = table.Column<int>(type: "INTEGER", nullable: false),
                    MessageSendTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    SupportTicketId = table.Column<int>(type: "INTEGER", nullable: true),
                    SupportTicketMessageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportTicketMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupportTicketMessages_AccountBaseAttributes_MessageOwnerId",
                        column: x => x.MessageOwnerId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportTicketMessages_SupportTicketMessages_SupportTicketMessageId",
                        column: x => x.SupportTicketMessageId,
                        principalTable: "SupportTicketMessages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SupportTicketMessages_SupportTickets_SupportTicketId",
                        column: x => x.SupportTicketId,
                        principalTable: "SupportTickets",
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
                    IsVisible = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsPrivate = table.Column<bool>(type: "INTEGER", nullable: false),
                    PreviewImageForeignKey = table.Column<string>(type: "TEXT", nullable: false),
                    IsVip = table.Column<bool>(type: "INTEGER", nullable: false),
                    ImagesForeignKeys = table.Column<string>(type: "TEXT", nullable: true),
                    TourName = table.Column<string>(type: "TEXT", nullable: false),
                    TourDescription = table.Column<string>(type: "TEXT", nullable: false),
                    TourOwnerId = table.Column<int>(type: "INTEGER", nullable: false),
                    TourMaximumMembers = table.Column<int>(type: "INTEGER", nullable: false),
                    AccommodationType = table.Column<string>(type: "TEXT", nullable: false),
                    TourDifficulty = table.Column<int>(type: "INTEGER", nullable: false),
                    DepartureDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReturnDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PricePerPerson = table.Column<ulong>(type: "INTEGER", nullable: false),
                    MinAge = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxAge = table.Column<int>(type: "INTEGER", nullable: false),
                    Origin = table.Column<string>(type: "TEXT", nullable: false),
                    Destination = table.Column<string>(type: "TEXT", nullable: false),
                    TourCountry = table.Column<string>(type: "TEXT", nullable: false),
                    Attributes = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_AccountBaseAttributes_TourOwnerId",
                        column: x => x.TourOwnerId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    CommentOwnerId = table.Column<int>(type: "INTEGER", nullable: false),
                    MessageSendTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: false),
                    TourCommentId = table.Column<int>(type: "INTEGER", nullable: true),
                    TourId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourComment_AccountBaseAttributes_CommentOwnerId",
                        column: x => x.CommentOwnerId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourComment_TourComment_TourCommentId",
                        column: x => x.TourCommentId,
                        principalTable: "TourComment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TourComment_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
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

            migrationBuilder.CreateTable(
                name: "TourReservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    NationalCode = table.Column<ulong>(type: "INTEGER", nullable: false),
                    PhoneNumber = table.Column<ulong>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    TourId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourReservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourReservation_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TourUserAccount",
                columns: table => new
                {
                    TourUserMembersId = table.Column<int>(type: "INTEGER", nullable: false),
                    TripsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourUserAccount", x => new { x.TourUserMembersId, x.TripsId });
                    table.ForeignKey(
                        name: "FK_TourUserAccount_AccountBaseAttributes_TourUserMembersId",
                        column: x => x.TourUserMembersId,
                        principalTable: "AccountBaseAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourUserAccount_Tours_TripsId",
                        column: x => x.TripsId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountBaseAttributes_SupportTicketId",
                table: "AccountBaseAttributes",
                column: "SupportTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountBaseAttributesSupportTicket_TicketsId",
                table: "AccountBaseAttributesSupportTicket",
                column: "TicketsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitieLogs_AccountId",
                table: "ActivitieLogs",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityArea_TourLeaderAccountId",
                table: "ActivityArea",
                column: "TourLeaderAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestsEntitie_TourLeaderAccountId",
                table: "InterestsEntitie",
                column: "TourLeaderAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestsEntitie_TourLeaderAccountId1",
                table: "InterestsEntitie",
                column: "TourLeaderAccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_InterestsEntitie_UserAccountId",
                table: "InterestsEntitie",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestsEntitie_UserAccountId1",
                table: "InterestsEntitie",
                column: "UserAccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_Score_TourLeaderAccountId",
                table: "Score",
                column: "TourLeaderAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Score_VoterId",
                table: "Score",
                column: "VoterId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTicketMessages_MessageOwnerId",
                table: "SupportTicketMessages",
                column: "MessageOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTicketMessages_SupportTicketId",
                table: "SupportTicketMessages",
                column: "SupportTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTicketMessages_SupportTicketMessageId",
                table: "SupportTicketMessages",
                column: "SupportTicketMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_TourComment_CommentOwnerId",
                table: "TourComment",
                column: "CommentOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TourComment_TourCommentId",
                table: "TourComment",
                column: "TourCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_TourComment_TourId",
                table: "TourComment",
                column: "TourId");

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
                name: "IX_TourReservation_TourId",
                table: "TourReservation",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TourOwnerId",
                table: "Tours",
                column: "TourOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TourUserAccount_TripsId",
                table: "TourUserAccount",
                column: "TripsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountBaseAttributesSupportTicket");

            migrationBuilder.DropTable(
                name: "ActivitieLogs");

            migrationBuilder.DropTable(
                name: "ActivityArea");

            migrationBuilder.DropTable(
                name: "InterestsEntitie");

            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "SupportTicketMessages");

            migrationBuilder.DropTable(
                name: "TourComment");

            migrationBuilder.DropTable(
                name: "TourLeaderReports");

            migrationBuilder.DropTable(
                name: "TourLeaderVerificationList");

            migrationBuilder.DropTable(
                name: "TourReport");

            migrationBuilder.DropTable(
                name: "TourReservation");

            migrationBuilder.DropTable(
                name: "TourUserAccount");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "AccountBaseAttributes");

            migrationBuilder.DropTable(
                name: "SupportTickets");
        }
    }
}
