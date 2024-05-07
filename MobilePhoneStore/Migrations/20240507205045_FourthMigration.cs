using Microsoft.EntityFrameworkCore.Migrations;

namespace MobilePhoneStore.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 9,
                column: "Photo",
                value: "https://img.gigatron.rs/img/products/large/image6467404c20680.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 10,
                column: "Photo",
                value: "https://img.gigatron.rs/img/products/large/image652e84afa707f.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 11,
                column: "Photo",
                value: "https://img.gigatron.rs/img/products/large/image63c52aab38686.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 12,
                column: "Photo",
                value: "https://www.giztop.com/media/catalog/product/cache/dc206057cdd42d7e34b9d36e347785ca/x/i/xiaomi_14_ultra_white.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 13,
                column: "Photo",
                value: "https://www.tehnomedia.rs/image/103970.jpg?tip=webp&tip_slike=0");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 14,
                column: "Photo",
                value: "https://mi-srbija.rs/storage/product/images/4c/55/xiaomi-13t-pro-6539.png");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 15,
                column: "Photo",
                value: "https://www.honor.com/content/dam/honor/my/product-list/smartphone/honor-magic6-pro/honor-magic6-pro-green.png");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 16,
                column: "Photo",
                value: "https://img.gigatron.rs/img/products/large/image64a7ec239245d.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 17,
                column: "Photo",
                value: "https://api.tehnoteka.rs/uploads/cache/product_4x3/uploads/2024/01/honor-magic5-lite-8-256gb-emerald-green-659e89d880e04.jpeg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 18,
                column: "Photo",
                value: "https://e-mobilni.rs/wp-content/uploads/2023/11/mobilni-telefon-honor-x8a-67-6gb-128gb-plavi-190763-291451.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 9,
                column: "Photo",
                value: "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 10,
                column: "Photo",
                value: "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 11,
                column: "Photo",
                value: "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 12,
                column: "Photo",
                value: "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 13,
                column: "Photo",
                value: "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 14,
                column: "Photo",
                value: "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 15,
                column: "Photo",
                value: "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 16,
                column: "Photo",
                value: "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 17,
                column: "Photo",
                value: "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 18,
                column: "Photo",
                value: "https://istyle.rs/media/catalog/product/i/p/iphone_13_pink_pdp_image_position-1a__wwen_7_1_1.jpg");
        }
    }
}
