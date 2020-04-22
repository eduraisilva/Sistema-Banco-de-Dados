namespace Forms
{
    partial class _5_Vendas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_5_Vendas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxValorTotal = new System.Windows.Forms.TextBox();
            this.buttonEfetuarCompra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIdQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxIdProduto = new System.Windows.Forms.TextBox();
            this.dataGridViewVendas = new System.Windows.Forms.DataGridView();
            this.textBoxValorProduto = new System.Windows.Forms.TextBox();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.Barra_Título = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).BeginInit();
            this.panel2.SuspendLayout();
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
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(1044, 193);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(107, 20);
            this.textBoxIdCliente.TabIndex = 6;
            this.textBoxIdCliente.TextChanged += new System.EventHandler(this.TextBoxIdCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(978, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(988, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Produto:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-15, -15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorTotal.Location = new System.Drawing.Point(1044, 307);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.Size = new System.Drawing.Size(107, 20);
            this.textBoxValorTotal.TabIndex = 11;
            this.textBoxValorTotal.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // buttonEfetuarCompra
            // 
            this.buttonEfetuarCompra.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEfetuarCompra.Image = ((System.Drawing.Image)(resources.GetObject("buttonEfetuarCompra.Image")));
            this.buttonEfetuarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEfetuarCompra.Location = new System.Drawing.Point(152, 342);
            this.buttonEfetuarCompra.Name = "buttonEfetuarCompra";
            this.buttonEfetuarCompra.Size = new System.Drawing.Size(127, 36);
            this.buttonEfetuarCompra.TabIndex = 12;
            this.buttonEfetuarCompra.Text = "Efetuar Compra";
            this.buttonEfetuarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEfetuarCompra.UseVisualStyleBackColor = true;
            this.buttonEfetuarCompra.Click += new System.EventHandler(this.ButtonEfetuarCompra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(973, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(967, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantidade:";
            // 
            // textBoxIdQuantidade
            // 
            this.textBoxIdQuantidade.Location = new System.Drawing.Point(1044, 278);
            this.textBoxIdQuantidade.Name = "textBoxIdQuantidade";
            this.textBoxIdQuantidade.Size = new System.Drawing.Size(107, 20);
            this.textBoxIdQuantidade.TabIndex = 15;
            this.textBoxIdQuantidade.TextChanged += new System.EventHandler(this.TextBoxIdQuantidade_TextChanged);
            // 
            // textBoxIdProduto
            // 
            this.textBoxIdProduto.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdProduto.Location = new System.Drawing.Point(1044, 221);
            this.textBoxIdProduto.Name = "textBoxIdProduto";
            this.textBoxIdProduto.Size = new System.Drawing.Size(107, 20);
            this.textBoxIdProduto.TabIndex = 16;
            this.textBoxIdProduto.TextChanged += new System.EventHandler(this.TextBoxIdProduto_TextChanged);
            // 
            // dataGridViewVendas
            // 
            this.dataGridViewVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewVendas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewVendas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.dataGridViewVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVendas.ColumnHeadersHeight = 26;
            this.dataGridViewVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVendas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVendas.EnableHeadersVisualStyles = false;
            this.dataGridViewVendas.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewVendas.Location = new System.Drawing.Point(195, 53);
            this.dataGridViewVendas.Name = "dataGridViewVendas";
            this.dataGridViewVendas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVendas.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridViewVendas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVendas.Size = new System.Drawing.Size(668, 464);
            this.dataGridViewVendas.TabIndex = 17;
            this.dataGridViewVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // textBoxValorProduto
            // 
            this.textBoxValorProduto.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxValorProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorProduto.Location = new System.Drawing.Point(1044, 250);
            this.textBoxValorProduto.Name = "textBoxValorProduto";
            this.textBoxValorProduto.Size = new System.Drawing.Size(107, 20);
            this.textBoxValorProduto.TabIndex = 19;
            this.textBoxValorProduto.TextChanged += new System.EventHandler(this.TextBoxValorProduto_TextChanged);
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorProduto.ForeColor = System.Drawing.Color.White;
            this.lblValorProduto.Location = new System.Drawing.Point(941, 251);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(104, 17);
            this.lblValorProduto.TabIndex = 18;
            this.lblValorProduto.Text = "Valor do Protuto:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBoxProduto);
            this.panel2.Controls.Add(this.buttonEfetuarCompra);
            this.panel2.Location = new System.Drawing.Point(869, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 603);
            this.panel2.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(152, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 30);
            this.button4.TabIndex = 15;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(57, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Selecionar Produto:";
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(175, 104);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(104, 21);
            this.comboBoxProduto.TabIndex = 13;
            this.comboBoxProduto.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // Barra_Título
            // 
            this.Barra_Título.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Barra_Título.Controls.Add(this.label7);
            this.Barra_Título.Controls.Add(this.button1);
            this.Barra_Título.Controls.Add(this.button5);
            this.Barra_Título.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_Título.Location = new System.Drawing.Point(0, 0);
            this.Barra_Título.Name = "Barra_Título";
            this.Barra_Título.Size = new System.Drawing.Size(1201, 26);
            this.Barra_Título.TabIndex = 26;
            this.Barra_Título.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_Título_MouseDown);
            this.Barra_Título.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Barra_Título_MouseMove);
            this.Barra_Título.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Barra_Título_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vendas";
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
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
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
            this.panel1.TabIndex = 27;
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
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // _5_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1201, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Barra_Título);
            this.Controls.Add(this.textBoxValorProduto);
            this.Controls.Add(this.lblValorProduto);
            this.Controls.Add(this.dataGridViewVendas);
            this.Controls.Add(this.textBoxIdProduto);
            this.Controls.Add(this.textBoxIdQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxValorTotal);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdCliente);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_5_Vendas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_4___Vendas";
            this.TopMost = true;
            this.Load += new System.EventHandler(this._5_Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxValorTotal;
        private System.Windows.Forms.Button buttonEfetuarCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIdQuantidade;
        private System.Windows.Forms.TextBox textBoxIdProduto;
        private System.Windows.Forms.DataGridView dataGridViewVendas;
        private System.Windows.Forms.TextBox textBoxValorProduto;
        private System.Windows.Forms.Label lblValorProduto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Barra_Título;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.Button button4;
    }
}