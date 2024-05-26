// Screen Sound

string logo = @"  _____                             _____                       _ 
  / ____|                           / ____|                     | |
 | (___   ___ _ __ ___  ___ _ __   | (___   ___  _   _ _ __   __| |
  \___ \ / __| '__/ _ \/ _ \ '_ \   \___ \ / _ \| | | | '_ \ / _` |
  ____) | (__| | |  __/  __/ | | |  ____) | (_) | |_| | | | | (_| |
 |_____/ \___|_|  \___|\___|_| |_| |_____/ \___/ \__,_|_| |_|\__,_|
                                                                   
                                                              ";
string mensagemBoasVindas = "Boas vindas ao Screen Sound";

//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 9, 10 });
bandasRegistradas.Add("The Beatles", new List<int>());

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
            AvaliarUmaBanda();
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
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    //listaDasBandas.Add(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    // for (int i = 0; i < listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
    // }

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    //Digitar qual banda deseja avaliar
    //Se a banda existir no dicionário >> atribuir nota
    //Senão voltar ao menu principal
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine());
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota foi {nota} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal ");
        Console.ReadKey(true);

        ExibirOpcoesDoMenu();
    }
}
ExibirOpcoesDoMenu();