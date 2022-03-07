using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchMvc.Infra.Data.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Products(Name, Description, Price, Stock, Image, CategoryId)" +
                "Values('Produto 1', 'Descricao de produto 1',9.90,50,null,1)");
            migrationBuilder.Sql("Insert Into Products(Name, Description, Price, Stock, Image, CategoryId)" +
                "Values('Produto 2', 'Descricao de produto 2',9.90,50,null,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Truncate Table Products");
        }
    }
}
