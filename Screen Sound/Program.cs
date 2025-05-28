using ScreenSound;
using ScreenSound.Menus;
using ScreenSound.Modelos;

Banda ira = new Banda("Ira!");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(5));
Banda beatles = new("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);




void ExibirLogo()
{
    Console.WriteLine(@"

        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");

    
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
    
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica)
    {
        case 1: MenuRegistrarBanda menu1 = new();
            menu1.Executar(bandasRegistradas);
            break;
        case 2: MenuRegistrarAlbum menu2 = new();
            menu2.Executar(bandasRegistradas);
            break;
        case 3: MenuBandasRegistradas menu3 = new();
            menu3.Executar(bandasRegistradas);
            break;
        case 4: MenuAvaliarBanda menu4 = new();
            menu4.Executar(bandasRegistradas);
            break;
        case 5:
            MenuExibirDetalhes menu5 = new();
            menu5.Executar(bandasRegistradas);
            break;
        case -1: Console.WriteLine("Até a proxima!");
            break;
        default: Console.WriteLine("Opção Invalida!!");
            break;
    }
}

ExibirOpcoesDoMenu();