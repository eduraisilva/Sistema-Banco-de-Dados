using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Sistema.Domain.Entities;
using Sistema.Infra.Data.Config;

namespace Sistema.Infra.Data.Context
{
    public class SistemaContext : DbContext
    {
        //Referencia de Tabelas.
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Item_Pedido> Itens_Pedido { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
               
    }
    public SistemaContext(DbContextOptions options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        modelBuilder.ApplyConfiguration(new EstoqueConfiguration());
        modelBuilder.ApplyConfiguration(new Item_PedidoConfiguration());
        modelBuilder.ApplyConfiguration(new PedidoConfiguration());
        modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }

}
