using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.UI.Migrations
{
    public partial class ImageThumbnailUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageThumbnailUrl",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageThumbnailUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ImageThumbnailUrl",
                value: "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg");
        }
    }
}
