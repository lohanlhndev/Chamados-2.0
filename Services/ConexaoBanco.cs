using MySql.Data.MySqlClient;
using System.Data;

namespace Services
{
    /// <summary>
    /// Classe para conexão com o banco de dados
    /// </summary>
    public class ConexaoBanco
    {
        //TODO mudar database
        #region Atributos da classe
       
        /// <summary>
        /// Objeto de conexão com o MySQL
        /// </summary>
        protected MySqlConnection mySqlConnection;

        #endregion

        #region Metodos da classe

        /// <summary>
        /// Metodo construtor da classe
        /// </summary>
        public ConexaoBanco()
        {
            mySqlConnection = new MySqlConnection("Server=localhost;Database=dbteste;Uid=root;Pwd=1234");
        }

        /// <summary>
        /// Abre a conexao com o banco de dados
        /// </summary>
        public void AbrirConexao()
        {

            if (mySqlConnection.State != ConnectionState.Open)
                mySqlConnection.Open();

        }

        /// <summary>
        /// Fecha a conexao com o banco de dados
        /// </summary>
        public void FecharConexao()
        {

            if (mySqlConnection.State != ConnectionState.Closed)
                mySqlConnection.Close();

        }

        /// <summary>
        /// Metodo para pesquisar dados no banco
        /// </summary>
        /// <param name="cmd">Comando SQL</param>
        /// <returns>Dados recuperados do banco</returns>
        public MySqlDataReader Pesquisar(MySqlCommand cmd)
        {
            try
            {

                cmd.Connection = mySqlConnection;
                return cmd.ExecuteReader();

            }
            catch
            {
                FecharConexao();
                throw;
            }
        }

        /// <summary>
        /// Metodo para executar comando SQL
        /// </summary>
        /// <param name="cmd">Comando SQL</param>
        public void Executar(MySqlCommand cmd)
        {
            try
            {
                cmd.Connection = mySqlConnection;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                FecharConexao();
                throw;
            }
        }

        #endregion

    }
}
