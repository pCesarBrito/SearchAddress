using System;
using System.IO;
using System.Windows.Forms;

namespace SearchAddress
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void btnBroser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
               
                fd.RootFolder = Environment.SpecialFolder.Desktop;
                txtBeckap.Text = fd.SelectedPath;
                btnBroser.Enabled = false;
                btnSalvar.Enabled = true;
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                op.Title = "Restaurar Dados";
               
                
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Será criada uma Cópia de Segurança Neste Endereço:" +
                    "\n " + txtBeckap.Text + "\n Clique em ok Para Confirma!"  , "Beckap Base de Dados", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {

                string rp = Guid.NewGuid().ToString("N").Substring(0, 12);
                string destino = txtBeckap.Text+"\\ maps_copy" +rp+".sdf" ;
                string origem = Application.StartupPath + "\\maps.sdf";
                File.Copy(origem, destino);
                btnBroser.Enabled = true;
                btnSalvar.Enabled = false;
                MessageBox.Show("Uma Cópia de Segurança foi criada com Sucesso \n no diretório:" + txtBeckap.Text
                    ,"Beckap da Base de Dados.",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtBeckap.Text = "";
            }
            else
            {
                txtBeckap.Text = "";
                btnBroser.Enabled = true;
                btnSalvar.Enabled = false;


            }
        }
    }
}
