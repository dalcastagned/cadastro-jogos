using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeJogos
{

    public enum TipoGenero { Acao, Aventura, Casual, Puzzle, Estrategia, Outro}
    public enum TipoConsole {  PS4, PS5, Switch, XboxOne, XboxSeries, PC, Outro}
    public class Jogo
    {

        public Jogo()
        {
            Id = 1;
            Nome = "";
            Descricao = "";
            Genero = TipoGenero.Outro;
            Console = TipoConsole.Outro;
        }

        public Jogo(int id, String nome, String descricao, TipoGenero genero, TipoConsole console)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Genero = genero;
            Console = console;
        }

        private int id;

        public int Id
        {
            get { return id; }
            set {
                if (value > 0) id = value;
                else
                {
                    throw new Exception("Permitido apenas números positivos!!!");
                }
            }
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private String descricao;

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value.ToUpper(); }
        }

        public TipoConsole Console { get; set; }

        public TipoGenero Genero { get; set; }
    }
}
