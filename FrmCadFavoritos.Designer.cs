﻿namespace SearchAddress
{
    partial class FrmCadFavoritos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFaforito = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFavorito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnFaforito);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFavorito);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 104);
            this.panel1.TabIndex = 15;
            // 
            // btnFaforito
            // 
            this.btnFaforito.BackColor = System.Drawing.Color.Yellow;
            this.btnFaforito.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFaforito.FlatAppearance.BorderSize = 0;
            this.btnFaforito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFaforito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnFaforito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaforito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaforito.Location = new System.Drawing.Point(155, 69);
            this.btnFaforito.Name = "btnFaforito";
            this.btnFaforito.Size = new System.Drawing.Size(87, 28);
            this.btnFaforito.TabIndex = 1;
            this.btnFaforito.Text = "Adicionar";
            this.btnFaforito.UseVisualStyleBackColor = false;
            this.btnFaforito.Click += new System.EventHandler(this.btnFaforito_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SearchAddress.Properties.Resources.estrela;
            this.pictureBox1.Location = new System.Drawing.Point(190, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "exemplo: Gerdal-meu trabalho.";
            // 
            // txtFavorito
            // 
            this.txtFavorito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFavorito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFavorito.Location = new System.Drawing.Point(7, 37);
            this.txtFavorito.MaxLength = 100;
            this.txtFavorito.Multiline = true;
            this.txtFavorito.Name = "txtFavorito";
            this.txtFavorito.Size = new System.Drawing.Size(228, 26);
            this.txtFavorito.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adicionar Meus do Favorito";
            // 
            // FrmCadFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(266, 120);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCadFavoritos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar aos Meus Favoritos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFavorito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFaforito;
    }
}