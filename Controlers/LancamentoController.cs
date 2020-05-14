using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlers
{
    public class LancamentoController
    {

        public void Incluir(Lancamento objEntrada)
        {
            new LancamentoService().Incluir(objEntrada);
        }

    }
}
