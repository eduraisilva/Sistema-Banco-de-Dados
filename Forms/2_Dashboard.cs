using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class _2_Dashboard : Form
    {
        // Localizar área
        int mov;
        int movX;
        int movY;

        MySqlConnection objeto_connection = new MySqlConnection("server=localhost;userid=root;password=admin123;database=SistemaDB");
        MySqlCommand command;
        MySqlDataReader dr;


        public _2_Dashboard()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            _5_Vendas form = new _5_Vendas();
            form.Show();
            this.Hide();
        }

        private void ButtonDashboard_Click(object sender, EventArgs e)
        {
            _2_Dashboard form = new _2_Dashboard();
            form.Show();
            this.Hide();

        }

        private void _2___Dashboard_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;

            Graf_ProdutoEstoque();
            Graf_ProdutosVendidos();

            

            dash_faturamento_bruto_A();
            dash_qtde_vendas_B();
            dash_qtde_cliente_C();
            dash_qtde_clientes_compras_D();
            dash_qtde_usuarios_E();
            dash_qtde_produtos_F();

        }

        private void ButtonCadastrarCliente_Click(object sender, EventArgs e)
        {
            _3_Cadastrar_Cliente form = new _3_Cadastrar_Cliente();
            form.Show();
            this.Hide();
        }

        private void ButtonEstoque_Click(object sender, EventArgs e)
        {
            _4_Estoque form = new _4_Estoque();
            form.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _7_Cadastrar_Produtos form = new _7_Cadastrar_Produtos();
            form.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _6_Cadastrar_Usuario form_6 = new _6_Cadastrar_Usuario();
            form_6.Show();
            this.Hide();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            
        }

        private void Chart1_Produto_Estoque_Click(object sender, EventArgs e)
        {

        }

        ArrayList Produto = new ArrayList();
        ArrayList Qtde_Produto = new ArrayList();
        private void Graf_ProdutoEstoque()
        {
            command = new MySqlCommand("Chart_ProdutoEstoque", objeto_connection);
            command.CommandType = CommandType.StoredProcedure;
            objeto_connection.Open();
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                Produto.Add(dr.GetString(0));
                Qtde_Produto.Add(dr.GetInt32(1));
            }
            chart_Produto_Estoque.Series[0].Points.DataBindXY(Produto, Qtde_Produto);
            dr.Close();
            objeto_connection.Close();
        }

        ArrayList Produtos_Vendidos = new ArrayList();
        ArrayList Qtde_Vendidas = new ArrayList();
       
        private void Graf_ProdutosVendidos()
        {
            command = new MySqlCommand("Chart_Produtos_Vendidos", objeto_connection);
            command.CommandType = CommandType.StoredProcedure;
            objeto_connection.Open();
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                Produtos_Vendidos.Add(dr.GetString(0));
                Qtde_Vendidas.Add(dr.GetInt32(1));
            }
            chart_QtdeProdutosVendidos.Series[0].Points.DataBindXY(Produtos_Vendidos, Qtde_Vendidas);
            dr.Close();
            objeto_connection.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox17_Click(object sender, EventArgs e)
        {

        }

        
        private void dash_faturamento_bruto_A()
        {
            objeto_connection.Open();
            MySqlCommand command = new MySqlCommand("select sum(Valor_Total_Compra) from pedidos", objeto_connection);

            command.CommandType = CommandType.Text;

            MySqlDataReader Registro_Query;
            Registro_Query = command.ExecuteReader();
            Registro_Query.Read();


            lbl_faturamento_bruto.Text = Registro_Query.GetString(0);

            double valor = Double.Parse(lbl_faturamento_bruto.Text);
            lbl_faturamento_bruto.Text = valor.ToString("C");
                           
            objeto_connection.Close();
            
        }
        private void dash_qtde_vendas_B()
        {
            objeto_connection.Open();
            MySqlCommand command = new MySqlCommand("select count(Pedido_Id) from pedidos", objeto_connection);

            command.CommandType = CommandType.Text;

            MySqlDataReader Registro_Query;
            Registro_Query = command.ExecuteReader();
            Registro_Query.Read();

            lbl_qtde_vendas.Text = Registro_Query.GetString(0);

            objeto_connection.Close();
        }
        private void dash_qtde_cliente_C()
        {
            objeto_connection.Open();
            MySqlCommand command = new MySqlCommand("select count(Cliente_Id) from clientes", objeto_connection);

            command.CommandType = CommandType.Text;

            MySqlDataReader Registro_Query;
            Registro_Query = command.ExecuteReader();
            Registro_Query.Read();

            lbl_qtde_clientes.Text = Registro_Query.GetString(0);

            objeto_connection.Close();
        }
        private void dash_qtde_clientes_compras_D()
        {
            objeto_connection.Open();
            MySqlCommand command = new MySqlCommand("select count(*) from clientes inner join pedidos on clientes.Cliente_Id = pedidos.Cliente_Id", objeto_connection);

            command.CommandType = CommandType.Text;

            MySqlDataReader Registro_Query;
            Registro_Query = command.ExecuteReader();
            Registro_Query.Read();

            lbl_qtde_clientes_compras.Text = Registro_Query.GetString(0);

            objeto_connection.Close();
        }
        private void dash_qtde_usuarios_E()
        {
            objeto_connection.Open();
            MySqlCommand command = new MySqlCommand("select count(Codigo) from usuarios", objeto_connection);

            command.CommandType = CommandType.Text;

            MySqlDataReader Registro_Query;
            Registro_Query = command.ExecuteReader();
            Registro_Query.Read();

            lbl_usuarios.Text = Registro_Query.GetString(0);

            objeto_connection.Close();
        }
        private void dash_qtde_produtos_F()
        {
            objeto_connection.Open();
            MySqlCommand command = new MySqlCommand("select count(Produto_Id) from produtos", objeto_connection);

            command.CommandType = CommandType.Text;

            MySqlDataReader Registro_Query;
            Registro_Query = command.ExecuteReader();
            Registro_Query.Read();

            lbl_produtos.Text = Registro_Query.GetString(0);

            objeto_connection.Close();
        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_qtde_clientes_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox23_Click(object sender, EventArgs e)
        {
            //minimizar
           
        }

        private void PictureBox24_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Lbl_faturamento_bruto_Click(object sender, EventArgs e)
        {

        }

        private void Barra_Título_Paint(object sender, PaintEventArgs e)
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
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Barra_Título_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }






        /*
private void ButtonClientes_Click(object sender, EventArgs e)
{
_6_Clientes form_6 = new _6_Clientes();
form_6.Show();
this.Hide();
}
*/
    }
}
