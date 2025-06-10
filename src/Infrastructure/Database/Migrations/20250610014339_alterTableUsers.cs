using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Database.Migrations;

/// <inheritdoc />
public partial class alterTableUsers : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameColumn(
            name: "password_hash",
            schema: "dbo",
            table: "Users",
            newName: "PasswordHash");

        migrationBuilder.RenameColumn(
            name: "last_name",
            schema: "dbo",
            table: "Users",
            newName: "LastName");

        migrationBuilder.RenameColumn(
            name: "first_name",
            schema: "dbo",
            table: "Users",
            newName: "FirstName");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameColumn(
            name: "PasswordHash",
            schema: "dbo",
            table: "Users",
            newName: "password_hash");

        migrationBuilder.RenameColumn(
            name: "LastName",
            schema: "dbo",
            table: "Users",
            newName: "last_name");

        migrationBuilder.RenameColumn(
            name: "FirstName",
            schema: "dbo",
            table: "Users",
            newName: "first_name");
    }
}
