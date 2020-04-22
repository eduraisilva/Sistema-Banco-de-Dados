using Forms.FormData;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Forms
{
    public partial class _3_Cadastrar_Cliente : Form
    {
        // Localizar área
        int mov;
        int movX;
        int movY;
        public _3_Cadastrar_Cliente()
        {
            InitializeComponent();
        }

        MySqlConnection objeto_connection = new MySqlConnection("server=localhost;userid=root;password=admin123;database=SistemaDB");
        MySqlCommand command;

        SqlData obj = new SqlData();


        public void tableclientes()
        {
            string selectQuery = "select * from clientes";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, objeto_connection);
            adapter.Fill(table);
            dataGridView_clientes.DataSource = table;
        }
        
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblDataNascimento_Click(object sender, EventArgs e)
        {

        }

        private void _3_Cadastrar_Cliente_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;

            tableclientes();
        }

        private void DataGridView_clientes_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }

        public void openConnection()
        {
            if(objeto_connection.State == ConnectionState.Closed)
            {
                objeto_connection.Open();
            }
        }

        public void closeConnection()
        {
            if(objeto_connection.State == ConnectionState.Open)
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


                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                    MessageBox.Show("Query Not Executed");
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {


            obj.Nome = TextBoxNome.Text;
            obj.SobreNome = TextBoxSobreNome.Text;
            obj.DataNascimento = TextBoxDataNascimento.Text;
            obj.Sexo = (rbMasculino.Checked) ? "Masculino" : "Feminino";
            obj.Email = TextBoxEmail.Text;

            string insertQuery = "call New_Cliente('" + obj.Nome + "', '" + obj.SobreNome + "', '" + obj.DataNascimento + "', '" + obj.Sexo + "', '" + obj.Email + "')";

            executeMyQuery(insertQuery);
            tableclientes();
            }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {

            objeto_connection.Open();

            string Cli_Id = dataGridView_clientes.CurrentRow.Cells[0].Value.ToString();
            obj.Sexo = (rbMasculino.Checked) ? "Masculino" : "Feminino";

            MySqlCommand command = new MySqlCommand( "update clientes set Nome = ?, SobreNome= ?, DataNascimento= ?, Sexo= ?, Email= ? where Cliente_Id =" + int.Parse(Cli_Id), objeto_connection);

            command.Parameters.Add("@Nome", MySqlDbType.VarChar, 200).Value = TextBoxNome.Text;
            command.Parameters.Add("@SobreNome", MySqlDbType.VarChar, 200).Value = TextBoxSobreNome.Text;
            command.Parameters.Add("@DataNascimento", MySqlDbType.VarChar, 200).Value = TextBoxDataNascimento.Text;
            command.Parameters.Add("@Sexo", MySqlDbType.VarChar, 200).Value = obj.Sexo;
            command.Parameters.Add("@Email", MySqlDbType.VarChar, 200).Value = TextBoxEmail.Text;
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            objeto_connection.Close();



            MessageBox.Show("Query Executed");



            tableclientes();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string Cli_Id = dataGridView_clientes.CurrentRow.Cells[0].Value.ToString();
            string deleteQuery = "delete from clientes where Cliente_Id = " + int.Parse(Cli_Id);

            executeMyQuery(deleteQuery);
            tableclientes();
        }

        private void DataGridView_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_clientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Cli_Id = dataGridView_clientes.CurrentRow.Cells[0].Value.ToString();
            TextBoxNome.Text = dataGridView_clientes.CurrentRow.Cells[1].Value.ToString();
            TextBoxSobreNome.Text = dataGridView_clientes.CurrentRow.Cells[2].Value.ToString();
            TextBoxDataNascimento.Text = dataGridView_clientes.CurrentRow.Cells[3].Value.ToString();
            string SEXO = dataGridView_clientes.CurrentRow.Cells[4].Value.ToString();
            TextBoxEmail.Text = dataGridView_clientes.CurrentRow.Cells[5].Value.ToString();

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

        private void Button4_Click(object sender, EventArgs e)
        {
            TextBoxNome.Text = String.Empty;
            TextBoxSobreNome.Text = String.Empty;
            TextBoxDataNascimento.Text = String.Empty;
            TextBoxDataNascimento.Text = String.Empty;
            TextBoxEmail.Text = String.Empty;
            
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

   
