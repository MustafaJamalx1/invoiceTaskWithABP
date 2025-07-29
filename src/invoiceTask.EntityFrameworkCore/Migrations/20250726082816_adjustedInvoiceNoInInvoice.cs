using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace invoiceTask.Migrations
{
    /// <inheritdoc />
    public partial class adjustedInvoiceNoInInvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceNo",
                table: "AppInvoices");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceNo",
                table: "AppInvoices",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceNo",
                table: "AppInvoices");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceNo",
                table: "AppInvoices",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
