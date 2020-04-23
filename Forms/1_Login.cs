using Forms.FormUsuarios;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class Login : Form
    {
        // Localizar área
        int mov;
        int movX;
        int movY;
        public Login()
        {
            InitializeComponent();
        }
        UsuarioData obj = new UsuarioData();

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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;

            CarregarUsuarios();
        }
        private void CarregarUsuarios()
        {
            var lista = new UsuarioNegocio().ListarUsuarios();

            if(lista.Count > 0)
            {
                foreach (var item in lista)
                {
                    cmbUsuarios.Items.Add(new ComboBoxItemUsuario(item.Login, item.Codigo, item.Senha));
                }
            }
        }

        private void ButtonEntrar_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve selecionar um 'Login' para acessar o sistema!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Cryptografar(textBoxPassword.Text).Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve inserir uma 'Senha' para acessar o sistema!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var item = (ComboBoxItemUsuario)cmbUsuarios.SelectedItem;

            if(item.Senha != Cryptografar(textBoxPassword.Text).Trim())
            {
                MessageBox.Show("A senha informada está incorreta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _2_Dashboard form_2 = new _2_Dashboard();
                form_2.Show();
                this.Hide();
            }
            //bFlagLogin = true;

            
        }

        private void CmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
