using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema.Infra.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Cliente_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 400, nullable: false),
                    SobreNome = table.Column<string>(maxLength: 400, nullable: false),
                    DataNascimento = table.Column<string>(nullable: false),
                    Sexo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Cliente_Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Produto_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Produto_Nome = table.Column<string>(maxLength: 400, nullable: false),
                    Produto_Valor = table.Column<string>(maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Produto_Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Cliente_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Pedido_Id = table.Column<int>(nullable: false),
                    Pedido_Data = table.Column<string>(maxLength: 400, nullable: false),
                    Pedido_Valor = table.Column<string>(nullable: false),
                    Pedido_QTDE = table.Column<string>(maxLength: 400, nullable: false),
                    Cliente_Id1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Cliente_Id);
                    table.UniqueConstraint("AK_Pedidos_Pedido_Id", x => x.Pedido_Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_Cliente_Id1",
                        column: x => x.Cliente_Id1,
                        principalTable: "Clientes",
                        principalColumn: "Cliente_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estoques",
                columns: table => new
                {
                    Estoque_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Estoque_QTDE = table.Column<int>(maxLength: 400, nullable: false),
                    ProdutosProduto_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoques", x => x.Estoque_Id);
                    table.ForeignKey(
                        name: "FK_Estoques_Produtos_ProdutosProduto_Id",
                        column: x => x.ProdutosProduto_Id,
                        principalTable: "Produtos",
                        principalColumn: "Produto_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Itens_Pedido",
                columns: table => new
                {
                    Pedido_Id = table.Column<int>(nullable: false),
                    Produto_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemPed_Nome = table.Column<string>(maxLength: 400, nullable: false),
                    ItemPed_QTDE = table.Column<int>(maxLength: 400, nullable: false),
                    ItemPed_Valor = table.Column<int>(nullable: false),
                    PedidosCliente_Id = table.Column<int>(nullable: true),
                    ProdutosProduto_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens_Pedido", x => x.Produto_Id);
                    table.UniqueConstraint("AK_Itens_Pedido_Pedido_Id", x => x.Pedido_Id);
                    table.ForeignKey(
                        name: "FK_Itens_Pedido_Pedidos_PedidosCliente_Id",
                        column: x => x.PedidosCliente_Id,
                        principalTable: "Pedidos",
                        principalColumn: "Cliente_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Itens_Pedido_Produtos_ProdutosProduto_Id",
                        column: x => x.ProdutosProduto_Id,
                        principalTable: "Produtos",
                        principalColumn: "Produto_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_ProdutosProduto_Id",
                table: "Estoques",
                column: "ProdutosProduto_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_Pedido_PedidosCliente_Id",
                table: "Itens_Pedido",
                column: "PedidosCliente_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_Pedido_ProdutosProduto_Id",
                table: "Itens_Pedido",
                column: "ProdutosProduto_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Cliente_Id1",
                table: "Pedidos",
                column: "Cliente_Id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.DropTable(
                name: "Itens_Pedido");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
