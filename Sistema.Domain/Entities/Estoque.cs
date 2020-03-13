using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Domain.Entities
{
    public class Estoque
    {
        public int Estoque_Id { get; set; }
        public int Estoque_QTDE { get; set; }

        public virtual Produto Produtos { get; set; }



    }
}
