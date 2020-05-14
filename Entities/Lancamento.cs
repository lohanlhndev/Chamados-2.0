using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Lancamento
    {
        public Chamado chamado { get; set; }
        public DateTime data { get; set; }
        public Status status { get; set; }
    }
}
