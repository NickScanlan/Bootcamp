using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JumpStart.Migrations
{
    public partial class othermany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProjectSupports_UserProjectSupports_UserProjectSupportId1",
                table: "UserProjectSupports");

            migrationBuilder.DropIndex(
                name: "IX_UserProjectSupports_UserProjectSupportId1",
                table: "UserProjectSupports");

            migrationBuilder.DropColumn(
                name: "UserProjectSupportId1",
                table: "UserProjectSupports");

            migrationBuilder.AddColumn<int>(
                name: "UserProjectGoalSupport",
                table: "UserProjectSupports",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserProjectGoalSupport",
                table: "UserProjectSupports");

            migrationBuilder.AddColumn<int>(
                name: "UserProjectSupportId1",
                table: "UserProjectSupports",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserProjectSupports_UserProjectSupportId1",
                table: "UserProjectSupports",
                column: "UserProjectSupportId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProjectSupports_UserProjectSupports_UserProjectSupportId1",
                table: "UserProjectSupports",
                column: "UserProjectSupportId1",
                principalTable: "UserProjectSupports",
                principalColumn: "UserProjectSupportId");
        }
    }
}
