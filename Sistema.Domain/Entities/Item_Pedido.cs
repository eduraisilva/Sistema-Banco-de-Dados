using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Domain.Entities
{
    public class Item_Pedido
    {
        public int Pedido_Id { get; set; }
        public int Produto_Id { get; set; }
        public string ItemPed_Nome { get; set; }
        public int ItemPed_QTDE { get; set; }
        public int ItemPed_Valor { get; set; }

        public virtual Pedido Pedidos { get; set; }

        public virtual Produto Produtos { get; set; }


    }
}
