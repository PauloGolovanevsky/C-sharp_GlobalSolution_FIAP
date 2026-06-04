# SpaceMonitor

## Motivação

O SpaceMonitor simula uma central de monitoramento espacial capaz de registrar objetos em órbita, listar informações operacionais, avaliar riscos simples de colisão e manter um histórico de eventos.

## Solução Proposta

O **SpaceMonitor** foi desenvolvido para simular uma central de monitoramento de objetos em órbita terrestre, contribuindo para a análise e prevenção de riscos relacionados ao lixo espacial.

A aplicação permite o cadastro e gerenciamento de diferentes tipos de objetos espaciais, como satélites ativos, detritos espaciais e estágios de foguetes desativados. Com base nos dados informados, o sistema realiza uma simulação de monitoramento orbital, comparando a altitude dos objetos cadastrados para identificar possíveis situações de risco.

Quando a diferença de altitude entre dois objetos é inferior a 50 km, o sistema considera a existência de um potencial risco de colisão e gera automaticamente um alerta preventivo. Todas as ocorrências são registradas em um histórico de eventos, permitindo o acompanhamento das operações realizadas e das situações identificadas durante o monitoramento.

Além disso, o sistema disponibiliza funcionalidades de consulta, geração de relatórios e visualização do histórico, proporcionando uma visão consolidada dos objetos monitorados e dos alertas emitidos.


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

### Diagrama de Classes UML
<p align="center">
  <img width="100%" height="1287" alt="diagrama uml drawio" src="https://github.com/user-attachments/assets/e353cc1d-73b2-48ae-a70f-08a228e85c2c" />
</p>

---

### Diagrama de Fluxo do Sistema
<p align="center">
  <img width="450" alt="Diagrama de fluxo do sistema" src="https://github.com/user-attachments/assets/34ead715-6d59-43a4-84c5-aa2a4385f6e2" />
</p>

## Evidencias da Aplicação funcionando
- Menu do sistema
<p align="center">
  <img width="450" alt="Diagrama de fluxo do sistema" src="https://github.com/user-attachments/assets/4921c58f-a6aa-4c79-afcb-67a7e9d4b308" />
</p>

- Cadastro de dois detritos espaciais e simulação de risco de colisão
<p align="center">
  <img width="450" alt="Diagrama de fluxo do sistema" src="https://github.com/user-attachments/assets/8ab0a11e-bf75-4cc2-a8a5-5d5f23b655ff" />
</p>

- Relatorio completo de todos os itens sendo monitorados no momento
<p align="center">
  <img width="450" alt="Diagrama de fluxo do sistema" src="https://github.com/user-attachments/assets/23115a3c-2309-4f18-916b-b0ed6cf68426" />
</p>


- Listagem de todos os objetos espaciais cadastrados / Exibir Histórico de Eventos do sistema
<p align="center">
  <img width="450" alt="Diagrama de fluxo do sistema" src="https://github.com/user-attachments/assets/0679ef8a-28f3-4385-9c48-4911999e1f54" />
</p>
