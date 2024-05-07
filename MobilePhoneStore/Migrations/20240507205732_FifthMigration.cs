using Microsoft.EntityFrameworkCore.Migrations;

namespace MobilePhoneStore.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Model", "Photo" },
                values: new object[] { "iPhone 13", "https://www.tehnomedia.rs/image/85400.jpg?tip=webp&tip_slike=0" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Model",
                value: "iPhone 14");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Model", "Photo" },
                values: new object[] { "iPhone 15 Pro", "https://www.tehnomedia.rs/image/100132.jpg?tip=webp&tip_slike=0" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Model", "Photo" },
                values: new object[] { "iPhone 15", "https://www.tehnomedia.rs/image/100086.jpg?tip=webp&tip_slike=0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Model", "Photo" },
                values: new object[] { "IPhone 13", "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Model",
                value: "IPhone 14");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Model", "Photo" },
                values: new object[] { "IPhone 15 Pro", "https://istyle.rs/media/catalog/product/i/p/iphone_15_pro_natural_titanium_pdp_image_position-1__en-us_1_2.jpg" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Model", "Photo" },
                values: new object[] { "IPhone 15", "https://istyle.rs/media/catalog/product/i/p/iphone_15_black_pdp_image_position-1__en-us_2.jpg" });
        }
    }
}
