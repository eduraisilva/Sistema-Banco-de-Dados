namespace Forms
{
    partial class _6_Cadastrar_Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_6_Cadastrar_Usuario));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.dataGridView_usuarios = new System.Windows.Forms.DataGridView();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblSobreNome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.TextBoxLoginUsuario = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxSenhaUsuario = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxEmailUsuario = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxNomeUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Barra_Título = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonCadastrarCliente = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonVendas = new System.Windows.Forms.Button();
            this.buttonEstoque = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usuarios)).BeginInit();
            this.Barra_Título.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(300, 490);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(63, 25);
            this.buttonDelete.TabIndex = 41;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(987, 277);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(63, 25);
            this.buttonInsert.TabIndex = 40;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // dataGridView_usuarios
            // 
            this.dataGridView_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_usuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.dataGridView_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_usuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_usuarios.ColumnHeadersHeight = 26;
            this.dataGridView_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_usuarios.EnableHeadersVisualStyles = false;
            this.dataGridView_usuarios.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView_usuarios.Location = new System.Drawing.Point(173, 48);
            this.dataGridView_usuarios.Name = "dataGridView_usuarios";
            this.dataGridView_usuarios.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridView_usuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_usuarios.Size = new System.Drawing.Size(624, 436);
            this.dataGridView_usuarios.TabIndex = 39;
            this.dataGridView_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_usuarios_CellClick);
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFeminino.ForeColor = System.Drawing.Color.White;
            this.rbFeminino.Location = new System.Drawing.Point(925, 228);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(77, 21);
            this.rbFeminino.TabIndex = 38;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.ForeColor = System.Drawing.Color.White;
            this.rbMasculino.Location = new System.Drawing.Point(838, 228);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(83, 21);
            this.rbMasculino.TabIndex = 37;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(836, 211);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 17);
            this.lblSexo.TabIndex = 36;
            this.lblSexo.Text = "Sexo";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(885, 118);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 17);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Email:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.Color.White;
            this.lblDataNascimento.Location = new System.Drawing.Point(883, 167);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(46, 17);
            this.lblDataNascimento.TabIndex = 34;
            this.lblDataNascimento.Text = "Senha:";
            // 
            // lblSobreNome
            // 
            this.lblSobreNome.AutoSize = true;
            this.lblSobreNome.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobreNome.ForeColor = System.Drawing.Color.White;
            this.lblSobreNome.Location = new System.Drawing.Point(887, 144);
            this.lblSobreNome.Name = "lblSobreNome";
            this.lblSobreNome.Size = new System.Drawing.Size(42, 17);
            this.lblSobreNome.TabIndex = 33;
            this.lblSobreNome.Text = "Login:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(826, 93);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(103, 17);
            this.lblNome.TabIndex = 32;
            this.lblNome.Text = "Nome Completo:";
            // 
            // TextBoxLoginUsuario
            // 
            this.TextBoxLoginUsuario.Location = new System.Drawing.Point(931, 141);
            this.TextBoxLoginUsuario.Name = "TextBoxLoginUsuario";
            this.TextBoxLoginUsuario.Size = new System.Drawing.Size(261, 20);
            this.TextBoxLoginUsuario.TabIndex = 30;
            // 
            // TextBoxSenhaUsuario
            // 
            this.TextBoxSenhaUsuario.Location = new System.Drawing.Point(931, 166);
            this.TextBoxSenhaUsuario.Name = "TextBoxSenhaUsuario";
            this.TextBoxSenhaUsuario.PasswordChar = '*';
            this.TextBoxSenhaUsuario.Size = new System.Drawing.Size(261, 20);
            this.TextBoxSenhaUsuario.TabIndex = 29;
            // 
            // TextBoxEmailUsuario
            // 
            this.TextBoxEmailUsuario.Location = new System.Drawing.Point(931, 116);
            this.TextBoxEmailUsuario.Name = "TextBoxEmailUsuario";
            this.TextBoxEmailUsuario.Size = new System.Drawing.Size(261, 20);
            this.TextBoxEmailUsuario.TabIndex = 28;
            // 
            // TextBoxNomeUsuario
            // 
            this.TextBoxNomeUsuario.Location = new System.Drawing.Point(931, 91);
            this.TextBoxNomeUsuario.Name = "TextBoxNomeUsuario";
            this.TextBoxNomeUsuario.Size = new System.Drawing.Size(261, 20);
            this.TextBoxNomeUsuario.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(933, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Cadastro Usuario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Location = new System.Drawing.Point(818, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 603);
            this.panel2.TabIndex = 44;
            // 
            // Barra_Título
            // 
            this.Barra_Título.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Barra_Título.Controls.Add(this.label1);
            this.Barra_Título.Controls.Add(this.button1);
            this.Barra_Título.Controls.Add(this.button5);
            this.Barra_Título.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_Título.Location = new System.Drawing.Point(0, 0);
            this.Barra_Título.Name = "Barra_Título";
            this.Barra_Título.Size = new System.Drawing.Size(1201, 26);
            this.Barra_Título.TabIndex = 45;
            this.Barra_Título.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_Título_MouseDown);
            this.Barra_Título.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Barra_Título_MouseMove);
            this.Barra_Título.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Barra_Título_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuarios";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1178, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 21);
            this.button1.TabIndex = 47;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1147, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 21);
            this.button5.TabIndex = 46;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.buttonCadastrarCliente);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.buttonVendas);
            this.panel1.Controls.Add(this.buttonEstoque);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 591);
            this.panel1.TabIndex = 46;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Location = new System.Drawing.Point(11, 385);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 47);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox7.Location = new System.Drawing.Point(11, 150);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 47);
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox8.Location = new System.Drawing.Point(11, 339);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 47);
            this.pictureBox8.TabIndex = 24;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox9.Location = new System.Drawing.Point(11, 247);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 47);
            this.pictureBox9.TabIndex = 25;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(11, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 47);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Location = new System.Drawing.Point(11, 198);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 49);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // buttonCadastrarCliente
            // 
            this.buttonCadastrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonCadastrarCliente.FlatAppearance.BorderSize = 0;
            this.buttonCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrarCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.buttonCadastrarCliente.Location = new System.Drawing.Point(0, 204);
            this.buttonCadastrarCliente.Name = "buttonCadastrarCliente";
            this.buttonCadastrarCliente.Size = new System.Drawing.Size(148, 39);
            this.buttonCadastrarCliente.TabIndex = 6;
            this.buttonCadastrarCliente.Text = "Clientes";
            this.buttonCadastrarCliente.UseVisualStyleBackColor = false;
            this.buttonCadastrarCliente.Click += new System.EventHandler(this.ButtonCadastrarCliente_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Location = new System.Drawing.Point(5, 156);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(148, 39);
            this.buttonDashboard.TabIndex = 2;
            this.buttonDashboard.Text = "Dashbord";
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.ButtonDashboard_Click);
            // 
            // buttonVendas
            // 
            this.buttonVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonVendas.FlatAppearance.BorderSize = 0;
            this.buttonVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVendas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVendas.ForeColor = System.Drawing.Color.White;
            this.buttonVendas.Location = new System.Drawing.Point(-1, 297);
            this.buttonVendas.Name = "buttonVendas";
            this.buttonVendas.Size = new System.Drawing.Size(148, 39);
            this.buttonVendas.TabIndex = 4;
            this.buttonVendas.Text = "Vendas";
            this.buttonVendas.UseVisualStyleBackColor = false;
            this.buttonVendas.Click += new System.EventHandler(this.ButtonVendas_Click);
            // 
            // buttonEstoque
            // 
            this.buttonEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonEstoque.FlatAppearance.BorderSize = 0;
            this.buttonEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEstoque.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEstoque.ForeColor = System.Drawing.Color.White;
            this.buttonEstoque.Location = new System.Drawing.Point(1, 252);
            this.buttonEstoque.Name = "buttonEstoque";
            this.buttonEstoque.Size = new System.Drawing.Size(148, 39);
            this.buttonEstoque.TabIndex = 5;
            this.buttonEstoque.Text = "Estoque";
            this.buttonEstoque.UseVisualStyleBackColor = false;
            this.buttonEstoque.Click += new System.EventHandler(this.ButtonEstoque_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(6, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "Usuarios";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(5, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 39);
            this.button3.TabIndex = 9;
            this.button3.Text = "Produtos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // _6_Cadastrar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1201, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Barra_Título);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridView_usuarios);
            this.Controls.Add(this.rbFeminino);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblSobreNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.TextBoxLoginUsuario);
            this.Controls.Add(this.TextBoxSenhaUsuario);
            this.Controls.Add(this.TextBoxEmailUsuario);
            this.Controls.Add(this.TextBoxNomeUsuario);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_6_Cadastrar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_6_Cadastrar_Usuario";
            this.TopMost = true;
            this.Load += new System.EventHandler(this._6_Cadastrar_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usuarios)).EndInit();
            this.Barra_Título.ResumeLayout(false);
            this.Barra_Título.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView dataGridView_usuarios;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblSobreNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox TextBoxLoginUsuario;
        private System.Windows.Forms.MaskedTextBox TextBoxSenhaUsuario;
        private System.Windows.Forms.MaskedTextBox TextBoxEmailUsuario;
        private System.Windows.Forms.TextBox TextBoxNomeUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Barra_Título;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonCadastrarCliente;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonVendas;
        private System.Windows.Forms.Button buttonEstoque;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}