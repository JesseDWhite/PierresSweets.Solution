using Microsoft.EntityFrameworkCore.Migrations;

namespace PierresSweets.Migrations
{
    public partial class UpdateType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerTreat_AspNetUsers_CustomerId1",
                table: "CustomerTreat");

            migrationBuilder.DropIndex(
                name: "IX_CustomerTreat_CustomerId1",
                table: "CustomerTreat");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "CustomerTreat");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "CustomerTreat",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTreat_CustomerId",
                table: "CustomerTreat",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerTreat_AspNetUsers_CustomerId",
                table: "CustomerTreat",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerTreat_AspNetUsers_CustomerId",
                table: "CustomerTreat");

            migrationBuilder.DropIndex(
                name: "IX_CustomerTreat_CustomerId",
                table: "CustomerTreat");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerTreat",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerId1",
                table: "CustomerTreat",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTreat_CustomerId1",
                table: "CustomerTreat",
                column: "CustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerTreat_AspNetUsers_CustomerId1",
                table: "CustomerTreat",
                column: "CustomerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
