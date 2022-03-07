using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeJogos
{
    class Program
    {

        static int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Controle de Jogos ===");
            Console.WriteLine("\nSelecione uma Opção: ");
            Console.WriteLine("\n[1] Cadastrar um Jogo");
            Console.WriteLine("[2] Excluir um Jogo");
            Console.WriteLine("[3] Alterar um Jogo");
            Console.WriteLine("[4] Localizar um Jogo por nome");
            Console.WriteLine("[5] Listar os Jogos por Gênero");
            Console.WriteLine("[6] Listar os Jogos por Console");
            Console.WriteLine("[7] Listar Todos os Jogos");
            Console.WriteLine("[8] Sair");
            Console.Write("\nOpção: ");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void Main(string[] args)
        {
            int op = 0;
            ListaDeJogos Jogos = new ListaDeJogos();

            Jogo jogo = new Jogo(1,"BF5","Jogo FPS",TipoGenero.Acao,TipoConsole.PS5);
            Jogos.Inserir(jogo);
            jogo = new Jogo(2, "Lost Ark", "Jogo RPG", TipoGenero.Estrategia, TipoConsole.PC);
            Jogos.Inserir(jogo);
            jogo = new Jogo(3, "Fortnite", "Jogo Battle Royale", TipoGenero.Acao, TipoConsole.PC);
            Jogos.Inserir(jogo);

            while (op != 8)
            {
                op = ShowMenu();
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Inserir Jogo");
                        jogo = new Jogo();
                        Console.Write("\nInforme o Id do Jogo: ");
                        jogo.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o Nome do Jogo: ");
                        jogo.Nome = Console.ReadLine();
                        Console.Write("Informe a Descrição do Jogo: ");
                        jogo.Descricao = Console.ReadLine();
                        Console.Write("Informe o Gênero Ação [0], Aventura [1], Casual [2], Puzzle [3], Estratégia [4], Outro [5]: ");
                        jogo.Genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o Console PS4 [0], PS5 [1], Switch [2], Xbox One [3], Xbox Series [4], PC [5], Outro [6]: ");
                        jogo.Console = (TipoConsole)Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (Jogos.Inserir(jogo))
                        {
                            Console.WriteLine("Jogo Adicionado");
                        }
                        else
                        {
                            Console.WriteLine($"Já Existe um Jogo Cadastrado com o Código {jogo.Id}");
                        }
                        Console.WriteLine("\nAperte Qualquer Tecla para Continuar");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Excluir Jogo");
                        Console.Write("\nInforme o Id do Jogo: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (Jogos.Excluir(id))
                        {
                            Console.WriteLine("Jogo Excluído");
                        }
                        else
                        {
                            Console.WriteLine("Jogo Não Excluído");
                        }
                        Console.WriteLine("\nAperte Qualquer Tecla para Continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Alterar Jogo");
                        jogo = new Jogo();
                        Console.Write("\nInforme o Id do Jogo: ");
                        jogo.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o Nome do Jogo: ");
                        jogo.Nome = Console.ReadLine();
                        Console.Write("Informe a Descrição do Jogo: ");
                        jogo.Descricao = Console.ReadLine();
                        Console.Write("Informe o Gênero Ação [0], Aventura [1], Casual [2], Puzzle [3], Estratégia [4], Outro [5]: ");
                        jogo.Genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o Console PS4 [0], PS5 [1], Switch [2], Xbox One [3], Xbox Series [4], PC [5], Outro [6]: ");
                        jogo.Console = (TipoConsole)Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (Jogos.Alterar(jogo))
                        {
                            Console.WriteLine("Jogo Alterado");
                        }
                        else
                        {
                            Console.WriteLine($"Código {jogo.Id} não Existe");
                        }
                        Console.WriteLine("\nAperte Qualquer Tecla para Continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Listar Jogos por Nome");
                        Console.Write("\nInforme o Nome do Jogo: ");
                        String nomeJogo = Console.ReadLine();
                        Console.Clear();
                        List<Jogo> listaPorNome = Jogos.Localizar(nomeJogo);
                        foreach (var j in listaPorNome)
                        {
                            Console.WriteLine($"Código: {j.Id} - Nome: {j.Nome} - Descrição: {j.Descricao} - Gênero: {j.Genero} - Console: {j.Console}");
                        }
                        if (listaPorNome.Count < 1)
                        {
                            Console.WriteLine("Nenhum Jogo na Lista");
                        }
                        Console.WriteLine("\nAperte Qualquer Tecla para Continuar");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Listar Jogos por Gênero");
                        Console.Write("\nInforme o Gênero Ação [0], Aventura [1], Casual [2], Puzzle [3], Estratégia [4], Outro [5]: ");
                        TipoGenero genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        List<Jogo> listaGenero = Jogos.ListarPorGenero(genero);
                        foreach (var j in listaGenero)
                        {
                            Console.WriteLine($"Código: {j.Id} - Nome: {j.Nome} - Descrição: {j.Descricao} - Gênero: {j.Genero} - Console: {j.Console}");
                        }
                        if (listaGenero.Count < 1)
                        {
                            Console.WriteLine("Nenhum Jogo na Lista");
                        }
                        Console.WriteLine("\nAperte Qualquer Tecla para Continuar");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("Listar Jogos por Console");
                        Console.Write("\nInforme o Console PS4 [0], PS5 [1], Switch [2], Xbox One [3], Xbox Series [4], PC [5], Outro [6]: ");
                        TipoConsole console = (TipoConsole)Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        List<Jogo> listaConsole = Jogos.ListarPorConsole(console);
                        foreach (var j in listaConsole)
                        {
                            Console.WriteLine($"Código: {j.Id} - Nome: {j.Nome} - Descrição: {j.Descricao} - Gênero: {j.Genero} - Console: {j.Console}");
                        }
                        if (listaConsole.Count <1)
                        {
                            Console.WriteLine("Nenhum Jogo na Lista");
                        }
                        Console.WriteLine("\nAperte Qualquer Tecla para Continuar");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Listar Todos os Jogos\n");
                        foreach (var j in Jogos.Jogos)
                        {
                            Console.WriteLine($"Código: {j.Id} - Nome: {j.Nome} - Descrição: {j.Descricao} - Gênero: {j.Genero} - Console: {j.Console}");
                        }
                        Console.WriteLine("\nAperte Qualquer Tecla para Continuar");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
