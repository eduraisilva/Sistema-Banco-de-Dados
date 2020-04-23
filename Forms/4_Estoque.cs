using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Forms
{
    public partial class _4_Estoque : Form
    {
        int mov;
        int movX;
        int movY;
        public _4_Estoque()
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
            dataGridView_produtos.DataSource = table;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edu lindo");
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void _4_Estoque_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;

            tableprodutos();
        }

        private void Repor_Estoque(object sender, EventArgs e)
        {
            string insertQuery = "call Reposicao_Estoque('" + textBoxCodigoProduto.Text + "','" + textBoxQuantidade.Text + "')";

            executeMyQuery(insertQuery);
            tableprodutos();
        }

        private void Barra_Título_Paint(object sender, PaintEventArgs e)
        {

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
