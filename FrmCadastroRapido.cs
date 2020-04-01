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
    public partial class FrmCadastroRapido : Form
    {
        public FrmCadastroRapido()
        {
            InitializeComponent();
        }

        public delegate void PassarDadoas(Hashtable tabela);
        public event PassarDadoas TransferirDados;

        private void TranferidadosCep()
        {
            Hashtable trasnferir = new Hashtable();
            trasnferir.Add("cep", textBox1.Text.ToString());
            TransferirDados(trasnferir);
            this.textBox1.Text = "";
            this.textBox1.Focus();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length >= 8)
            {
                try
                {
                    TranferidadosCep();
                }
                catch (Exception)
                {

                    throw;
                }

            }

        }
    }
}
