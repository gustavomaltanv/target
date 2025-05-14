using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoDistribuidora
{
    public class FaturamentoMensalEstatisticas
    {
        private readonly IEnumerable<FaturamentoDiario> _dias;

        public FaturamentoMensalEstatisticas(IEnumerable<FaturamentoDiario> dias)
        {
            _dias = dias;
        }

        private IEnumerable<decimal> ValoresValidos => _dias.Where(d => d.Valor > 0).Select(d => d.Valor);

        public decimal MenorValor => ValoresValidos.Min();

        public decimal MaiorValor => ValoresValidos.Max();

        public decimal MediaMensal => ValoresValidos.Average();

        public int DiasAcimaDaMedia => _dias.Count(d => d.Valor > MediaMensal);
    }
}