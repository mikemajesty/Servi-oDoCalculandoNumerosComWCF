using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Host
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost servico = new ServiceHost(typeof(WCF_Serviço.OperacaoMatematicas),
                    new Uri[]
                              { new Uri("net.tcp://localhost:9090")
                              , new Uri("http://localhost:9091") }))
            {
                servico.AddServiceEndpoint(typeof(WCF_Contrato.IOperacao), new NetTcpBinding(), "Mensagem");
                servico.AddServiceEndpoint(typeof(WCF_Contrato.IOperacao), new BasicHttpBinding(), "Mensagem");

                servico.Description.Behaviors.Add(new System.ServiceModel.Description.ServiceMetadataBehavior() { HttpGetEnabled = true });

                servico.Open();
                Console.WriteLine("Host Esta Rodando, O  Serviço Esta No Ar...");
                Console.Read();
            }
        }
    }
}
