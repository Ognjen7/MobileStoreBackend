using Microsoft.EntityFrameworkCore.Migrations;

namespace MobilePhoneStore.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Model",
                value: "IPhone 13");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Model", "Photo" },
                values: new object[] { "IPhone 14", "https://www.tehnomedia.rs/image/91914.jpg?tip=webp&tip_slike=0" });

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

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 5,
                column: "Photo",
                value: "https://img.ep-cdn.com/i/500/500/al/alhkinftrpeswyxbgvou/samsung-galaxy-z-fold-4-12gb-256gb-black-cene.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 6,
                column: "Photo",
                value: "https://www.tehnomedia.rs/image/102822.jpg?tip=webp&tip_slike=0");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 7,
                column: "Photo",
                value: "https://www.tehnomedia.rs/image/95008.jpg?tip=webp&tip_slike=0");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 8,
                column: "Photo",
                value: "https://www.tehnomedia.rs/image/104507.jpg?tip=webp&tip_slike=0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Model",
                value: "13");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Model", "Photo" },
                values: new object[] { "14", "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Model", "Photo" },
                values: new object[] { "15 Pro Max", "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Model", "Photo" },
                values: new object[] { "15", "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 5,
                column: "Photo",
                value: "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 6,
                column: "Photo",
                value: "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 7,
                column: "Photo",
                value: "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 8,
                column: "Photo",
                value: "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg");
        }
    }
}
