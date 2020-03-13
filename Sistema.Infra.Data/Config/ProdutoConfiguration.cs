using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Domain.Entities;

namespace Sistema.Infra.Data.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            //chave primária
            builder.HasKey(u => u.Produto_Id);
            builder.Property(u => u.Produto_Nome).HasMaxLength(400).IsRequired();
            builder.Property(u => u.Produto_Valor).HasMaxLength(400).IsRequired();

            builder.HasMany(u => u.Itens_Pedido).WithOne(p => p.Produtos);
            builder.HasMany(u => u.Estoques).WithOne(p => p.Produtos);


        }
    
    }
}
