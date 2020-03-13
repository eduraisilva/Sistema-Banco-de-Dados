using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Domain.Entities;

namespace Sistema.Infra.Data.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            //chave primária
            builder.HasKey(u => u.Pedido_Id);
            builder.HasKey(u => u.Cliente_Id);

            //chave estrangeira
            //builder.Property(u => u.Cliente_Id).HasMaxLength(400).IsRequired();
            builder.Property(u => u.Pedido_Data).HasMaxLength(400).IsRequired();
            builder.Property(u => u.Pedido_QTDE).HasMaxLength(400).IsRequired();
            builder.Property(u => u.Pedido_Valor).IsRequired();
            

            



        }
    
    }
}
