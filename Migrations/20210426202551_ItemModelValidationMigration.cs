using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoListMVC.Migrations
{
    public partial class ItemModelValidationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Items",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Items",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ID", "Deadline", "Description", "Done", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 28, 23, 25, 50, 746, DateTimeKind.Local).AddTicks(7203), "Add database with entity framework", false, "DB" },
                    { 2, new DateTime(2021, 4, 28, 23, 25, 50, 747, DateTimeKind.Local).AddTicks(7596), "Add messages on index page to inform about actions (create/edit/delete)", true, "Messages" },
                    { 3, new DateTime(2021, 4, 28, 23, 25, 50, 747, DateTimeKind.Local).AddTicks(8059), "Crossout deadline when expired", false, "Deadline" },
                    { 4, new DateTime(2021, 4, 28, 23, 25, 50, 747, DateTimeKind.Local).AddTicks(8077), "Do not show controls on the delete page", false, "Controls" },
                    { 5, new DateTime(2021, 4, 28, 23, 25, 50, 747, DateTimeKind.Local).AddTicks(8090), "Two containers with completed and not completed todos", false, "Filter" },
                    { 6, new DateTime(2021, 4, 28, 23, 25, 50, 747, DateTimeKind.Local).AddTicks(8114), "Model validation on edit/create page", false, "Validation" },
                    { 7, new DateTime(2021, 4, 28, 23, 25, 50, 747, DateTimeKind.Local).AddTicks(8127), "Add information page, describe why this project was created", false, "Information" },
                    { 8, new DateTime(2021, 4, 28, 23, 25, 50, 747, DateTimeKind.Local).AddTicks(8139), "Scrolling is not working (not showing) when there are more than 9 items", false, "Scrolling" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600);
        }
    }
}
