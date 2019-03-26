using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;
using Microsoft.Crm.Sdk.Messages;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Tooling.Connector;
using Microsoft.Xrm.Sdk.Query;


namespace BuscandoArquivos.DAO
{
    class Program
    {
        public static IOrganizationService _orgService;
        static void Main(string[] args)
        {
            Console.WriteLine("conectando...", DateTime.Now.ToString(("HH:mm:ss")));
            try
            {
                //email trial dynamics 30 dias
                String connectionString = @"Url=https://testesmart9.api.crm2.dynamics.com/; 
            		Username = danielruy@testesmart9.onmicrosoft.com; 
            		Password = Temp@2019; authtype=Office365";


                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                CrmServiceClient getCrmServiceClient = new CrmServiceClient(connectionString);
                _orgService = (IOrganizationService)getCrmServiceClient.OrganizationWebProxyClient != null
                        ? (IOrganizationService)getCrmServiceClient.OrganizationWebProxyClient
                        : (IOrganizationService)getCrmServiceClient.OrganizationServiceProxy;

                if (Program._orgService == null)
                {
                    throw new Exception();

                }
            }             
                
             catch(Exception ex)
            {
                Console.WriteLine("Não foi possivel conectar ao duynamics." + ex.Message);
                Console.ReadLine();
                System.Environment.Exit(0);
            }


            Guid userid = DAO.SystemUser.ObterIdUsuario();
            Console.WriteLine(userid.ToString());

            DAO.SystemUser.exibirInformacaoUsuario(userid);          


            //atualizar
            DAO.SystemUser.AtualizarTelefoneUsuario(userid, "(11)970761743");

            //obter leads

            DAO.Lead.ObterLeads();
            Console.WriteLine("Digite o email de busca");
            String Email = Console.ReadLine();
            DAO.Lead.ObterLeadsFetchXML(Email);
            Console.ReadKey();


        }



    }
}




