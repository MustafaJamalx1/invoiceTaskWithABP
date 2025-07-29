using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace invoiceTask.Migrations
{
    /// <inheritdoc />
    public partial class adjustedFiledsNamesInInvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalDicsount",
                table: "AppInvoices",
                newName: "TotalDiscount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalDiscount",
                table: "AppInvoices",
                newName: "TotalDicsount");
        }
    }
}
