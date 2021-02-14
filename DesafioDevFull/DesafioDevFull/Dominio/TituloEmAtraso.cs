using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDevFull.Dominio
{
    public class TituloEmAtraso
    {
        public Guid Numero { get; set; }
        public string NomeDevedor { get; set; }
        public string CPFDevedor { get; set; }

        public decimal PercentualJuros { get; set; }
        public decimal PercentualMulta { get; set; }
        public IList<TituloEmAtrasoParcela> Parcelas { get; set; }
    }
}
