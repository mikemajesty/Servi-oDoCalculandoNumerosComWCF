using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_Contrato;

namespace WCF_Serviço
{
    public class OperacaoMatematicas : IOperacao
    {

        public double Somar(double valor1, double valor2)
        {
            double final = valor1 + valor2;
            return final;
        }

        public double Subtrair(double valor1, double valor2)
        {
            double final = valor1 - valor2;
            return final;
        }

        public double Divisao(double valor1, double valor2)
        {
            double final = valor1 / valor2;
            return final;
        }

        public double Multiplicacao(double valor1, double valor2)
        {
            double final = valor1 * valor2;
            return final;
        }

        public string CaixaAlta(string pTexto)
        {
            return pTexto.ToUpper();
        }

        public string CaixaBaixa(string pTexto)
        {
            return pTexto.ToLower();
        }
    }
}
