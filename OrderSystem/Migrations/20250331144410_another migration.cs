using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderSystem.Migrations
{
    /// <inheritdoc />
    public partial class anothermigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Orders",
                newName: "ClientID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Orders",
                newName: "Статус");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "Дата_и_время");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Orders",
                newName: "Сумма");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                newName: "IX_Orders_ClientID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clients",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Clients",
                newName: "Фамилия");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Clients",
                newName: "Имя");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Clients",
                newName: "Дата_рождения");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientID",
                table: "Orders",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientID",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "Orders",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Сумма",
                table: "Orders",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "Статус",
                table: "Orders",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Дата_и_время",
                table: "Orders",
                newName: "OrderDate");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ClientID",
                table: "Orders",
                newName: "IX_Orders_ClientId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Clients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Фамилия",
                table: "Clients",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Имя",
                table: "Clients",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Дата_рождения",
                table: "Clients",
                newName: "BirthDate");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
