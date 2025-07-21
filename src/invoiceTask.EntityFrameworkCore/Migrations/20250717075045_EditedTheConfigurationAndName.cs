using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace invoiceTask.Migrations
{
    /// <inheritdoc />
    public partial class EditedTheConfigurationAndName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoicesItems_Invoices_InvoiceId",
                table: "InvoicesItems");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoicesItems_Products_ProductId",
                table: "InvoicesItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDiscounts_Products_ProductId",
                table: "ProductDiscounts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductPricings_Products_ProductId",
                table: "ProductPricings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductPricings",
                table: "ProductPricings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductDiscounts",
                table: "ProductDiscounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoicesItems",
                table: "InvoicesItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "AppProducts");

            migrationBuilder.RenameTable(
                name: "ProductPricings",
                newName: "AppProductPricings");

            migrationBuilder.RenameTable(
                name: "ProductDiscounts",
                newName: "AppProductDiscounts");

            migrationBuilder.RenameTable(
                name: "InvoicesItems",
                newName: "AppInvoiceItems");

            migrationBuilder.RenameTable(
                name: "Invoices",
                newName: "AppInvoices");

            migrationBuilder.RenameIndex(
                name: "IX_ProductPricings_ProductId",
                table: "AppProductPricings",
                newName: "IX_AppProductPricings_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductDiscounts_ProductId",
                table: "AppProductDiscounts",
                newName: "IX_AppProductDiscounts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoicesItems_ProductId",
                table: "AppInvoiceItems",
                newName: "IX_AppInvoiceItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoicesItems_InvoiceId",
                table: "AppInvoiceItems",
                newName: "IX_AppInvoiceItems_InvoiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppProducts",
                table: "AppProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppProductPricings",
                table: "AppProductPricings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppProductDiscounts",
                table: "AppProductDiscounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppInvoiceItems",
                table: "AppInvoiceItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppInvoices",
                table: "AppInvoices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppInvoiceItems_AppInvoices_InvoiceId",
                table: "AppInvoiceItems",
                column: "InvoiceId",
                principalTable: "AppInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppInvoiceItems_AppProducts_ProductId",
                table: "AppInvoiceItems",
                column: "ProductId",
                principalTable: "AppProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppProductDiscounts_AppProducts_ProductId",
                table: "AppProductDiscounts",
                column: "ProductId",
                principalTable: "AppProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppProductPricings_AppProducts_ProductId",
                table: "AppProductPricings",
                column: "ProductId",
                principalTable: "AppProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppInvoiceItems_AppInvoices_InvoiceId",
                table: "AppInvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_AppInvoiceItems_AppProducts_ProductId",
                table: "AppInvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_AppProductDiscounts_AppProducts_ProductId",
                table: "AppProductDiscounts");

            migrationBuilder.DropForeignKey(
                name: "FK_AppProductPricings_AppProducts_ProductId",
                table: "AppProductPricings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppProducts",
                table: "AppProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppProductPricings",
                table: "AppProductPricings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppProductDiscounts",
                table: "AppProductDiscounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppInvoices",
                table: "AppInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppInvoiceItems",
                table: "AppInvoiceItems");

            migrationBuilder.RenameTable(
                name: "AppProducts",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "AppProductPricings",
                newName: "ProductPricings");

            migrationBuilder.RenameTable(
                name: "AppProductDiscounts",
                newName: "ProductDiscounts");

            migrationBuilder.RenameTable(
                name: "AppInvoices",
                newName: "Invoices");

            migrationBuilder.RenameTable(
                name: "AppInvoiceItems",
                newName: "InvoicesItems");

            migrationBuilder.RenameIndex(
                name: "IX_AppProductPricings_ProductId",
                table: "ProductPricings",
                newName: "IX_ProductPricings_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_AppProductDiscounts_ProductId",
                table: "ProductDiscounts",
                newName: "IX_ProductDiscounts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_AppInvoiceItems_ProductId",
                table: "InvoicesItems",
                newName: "IX_InvoicesItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_AppInvoiceItems_InvoiceId",
                table: "InvoicesItems",
                newName: "IX_InvoicesItems_InvoiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductPricings",
                table: "ProductPricings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductDiscounts",
                table: "ProductDiscounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoicesItems",
                table: "InvoicesItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoicesItems_Invoices_InvoiceId",
                table: "InvoicesItems",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoicesItems_Products_ProductId",
                table: "InvoicesItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDiscounts_Products_ProductId",
                table: "ProductDiscounts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPricings_Products_ProductId",
                table: "ProductPricings",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
