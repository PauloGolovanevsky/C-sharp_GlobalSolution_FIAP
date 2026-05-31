using SpaceMonitor.Data;
using SpaceMonitor.Exceptions;
using SpaceMonitor.Models;
using SpaceMonitor.Services;
using SpaceMonitor.Structs;

HistoricoEventos historicoEventos = new();
AlertaService alertaService = new(historicoEventos);
MonitoramentoService monitoramentoService = new(alertaService, historicoEventos);
RelatorioService relatorioService = new(monitoramentoService, historicoEventos);

ExecutarMenu();

void ExecutarMenu()
{
    bool continuar = true;

    while (continuar)
    {
        ExibirMenu();
        string opcao = LerTexto("Escolha uma opção: ");

        try
        {
            continuar = ProcessarOpcao(opcao);
        }
        catch (AltitudeInvalidaException ex)
        {
            Console.WriteLine($"Erro de altitude: {ex.Message}");
            historicoEventos.RegistrarEvento($"Erro de cadastro: {ex.Message}");
        }
        catch (ObjetoNaoEncontradoException ex)
        {
            Console.WriteLine($"Erro de monitoramento: {ex.Message}");
            historicoEventos.RegistrarEvento($"Operação não concluída: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Informe um valor numérico quando solicitado.");
            historicoEventos.RegistrarEvento("Erro de entrada: formato inválido informado pelo usuário.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
            historicoEventos.RegistrarEvento($"Erro inesperado: {ex.Message}");
        }

        Console.WriteLine();
    }
}

void ExibirMenu()
{
    Console.WriteLine("=== SpaceMonitor - Central de Monitoramento Espacial ===");
    Console.WriteLine("1 - Cadastrar Satélite");
    Console.WriteLine("2 - Cadastrar Detrito Espacial");
    Console.WriteLine("3 - Cadastrar Estágio de Foguete");
    Console.WriteLine("4 - Listar Objetos Espaciais");
    Console.WriteLine("5 - Simular Risco de Colisão");
    Console.WriteLine("6 - Gerar Relatório");
    Console.WriteLine("7 - Exibir Histórico de Eventos");
    Console.WriteLine("0 - Sair");
}

bool ProcessarOpcao(string opcao)
{
    switch (opcao)
    {
        case "1":
            CadastrarSatelite();
            return true;
        case "2":
            CadastrarDetritoEspacial();
            return true;
        case "3":
            CadastrarEstagioFoguete();
            return true;
        case "4":
            monitoramentoService.MonitorarObjetos();
            return true;
        case "5":
            monitoramentoService.VerificarRiscoColisao();
            return true;
        case "6":
            relatorioService.GerarRelatorio();
            return true;
        case "7":
            historicoEventos.ExibirHistorico();
            return true;
        case "0":
            historicoEventos.RegistrarEvento("Sistema encerrado pelo usuário.");
            Console.WriteLine("Encerrando o SpaceMonitor.");
            return false;
        default:
            Console.WriteLine("Opção inválida.");
            return true;
    }
}

void CadastrarSatelite()
{
    Console.WriteLine("Cadastro de Satélite");
    string nome = LerTexto("Nome: ");
    double altitude = LerDouble("Altitude (km): ");
    double velocidade = LerDouble("Velocidade (km/h): ");
    CoordenadaOrbital coordenada = LerCoordenadaOrbital();
    string agencia = LerTexto("Agência responsável: ");

    Satelite satelite = new(nome, altitude, velocidade, coordenada, agencia);
    monitoramentoService.CadastrarObjeto(satelite);
    Console.WriteLine("Satélite cadastrado com sucesso.");
}

void CadastrarDetritoEspacial()
{
    Console.WriteLine("Cadastro de Detrito Espacial");
    string nome = LerTexto("Nome: ");
    double altitude = LerDouble("Altitude (km): ");
    double velocidade = LerDouble("Velocidade (km/h): ");
    CoordenadaOrbital coordenada = LerCoordenadaOrbital();
    string origem = LerTexto("Origem provável: ");

    DetritoEspacial detrito = new(nome, altitude, velocidade, coordenada, origem);
    monitoramentoService.CadastrarObjeto(detrito);
    Console.WriteLine("Detrito espacial cadastrado com sucesso.");
}

void CadastrarEstagioFoguete()
{
    Console.WriteLine("Cadastro de Estágio de Foguete");
    string nome = LerTexto("Nome: ");
    double altitude = LerDouble("Altitude (km): ");
    double velocidade = LerDouble("Velocidade (km/h): ");
    CoordenadaOrbital coordenada = LerCoordenadaOrbital();
    string missao = LerTexto("Missão de origem: ");

    EstagioFoguete estagio = new(nome, altitude, velocidade, coordenada, missao);
    monitoramentoService.CadastrarObjeto(estagio);
    Console.WriteLine("Estágio de foguete cadastrado com sucesso.");
}

CoordenadaOrbital LerCoordenadaOrbital()
{
    double latitude = LerDouble("Latitude: ");
    double longitude = LerDouble("Longitude: ");
    return new CoordenadaOrbital(latitude, longitude);
}

string LerTexto(string mensagem)
{
    Console.Write(mensagem);
    string? valor = Console.ReadLine();
    return string.IsNullOrWhiteSpace(valor) ? "Não informado" : valor.Trim();
}

double LerDouble(string mensagem)
{
    Console.Write(mensagem);
    string? valor = Console.ReadLine();
    return double.Parse(valor ?? string.Empty);
}
