using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor.Entity
{
    interface IDados
    {
        public int id { get; set; }
        public string dadosPergunta { get; set; }
        public string dadosResposta { get; set; }

    }
}
