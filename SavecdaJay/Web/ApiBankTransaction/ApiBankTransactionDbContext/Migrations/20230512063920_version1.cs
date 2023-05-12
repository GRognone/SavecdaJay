using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiBankTransactionDb.Migrations
{
    /// <inheritdoc />
    public partial class version1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransactionId = table.Column<int>(name: "Transaction Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(name: "Transaction Date", type: "datetime2", nullable: false),
                    TransactionFrom = table.Column<long>(name: "Transaction From", type: "bigint", maxLength: 11, nullable: false),
                    TransactionTo = table.Column<long>(name: "Transaction To", type: "bigint", maxLength: 11, nullable: false),
                    TransactionAmount = table.Column<double>(name: "Transaction Amount", type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");
        }
    }
}
