using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoDistribuidoraPorEstado
{
    public class FaturamentoPorEstadoEstatisticas
    {
        private readonly IEnumerable<EstadoFaturamento> _dados;

        public FaturamentoPorEstadoEstatisticas(IEnumerable<EstadoFaturamento> dados)
        {
            _dados = dados;
        }

        public decimal Total => _dados.Sum(d => d.Valor);

        public IDictionary<string, decimal> Percentuais =>
            _dados.ToDictionary(
                d => d.Estado,
                d => Math.Round(d.Valor / Total * 100m, 2)
            );
    }
}
