using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.FormUsuarios
{
    public class UsuarioNegocio
    {
        private readonly UsuarioBD _bd;

        public UsuarioNegocio()
        {
            _bd = new UsuarioBD();
        }
        public List<UsuarioData> ListarUsuarios()
        {
            return _bd.ListarUsuarios();
        }
    }

    public class ComboBoxItemUsuario
    {
        public string Login { get; set; }
        public int Codigo { get; set; }
        public string Senha { get; set; }

        public ComboBoxItemUsuario(string login, int codigo, string senha)
        {
            Login = login;
            Codigo = codigo;
            Senha = senha;
        }

        public override string ToString()
        {
            return Login;
        }
    }
}
