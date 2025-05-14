using FaturamentoDistribuidora;

Console.WriteLine("Estatisticas Faturamento de Distribuidora:");

var baseDir = AppContext.BaseDirectory;
var caminho = Path.Combine(baseDir, "Data", "dados.json");

// Injeção simples de dependência
IFaturamentoMensal provider =
    new JsonFaturamentoMensal(caminho);

var dados = provider.LeituraDados();
var stats = new FaturamentoMensalEstatisticas(dados);

Console.WriteLine($"Menor faturamento: {stats.MenorValor:C}");
Console.WriteLine($"Maior faturamento: {stats.MaiorValor:C}");
Console.WriteLine($"Média mensal: {stats.MediaMensal:C}");
Console.WriteLine($"Dias acima da média: {stats.DiasAcimaDaMedia}");