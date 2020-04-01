using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SearchAddress
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            txtCep.Focus();
        }
        void LimpaCampos()
        {
            txtCidade.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtNume.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCep.Text = string.Empty;
        }
        void AbreMapa()
        {
            string rua = txtRua.Text;
            string num = txtNume.Text;
            string bar = txtBairro.Text;
            string cidade = txtCidade.Text;
            string estado = txtEstado.Text;
            string cep = txtCep.Text;

            try
            {

                StringBuilder str = new StringBuilder();
                str.Append("https://maps.google.com/maps?q=");

                if (rua != "")
                {
                    str.Append(rua + "," + "+");
                }
                if (num != "")
                {
                    str.Append(num + "," + "+");
                }
                if (bar != "")
                {
                    str.Append(bar + "," + "+");
                }
                if (cidade != "")
                {
                    str.Append(cidade + "," + "+");
                }
                if (estado != "")
                {
                    str.Append(estado + "," + "+");
                }
                if (cep != "")
                {
                    str.Append(cep + "," + "+");
                }
                timer1.Start();
               
                this.webBrowser1.Navigate(str.ToString());
                this.webBrowser1.ScriptErrorsSuppressed = true;


            }
            catch (Exception)
            {

                throw;
            }

        }
        void BuscaCeep()
        {
            try
            {

                try
                {
                    Correio.AtendeClienteClient consulta = new Correio.AtendeClienteClient("AtendeClientePort");
                    var resultado = consulta.consultaCEP(txtCep.Text);
                    if (resultado != null)
                    {
                        txtRua.Text = resultado.end;
                        txtBairro.Text = resultado.bairro;
                        txtEstado.Text = resultado.uf;
                        txtCidade.Text = resultado.cidade;
                        txtCep.Text = resultado.cep;

                    }
                }
                catch (Exception erro)
                {

                    MessageBox.Show("Tente Novamente por favor! ERRO no servidor :" + erro.Message);
                }




            }
            catch (System.ServiceModel.FaultException erro)
            {
                MessageBox.Show("Tente Novamente por favor! ERRO:" + erro.Message);

            }
            //try
            //{

            //    string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Trim()
            //    .Replace("@cep", txtCep.Text);
            //    DataSet dt = new DataSet();
            //    dt.ReadXml(xml);
            //    txtRua.Text = dt.Tables[0].Rows[0]["logradouro"].ToString();
            //    txtBairro.Text = dt.Tables[0].Rows[0]["bairro"].ToString();
            //    txtCidade.Text = dt.Tables[0].Rows[0]["cidade"].ToString();
            //    txtEstado.Text = dt.Tables[0].Rows[0]["uf"].ToString();
            //    txtNume.Focus();


            //}
            //catch (Exception ex)
            //{
            //    txtCep.Focus();
            //    txtRua.Clear();
            //    txtBairro.Clear();
            //    txtCidade.Clear();
            //    txtEstado.Clear();
            //    // txtCEP.Text = txtCEP.Text.Insert(5, "-");
            //    txtRua.Focus();
            //   MessageBox.Show("Não Encontrado", "É necessário está Conectado à Internet :" + ex.Message);

            //}
        }
        void Transferir(Hashtable info)
        {
            txtRua.Text = info["rua"].ToString();
            txtBairro.Text = info["bairro"].ToString();
            txtCidade.Text = info["cidade"].ToString();
            txtEstado.Text = info["uf"].ToString();
            txtCep.Text = info["cep"].ToString();
            if (info["numero"].ToString() == null) txtNume.Text = " ";   
            txtNume.Text = info["numero"].ToString();
            //txtCep.SelectionStart = 6;

        }
        void TransferirCep(Hashtable info)
        {
            txtCep.Text = info["cep"].ToString();
        }
      

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            txtCep.Text = txtCep.Text.Replace("-", "");
            if (txtCep.Text.Length == 8)
            {
               //var ressut = enderecoTableAdapter1.SelectCep(txtCep.Text);
                var result1 = Mps_4512sp.RetornaCep(txtCep.Text);

                if (result1 != null  && result1.ToString() == txtCep.Text)
                {

                    BuscaCeep();
                    AbreMapa();
                    timer1.Start();
                    return;
                }
                timer1.Start();
                BuscaCeep();
                AbreMapa();

                if (txtCidade.Text != "" && txtEstado.Text != "" && result1 == null)
                {

                   //enderecoTableAdapter1.InsertEndereco(txtRua.Text, txtNume.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text, txtCep.Text);
                    Mps_4512sp.NewEndERECO(txtRua.Text,
                                           txtNume.Text,
                                           txtBairro.Text,
                                           txtCidade.Text,
                                           txtEstado.Text,
                                           txtCep.Text);
                }
                else
                {
                    MessageBox.Show("Cep não existe!", "Procura Cep", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCep.Text = string.Empty;
                    txtCep.Focus();

                }
            }


        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            webBrowser1.ScriptErrorsSuppressed = true;
            notify.ShowBalloonTip(10, "Search Address", "Programa Em Execução! \n Encontre seu Endereço com Nosso \n Programa e Veja Sua Rua de Destino!",
                                         ToolTipIcon.None);
            txtCep.Focus();
            webBrowser1.Navigate("https://maps.google.com/maps");


        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel2.Visible=true;
            button1.Visible = false;
            button2.Visible = true;
            this.WindowState = FormWindowState.Normal;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = true;
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            webBrowser1.Navigate("");
            button1.Visible = false;
            button2.Visible = false;
            timer1.Stop();

            FrmBusca fr = new FrmBusca();
            fr.TransferirDados += new FrmBusca.PassarDadoas(Transferir);
            fr.ShowDialog();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmCadastroRapido fr = new FrmCadastroRapido();
            fr.TransferirDados += new FrmCadastroRapido.PassarDadoas(TransferirCep);
            fr.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            teste tc = new teste();
            tc.Show();
        }

        private void btnManutenção_Click(object sender, EventArgs e)
        {
            FrmManutencao fr = new FrmManutencao();
            fr.ShowDialog();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            FrmConfig fr = new FrmConfig();
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "/ajuda/index.html");
            
        }

        private void txtCep_MouseEnter(object sender, EventArgs e)
        {
           

        }

        private void txtCep_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtCep.Clear();
            this.txtCep.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            button1.Visible = true;
            button2.Visible = false;
            this.WindowState = FormWindowState.Maximized;

        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FrmSobre fr = new FrmSobre();
            fr.ShowDialog();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            AbreMapa();
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            if (txtCep.Text.Length==8 && txtEstado.Text!="" && txtCidade.Text!="")
            {
               
                FrmCadFavoritos fr = new FrmCadFavoritos();
                fr.MeusFavoritos += new FrmCadFavoritos.Favoritos(MFavoritos);
                fr.ShowDialog();

            }
           
        }
        public void MFavoritos(string info)
        {


            if (MessageBox.Show(" Este Endereço Será Salvo nos Favorito!", "Favoritos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Mps_4512sp.AddFavoritos(Convert.ToInt32(Mps_4512sp.RetornaIdCep(txtCep.Text)), info);
                MessageBox.Show("O Endereço Foi Salvo nos Favorito Com Sucesso!", "Favoritos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                return;
            }
        }

        private void btnFavoritosVer_Click(object sender, EventArgs e)
        {

            FrmFavoritos fr = new FrmFavoritos(); ;
            fr.TransferirTexto += new FrmFavoritos.TransferirDados(TransferirFavoritos);
            fr.ShowDialog();
          
        }
        public void TransferirFavoritos(string Dados)
        {
            txtCep.Text = Dados;
        }

        private void frmPrincipal_Paint(object sender, PaintEventArgs e)
        {
            txtCep.Focus();
        }
    }
}
