using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Domain.Entities
{
    public class Produto
    {
        public int Produto_Id { get; set; }
        public string Produto_Nome { get; set; }
        public string Produto_Valor { get; set; }

        public virtual ICollection<Item_Pedido> Itens_Pedido { get; set; }
        public virtual ICollection<Estoque> Estoques { get; set; }

        
    }
}
