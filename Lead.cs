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
    public class Lead
    {
        public static void ObterLeads()
        {
            Console.WriteLine("carregando clientes potenciais...");

            QueryExpression consultaLead = new QueryExpression("lead");
            consultaLead.ColumnSet.AddColumns("firstname", "lastname");
            EntityCollection leads = new EntityCollection();

            leads = Program._orgService.RetrieveMultiple(consultaLead);


            Int32 quantidadeRegistros = leads.Entities.Count;

            foreach (Entity registroLead in leads.Entities)
            {
                Console.WriteLine(registroLead.Attributes["firstname"].ToString());


            }


            Console.WriteLine(String.Format("total de clientes potencieias : {0}", quantidadeRegistros));

        }

        public static void ObterLeadsFetchXML()
        {
            String XML = @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='lead'>
    <attribute name='fullname' />
    <attribute name='leadid' />
    <attribute name='emailaddress1' />
    <attribute name='telephone1' />
    <order attribute='fullname' descending='true' />
  </entity>
</fetch>";
            EntityCollection result = Program._orgService.RetrieveMultiple(new FetchExpression(XML));

            foreach (Entity lead in result.Entities)

            {
                String nome = "";
                String telefone = "";
                String email = "";

                if (lead.Contains("fullname"))
                {
                    nome = lead["fullname"].ToString();

                }

                if (lead.Contains("emailaddress1"))
                {
                    email = lead["emailaddress1"].ToString();

                }
                if (lead.Contains("telephone1"))
                {
                    telefone = lead["telephone1"].ToString();

                }
                Console.WriteLine(String.Format("\nNome:{0}", nome));
                Console.WriteLine(String.Format("\nNome:{0}", email));
                Console.WriteLine(String.Format("\nNome:{0}", telefone));



            }
            Console.ReadKey();

        }
        public static void ObterLeadsFetchXML(String _email)
        {
            String XML = @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                            <entity name='lead'>
                            <attribute name='fullname' />
                            <attribute name='leadid' />
                            <attribute name='telephone1' />
                            <attribute name='emailaddress1' />
                            <order attribute='fullname' descending='true' />
                            <filter type='and'>
                            <condition attribute='emailaddress1' operator='eq' value=" + _email +@"/>
                            </filter>
                            </entity>
                            </fetch>";
            EntityCollection emailResult = Program._orgService.RetrieveMultiple(new FetchExpression(XML));

            foreach (Entity lead in emailResult.Entities)

            {
                String nome = String.Empty;
                String telefone = String.Empty;
                String email = String.Empty;

                if (lead.Contains("fullname"))
                {
                    nome = lead["fullname"].ToString();

                }

                if (lead.Contains("emailaddress1"))
                {
                    email = lead["emailaddress1"].ToString();

                }
                if (lead.Contains("telephone1"))
                {
                    telefone = lead["telephone1"].ToString();

                }
                Console.WriteLine(String.Format("\nNome:{0}", nome));
                Console.WriteLine(String.Format("\nNome:{0}", email));
                Console.WriteLine(String.Format("\nNome:{0}", telefone));


                Console.ReadLine();
            }
            

        }
    }
}
