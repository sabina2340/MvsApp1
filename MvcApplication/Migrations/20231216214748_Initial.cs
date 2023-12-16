using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MvcApplication.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TGROUP",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TGROUP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TRELATION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentGroupId = table.Column<long>(type: "bigint", nullable: false),
                    ChildGroupId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRELATION", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TRELATION_TGROUP_ChildGroupId",
                        column: x => x.ChildGroupId,
                        principalTable: "TGROUP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRELATION_TGROUP_ParentGroupId",
                        column: x => x.ParentGroupId,
                        principalTable: "TGROUP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TRELATION_ChildGroupId",
                table: "TRELATION",
                column: "ChildGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TRELATION_ParentGroupId",
                table: "TRELATION",
                column: "ParentGroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TRELATION");

            migrationBuilder.DropTable(
                name: "TGROUP");
        }
    }
}
