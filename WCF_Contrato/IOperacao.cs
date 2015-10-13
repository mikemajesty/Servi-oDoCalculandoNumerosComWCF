
using System.ServiceModel;
namespace WCF_Contrato
{
    [ServiceContract]
    public interface IOperacao
    {
        [OperationContract]
        double Somar(double valor1, double valor2);
        [OperationContract]
        double Subtrair(double valor1,double valor2);
        [OperationContract]
        double Divisao(double valor1,double valor2);
        [OperationContract]
        double Multiplicacao(double valor1, double valor2);
        [OperationContract]
        string CaixaAlta(string pTexto);
        [OperationContract]
        string CaixaBaixa(string pTexto);
    }
}
