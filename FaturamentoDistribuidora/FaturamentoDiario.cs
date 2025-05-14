﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FaturamentoDistribuidora
{
    public class FaturamentoDiario
    {
        [JsonPropertyName("dia")]
        public int Dia { get; set; }

        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }
    }
}
