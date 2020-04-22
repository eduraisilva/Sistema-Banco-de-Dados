using Forms.FormUsuarios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class _6_Cadastrar_Usuario : Form
    {
        // Localizar área
        int mov;
        int movX;
        int movY;


        public _6_Cadastrar_Usuario()
        {
            InitializeComponent();
        }
        MySqlConnection objeto_connection = new MySqlConnection("server=localhost;userid=root;password=admin123;database=SistemaDB");
        MySqlCommand command;

        UsuarioData obj = new UsuarioData();
        UsuarioData obj2 = new UsuarioData();


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

        public void tableusuarios()
        {
            string selectQuery = "select * from usuarios";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, objeto_connection);
            adapter.Fill(table);
            dataGridView_usuarios.DataSource = table;
        }
        public void openConnection()
        {
            if (objeto_connection.State == ConnectionState.Closed)
            {
                objeto_connection.Open();
            }
        }

        public void closeConnection()
        {
            if (objeto_connection.State == ConnectionState.Open)
            {
                objeto_connection.Close();
            }
        }

        public void executeMyQuery(string query)
        {


            try
            {
                openConnection();
                command = new MySqlCommand(query, objeto_connection);


                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                    MessageBox.Show("Query Not Executed");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void _6_Cadastrar_Usuario_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;

            tableusuarios();
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            obj.Sexo = (rbMasculino.Checked) ? "Masculino" : "Feminino";
            obj.Senha = Cryptografar(TextBoxSenhaUsuario.Text);
            string insertQuery = "call New_Usuario('" + TextBoxNomeUsuario.Text + "','" + obj.Sexo + "','" + TextBoxEmailUsuario.Text + "','" + TextBoxLoginUsuario.Text + "','" + obj.Senha + "')";

            executeMyQuery(insertQuery);
            tableusuarios();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string Id = dataGridView_usuarios.CurrentRow.Cells[0].Value.ToString();
            string deleteQuery = "delete from usuarios where Codigo = " + int.Parse(Id);

            executeMyQuery(deleteQuery);
            tableusuarios();
        }

        private void DataGridView_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string usuario_id = dataGridView_usuarios.CurrentRow.Cells[0].Value.ToString();
            obj2.Nome_Completo = dataGridView_usuarios.CurrentRow.Cells[1].Value.ToString();
            obj2.Email = dataGridView_usuarios.CurrentRow.Cells[3].Value.ToString();
            obj2.Login = dataGridView_usuarios.CurrentRow.Cells[4].Value.ToString();
            obj2.Senha = dataGridView_usuarios.CurrentRow.Cells[5].Value.ToString();
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void ButtonDashboard_Click(object sender, EventArgs e)
        {
            _2_Dashboard form_2 = new _2_Dashboard();
            form_2.Show();
            this.Hide();
        }

        private void ButtonCadastrarCliente_Click(object sender, EventArgs e)
        {
            _3_Cadastrar_Cliente form_3 = new _3_Cadastrar_Cliente();
            form_3.Show();
            this.Hide();
        }

        private void ButtonEstoque_Click(object sender, EventArgs e)
        {
            _4_Estoque form_4 = new _4_Estoque();
            form_4.Show();
            this.Hide();

        }

        private void ButtonVendas_Click(object sender, EventArgs e)
        {
            _5_Vendas form_5 = new _5_Vendas();
            form_5.Show();
            this.Hide();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _6_Cadastrar_Usuario form_6 = new _6_Cadastrar_Usuario();
            form_6.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            _7_Cadastrar_Produtos form_7 = new _7_Cadastrar_Produtos();
            form_7.Show();
            this.Hide();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            


        }

        private void Barra_Título_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Barra_Título_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Barra_Título_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
