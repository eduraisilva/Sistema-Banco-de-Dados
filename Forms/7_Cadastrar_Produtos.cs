using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Forms
{
    public partial class _7_Cadastrar_Produtos : Form
    {
        // Localizar área
        int mov;
        int movX;
        int movY;

        public _7_Cadastrar_Produtos()
        {
            InitializeComponent();
        }
        MySqlConnection objeto_connection = new MySqlConnection("server=localhost;userid=root;password=admin123;database=SistemaDB");
        MySqlCommand command;

        public void tableprodutos()
        {
            string selectQuery = "select * from produtos";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, objeto_connection);
            adapter.Fill(table);
            dataGridView_cadastro_produto.DataSource = table;
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


        private void LblDataNascimento_Click(object sender, EventArgs e)
        {

        }

        private void _7_Cadastrar_Produtos_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;

            tableprodutos();
        }

        private void ButtonInsertProduto_Click(object sender, EventArgs e)
        {
            string insertQuery = "call New_Produto('" + TextBoxProduto_Nome.Text + "','" + TextBoxProdutoValor.Text + "')";

            
            executeMyQuery(insertQuery);
            tableprodutos();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            

            string Produto_Id = dataGridView_cadastro_produto.CurrentRow.Cells[0].Value.ToString();
            string deleteQuery = "delete from produtos where Produto_Id = " + int.Parse(Produto_Id);

            executeMyQuery(deleteQuery);
            tableprodutos();
        }

        private void DataGridView_cadastro_produto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView_cadastro_produto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TextBoxProduto_Nome.Text = dataGridView_cadastro_produto.CurrentRow.Cells[1].Value.ToString();
            TextBoxProdutoValor.Text = dataGridView_cadastro_produto.CurrentRow.Cells[2].Value.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TextBoxProduto_Nome.Text = String.Empty;
            TextBoxProdutoValor.Text = String.Empty;
        }

        private void Button4_Click(object sender, EventArgs e)
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
            
            try
            {
                string Produto_Id = dataGridView_cadastro_produto.CurrentRow.Cells[0].Value.ToString();
                int Produto_Id2 = Convert.ToInt32(Produto_Id);

                objeto_connection.Open();

                MySqlCommand command = new MySqlCommand("update produtos set Produto_Nome = ?, Produto_Valor = ? where Produto_Id = " + Produto_Id2 + ";", objeto_connection);

                command.Parameters.Add("@Produto_Nome", MySqlDbType.VarChar, 200).Value = TextBoxProduto_Nome.Text;
                command.Parameters.Add("@Produto_Valor", MySqlDbType.VarChar, 200).Value = TextBoxProdutoValor.Text;
                

                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                objeto_connection.Close();
                

                
                MessageBox.Show("Query Executed");

                tableprodutos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Mensagem: " + erro);
            }
        }

        private void TextBoxProdutoValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
             
        }
        
        private void TextBoxProdutoValor_TextChanged(object sender, EventArgs e)
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
