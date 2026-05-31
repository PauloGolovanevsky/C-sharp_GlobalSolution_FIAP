# SpaceMonitor

## Motivação

O SpaceMonitor simula uma central de monitoramento espacial capaz de registrar objetos em órbita, listar informações operacionais, avaliar riscos simples de colisão e manter um histórico de eventos.

## Solução Proposta

O **SpaceMonitor** foi desenvolvido para simular uma central de monitoramento de objetos em órbita terrestre, contribuindo para a análise e prevenção de riscos relacionados ao lixo espacial.

A aplicação permite o cadastro e gerenciamento de diferentes tipos de objetos espaciais, como satélites ativos, detritos espaciais e estágios de foguetes desativados. Com base nos dados informados, o sistema realiza uma simulação de monitoramento orbital, comparando a altitude dos objetos cadastrados para identificar possíveis situações de risco.

Quando a diferença de altitude entre dois objetos é inferior a 50 km, o sistema considera a existência de um potencial risco de colisão e gera automaticamente um alerta preventivo. Todas as ocorrências são registradas em um histórico de eventos, permitindo o acompanhamento das operações realizadas e das situações identificadas durante o monitoramento.

Além disso, o sistema disponibiliza funcionalidades de consulta, geração de relatórios e visualização do histórico, proporcionando uma visão consolidada dos objetos monitorados e dos alertas emitidos pela central.


## Conceitos de POO aplicados

- Programação Orientada a Objetos com entidades e serviços.
- Encapsulamento em propriedades com setters privados.
- Herança a partir da classe abstrata `ObjetoEspacial`.
- Polimorfismo ao percorrer uma coleção de `ObjetoEspacial` e executar `ExibirInformacoes()`.
- Classe abstrata com método abstrato.
- Interface `IMonitoramento`.
- Injeção de dependência via construtor.
- Tratamento de exceções com `try/catch`.
- Exceções customizadas.
- `struct` `CoordenadaOrbital`.
- `partial class` `Relatorio`.
- Uso de `DateTime` para registros e histórico.
- Métodos pequenos e modularizados.

## Estrutura de pastas

```text
SpaceMonitor
├── Models
│   ├── ObjetoEspacial.cs
│   ├── Satelite.cs
│   ├── DetritoEspacial.cs
│   └── EstagioFoguete.cs
├── Interfaces
│   └── IMonitoramento.cs
├── Services
│   ├── MonitoramentoService.cs
│   ├── AlertaService.cs
│   └── RelatorioService.cs
├── Structs
│   └── CoordenadaOrbital.cs
├── Exceptions
│   ├── ObjetoNaoEncontradoException.cs
│   └── AltitudeInvalidaException.cs
├── Reports
│   ├── Relatorio.Part1.cs
│   └── Relatorio.Part2.cs
├── Data
│   └── HistoricoEventos.cs
├── Program.cs
├── SpaceMonitor.csproj
└── README.md
```

## Como executar o projeto

Pré-requisito: .NET SDK 8 instalado.

```bash
dotnet restore
dotnet build
dotnet run
```

## Funcionalidades

- Cadastrar satélite.
- Cadastrar detrito espacial.
- Cadastrar estágio de foguete.
- Listar objetos espaciais de forma polimórfica.
- Simular risco de colisão por diferença de altitude.
- Emitir alertas preventivos.
- Gerar relatório consolidado.
- Exibir histórico de eventos com data e hora.

## Diagramas da Solução



## Evidencias da Aplicação funcionando