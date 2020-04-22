using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Sistema.Domain.Entities;
using Sistema.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using Sistema.Domain;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Console.Sistema
{
    class Program 
    {
        static void Main(string[] args)
        {
            string Cryptografar(string senha)
            {

                MD5 md5Hash = MD5.Create();
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
            // TRY consulta Quantidade produto
            int Id_Produto = 8;
            string Resultado_Qtde = "s";
            string produto_nome;
            string produto_valor = "s";

            int Cliente_Id = 3;
            int Qtde_produto = 5;

            decimal Valor_Total_Compra = 1;

            

            //Criptografia de login e senha










            //Cliente cliente2;

            /*Cliente CriarCliente(string nome)
            {
                return new Cliente()
                {
                    Cliente_Id = 3,
                    Nome = nome,
                    SobreNome = "Silva",
                    DataNascimento = "17/07/1986",
                    //Sexo = "Masculino"
                    
                };


            }*/

            var optionsBuilder = new DbContextOptionsBuilder<SistemaContext>();
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySql("server=localhost;userid=root;password=admin123;database=SistemaDB", m => m.MigrationsAssembly("Sistema.Infra.Data").MaxBatchSize(100));


            System.Console.Write("Digite seu nome: ");
            var nome1 = System.Console.ReadLine();

            System.Console.Write("Qual seu Sobrenome: ");
            string SobreNomeCliente = System.Console.ReadLine();

            System.Console.Write("Qual sua data de nascimento: ");
            string DataNascimentoCliente = System.Console.ReadLine();

            System.Console.Write("Login: ");
            string login_digitado = System.Console.ReadLine();

            System.Console.Write("Senha: ");
            string senha_digitado = System.Console.ReadLine();














            //cliente2 = CriarCliente(nome1);


            // TRY Procedure: New_Cliente
            try
            {


                using (var dbcontext = new SistemaContext(optionsBuilder.Options))
                {


                    //dbcontext.Clientes.Add(cliente2);
                    // dbcontext.SaveChanges();

                    string usuario = Cryptografar(login_digitado);
                    string senha = Cryptografar(senha_digitado);

                    var connection = dbcontext.Database.GetDbConnection();

                    //Executa uma instrução SQL
                    using (var command = connection.CreateCommand())
                    {
                        connection.Open();
                        command.CommandText = "call New_Cliente(@nome, @sobrenome, @datanascimento, @usuario, @senha)";

                        MySqlParameter param = new MySqlParameter("@nome", MySqlDbType.VarChar);
                        param.Value = nome1;
                        command.Parameters.Add(param);

                        MySqlParameter param2 = new MySqlParameter("@sobrenome", MySqlDbType.VarChar);
                        param2.Value = SobreNomeCliente;
                        command.Parameters.Add(param2);

                        MySqlParameter param3 = new MySqlParameter("@datanascimento", MySqlDbType.LongText);
                        param3.Value = DataNascimentoCliente;
                        command.Parameters.Add(param3);

                        MySqlParameter param4 = new MySqlParameter("@usuario", MySqlDbType.LongText);
                        param4.Value = usuario;
                        command.Parameters.Add(param4);

                        MySqlParameter param5 = new MySqlParameter("@senha", MySqlDbType.LongText);
                        param5.Value = senha;
                        command.Parameters.Add(param5);

                        command.ExecuteReader();

                    }

                }

            }
            catch
            {
                System.Console.WriteLine("FIM !!!");

            }


                /*
                // TRY consulta Quantidade produto
                try
                {
                    //using (var dbcontext = new SistemaContext(optionsBuilder.Options))
                    //{



                        comando = command
                        conn == objeto_conection
                    MySqlConnection objeto_connection = new MySqlConnection("server=localhost;userid=root;password=admin123;database=SistemaDB");
                    //Executa uma instrução SQL
                   // MySqlConnection command = objeto_connection;
                       // {

                            objeto_connection.Open();
                          MySqlCommand command = new MySqlCommand("select * from produtos where Produto_Id = @Id_Produto", objeto_connection);

                            MySqlParameter param = new MySqlParameter("@Id_Produto", MySqlDbType.Int32);
                            param.Value = Id_Produto;
                            command.Parameters.Add(param);

                            //executa o comando
                            command.CommandType = System.Data.CommandType.Text;

                            //recebe resultado do SELECT
                            MySqlDataReader Registro_Query;
                       reader   ==  Registro_Query = command.ExecuteReader();//  "MySql.Data.MySqlClient.MySqlDataReader"

                            Registro_Query.Read();
                            // 0 => Produto_Id
                            // 1 => Produto_Nome
                            // 2 => Produto_Valor
                            // 3 => Qtde_Produto

                            Resultado_Qtde = Registro_Query.GetString(3);







                        //}
                    //}
                    System.Console.WriteLine($"Resultado é: {Resultado_Qtde}");




                }


                catch(Exception erro)
                {
                    System.Console.WriteLine("Erro de registro" + erro);


                }

                int d = int.Parse(Resultado_Qtde);
                if (d < 51)
                {
                    System.Console.WriteLine("Quantidade Indisponível em Estoque");
                }
                else
                {
                    System.Console.WriteLine("Produto Disponível para venda");
                }
                */
                /*
                // TRY Procedure Reposição de Estoque
                try
                {
                    using (var dbcontext = new SistemaContext(optionsBuilder.Options))
                    {




                        var connection = dbcontext.Database.GetDbConnection();

                        //Executa uma instrução SQL
                        using (var command = connection.CreateCommand())
                        {
                            connection.Open();
                            command.CommandText = "call Reposicao_Estoque(@Cliente_Id, @Qtde_produto)";

                            MySqlParameter param = new MySqlParameter("@Cliente_Id", MySqlDbType.Int32);
                            param.Value = Cliente_Id;
                            command.Parameters.Add(param);

                            MySqlParameter param2 = new MySqlParameter("@Qtde_produto", MySqlDbType.Int32);
                            param2.Value = Qtde_produto;
                            command.Parameters.Add(param2);

                            command.ExecuteReader();

                        }

                    }

                }
                catch (Exception erro)
                {
                    System.Console.WriteLine("Erro de registro" + erro);


                }
                */

                /*
                // TRY Cliente_Compra
                try
                {
                    using (var dbcontext = new SistemaContext(optionsBuilder.Options))
                    {
                        //SuB Tray - Valor do produto
                        try
                        {
                            //using (var dbcontext = new SistemaContext(optionsBuilder.Options))
                            //{





                            MySqlConnection objeto_connection = new MySqlConnection("server=localhost;userid=root;password=admin123;database=SistemaDB");
                            //Executa uma instrução SQL
                            // MySqlConnection command = objeto_connection;
                            // {

                            objeto_connection.Open();
                            MySqlCommand command = new MySqlCommand("select * from produtos where Produto_Id = @Id_Produto", objeto_connection);

                            MySqlParameter param = new MySqlParameter("@Id_Produto", MySqlDbType.Int32);
                            param.Value = Id_Produto;
                            command.Parameters.Add(param);

                            //executa o comando
                            command.CommandType = System.Data.CommandType.Text;

                            //recebe resultado do SELECT
                            MySqlDataReader Registro_Query;
                            Registro_Query = command.ExecuteReader();//  "MySql.Data.MySqlClient.MySqlDataReader"

                            Registro_Query.Read();
                            // 0 => Produto_Id
                            // 1 => Produto_Nome
                            // 2 => Produto_Valor
                            // 3 => Qtde_Produto

                            Resultado_Qtde = Registro_Query.GetString(3);
                            produto_nome = Registro_Query.GetString(1);
                            produto_valor = Registro_Query.GetString(2);

                            Valor_Total_Compra = Qtde_produto * decimal.Parse(produto_valor);







                            //}
                            //}
                            System.Console.WriteLine($"Resultado é: {produto_valor}");




                        }


                        catch (Exception erro)
                        {
                            System.Console.WriteLine("Erro de registro" + erro);


                        }


                        var connection = dbcontext.Database.GetDbConnection();

                        //Executa uma instrução SQL
                        using (var command = connection.CreateCommand())
                        {
                            connection.Open();
                            command.CommandText = "call Cliente_Compra(@Cliente_Id, @Qtde_produto, @produto_valor, @Produto_Id, @Valor_Total_Compra)";

                            MySqlParameter param = new MySqlParameter("@Cliente_Id", MySqlDbType.Int32);
                            param.Value = Cliente_Id;
                            command.Parameters.Add(param);

                            MySqlParameter param2 = new MySqlParameter("@Qtde_produto", MySqlDbType.Int32);
                            param2.Value = Qtde_produto;
                            command.Parameters.Add(param2);

                            MySqlParameter param3 = new MySqlParameter("@produto_valor", MySqlDbType.VarChar);
                            param3.Value = produto_valor;
                            command.Parameters.Add(param3);

                            MySqlParameter param4 = new MySqlParameter("@Produto_Id", MySqlDbType.VarChar);
                            param4.Value = Id_Produto;
                            command.Parameters.Add(param4);

                            MySqlParameter param5 = new MySqlParameter("@Valor_Total_Compra", MySqlDbType.VarChar);
                            param5.Value = Valor_Total_Compra;
                            command.Parameters.Add(param5);

                            command.ExecuteReader();

                        }

                    }

                }
                catch (Exception erro)
                {
                    System.Console.WriteLine("Erro de registro" + erro);


                }
                */








            
        }
    }
}
