// Screen Sound

string logo = @"  _____                             _____                       _ 
  / ____|                           / ____|                     | |
 | (___   ___ _ __ ___  ___ _ __   | (___   ___  _   _ _ __   __| |
  \___ \ / __| '__/ _ \/ _ \ '_ \   \___ \ / _ \| | | | '_ \ / _` |
  ____) | (__| | |  __/  __/ | | |  ____) | (_) | |_| | | | | (_| |
 |_____/ \___|_|  \___|\___|_| |_| |_____/ \___/ \__,_|_| |_|\__,_|
                                                                   
                                                              ";
string mensagemBoasVindas = "Boas vindas ao Screen Sound";

List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };

void ExibirOpcoesDoMenu()
{

    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("Digite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine($"A opção escolhida foi: ${opcaoEscolhidaNumerica}");
            break;
        case 4:
            Console.WriteLine("A opção escolhida foi: {0}", opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Tchau tchau =)");
            break;
        default:
            Console.WriteLine("A opção digitada é inválida");
            break;
    }
}

void ExibirLogo()
{
    Console.WriteLine(logo);
    Console.WriteLine(mensagemBoasVindas);

}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("***************************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("***************************");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("************************************\n");

    // for (int i = 0; i < listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
    // }

    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}


ExibirOpcoesDoMenu();