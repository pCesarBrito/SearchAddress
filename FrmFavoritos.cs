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
    public partial class FrmFavoritos : Form
    {
        public FrmFavoritos()
        {
            InitializeComponent();
        }
        public delegate void TransferirDados(string info);
        public event TransferirDados TransferirTexto;
        public void Mandar()
        {
            string info = string.Empty;
            info=gridFavorito.CurrentRow.Cells[1].Value.ToString();
            TransferirTexto(info);
        }

        private void FrmFavoritos_Load(object sender, EventArgs e)
        {
            gridFavorito.DataSource = Mps_4512sp.CarregaFavoritos();
            gridFavorito.Columns[0].Width = 350;
        }

        private void gridFavorito_DoubleClick(object sender, EventArgs e)
        {
            Mandar();
            this.Close();

        }

        private void txtBuscaFavoritos_TextChanged(object sender, EventArgs e)
        {
            gridFavorito.DataSource = Mps_4512sp.PesquisaFavoritos(txtBuscaFavoritos.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           
            if(MessageBox.Show(" Voce Tem Certeza que Deseja Excluir Este favorito?","Excluir",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.OK)
            {
                Mps_4512sp.DeleteFavorito(gridFavorito.CurrentRow.Cells[2].Value.ToString());
                MessageBox.Show("O favorito Foi Excluido Com Sucesso!", "Excluido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridFavorito.DataSource = Mps_4512sp.CarregaFavoritos();
                gridFavorito.Columns[0].Width = 350;

            }
            else
            {
                return;
            }
        }
    }
}
