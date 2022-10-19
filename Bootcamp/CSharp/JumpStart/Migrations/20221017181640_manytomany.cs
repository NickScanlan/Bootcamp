using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JumpStart.Migrations
{
    public partial class manytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserProjectSupports",
                columns: table => new
                {
                    UserProjectSupportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    UserProjectSupportId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProjectSupports", x => x.UserProjectSupportId);
                    table.ForeignKey(
                        name: "FK_UserProjectSupports_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProjectSupports_UserProjectSupports_UserProjectSupportId1",
                        column: x => x.UserProjectSupportId1,
                        principalTable: "UserProjectSupports",
                        principalColumn: "UserProjectSupportId");
                    table.ForeignKey(
                        name: "FK_UserProjectSupports_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjectSupports_ProjectId",
                table: "UserProjectSupports",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjectSupports_UserId",
                table: "UserProjectSupports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjectSupports_UserProjectSupportId1",
                table: "UserProjectSupports",
                column: "UserProjectSupportId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "UserProjectSupports");

            migrationBuilder.DropIndex(
                name: "IX_Projects_UserId",
                table: "Projects");
        }
    }
}
