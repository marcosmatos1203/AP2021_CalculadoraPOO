using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCalculadoraPOO
{
    class CalculadoraMetodos
    {
        CalculadoraDados dadosCalculadora = new CalculadoraDados();
        Menu menu = new Menu();

        private ArrayList listaResultado = new ArrayList();
        public string RetornaSimboloOperacao(string operador)
        {
            if (operador == "1")
                dadosCalculadora.Operador = "+";
            else if (operador == "2")
                dadosCalculadora.Operador = "-";
            else if (operador == "3")
                dadosCalculadora.Operador = "*";
            else if (operador == "4")
                dadosCalculadora.Operador = "/";

            return dadosCalculadora.Operador;
        }
        public string ApresentaResultadoDaOperacao(double n1, double n2)
        {
            return 
                $"{n1} {dadosCalculadora.Operador} {n2} = {dadosCalculadora.Resultado}";
        }
        public void AdicionaOperacaoNaLista(double n1, double n2)
        {
            ListaResultado.Add(
                $"{n1} {dadosCalculadora.Operador} {n2} = {dadosCalculadora.Resultado}");
        }
        public double Somar(double n1, double n2)
        {
            dadosCalculadora.Resultado = n1 + n2;
            return dadosCalculadora.Resultado;
        }
        public double Diminuir(double n1, double n2)
        {
            dadosCalculadora.Resultado = n1 - n2;
            return dadosCalculadora.Resultado;
        }
        public double Multiplicar(double n1, double n2)
        {
            dadosCalculadora.Resultado = n1 * n2;
            return dadosCalculadora.Resultado;
        }
        public double Dividir(double n1, double n2)
        {
            dadosCalculadora.Resultado = n1 / n2;
            return dadosCalculadora.Resultado;
        }
        public void ApresentaOperacoesRealizadas()
        {
            Console.WriteLine();
            Console.WriteLine("Operações Realizadas");
            for (int i = 0; i < ListaResultado.Count; i++)
            {
                Console.WriteLine(ListaResultado[i]);
            }
        }
        
        public bool EhListaVazia()
        {
            return ListaResultado.Count == 0;
        }
        public bool EhDivisaoPorZero(string op, double n2)
        {
            return op == "4" && n2 == 0;
        }
        
        public ArrayList ListaResultado { get => listaResultado; set => listaResultado = value; }
    }
}
