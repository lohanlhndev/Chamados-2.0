using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class ConsistenciaException : Exception
    {

        public string mensagem { get; set; }

        public ConsistenciaException(string mensagem)
        {
            this.mensagem = mensagem;
        }
    }
}
