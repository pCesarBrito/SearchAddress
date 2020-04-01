using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SearchAddress
{
    public partial class FrmCadFavoritos : Form
    {
        public FrmCadFavoritos()
        {
            InitializeComponent();
        }
        public delegate void Favoritos(string info);
        public event Favoritos MeusFavoritos;

        private void Enviar()
        {
            //Hashtable info = new Hashtable();
            //info.Add("nome", txtFavorito.Text);
            string nome = txtFavorito.Text;
             MeusFavoritos(nome); 
        }

        private void btnFaforito_Click(object sender, EventArgs e)
        {
            Enviar();
            this.Close();
        }
    }
}
