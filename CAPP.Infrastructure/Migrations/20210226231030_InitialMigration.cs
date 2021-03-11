using Microsoft.EntityFrameworkCore.Migrations;

namespace CAPP.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperationGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationObjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationObjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    KeyWord = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationGroupOperations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationGroupId = table.Column<int>(type: "int", nullable: false),
                    OperationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationGroupOperations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationGroupOperations_OperationGroups_OperationGroupId",
                        column: x => x.OperationGroupId,
                        principalTable: "OperationGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationGroupOperations_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationOperationObjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationId = table.Column<int>(type: "int", nullable: false),
                    OperationObjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationOperationObjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationOperationObjects_OperationObjects_OperationObjectId",
                        column: x => x.OperationObjectId,
                        principalTable: "OperationObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationOperationObjects_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OperationGroupOperations_OperationGroupId",
                table: "OperationGroupOperations",
                column: "OperationGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationGroupOperations_OperationId",
                table: "OperationGroupOperations",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationGroups_Code",
                table: "OperationGroups",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OperationObjects_Code",
                table: "OperationObjects",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OperationOperationObjects_OperationId",
                table: "OperationOperationObjects",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationOperationObjects_OperationObjectId",
                table: "OperationOperationObjects",
                column: "OperationObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_Code",
                table: "Operations",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationGroupOperations");

            migrationBuilder.DropTable(
                name: "OperationOperationObjects");

            migrationBuilder.DropTable(
                name: "OperationGroups");

            migrationBuilder.DropTable(
                name: "OperationObjects");

            migrationBuilder.DropTable(
                name: "Operations");
        }
    }
}
