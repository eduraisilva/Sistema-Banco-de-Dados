using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Domain.Entities;

namespace Sistema.Infra.Data.Config
{
    public class EstoqueConfiguration : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            //chave primária
            builder.HasKey(u => u.Estoque_Id);
            builder.Property(u => u.Estoque_QTDE).HasMaxLength(400).IsRequired();
           

            



        }
    
    }
}
