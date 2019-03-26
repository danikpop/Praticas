using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using System.ServiceModel.Description;
using Microsoft.Crm.Sdk.Messages;
using System.Runtime.Serialization;
using Entities;






namespace ImportaLead
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrganizationService orgService = null;

            Uri serviceUri = new Uri("https://testesmart9.api.crm2.dynamics.com/XRMServices/2011/Organization.svc");
            string userName = "danielruy@testesmart9.onmicrosoft.com";
            string password = "Temp@2019";

            // gera as credenciais

            ClientCredentials credentials = new ClientCredentials();
            credentials.UserName.UserName = userName;
            credentials.UserName.Password = password;
     

            // gerar serviço de organização
            OrganizationServiceProxy serviceProxy = new OrganizationServiceProxy(serviceUri, null, credentials, null);
            serviceProxy.EnableProxyTypes();
            orgService = (IOrganizationService)serviceProxy;


            //retornar guid do usuario atual

            Guid idUsuario = new Guid();
            idUsuario = ((WhoAmIResponse)orgService.Execute(new WhoAmIRequest())).UserId;

            Console.WriteLine(idUsuario.ToString());


            ////criar leads (Late Bound)
            //Entity novoLead = new Entity("lead");
            //novoLead.Attributes["firstname"] = "Daniel";
            //novoLead.Attributes["lastname"] = "Costa Ruy";
            //novoLead["emailaddress1"] = "daniel.ruy@smartconsulting.com.br";
            //novoLead["telephone1"] = "(11) 3000-0003";
            //Guid idNovoLead = orgService.Create(novoLead);


            //Console.WriteLine("lead criado com sucesso!" + idNovoLead.ToString());


            //Entity atualizalead = new Entity("lead", idNovoLead);
            //atualizalead["subject"] = "Novo Cliente Elton";
            //orgService.Update(atualizalead);       

            ////criar leads(Early Bound)

            Lead novoLead = new Lead();
            novoLead.FirstName = "Daniel";
            novoLead.LastName = "Costa Ruy";
            novoLead.EMailAddress1 = "daniel.costa.ruy@outlook.com";
            novoLead.Telephone1 = "(11)4789-1385";

            Guid idLead = orgService.Create(novoLead);
            Console.WriteLine("Lead criado com sucesso!", novoLead.ToString());










            Console.ReadKey();








        }
    }
}
