using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StatusService
    {
        public List<Status> Listar()
        {
            MySqlCommand cmd;
            ConexaoBanco banco = new ConexaoBanco();
            banco.AbrirConexao();

            cmd = new MySqlCommand("SELECT id, descricao FROM status");                        
            
            MySqlDataReader reader = banco.Pesquisar(cmd);

            List<Status> lstRetorno = new List<Status>();

            while (reader.Read())
            {
                Status obj = new Status();
                obj.id = reader.GetInt32(0);
                obj.descricao = reader.GetString(1);                

                lstRetorno.Add(obj);
            }

            reader.Close();
            banco.FecharConexao();

            return lstRetorno;
        }
        
    }
}
