using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace invoiceTask.Migrations
{
    /// <inheritdoc />
    public partial class NewAggregateRootImplementation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AppInvoiceItems");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "AppInvoiceItems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AppInvoiceItems",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "AppInvoiceItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
