using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.FormUsuarios
{
    public class UsuarioBD
    {
        public List<UsuarioData> ListarUsuarios()
        {
            MySqlConnection objeto_connection = new MySqlConnection("server=localhost;userid=root;password=admin123;database=SistemaDB");
            objeto_connection.Open();
            MySqlCommand command = new MySqlCommand("select * from usuarios", objeto_connection);
            var listaUsuarios = new List<UsuarioData>();

            try
            {
                

                //executa o comando
                command.CommandType = System.Data.CommandType.Text;

                //recebe resultado do SELECT
                MySqlDataReader Registro_Query;
                Registro_Query = command.ExecuteReader();

                while (Registro_Query.Read())
                {
                    var oUsuario = new UsuarioData();
                    oUsuario.Codigo = Convert.ToInt32(Registro_Query["Codigo"].ToString());
                    oUsuario.Nome_Completo = (Registro_Query["Nome_Completo"].ToString());
                    oUsuario.Sexo = (Registro_Query["Sexo"].ToString());
                    oUsuario.Email = (Registro_Query["Email"].ToString());
                    oUsuario.Login = (Registro_Query["Login"].ToString());
                    oUsuario.Senha = (Registro_Query["Senha"].ToString());
                    oUsuario.Data_Cadastro = (Registro_Query["Data_Cadastro"].ToString());


                    listaUsuarios.Add(oUsuario);
                }

            }
            catch(MySqlException mysqle)
            {
                throw new System.Exception(mysqle.ToString());
            }
            finally
            {
                objeto_connection.Close();
            }
            return listaUsuarios;
            
            
        }

        

    }
}
