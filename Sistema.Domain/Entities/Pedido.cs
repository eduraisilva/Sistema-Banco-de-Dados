using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Domain.Entities
{
    public class Pedido
    {
        public int Cliente_Id { get; set; }
        public int Pedido_Id { get; set; }
        public string Pedido_Data { get; set; }
        public string Pedido_Valor { get; set; }
        public string Pedido_QTDE { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<Item_Pedido> Itens_Pedido { get; set; }

        public Pedido()
        {
            Itens_Pedido = new List<Item_Pedido>();
        }
    }

}
