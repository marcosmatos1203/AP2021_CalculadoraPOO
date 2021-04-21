using System;

namespace ConsoleAppCalculadoraPOO
{
    class Program
    {
        #region Requisito Funcional 01 [OK]
        //Nossa calculadora deve ter a possibilidade de somar dois números
        #endregion

        #region Requisito Funcional 02 [OK]
        //Nossa calculadora deve ter a possibilidade fazer várias operações de soma
        #endregion

        #region Requisito Funcional 03 [OK]
        //Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração
        #endregion

        #region Requisito Funcional 04 [OK]
        //Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática
        #endregion

        #region Requisito Funcional 05 [OK]
        //Nossa calculadora deve validar a opções do menu [OK]
        #endregion

        #region Requisito Funcional 06 [OK]
        /** Nossa calculadora deve permitir visualizar as operações já realizadas
         *  Critérios:
         *      1 - A descrição da operação realizada deve aparecer assim, exemplo:
         *          2 + 2 = 4
         *          10 - 5 = 5
         *          
         *      2 - Caso não nehuma operação foi realizada, mostrar a msg:
         *          Nehuma operação foi realizada ainda
         */
        #endregion

        static void Main(string[] args)
        {
            CalculadoraMetodos metodosCalculadora = new CalculadoraMetodos();
            CalculadoraDados dadosCalculadora = new CalculadoraDados();
            Menu menu = new Menu();

            while (true)
            {
                menu.MostrarMenu();
                menu.OpcaoMenu = Console.ReadLine();
                if (menu.EhOpcaoDeMenuInvalida(menu.OpcaoMenu))
                { ApresentaMensagemIncorreta("Opção inválida Tente novamente"); continue; }

                metodosCalculadora.RetornaSimboloOperacao(menu.OpcaoMenu);

                if (menu.OpcaoMenu == "5")
                {
                    Console.Clear();
                    if (metodosCalculadora.EhListaVazia())
                        ApresentaMensagemIncorreta("Nenhuma operação realizada");
                    else
                        metodosCalculadora.ApresentaOperacoesRealizadas();

                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                if (menu.EhOpcaoSair(menu.OpcaoMenu))
                    break;

                Console.WriteLine("Digite o primeiro número");
                dadosCalculadora.Numero1 = Convert.ToDouble(Console.ReadLine());

                do
                {
                    Console.WriteLine("Digite o segundo número");
                    dadosCalculadora.Numero2 = Convert.ToDouble(Console.ReadLine());

                    if (metodosCalculadora.EhDivisaoPorZero(menu.OpcaoMenu, dadosCalculadora.Numero2))
                        ApresentaMensagemIncorreta("Impossível dividir por Zero");

                } while (menu.OpcaoMenu == "4" && dadosCalculadora.Numero2 == 0);

                switch (menu.OpcaoMenu)
                {
                    case "1": metodosCalculadora.Somar(dadosCalculadora.Numero1, dadosCalculadora.Numero2); break;
                    case "2": metodosCalculadora.Diminuir(dadosCalculadora.Numero1, dadosCalculadora.Numero2); break;
                    case "3": metodosCalculadora.Multiplicar(dadosCalculadora.Numero1, dadosCalculadora.Numero2); break;
                    case "4": metodosCalculadora.Dividir(dadosCalculadora.Numero1, dadosCalculadora.Numero2); break;

                    default: break;
                }

                metodosCalculadora.AdicionaOperacaoNaLista(dadosCalculadora.Numero1, dadosCalculadora.Numero2);
                Console.WriteLine(metodosCalculadora.ApresentaResultadoDaOperacao(dadosCalculadora.Numero1, dadosCalculadora.Numero2));
                Console.ReadLine();
                Console.Clear();
            }
        }
        public static void ApresentaMensagemIncorreta(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(mensagem);

            Console.ResetColor();

            Console.ReadLine();

            Console.Clear();
        }
    }

}
