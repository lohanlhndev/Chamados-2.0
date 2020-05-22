using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Utils;

namespace Controllers
{
    public class ChamadoController
    {

        public List<Chamado> Listar(Chamado objEntrada)
        {
            return new ChamadoService().Listar(objEntrada);
        }

        public Chamado Selecionar(Chamado objEntrada)
        {
            return new ChamadoService().Selecionar(objEntrada);
        }

        public void Incluir(Chamado objEntrada)
        {
            Consistir(objEntrada);

            new ChamadoService().Incluir(objEntrada);
        }

        public void Atualizar(Chamado objEntrada)
        {
            Consistir(objEntrada);

            new ChamadoService().Atualizar(objEntrada);
        }

        public void Consistir(Chamado objEntrada)
        {
            if (String.IsNullOrEmpty(objEntrada.descricao))
            {
                throw new ConsistenciaException("Por favor, preencha o campo Descrição");
            }

            if (objEntrada.custo <= 0)
            {
                throw new ConsistenciaException("Por favor, preencha o campo Custo com valor maior que zero");
            }
        }
    }
}
