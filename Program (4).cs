using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Entities;
using Microsoft.Xrm.Tooling.Connector;
using System.Runtime.Serialization;
using System.IO;



namespace ImportaLeadNovo
{
    class Program

    {

        private static IOrganizationService _orgService;
        static void Main(string[] args)
        {

            string connectionString = @"url =https://testesmart9.api.crm2.dynamics.com;
            Username = danielruy@testesmart9.onmicrosoft.com;
            Password = Temp@2019;
            authtype = Office365";

            CrmServiceClient orgService = new CrmServiceClient(connectionString);
            
           
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            CrmServiceClient getcrmServiceClient = new CrmServiceClient(connectionString);_orgService = (IOrganizationService)getcrmServiceClient.OrganizationWebProxyClient != null ? (IOrganizationService)getcrmServiceClient.OrganizationWebProxyClient : (IOrganizationService)getcrmServiceClient.OrganizationServiceProxy;

            if (orgService != null)
            {
                Guid userid = ((WhoAmIResponse)orgService.Execute(new WhoAmIRequest())).UserId;
                Console.WriteLine(userid.ToString());

            }


            Console.WriteLine("digite o caminho do arquivo:");
            String caminho = Console.ReadLine();

            StreamReader arquivo = new StreamReader(caminho);
            String linha;
            

            while(( linha = arquivo.ReadLine()) != null)
            {
                String linhaseparada = linha.Split(';');
                cadastro(linhaseparada[0], linhaseparada[1], linhaseparada[2], linhaseparada[3]);

            }
            string linha = null;
            string[] linhaLeitura = linha.Split(';');
            preencher(linhaLeitura[0], linhaLeitura[1], linhaLeitura[2], linhaLeitura[3]);          

            




            Console.ReadKey();

        }


        public static void preencher(String nome, String sobrenome, String email, String telefone)
        {



            Lead novoLead = new Lead();

            novoLead.FirstName = nome;

            novoLead.LastName = sobrenome;

            novoLead.EMailAddress1 = email;

            novoLead.Telephone1 = telefone;

            Guid idLead = _orgService.Create(novoLead);
            Console.WriteLine("Lead criado com sucesso!", novoLead.ToString());

        }
    }
}
