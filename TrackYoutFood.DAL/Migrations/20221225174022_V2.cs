using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackYourFood.DAL.Migrations
{
    /// <inheritdoc />
    public partial class V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(5516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(5181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(3221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(2905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Meals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(2015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Meals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(1711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Editors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(6573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Editors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(6276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 161, DateTimeKind.Local).AddTicks(9387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 161, DateTimeKind.Local).AddTicks(9045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 161, DateTimeKind.Local).AddTicks(7911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 161, DateTimeKind.Local).AddTicks(7354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(3019));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(8110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(7874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(6763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(6567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Meals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(6099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Meals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(5891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(5337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(5025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Editors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(9379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Editors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(9092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 162, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(4391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 161, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(4184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 161, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(3431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 161, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 25, 18, 58, 28, 411, DateTimeKind.Local).AddTicks(3019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 25, 20, 40, 22, 161, DateTimeKind.Local).AddTicks(7354));
        }
    }
}
