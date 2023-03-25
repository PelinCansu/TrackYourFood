using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackYourFood.DAL.Migrations
{
    /// <inheritdoc />
    public partial class vpelin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(8110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(7874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(6763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(6567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Meals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(6099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Meals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(5891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(5337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(5025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Editors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(9379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Editors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(9092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(4391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(4184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(3431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(3019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(7006));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(6864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(6523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(4011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(3377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Meals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(1710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Meals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(1230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(9848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Editors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(7935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Editors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(7618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(8868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(8553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(7587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(7006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(3019));
        }
    }
}
