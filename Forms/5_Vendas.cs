using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Forms
{
    public partial class _5_Vendas : Form
    {
        int mov;
        int movX;
        int movY;
        public _5_Vendas()
        {
            InitializeComponent();

            Combo_Produto();
        }
        MySqlConnection objeto_connection = new MySqlConnection("server=localhost;userid=root;password=admin123;database=SistemaDB");
        MySqlCommand command;
        
        public void tablepedidos()
        {
            string selectQuery = "select * from pedidos";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, objeto_connection);
            adapter.Fill(table);
            dataGridViewPedidos.DataSource = table;
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



        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _5_Vendas_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;

            tablepedidos();

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void ButtonEfetuarCompra_Click(object sender, EventArgs e)
        {
            
            MySqlConnection objeto_connection = new MySqlConnection("server=localhost;userid=root;password=admin123;database=SistemaDB");
            objeto_connection.Open();

            MySqlCommand command = new MySqlCommand("select * from produtos where Produto_Id = @Id_Produto", objeto_connection);

            MySqlParameter param = new MySqlParameter("@Id_Produto", MySqlDbType.Int32);
            param.Value = int.Parse(textBoxIdProduto.Text);
            command.Parameters.Add(param);

            //executa o comando
            command.CommandType = CommandType.Text;

            tablepedidos();

            //recebe resultado do SELECT
            MySqlDataReader Registro_Query;
            Registro_Query = command.ExecuteReader();

            Registro_Query.Read();
            

           string qtde_estoque = Registro_Query.GetString(3);
           int qtde_estoque2 = int.Parse(qtde_estoque);

            if (int.Parse(textBoxIdQuantidade.Text) <= qtde_estoque2)
            {
                string insertQuery = "call Cliente_Compra('" + textBoxIdCliente.Text + "', '" + textBoxIdQuantidade.Text + "', '" + textBoxValorProduto.Text + "', '" + textBoxIdProduto.Text + "', '" + textBoxValorTotal.Text + "')";

                executeMyQuery(insertQuery);
                tablepedidos();
            }
            else
            {
                MessageBox.Show("Operação não Completada!!! Quantidade total disponível para esse produto: " + qtde_estoque2);
            }
            
        }

        private void TextBoxValorProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
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

        
        private void TextBoxIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void TextBoxIdProduto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBoxIdQuantidade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxValorTotal.Text = (decimal.Parse(textBoxValorProduto.Text) * int.Parse(textBoxIdQuantidade.Text)).ToString();
            }
            catch 
            {
                
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection objeto_connection = new MySqlConnection("server=localhost;userid=root;password=admin123;database=SistemaDB");
            MySqlCommand command = new MySqlCommand("select * from produtos where Produto_Nome='"+ comboBoxProduto.Text + "';", objeto_connection);
            MySqlDataReader Registro_Query;
            
            try
            {
                objeto_connection.Open();
                Registro_Query = command.ExecuteReader();

                while (Registro_Query.Read())
                {
                    string Id = Registro_Query.GetInt32("Produto_Id").ToString();
                    string Valor = Registro_Query.GetDecimal("Produto_Valor").ToString();
                   


                    textBoxIdProduto.Text = Id;
                    textBoxValorProduto.Text = Valor;
                   
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Message: " + erro);
            }
        }
        private void Combo_Produto()
        {
            MySqlConnection objeto_connection = new MySqlConnection("server=localhost;userid=root;password=admin123;database=SistemaDB");
            MySqlCommand command = new MySqlCommand("select * from produtos  ;", objeto_connection);
            MySqlDataReader Registro_Query;


            try
            {
                objeto_connection.Open();
                Registro_Query = command.ExecuteReader();

                while (Registro_Query.Read())
                {
                    
                    string Nome = Registro_Query.GetString("Produto_Nome");


                    comboBoxProduto.Items.Add(Nome);
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Message: " + erro);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            comboBoxProduto.Text = String.Empty;
            textBoxIdCliente.Text = String.Empty;
            textBoxIdProduto.Text = String.Empty;
            textBoxValorProduto.Text = String.Empty;
            textBoxIdQuantidade.Text = String.Empty;
            textBoxValorTotal.Text = String.Empty;

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
