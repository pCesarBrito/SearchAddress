using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace SearchAddress
{
    public partial class teste : Form
    {
        public teste()
        {
            InitializeComponent();
        }
       // private static string conectar=@"Data Source=maps.db; Version=3";
        //private static string nomeBanco = "maps.db";
        private void teste_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.endereco' table. You can move, or remove it, as needed.

            //SqlCeConnection m = new SqlCeConnection();
            //if(!File.Exists(nomeBanco))
            // {
            //     SQLiteConnection.CreateFile(nomeBanco);

            //     MessageBox.Show("banco criado com suicesso");

            // }

            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\maps.sdf;Password=Maps_4512sp");
            con.Open();
            SqlCeDataAdapter adapter = new SqlCeDataAdapter("SELECT * FROM ENDERECO", con);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView1.DataSource = tb;
            label1.Text = " Número de Rgistros:"+tb.Rows.Count.ToString();
            // SqlCeEngine nev = new SqlCeEngine(@"Data Source=|DataDirectory|\maps1.sdf ;Password=Maps_4512sp");
            // nev.CreateDatabase();
            //try
            //{
            //    SQLiteConnection con = new SQLiteConnection(conectar);
            //    con.Open();
            //    SQLiteCommand adapter = new SQLiteCommand("SELECT * FROM ENDERECO", con);
            //    SQLiteDataReader dr = adapter.ExecuteReader();
            //    List<enderecos> lista = new List<enderecos>();
            //    while (dr.Read())
            //    {
            //        lista.Add(new enderecos
            //        {
            //            id = Convert.ToInt32(dr["id"]),
            //            rau = dr["rua"].ToString(),
            //            numero = dr["numero"].ToString(),
            //            cidade = dr["cidade"].ToString()
            //        });
            //        dataGridView1.DataSource = lista;
            //    }
            //}
            //catch (SQLiteException ex)
            //{

            //    throw new Exception(ex.Message);
            //}
          
          
            
           
        }

        private void enderecoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           
            

        }

        private void enderecoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            //this.enderecoBindingSource.EndEdit();

        }
    }
}
public class enderecos
{

    public int id { get; set; }
    public string rau { get; set; }
    public string numero { get; set; }
    public string bairro { get; set; }
    public string cidade { get; set; }
    public string cep { get; set; }
    public string estado { get; set; }



}