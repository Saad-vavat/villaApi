using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForiegnKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VIllaID",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 4, 12, 59, 7, 513, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 4, 12, 59, 7, 513, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 4, 12, 59, 7, 513, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 2, 4, 12, 59, 7, 513, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 2, 4, 12, 59, 7, 513, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VIllaID",
                table: "VillaNumbers",
                column: "VIllaID");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VIllaID",
                table: "VillaNumbers",
                column: "VIllaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VIllaID",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VIllaID",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VIllaID",
                table: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 20, 29, 34, 814, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 20, 29, 34, 814, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 20, 29, 34, 814, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 20, 29, 34, 814, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 20, 29, 34, 814, DateTimeKind.Local).AddTicks(5694));
        }
    }
}
