using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assimentefcore4444.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customerid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nationalid = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.customerid);
                });

            migrationBuilder.CreateTable(
                name: "manger",
                columns: table => new
                {
                    mangerid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<int>(type: "int", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manger", x => x.mangerid);
                });

            migrationBuilder.CreateTable(
                name: "branches",
                columns: table => new
                {
                    Branchcoude = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mangerid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branches", x => x.Branchcoude);
                    table.ForeignKey(
                        name: "FK_branches_manger_mangerid",
                        column: x => x.mangerid,
                        principalTable: "manger",
                        principalColumn: "mangerid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    AcountNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    openingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    currentBalance = table.Column<int>(type: "int", nullable: false),
                    Branchcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branchid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.AcountNumber);
                    table.ForeignKey(
                        name: "FK_accounts_branches_branchid",
                        column: x => x.branchid,
                        principalTable: "branches",
                        principalColumn: "Branchcoude",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "customerAcount",
                columns: table => new
                {
                    customerid = table.Column<int>(type: "int", nullable: false),
                    accountid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerAcount", x => new { x.customerid, x.accountid });
                    table.ForeignKey(
                        name: "FK_customerAcount_accounts_accountid",
                        column: x => x.accountid,
                        principalTable: "accounts",
                        principalColumn: "AcountNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_customerAcount_customers_customerid",
                        column: x => x.customerid,
                        principalTable: "customers",
                        principalColumn: "customerid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "transactions",
                columns: table => new
                {
                    transactionid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    transactiontype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    accountid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transactions", x => x.transactionid);
                    table.ForeignKey(
                        name: "FK_transactions_accounts_accountid",
                        column: x => x.accountid,
                        principalTable: "accounts",
                        principalColumn: "AcountNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_accounts_branchid",
                table: "accounts",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_branches_mangerid",
                table: "branches",
                column: "mangerid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_customerAcount_accountid",
                table: "customerAcount",
                column: "accountid");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_accountid",
                table: "transactions",
                column: "accountid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customerAcount");

            migrationBuilder.DropTable(
                name: "transactions");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "branches");

            migrationBuilder.DropTable(
                name: "manger");
        }
    }
}
