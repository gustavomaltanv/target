# Target

### 1. [SomaIndices](./SomaIndices/Program.cs)
  - Somar indices até 13.

### 2. [SequenciaFibonacci](./SequenciaFibonacci/Program.cs)
  - Verificar se o número digitado faz parte da Sequencia de Fibonacci.

### 3. [FaturamentoDistribuidora](./FaturamentoDistribuidora/Program.cs)
  - Carregar os dados do Json e fazer as estatísticas solicitadas.

### 4. [FaturamentoDistribuidoraPorEstado](./FaturamentoDistribuidoraPorEstado/Program.cs)
  - Obter percentual de represencação das distribuidoras por estado.

### 5. [InverterString](./InverterString/Program.cs)
  - Código para inversão de string.

---
## Estrutura: 
```
/
├── SomIndices/ # Questão 1
├── SequenciaFibonacci/ # Questão 2
├── FaturamentoDistribuidora/ # Questão 3
│ └── Data/dados.json
├── FaturamentoDistribuidoraPorEstado/ # Questão 4
├── InverterString/ # Questão 5
└── Target.sln 
```

## Como executar:

**Pré-requisitos**  
   - .NET 8.0 SDK instalado

**Clonar repositório**  
   ```bash
   git clone https://github.com/gustavomaltanv/target
   cd target
   ```

**Restaurar e Compilar**
```bash
dotnet restore
dotnet build
```

- Rodar cada aplicação
SomIndices
  ```bash
  dotnet run --project SomIndices/SomIndices.csproj
  ```
- SequenciaFibonacci
  ```bash
  dotnet run --project SequenciaFibonacci/SequenciaFibonacci.csproj
  ```

- FaturamentoDistribuidora
  ```bash
  dotnet run --project FaturamentoDistribuidora/FaturamentoDistribuidora.csproj
  ```

- FaturamentoDistribuidoraPorEstado
  ```bash
  dotnet run --project FaturamentoDistribuidoraPorEstado/FaturamentoDistribuidoraPorEstado.csproj
  ```

- InverterString
  ```bash
  dotnet run --project InverterString/InverterString.csproj
  ```