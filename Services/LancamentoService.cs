using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LancamentoService
    {

        public void Incluir(Lancamento objEntrada)
        {
            MySqlCommand cmd;
            ConexaoBanco banco = new ConexaoBanco();
            banco.AbrirConexao();

            cmd = new MySqlCommand("INSERT INTO lancamento(id_chamado, data, id_status)" +
                                   "VALUES (@id_chamado, @data, @id_status)");

            cmd.Parameters.Add(new MySqlParameter("@id_chamado", objEntrada.chamado.id));
            cmd.Parameters.Add(new MySqlParameter("@data", objEntrada.data));
            cmd.Parameters.Add(new MySqlParameter("@id_status", objEntrada.status.id));

            banco.Executar(cmd);
            banco.FecharConexao();
        }
    }
}
