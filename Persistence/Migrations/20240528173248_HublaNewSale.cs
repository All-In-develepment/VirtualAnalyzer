using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class HublaNewSale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HublaEventCanceledSale",
                columns: table => new
                {
                    HublaEventCanceledSaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recurring = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditCardLR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    IsRenewing = table.Column<bool>(type: "bit", nullable: false),
                    SellerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDocument = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HublaEventCanceledSale", x => x.HublaEventCanceledSaleId);
                });

            migrationBuilder.CreateTable(
                name: "HublaEventNewSale",
                columns: table => new
                {
                    HublaEventNewSaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recurring = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    IsRenewing = table.Column<bool>(type: "bit", nullable: false),
                    SellerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDocument = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HublaEventNewSale", x => x.HublaEventNewSaleId);
                });

            migrationBuilder.CreateTable(
                name: "HublaEventNewUser",
                columns: table => new
                {
                    HublaEventNewUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HublaEventNewUser", x => x.HublaEventNewUserId);
                });

            migrationBuilder.CreateTable(
                name: "HublaCanceledSales",
                columns: table => new
                {
                    HublaCanceledSaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventHublaEventCanceledSaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HublaCanceledSales", x => x.HublaCanceledSaleId);
                    table.ForeignKey(
                        name: "FK_HublaCanceledSales_HublaEventCanceledSale_EventHublaEventCanceledSaleId",
                        column: x => x.EventHublaEventCanceledSaleId,
                        principalTable: "HublaEventCanceledSale",
                        principalColumn: "HublaEventCanceledSaleId");
                });

            migrationBuilder.CreateTable(
                name: "HublaAffiliate",
                columns: table => new
                {
                    HublaAffiliateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AffiliateAmount = table.Column<int>(type: "int", nullable: false),
                    AffiliateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffiliateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HublaEventCanceledSaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HublaEventNewSaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HublaAffiliate", x => x.HublaAffiliateId);
                    table.ForeignKey(
                        name: "FK_HublaAffiliate_HublaEventCanceledSale_HublaEventCanceledSaleId",
                        column: x => x.HublaEventCanceledSaleId,
                        principalTable: "HublaEventCanceledSale",
                        principalColumn: "HublaEventCanceledSaleId");
                    table.ForeignKey(
                        name: "FK_HublaAffiliate_HublaEventNewSale_HublaEventNewSaleId",
                        column: x => x.HublaEventNewSaleId,
                        principalTable: "HublaEventNewSale",
                        principalColumn: "HublaEventNewSaleId");
                });

            migrationBuilder.CreateTable(
                name: "HublaNewSales",
                columns: table => new
                {
                    HublaNewSaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventHublaEventNewSaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HublaNewSales", x => x.HublaNewSaleId);
                    table.ForeignKey(
                        name: "FK_HublaNewSales_HublaEventNewSale_EventHublaEventNewSaleId",
                        column: x => x.EventHublaEventNewSaleId,
                        principalTable: "HublaEventNewSale",
                        principalColumn: "HublaEventNewSaleId");
                });

            migrationBuilder.CreateTable(
                name: "HublaNewUsers",
                columns: table => new
                {
                    HublaNewUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventHublaEventNewUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HublaNewUsers", x => x.HublaNewUserId);
                    table.ForeignKey(
                        name: "FK_HublaNewUsers_HublaEventNewUser_EventHublaEventNewUserId",
                        column: x => x.EventHublaEventNewUserId,
                        principalTable: "HublaEventNewUser",
                        principalColumn: "HublaEventNewUserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HublaAffiliate_HublaEventCanceledSaleId",
                table: "HublaAffiliate",
                column: "HublaEventCanceledSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_HublaAffiliate_HublaEventNewSaleId",
                table: "HublaAffiliate",
                column: "HublaEventNewSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_HublaCanceledSales_EventHublaEventCanceledSaleId",
                table: "HublaCanceledSales",
                column: "EventHublaEventCanceledSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_HublaNewSales_EventHublaEventNewSaleId",
                table: "HublaNewSales",
                column: "EventHublaEventNewSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_HublaNewUsers_EventHublaEventNewUserId",
                table: "HublaNewUsers",
                column: "EventHublaEventNewUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HublaAffiliate");

            migrationBuilder.DropTable(
                name: "HublaCanceledSales");

            migrationBuilder.DropTable(
                name: "HublaNewSales");

            migrationBuilder.DropTable(
                name: "HublaNewUsers");

            migrationBuilder.DropTable(
                name: "HublaEventCanceledSale");

            migrationBuilder.DropTable(
                name: "HublaEventNewSale");

            migrationBuilder.DropTable(
                name: "HublaEventNewUser");
        }
    }
}
