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
    public partial class FrmBusca : Form
    {
        public FrmBusca()
        {
            InitializeComponent();
        }
        public delegate void PassarDadoas(Hashtable tabela);
        public event PassarDadoas TransferirDados;

        private void Tranferidados()
        {
            Hashtable trasnferir = new Hashtable();

            trasnferir.Add("rua", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            trasnferir.Add("cep", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            trasnferir.Add("bairro", dataGridView1.CurrentRow.Cells[2].Value.ToString());
            trasnferir.Add("cidade", dataGridView1.CurrentRow.Cells[3].Value.ToString());
            trasnferir.Add("uf", dataGridView1.CurrentRow.Cells[4].Value.ToString());
            trasnferir.Add("numero", dataGridView1.CurrentRow.Cells[5].Value.ToString());
            TransferirDados(trasnferir);
            this.Close();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Tranferidados();
        }

        private void txtRuaProc_TextChanged(object sender, EventArgs e)
        {
           ///this.enderecoTableAdapter1.ProcRua(this.baseDataSet.endereco,txtRuaProc.Text);
            dataGridView1.DataSource = Mps_4512sp.BuscaRua(txtRuaProc.Text);
            lblRegistros.Text ="Registro: "+dataGridView1.Rows.Count.ToString();
        }

        private void txtCepProc_TextChanged(object sender, EventArgs e)
        {
            // this.enderecoTableAdapter.ProcCep(this.baseDataSet.endereco,txtCepProc.Text);
            dataGridView1.DataSource = Mps_4512sp.BuscaCep(txtCepProc.Text);
            lblRegistros.Text = "Registro: " + dataGridView1.Rows.Count.ToString();
        }

        private void txtBairroProc_TextChanged(object sender, EventArgs e)
        {
            //this.enderecoTableAdapter.ProcBairro(this.baseDataSet.endereco, txtBairroProc.Text);
            dataGridView1.DataSource = Mps_4512sp.BuscaBairro(txtBairroProc.Text);
            lblRegistros.Text = "Registro: " + dataGridView1.Rows.Count.ToString();
        }

        private void txtCidadeProc_TextChanged(object sender, EventArgs e)
        {
            //this.enderecoTableAdapter.ProcCidade(this.baseDataSet.endereco, txtCidadeProc.Text);
            dataGridView1.DataSource = Mps_4512sp.BuscaCidade(txtCidadeProc.Text);
            lblRegistros.Text = "Registro: " + dataGridView1.Rows.Count.ToString();
        }

        private void txtUfProc_TextChanged(object sender, EventArgs e)
        {
            //this.enderecoTableAdapter.ProcUf(this.baseDataSet.endereco, txtUfProc.Text);
            dataGridView1.DataSource = Mps_4512sp.BuscaUf(txtUfProc.Text);
            lblRegistros.Text = "Registro: " + dataGridView1.Rows.Count.ToString();
        }

        private void FrmBusca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDataSet.endereco' table. You can move, or remove it, as needed.
           // this.enderecoTableAdapter1.Fill(this.baseDataSet.endereco);
            dataGridView1.DataSource = Mps_4512sp.CarregaDados();
            ColunasGrid();
            lblRegistros.Text = "Registro: " + dataGridView1.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ColunasGrid()
        {
            dataGridView1.Columns[0].Width = 307;
            dataGridView1.Columns[2].Width = 205;
            dataGridView1.Columns[3].Width = 125;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[4].Width = 35;
        }
    }

}
