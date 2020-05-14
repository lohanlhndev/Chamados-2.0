using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ChamadoService
    {
        
        public List<Chamado> Listar(Chamado objEntrada)
        {
            MySqlCommand cmd;
            if (string.IsNullOrEmpty(objEntrada.descricao))
            {
                cmd = new MySqlCommand("SELECT id, descricao, dataAbertura, custo FROM chamado");
            }

            else
            {
                cmd = new MySqlCommand("SELECT id, descricao, dataAbertura, custo FROM chamado"+
                                       "WHERE descricao like @descricao");

                cmd.Parameters.Add(new MySqlParameter("@descicao", "%" + objEntrada.descricao + "%"));
            }

            ConexaoBanco banco = new ConexaoBanco();
            banco.AbrirConexao();

            MySqlDataReader reader = banco.Pesquisar(cmd);

            List <Chamado> lstRetorno = new List<Chamado>();

            while (reader.Read())
            {
                Chamado obj = new Chamado();
                obj.id = reader.GetInt32(0);
                obj.descricao = reader.GetString(1);
                obj.dataAbertura = reader.GetDateTime(2);
                obj.custo = reader.GetDouble(3);

                lstRetorno.Add(obj);
            }

            reader.Close();
            banco.FecharConexao();

            return lstRetorno;
        }

        public Chamado Selecionar(Chamado objEntrada)
        {
            MySqlCommand cmd;
            
            ConexaoBanco banco = new ConexaoBanco();
            banco.AbrirConexao();


            #region Carregando objeto chamado
            cmd = new MySqlCommand("SELECT id, descricao, dataAbertura, custo FROM chamado" +
                                   "WHERE id = @id");

            cmd.Parameters.Add(new MySqlParameter("@id", objEntrada.id));

            MySqlDataReader reader = banco.Pesquisar(cmd);            

            reader.Read();

            Chamado obj = new Chamado();
            obj.id = reader.GetInt32(0);
            obj.descricao = reader.GetString(1);
            obj.dataAbertura = reader.GetDateTime(2);
            obj.custo = reader.GetDouble(3);

            reader.Close();

            #endregion

            #region Carregando lista de lancamento
            cmd = new MySqlCommand("SELECT lancamento.data, status.id, status.descricao FROM lancamento" +
                                   "INNER JOIN status on lancamento.id_status = status.id" +
                                   "WHERE lancamento.id_chamado = @id_chamado");

            cmd.Parameters.Add(new MySqlParameter("@id_chamado", objEntrada.id));
            reader = banco.Pesquisar(cmd);

            obj.lancamentos = new List<Lancamento>();

            while (reader.Read())
            {
                Lancamento lancamento = new Lancamento();
                lancamento.status = new Status();

                lancamento.data = reader.GetDateTime(0);
                lancamento.status.id = reader.GetInt32(1);
                lancamento.status.descricao = reader.GetString(2);

                obj.lancamentos.Add(lancamento); 
            }

            reader.Close();
            #endregion

            banco.FecharConexao();

            return obj;
        }

        public void Incluir(Chamado objEntrada)
        {
            MySqlCommand cmd;
            ConexaoBanco banco = new ConexaoBanco();
            banco.AbrirConexao();

            cmd = new MySqlCommand("INSERT INTO chamado(descricao,dataAbertura, custo)"+
                                   "VALUES (@descricao, @dataAbertura, @custo)");

            cmd.Parameters.Add(new MySqlParameter("@descicao", objEntrada.descricao));
            cmd.Parameters.Add(new MySqlParameter("@dataAbertura", objEntrada.dataAbertura));
            cmd.Parameters.Add(new MySqlParameter("@custo", objEntrada.custo));

            banco.Executar(cmd);
            banco.FecharConexao();
        }

        public void Atualizar(Chamado objEntrada)
        {
            MySqlCommand cmd;
            ConexaoBanco banco = new ConexaoBanco();
            banco.AbrirConexao();

            cmd = new MySqlCommand("UPDATE chamado SET descricao = @descricao, custo = @custo" +
                                   "WHERE id = @id");

            cmd.Parameters.Add(new MySqlParameter("@id", objEntrada.id));            
            cmd.Parameters.Add(new MySqlParameter("@descicao", objEntrada.descricao));            
            cmd.Parameters.Add(new MySqlParameter("@custo", objEntrada.custo));

            banco.Executar(cmd);
            banco.FecharConexao();
        }
    }
}
