using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Chamado
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public DateTime dataAbertura { get; set; }
        public double custo { get; set; }
        public List<Lancamento> lancamentos { get; set; }
    }
}
