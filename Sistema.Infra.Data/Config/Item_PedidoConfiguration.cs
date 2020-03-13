using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Domain.Entities;

namespace Sistema.Infra.Data.Config
{
    public class Item_PedidoConfiguration : IEntityTypeConfiguration<Item_Pedido>
    {
        public void Configure(EntityTypeBuilder<Item_Pedido> builder)
        {
            //chave primária
            builder.HasKey(u => u.Pedido_Id);
            builder.HasKey(u => u.Produto_Id);
            builder.Property(u => u.ItemPed_Nome).HasMaxLength(400).IsRequired();
            builder.Property(u => u.ItemPed_QTDE).HasMaxLength(400).IsRequired();
            builder.Property(u => u.ItemPed_Valor).IsRequired();

            

            



        }
    
    }
}
