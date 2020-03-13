using Sistema.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Domain.Entities
{
    public class Cliente
    {
        public int Cliente_Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string DataNascimento { get; set; }
        public SexoEnum Sexo { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public Cliente()
        {
            Pedidos = new List<Pedido>();
        }


    }
}
