using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.UI.Migrations
{
    public partial class ChangedAmountToQuantityInOrderItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "ShoppingCartItems",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "OrderDetails",
                newName: "Quantity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "ShoppingCartItems",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "OrderDetails",
                newName: "Amount");
        }
    }
}
