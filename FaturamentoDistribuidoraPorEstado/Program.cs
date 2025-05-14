using System.Globalization;
using FaturamentoDistribuidoraPorEstado;

var faturamentoPorEstado = new List<EstadoFaturamento>
{
    new EstadoFaturamento { Estado = "SP",    Valor =  67836.43m },
    new EstadoFaturamento { Estado = "RJ",    Valor =  36678.66m },
    new EstadoFaturamento { Estado = "MG",    Valor =  29229.88m },
    new EstadoFaturamento { Estado = "ES",    Valor =  27165.48m },
    new EstadoFaturamento { Estado = "Outros",Valor =  19849.53m },
};


var estatisticas = new FaturamentoPorEstadoEstatisticas(faturamentoPorEstado);

Console.WriteLine($"Total mensal: {estatisticas.Total.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
Console.WriteLine("Percentual por estado:");
foreach (var estado in estatisticas.Percentuais)
{
    Console.WriteLine($"  {estado.Key.PadRight(6)} : {estado.Value.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"))}%");
};