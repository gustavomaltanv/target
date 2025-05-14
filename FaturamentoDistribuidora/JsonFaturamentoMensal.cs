using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FaturamentoDistribuidora
{
    public class JsonFaturamentoMensal : IFaturamentoMensal
    {
        private readonly string _filePath;
        
        public JsonFaturamentoMensal(string filePath)
        {
            _filePath = filePath;
        }

        public IEnumerable<FaturamentoDiario> LeituraDados()
        {
            var json = File.ReadAllText(_filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var lista = JsonSerializer.Deserialize<List<FaturamentoDiario>>(json, options)
                     ?? throw new InvalidOperationException("Falha ao desserializar JSON.");

            return lista;
        }
    }
    
}
