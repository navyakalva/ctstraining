using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectMvc.Migrations.SubCategory
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    Cid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Catname = table.Column<string>(nullable: true),
                    Briefdetails = table.Column<string>(nullable: true),
                    Sub_id = table.Column<int>(nullable: false),
                    Sub_name = table.Column<string>(nullable: true),
                    GST = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.Cid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategory");
        }
    }
}
