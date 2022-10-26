using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class ExpressaoNumerica
    {

        private string primeiroValor = null;
        private string segundoValor = null;
        private string operador = null;
        private string Expressao = null;

        public string PrimeiroValor { get => primeiroValor; set => primeiroValor = value; }

        public string Operador { get => operador; set => operador = value; }

        public string SegundoValor { get => segundoValor; set => segundoValor = value; }


        private void Operacao()
        {

            if( operador == "X")
                operador = "*";

            this.Expressao = this.primeiroValor.ToString().Replace(',', '.') + this.operador + this.segundoValor.ToString().Replace(',', '.');
        }

        public string calcular()
        {
            Operacao();
            return new DataTable().Compute(Expressao, null).ToString();
        }


        public void ResetarValores()
        {
            this.primeiroValor = null;
            this.segundoValor = null;
            this.operador = null;
        }

    }
}
