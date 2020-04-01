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
    public partial class FrmManutencao : Form
    {
        public FrmManutencao()
        {
            InitializeComponent();
        }
       

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            gridManutencao.DataSource = Mps_4512sp.CarregaDadosManutencao(txtBusca.Text);
            //gridManutencao.Columns[3].Width = 0;
            //gridManutencao.Columns[4].Width = 0;
            //gridManutencao.Columns[2].Width = 0;
            gridManutencao.Columns[0].Width = 200;
            gridManutencao.Columns[1].Width = 160;
            if(gridManutencao.RowCount==0)
            {
                txtRua.Text = String.Empty;
                txtNumero.Text = String.Empty;
                txtBairro.Text = String.Empty;
                txtCidade.Text = String.Empty;
                txtUf.Text = String.Empty;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }

        }

        private void gridManutencao_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtRua.Text = gridManutencao.CurrentRow.Cells[0].Value.ToString();
                txtNumero.Text = gridManutencao.CurrentRow.Cells[2].Value.ToString();
                txtBairro.Text = gridManutencao.CurrentRow.Cells[3].Value.ToString();
                txtCidade.Text = gridManutencao.CurrentRow.Cells[4].Value.ToString();
                txtUf.Text = gridManutencao.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void FrmManutencao_Load(object sender, EventArgs e)
        {
            txtBusca.Focus();
           
            gridManutencao.DataSource = Mps_4512sp.CarregaDadosManutencao("115");
            gridManutencao.Columns[0].Width = 200;
            gridManutencao.Columns[1].Width = 160;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string registro = gridManutencao.CurrentRow.Cells[6]
                                   .Value.ToString();
            Mps_4512sp.AtualizaEnder(txtRua.Text, txtNumero.Text,
                                    txtBairro.Text, txtCidade.Text,
                                    txtUf.Text,registro );
            MessageBox.Show("Registro Foi Atualizado Com Sucesso!", "Atualizar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridManutencao.DataSource = Mps_4512sp.CarregaDadosManutencao("115");
            txtBusca.Text = "";
            txtBusca.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Este Registro Será Apagado Permanetemente\n  Da Base de Dados! \n Tem certeza?","Excluir Registro",
                               MessageBoxButtons.OKCancel,MessageBoxIcon.Warning )== DialogResult.OK)
            {
                Mps_4512sp.DeletaEnder(gridManutencao.CurrentRow.Cells[6].Value.ToString());
                MessageBox.Show("Registro Excluido Com Sucesso!","Deletar Registro",MessageBoxButtons.OK,MessageBoxIcon.Information);
                gridManutencao.DataSource = Mps_4512sp.CarregaDadosManutencao("115");
                txtBusca.Text = "";
                txtBusca.Focus();
            }
           
        }

        private void FrmManutencao_Paint(object sender, PaintEventArgs e)
        {
            txtBusca.Focus();
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            FrmCadFavoritos fr = new FrmCadFavoritos();
            fr.MeusFavoritos += new FrmCadFavoritos.Favoritos(MFavoritos);
            fr.ShowDialog();

            
            
        }
        public void MFavoritos(string info)
        {

            
            if(MessageBox.Show(" Este Endereço Será Salvo nos Favorito!","Favoritos",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                {
                Mps_4512sp.AddFavoritos(Convert.ToInt32(gridManutencao.CurrentRow.Cells[6].Value.ToString()), info);
                MessageBox.Show("O Endereço Foi Salvo nos Favorito Com Sucesso!", "Favoritos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                return;
            }
        }
    }
}
