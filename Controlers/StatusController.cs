using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlers
{
    public class StatusController
    {

        public List<Status> Listar()
        {
            return new StatusService().Listar();
        }

    }
}
