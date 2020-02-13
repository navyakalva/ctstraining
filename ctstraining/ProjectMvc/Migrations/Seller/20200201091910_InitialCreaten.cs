using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectMvc.Migrations.Seller
{
    public partial class InitialCreaten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Sid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PostalAddress = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Companyname = table.Column<string>(nullable: true),
                    Bankdetails = table.Column<string>(nullable: true),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Sid);
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
