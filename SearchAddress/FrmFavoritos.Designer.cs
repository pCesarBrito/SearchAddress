namespace SearchAddress
{
    partial class FrmFavoritos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridFavorito = new System.Windows.Forms.DataGridView();
            this.txtBuscaFavoritos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridFavorito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFavorito
            // 
            this.gridFavorito.AllowDrop = true;
            this.gridFavorito.AllowUserToAddRows = false;
            this.gridFavorito.AllowUserToDeleteRows = false;
            this.gridFavorito.AllowUserToResizeColumns = false;
            this.gridFavorito.AllowUserToResizeRows = false;
            this.gridFavorito.BackgroundColor = System.Drawing.Color.Blue;
            this.gridFavorito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridFavorito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridFavorito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFavorito.ColumnHeadersVisible = false;
            this.gridFavorito.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFavorito.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridFavorito.EnableHeadersVisualStyles = false;
            this.gridFavorito.Location = new System.Drawing.Point(12, 51);
            this.gridFavorito.MultiSelect = false;
            this.gridFavorito.Name = "gridFavorito";
            this.gridFavorito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridFavorito.RowHeadersVisible = false;
            this.gridFavorito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridFavorito.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridFavorito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFavorito.Size = new System.Drawing.Size(297, 305);
            this.gridFavorito.TabIndex = 15;
            this.toolTip1.SetToolTip(this.gridFavorito, "Dois Cliques Para Ver o Endereço.");
            this.gridFavorito.DoubleClick += new System.EventHandler(this.gridFavorito_DoubleClick);
            // 
            // txtBuscaFavoritos
            // 
            this.txtBuscaFavoritos.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscaFavoritos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscaFavoritos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscaFavoritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaFavoritos.Location = new System.Drawing.Point(12, 19);
            this.txtBuscaFavoritos.Multiline = true;
            this.txtBuscaFavoritos.Name = "txtBuscaFavoritos";
            this.txtBuscaFavoritos.Size = new System.Drawing.Size(225, 26);
            this.txtBuscaFavoritos.TabIndex = 0;
            this.txtBuscaFavoritos.TextChanged += new System.EventHandler(this.txtBuscaFavoritos_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Buscar Meus Favoritos";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SearchAddress.Properties.Resources.yellow_trash_empty_icon;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(117, 350);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 77);
            this.btnExcluir.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnExcluir, "Excluir Meu Favorito Selecionado.");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SearchAddress.Properties.Resources.estrela;
            this.pictureBox1.Location = new System.Drawing.Point(243, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // FrmFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(321, 429);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscaFavoritos);
            this.Controls.Add(this.gridFavorito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFavoritos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meus Favoritos";
            this.Load += new System.EventHandler(this.FrmFavoritos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFavorito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridFavorito;
        private System.Windows.Forms.TextBox txtBuscaFavoritos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}