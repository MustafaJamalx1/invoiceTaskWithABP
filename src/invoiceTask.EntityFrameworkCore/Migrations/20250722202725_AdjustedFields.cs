using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace invoiceTask.Migrations
{
    /// <inheritdoc />
    public partial class AdjustedFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductDiscountId",
                table: "AppInvoiceItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductPricingId",
                table: "AppInvoiceItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductDiscountId",
                table: "AppInvoiceItems");

            migrationBuilder.DropColumn(
                name: "ProductPricingId",
                table: "AppInvoiceItems");
        }
    }
}
