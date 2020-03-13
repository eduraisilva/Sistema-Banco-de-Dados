using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Domain.Entities;

namespace Sistema.Infra.Data.Config
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            //chave primária
            builder.HasKey(u => u.Cliente_Id);

            builder.Property(u => u.Nome).HasMaxLength(400).IsRequired();
            builder.Property(u => u.SobreNome).HasMaxLength(400).IsRequired();
            builder.Property(u => u.DataNascimento).IsRequired();
            builder.Property(u => u.Sexo).IsRequired();

            builder.HasMany(u => u.Pedidos)
                .WithOne(i => i.Cliente);
                //.HasForeignKey<Pedido>(i => i.Pedido_Id);


        }
    }
}
