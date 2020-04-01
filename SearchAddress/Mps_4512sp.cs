using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Data.SQLite;

namespace SearchAddress
{
    /// <summary>
    /// Classe  do tipo abstract para efetuar
    /// Coneão com a Base de Dados sqlCeCompact
    /// </summary>
    abstract class Conexao
    {
        protected static SQLiteConnection con;
        protected static SQLiteCommand comando;
        protected static SQLiteDataAdapter adaptador;
        protected static DataTable tabela;

  /// <summary>
  /// Método protegido do tipo static que se conecta com a base de dados
  /// </summary>
  /// <returns>Retorna Uma Conexão Com base de dados.</returns>
        protected static SQLiteConnection Conectar()
        {
            //string query = @"Data Source=|DataDirectory|\maps.sdf;Password=Maps_4512sp";
            // string query = @"Data Source=C: \Users\Pc\Documents\Visual Studio 2017\Projects\SearchAddress\SearchAddress\bin\Debug\maps.db";
            string query = @"Data Source=|DataDirectory|\maps.db";
            con = new SQLiteConnection(query);
            try
            {

                con.Open();
                return con;
            }
            catch (SqlCeException ex)
            {
                throw new Exception("Não foi possivel se conecta coma a base de dados" + ex.Message);
            }
        }
        protected static void Fechar()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch
            {

            }
        }
    }
    /// <summary>
    /// Classe Responsave por todos os métodos do programa
    /// </summary>
    class Mps_4512sp : Conexao
    {
        /// <summary>
        /// Método statico retorna retorna tabela endereço.
        /// 
        /// </summary>
        /// <param name="RUA"></param>
        /// <param name="NUMERO"></param>
        /// <param name="BAIRRO"></param>
        /// <param name="CIDADE"></param>
        /// <param name="ESTADO"></param>
        /// <param name="CEP"></param>
        public static void NewEndERECO(String RUA, String NUMERO, String BAIRRO, String CIDADE, String ESTADO, String CEP)
        {

            try
            {
                string Query = "INSERT INTO ENDERECO(RUA,NUMERO,BAIRRO,CIDADE,ESTADO,CEP) VALUES(@RUA,@NUMERO,@BAIRRO,@CIDADE,@ESTADO,@CEP)";
                comando = new SQLiteCommand(Query, Conexao.Conectar());

                comando.Parameters.AddWithValue("@RUA", RUA);
                comando.Parameters.AddWithValue("@NUMERO", NUMERO);
                comando.Parameters.AddWithValue("@BAIRRO", BAIRRO);
                comando.Parameters.AddWithValue("@CIDADE", CIDADE);
                comando.Parameters.AddWithValue("@ESTADO", ESTADO);
                comando.Parameters.AddWithValue("@CEP", CEP);
                comando.ExecuteNonQuery();
                Fechar();

            }
            catch
            {
                throw new Exception("Não foi possivel se incerir dados");

            }



        }
        /// <summary>
        /// Método stático retorna cep da tabela endereço
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        public static object RetornaCep(string cep)
        {
            try
            {
                string query = "SELECT CEP FROM ENDERECO WHERE CEP=@CEP";
                comando = new SQLiteCommand(query, Conexao.Conectar());
                comando.Parameters.AddWithValue("@CEP", cep);
                var result = comando.ExecuteScalar();
                Fechar();
                return result;

            }
            catch (Exception)
            {

                throw;
            }

        }
        public static object RetornaIdCep(string cep)
        {
            try
            {
                string query = "SELECT ID FROM ENDERECO WHERE CEP=@CEP";
                comando = new SQLiteCommand(query, Conexao.Conectar());
                comando.Parameters.AddWithValue("@CEP", cep);
                var result = comando.ExecuteScalar();
                Fechar();
                return result;

            }
            catch (Exception)
            {

                throw;
            }

        }
        public static DataTable BuscaRua(string RUA)
        {
            try
            {
                string query = "SELECT RUA Rua,CEP Cep,BAIRRO Bairro,CIDADE Cidade,ESTADO UF,NUMERO Nº FROM ENDERECO  WHERE RUA LIKE '%" + RUA + "%'";
                adaptador = new SQLiteDataAdapter(query, Conexao.Conectar());
                tabela = new DataTable();
                adaptador.Fill(tabela);
                Fechar();
                return tabela;
            }
            catch
            {
                throw new Exception("erro ao temtar buscar dados");

            }

        }
        public static DataTable BuscaCep(string CEP)
        {
            try
            {
                string query = "SELECT RUA Rua,CEP Cep,BAIRRO Bairro,CIDADE Cidade,ESTADO UF,NUMERO Nº FROM ENDERECO WHERE CEP LIKE '%" + CEP + "%'";
                adaptador = new SQLiteDataAdapter(query, Conexao.Conectar());
                tabela = new DataTable();
                adaptador.Fill(tabela);
                Fechar();
                return tabela;
            }
            catch
            {
                throw new Exception("erro ao temtar buscar dados");

            }

        }
        public static DataTable BuscaCidade(string CIDADE)
        {
            try
            {
                string query = "SELECT RUA Rua,CEP Cep,BAIRRO Bairro,CIDADE Cidade,ESTADO UF,NUMERO Nº FROM ENDERECO  WHERE CIDADE LIKE '%" + CIDADE + "%'";
                adaptador = new SQLiteDataAdapter(query,Conexao. Conectar());
                tabela = new DataTable();
                adaptador.Fill(tabela);
                Fechar();
                return tabela;
            }
            catch
            {
                throw new Exception("erro ao temtar buscar dados");

            }

        }
        public static DataTable BuscaBairro(string BAIRRO)
        {
            try
            {
                string query = "SELECT RUA Rua,CEP Cep,BAIRRO Bairro,CIDADE Cidade,ESTADO UF,NUMERO Nº FROM ENDERECO  WHERE BAIRRO LIKE '%" + BAIRRO + "%'";
                adaptador = new SQLiteDataAdapter(query, Conexao.Conectar());
                tabela = new DataTable();
                adaptador.Fill(tabela);
                Fechar();
                return tabela;
            }
            catch
            {
                throw new Exception("erro ao temtar buscar dados");

            }

        }
        public static DataTable BuscaUf(string UF)
        {
            try
            {
                string query = "SELECT RUA Rua,CEP Cep,BAIRRO Bairro,CIDADE Cidade,ESTADO UF,NUMERO Nº FROM ENDERECO  WHERE ESTADO LIKE '%" + UF + "%'";
                adaptador = new SQLiteDataAdapter(query,Conexao. Conectar());
                tabela = new DataTable();
                adaptador.Fill(tabela);
                Fechar();
                return tabela;
            }
            catch
            {
                throw new Exception("erro ao temtar buscar dados");

            }

        }
        public static DataTable CarregaDados()
        {
            //try
            //{
                string query = "SELECT RUA Rua,CEP Cep,BAIRRO Bairro,CIDADE Cidade,ESTADO UF,NUMERO Nº FROM ENDERECO ";
                adaptador = new SQLiteDataAdapter(query, Conexao.Conectar());
                tabela = new DataTable();
                adaptador.Fill(tabela);
                Fechar();
                return tabela;
           // }
            //catch
           // {
               // throw new Exception("erro ao temtar buscar dados");

           // }

        }
        public static DataTable CarregaDadosManutencao(string CEP)
        {
            try
            {
                string query = "SELECT  RUA Rua, CEP CEP,NUMERO ,BAIRRO ,CIDADE ,ESTADO ,id  FROM ENDERECO WHERE CEP LIKE '%" + CEP + "%'";
                adaptador = new SQLiteDataAdapter(query, Conexao.Conectar());
                tabela = new DataTable();
                adaptador.Fill(tabela);
                Fechar();
                return tabela;
            }
            catch
            {
                throw new Exception("erro ao temtar buscar dados");

            }

        }
        public static void DeletaEnder(string id)
        {
            try
            {
                string query = "DELETE FROM ENDERECO WHERE ID=@ID";
                comando = new SQLiteCommand(query, Conexao.Conectar());
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();
                Fechar();

            }
            catch (Exception)
            {

                throw new Exception("ERRO AO TENTAR EXCLUIR O REGISTRO");
            }


        }
        public static void AtualizaEnder( string rua,string numero,string bairro,
                                         string cidade,string estado,string id)
        {
            try
            {
                string query = "UPDATE ENDERECO SET RUA=@RUA,NUMERO=@NUMERO," +
                                "BAIRRO=@BAIRRO,CIDADE=@CIDADE,ESTADO=@UF  WHERE ID=@ID";
                comando = new SQLiteCommand(query, Conexao.Conectar());
                comando.Parameters.AddWithValue("@ID", id);
                comando.Parameters.AddWithValue("@RUA",rua);
                comando.Parameters.AddWithValue("@NUMERO",numero);
                comando.Parameters.AddWithValue("@BAIRRO",bairro);
                comando.Parameters.AddWithValue("@CIDADE",cidade);
                comando.Parameters.AddWithValue("@UF",estado);
                comando.ExecuteNonQuery();
                Fechar();

            }
            catch (SqlCeException ERRO)
            {

                throw new Exception("ERRO AO TENTAR ATUALIZAR O REGISTRO:"+ERRO.Message);
            }


        }
        public static void AddFavoritos(int id, string nome)
        {
            
            try
            {
                string query = "INSERT INTO FAVORITO (ID_END,NOME_FA) VALUES(@ID,@NOME)";
                comando = new SQLiteCommand(query, Conexao.Conectar());
                comando.Parameters.AddWithValue("@ID", id);
                comando.Parameters.AddWithValue("@NOME", nome);
                comando.ExecuteNonQuery();
                Fechar();

            }
            catch (Exception)
            {

                throw new Exception("ERRO AO TENTAR SE CONECTAR");
            }


        }
        public static DataTable CarregaFavoritos()
        {

            try
            {
                string query = "SELECT F.NOME_FA,E.CEP,F.ID FROM FAVORITO AS F" +
                                " INNER JOIN ENDERECO AS E ON E.ID = F.ID_END";
                adaptador = new SQLiteDataAdapter(query, Mps_4512sp.Conectar());
                tabela = new DataTable();
                adaptador.Fill(tabela);
                Fechar();
                return tabela;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel carregar dados");
            }
        }
        public static DataTable PesquisaFavoritos(string nome)
        {
            try
            {
                string query = "SELECT F.NOME_FA,E.CEP,F.ID FROM FAVORITO AS F" +
                                " INNER JOIN ENDERECO AS E ON E.ID = F.ID_END " +
                                "WHERE NOME_FA LIKE '%" + nome + "%'";
                adaptador = new SQLiteDataAdapter(query, Conexao.Conectar());
                tabela = new DataTable();
                adaptador.Fill(tabela);
                Fechar();
                return tabela;
            }
            catch
            {
                throw new Exception("erro ao temtar buscar dados");

            }
        }
        public static void DeleteFavorito(string COD)
        {
            try
            {
                string query = "DELETE FROM FAVORITO WHERE ID=@ID";
                comando = new SQLiteCommand(query, Conexao.Conectar());
                comando.Parameters.AddWithValue("@ID", COD);
                comando.ExecuteNonQuery();
                Fechar();

            }
            catch (Exception)
            {

                throw new Exception("ERRO AO TENTAR EXCLUIR O REGISTRO");
            }





        }

    }
}
