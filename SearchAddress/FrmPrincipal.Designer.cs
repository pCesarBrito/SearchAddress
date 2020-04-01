namespace SearchAddress
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFavoritosVer = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFavoritos = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.btnManutenção = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBusca = new System.Windows.Forms.Button();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.Número = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.enderecoTableAdapter1 = new SearchAddress.BaseDataSetTableAdapters.enderecoTableAdapter();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnFavoritosVer);
            this.panel2.Controls.Add(this.btnFavoritos);
            this.panel2.Controls.Add(this.btnSobre);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnConfiguracao);
            this.panel2.Controls.Add(this.btnManutenção);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtNume);
            this.panel2.Controls.Add(this.Número);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnProcurar);
            this.panel2.Controls.Add(this.txtBairro);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtCidade);
            this.panel2.Controls.Add(this.txtEstado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtRua);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 171);
            this.panel2.TabIndex = 65;
            // 
            // btnFavoritosVer
            // 
            this.btnFavoritosVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFavoritosVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavoritosVer.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnFavoritosVer.FlatAppearance.BorderSize = 0;
            this.btnFavoritosVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnFavoritosVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnFavoritosVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavoritosVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavoritosVer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFavoritosVer.ImageKey = "estrela.png";
            this.btnFavoritosVer.ImageList = this.imageList1;
            this.btnFavoritosVer.Location = new System.Drawing.Point(204, 137);
            this.btnFavoritosVer.Name = "btnFavoritosVer";
            this.btnFavoritosVer.Size = new System.Drawing.Size(218, 28);
            this.btnFavoritosVer.TabIndex = 68;
            this.btnFavoritosVer.Text = " Abrir Meus Favoritos";
            this.btnFavoritosVer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFavoritosVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnFavoritosVer, "Visualizar Meus Favoritos");
            this.btnFavoritosVer.UseVisualStyleBackColor = true;
            this.btnFavoritosVer.Click += new System.EventHandler(this.btnFavoritosVer_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "estrela.png");
            // 
            // btnFavoritos
            // 
            this.btnFavoritos.BackColor = System.Drawing.Color.Yellow;
            this.btnFavoritos.BackgroundImage = global::SearchAddress.Properties.Resources.estrela;
            this.btnFavoritos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFavoritos.FlatAppearance.BorderSize = 0;
            this.btnFavoritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavoritos.Location = new System.Drawing.Point(379, 0);
            this.btnFavoritos.Name = "btnFavoritos";
            this.btnFavoritos.Size = new System.Drawing.Size(27, 35);
            this.btnFavoritos.TabIndex = 67;
            this.toolTip1.SetToolTip(this.btnFavoritos, "Adicionar aos Favoritos");
            this.btnFavoritos.UseVisualStyleBackColor = false;
            this.btnFavoritos.Click += new System.EventHandler(this.btnFavoritos_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSobre.BackgroundImage = global::SearchAddress.Properties.Resources.globe_6x;
            this.btnSobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Location = new System.Drawing.Point(350, 0);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(27, 34);
            this.btnSobre.TabIndex = 66;
            this.toolTip1.SetToolTip(this.btnSobre, "Sobre");
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.BackgroundImage = global::SearchAddress.Properties.Resources.question_mark_6x;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(407, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 34);
            this.button3.TabIndex = 65;
            this.toolTip1.SetToolTip(this.button3, "Manual de Ajuda do Programa");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfiguracao.BackgroundImage = global::SearchAddress.Properties.Resources.cog_6x;
            this.btnConfiguracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfiguracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracao.FlatAppearance.BorderSize = 0;
            this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracao.Location = new System.Drawing.Point(322, 0);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(27, 34);
            this.btnConfiguracao.TabIndex = 64;
            this.toolTip1.SetToolTip(this.btnConfiguracao, "Configurações do Programa");
            this.btnConfiguracao.UseVisualStyleBackColor = false;
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // btnManutenção
            // 
            this.btnManutenção.BackColor = System.Drawing.Color.Aqua;
            this.btnManutenção.BackgroundImage = global::SearchAddress.Properties.Resources.wrench_6x;
            this.btnManutenção.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManutenção.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManutenção.FlatAppearance.BorderSize = 0;
            this.btnManutenção.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManutenção.Location = new System.Drawing.Point(294, 0);
            this.btnManutenção.Name = "btnManutenção";
            this.btnManutenção.Size = new System.Drawing.Size(27, 34);
            this.btnManutenção.TabIndex = 63;
            this.toolTip1.SetToolTip(this.btnManutenção, "Manutenção de Dados");
            this.btnManutenção.UseVisualStyleBackColor = false;
            this.btnManutenção.Click += new System.EventHandler(this.btnManutenção_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(844, -2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(17, 19);
            this.button5.TabIndex = 62;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.BackgroundImage = global::SearchAddress.Properties.Resources.action_redo_6x;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(266, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 34);
            this.button4.TabIndex = 61;
            this.toolTip1.SetToolTip(this.button4, "Cadastro Rápido de Endereços");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnBusca);
            this.panel1.Controls.Add(this.lblCep);
            this.panel1.Controls.Add(this.txtCep);
            this.panel1.Location = new System.Drawing.Point(64, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 34);
            this.panel1.TabIndex = 60;
            // 
            // btnBusca
            // 
            this.btnBusca.BackgroundImage = global::SearchAddress.Properties.Resources.magnifying_glass_6x;
            this.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Location = new System.Drawing.Point(119, 7);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(23, 23);
            this.btnBusca.TabIndex = 1;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.BackColor = System.Drawing.Color.White;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCep.Location = new System.Drawing.Point(0, 17);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(34, 15);
            this.lblCep.TabIndex = 100;
            this.lblCep.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Location = new System.Drawing.Point(36, 7);
            this.txtCep.MaxLength = 8;
            this.txtCep.Multiline = true;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(76, 25);
            this.txtCep.TabIndex = 0;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            this.txtCep.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCep_MouseDown);
            this.txtCep.MouseEnter += new System.EventHandler(this.txtCep_MouseEnter);
            // 
            // txtNume
            // 
            this.txtNume.BackColor = System.Drawing.Color.White;
            this.txtNume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.ForeColor = System.Drawing.Color.Navy;
            this.txtNume.Location = new System.Drawing.Point(65, 61);
            this.txtNume.Multiline = true;
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(111, 25);
            this.txtNume.TabIndex = 101;
            // 
            // Número
            // 
            this.Número.AutoSize = true;
            this.Número.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Número.ForeColor = System.Drawing.Color.Yellow;
            this.Número.Location = new System.Drawing.Point(0, 71);
            this.Número.Name = "Número";
            this.Número.Size = new System.Drawing.Size(58, 15);
            this.Número.TabIndex = 12;
            this.Número.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(5, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cidade";
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.Blue;
            this.btnProcurar.FlatAppearance.BorderSize = 0;
            this.btnProcurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Location = new System.Drawing.Point(126, 139);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 26);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Buscar Manual";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Navy;
            this.txtBairro.Location = new System.Drawing.Point(65, 88);
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(370, 25);
            this.txtBairro.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rua:";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.Navy;
            this.txtCidade.Location = new System.Drawing.Point(65, 115);
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(370, 22);
            this.txtCidade.TabIndex = 103;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.Navy;
            this.txtEstado.Location = new System.Drawing.Point(65, 139);
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(61, 24);
            this.txtEstado.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(8, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bairro";
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.Color.White;
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.ForeColor = System.Drawing.Color.Navy;
            this.txtRua.Location = new System.Drawing.Point(64, 36);
            this.txtRua.Multiline = true;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(370, 24);
            this.txtRua.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(8, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Estado";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(864, 347);
            this.webBrowser1.TabIndex = 64;
            // 
            // timer1
            // 
            this.timer1.Interval = 7000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SearchAddress.Properties.Resources.align_center_2x;
            this.button1.Location = new System.Drawing.Point(-1, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 45);
            this.button1.TabIndex = 67;
            this.toolTip1.SetToolTip(this.button1, "Tela inteira.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enderecoTableAdapter1
            // 
            this.enderecoTableAdapter1.ClearBeforeFill = true;
            // 
            // notify
            // 
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Visible = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.webBrowser1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(868, 351);
            this.panel3.TabIndex = 69;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::SearchAddress.Properties.Resources.align_center_2x;
            this.button2.Location = new System.Drawing.Point(-1, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 45);
            this.button2.TabIndex = 68;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(316, 545);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Address";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPrincipal_Paint);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label Número;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private BaseDataSetTableAdapters.enderecoTableAdapter enderecoTableAdapter1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnConfiguracao;
        private System.Windows.Forms.Button btnManutenção;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFavoritos;
        private System.Windows.Forms.Button btnFavoritosVer;
        private System.Windows.Forms.ImageList imageList1;
    }
}

