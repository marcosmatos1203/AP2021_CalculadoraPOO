using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCalculadoraPOO
{
    class CalculadoraDados
    {
        private double numero1, numero2, resultado;
        private string operador;

 
        public CalculadoraDados(){}

        public CalculadoraDados(double numero1, double numero2, double resultado, string operador)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
            this.resultado = resultado;
            this.Operador = operador;
        }

        public double Numero1 { get => numero1; set => numero1 = value; }
        public double Numero2 { get => numero2; set => numero2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }
        public string Operador { get => operador; set => operador = value; }
    }
}
