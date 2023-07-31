using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PropertyStore.Migrations
{
    /// <inheritdoc />
    public partial class createtblItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemCode = table.Column<string>(type: "text", nullable: false),
                    Description1 = table.Column<string>(type: "text", nullable: false),
                    Description2 = table.Column<string>(type: "text", nullable: true),
                    Inventory = table.Column<string>(type: "text", nullable: false),
                    GLCOSG = table.Column<string>(type: "text", nullable: true),
                    ItemType = table.Column<string>(type: "text", nullable: false),
                    ItemClass = table.Column<string>(type: "text", nullable: false),
                    ItemGroup = table.Column<string>(type: "text", nullable: false),
                    BaseUnit = table.Column<string>(type: "text", nullable: false),
                    CostUnit = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedDate = table.Column<string>(type: "text", nullable: false),
                    Cancelled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
