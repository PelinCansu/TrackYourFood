using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackYourFood.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(8553)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(8868)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Editors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(7618)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(7935)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(1230)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(1710)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfUnit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(3377)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(4011)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(6523)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(6864)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProteinValue = table.Column<double>(type: "float", nullable: false),
                    FatValue = table.Column<double>(type: "float", nullable: false),
                    CarboValue = table.Column<double>(type: "float", nullable: false),
                    Kcal = table.Column<double>(type: "float", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    UnitID = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MealID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(9848)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(279)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Foods_Meals_MealID",
                        column: x => x.MealID,
                        principalTable: "Meals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Foods_Units_UnitID",
                        column: x => x.UnitID,
                        principalTable: "Units",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddedFoods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    CalculatedProtein = table.Column<double>(type: "float", nullable: false),
                    CalculatedFat = table.Column<double>(type: "float", nullable: false),
                    CalculatedCarbo = table.Column<double>(type: "float", nullable: false),
                    CalculatedKcal = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(7006)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(7587)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddedFoods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AddedFoods_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddedFoods_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, "Vegetables", "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, "Fruits", "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, "Dairy", "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, "Grains", "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, "Protein", "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Editors",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "FirstName", "LastName", "ModifiedBy", "ModifiedDate", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "System1", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Editor1", "Editor1", "System1", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "123qwe.", "editor1@tyf.com" },
                    { 2, "System1", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Editor2", "Editor2", "System1", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "123qwe.", "editor2@tyf.com" },
                    { 3, "System1", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Editor3", "Editor3", "System1", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "123qwe.", "editor3@tyf.com" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "MealType", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Breakfast", "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Lunch", "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Dinner", "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Snack", "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "NameOfUnit" },
                values: new object[,]
                {
                    { 1, "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "gr" },
                    { 2, "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "quantity" },
                    { 3, "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "portion" },
                    { 4, "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Emre Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "litre" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "ID", "CarboValue", "CategoryID", "CreatedBy", "CreatedDate", "FatValue", "FoodName", "Kcal", "MealID", "ModifiedBy", "ModifiedDate", "Picture", "ProteinValue", "UnitID" },
                values: new object[,]
                {
                    { 1, 11.07, 1, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 10.380000000000001, "Green Peas", 147.0, 2, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\bezelye.jpg", 3.48, 1 },
                    { 2, 4.7000000000000002, 1, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 5.0, "Artichokes in oil", 79.0, 2, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\zeytinyagli-enginar-500x500.jpeg", 1.8, 1 },
                    { 3, 19.300000000000001, 2, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 0.23999999999999999, "Apple", 73.0, 4, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\star-elma-p-2246.jpg", 0.35999999999999999, 2 },
                    { 4, 26.949999999999999, 2, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 0.39000000000000001, "Banana", 105.0, 4, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\benekli-muz.jpg", 1.29, 2 },
                    { 5, 4.6600000000000001, 3, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 3.3500000000000001, "Milk", 62.0, 1, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\sut.jpg", 3.3199999999999998, 4 },
                    { 6, 4.0899999999999999, 3, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 21.280000000000001, "White cheese", 264.0, 1, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\beyazPeynir.jpg", 14.210000000000001, 1 },
                    { 7, 29.399999999999999, 4, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 1.3999999999999999, "Dried beans", 282.0, 2, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\kurufasulye.jpg", 22.0, 1 },
                    { 8, 17.199999999999999, 4, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 0.82999999999999996, "Pea meal", 110.0, 2, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\nohut.jpg", 8.3000000000000007, 1 },
                    { 9, 0.0, 5, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 6.6299999999999999, "Beef steak", 187.0, 3, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\biftek.jpg", 29.809999999999999, 1 },
                    { 11, 0.0, 5, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 5.2999999999999998, "Boiled Egg", 78.0, 1, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\yumurta.jpg", 6.29, 1 },
                    { 12, 0.0, 5, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 1.24, "Chicken breast", 110.0, 3, "Pelin Gurcan", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\izgara-tavuk-gogsu.jpg", 23.100000000000001, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddedFoods_FoodID",
                table: "AddedFoods",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_AddedFoods_UserID",
                table: "AddedFoods",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryID",
                table: "Foods",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_MealID",
                table: "Foods",
                column: "MealID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_UnitID",
                table: "Foods",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddedFoods");

            migrationBuilder.DropTable(
                name: "Editors");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Units");
        }
    }
}
