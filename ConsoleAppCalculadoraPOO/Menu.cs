using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCalculadoraPOO
{
    class Menu
    {
        private string opcaoMenu;

        public string OpcaoMenu { get => opcaoMenu; set => opcaoMenu = value; }

        public void MostrarMenu()
        {
            Console.WriteLine("Calculadora 4 operações");
            Console.WriteLine();
            Console.WriteLine("Digite 1 para somar");
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine("Digite 3 para multiplicação");
            Console.WriteLine("Digite 4 para divisão");
            Console.WriteLine("Digite 5 para visualizar as operações realizadas");
            Console.WriteLine();
            Console.WriteLine("Digite S para sair");
        }
        public bool EhOpcaoSair(string opcao)
        {
            return opcao.Equals("s", StringComparison.OrdinalIgnoreCase);
        }
        public bool EhOpcaoDeMenuInvalida(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "3"
                                && opcao != "4" && opcao != "5"
                                && opcao != "S" && opcao != "s";
        }
        
    }
}
