using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantAdminProject.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Name", "Price", "Status" },
                values: new object[,]
                {
                    { 1, 0, "Burger", 5.99m, 0 },
                    { 2, 1, "Fries", 2.99m, 0 },
                    { 3, 3, "Coke", 1.99m, 0 }
                });

            migrationBuilder.InsertData(
                table: "SetMeals",
                columns: new[] { "Id", "Name", "Price", "Status" },
                values: new object[] { 1, "Combo Meal", 8.99m, 0 });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "Name", "Position" },
                values: new object[,]
                {
                    { 1, "Yuan", "Manager" },
                    { 2, "Mike", "Chef" }
                });

            migrationBuilder.InsertData(
                table: "SetMealMenuItems",
                columns: new[] { "Id", "MenuItemId", "SetMealId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SetMealMenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SetMealMenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SetMeals",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
