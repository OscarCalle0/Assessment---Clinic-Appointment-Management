using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Appointment_Management.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserWithRoleId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctors_bookings_UserId",
                table: "doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_logs_bookings_UserId",
                table: "logs");

            migrationBuilder.DropForeignKey(
                name: "FK_patients_bookings_UserId",
                table: "patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bookings",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "bookings");

            migrationBuilder.RenameTable(
                name: "bookings",
                newName: "users");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_users_RoleId",
                table: "users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_users_UserId",
                table: "doctors",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_logs_users_UserId",
                table: "logs",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_patients_users_UserId",
                table: "patients",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_roles_RoleId",
                table: "users",
                column: "RoleId",
                principalTable: "roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctors_users_UserId",
                table: "doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_logs_users_UserId",
                table: "logs");

            migrationBuilder.DropForeignKey(
                name: "FK_patients_users_UserId",
                table: "patients");

            migrationBuilder.DropForeignKey(
                name: "FK_users_roles_RoleId",
                table: "users");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_RoleId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "bookings");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "bookings",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bookings",
                table: "bookings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_bookings_UserId",
                table: "doctors",
                column: "UserId",
                principalTable: "bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_logs_bookings_UserId",
                table: "logs",
                column: "UserId",
                principalTable: "bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_patients_bookings_UserId",
                table: "patients",
                column: "UserId",
                principalTable: "bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
