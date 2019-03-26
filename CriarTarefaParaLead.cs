using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Crm.Sdk;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using Entities;
using System.Activities;





namespace ProjTreinamento



{

    // CABEÇALHO PADRÃO PARA INICIALIZAÇÃO DE UM IPLUGIN
    public class CriarTarefaParaLead : IPlugin
    {

        public static IOrganizationService _orgService;
        public void Execute(IServiceProvider serviceProvider)
        {
            IPluginExecutionContext context =
                (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            IOrganizationServiceFactory serviceFactory =
                (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            IOrganizationService _orgservice = serviceFactory.CreateOrganizationService(context.UserId);

            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                //obtendo o target da entitdade para imput dos parametros

                Entity lead = (Entity)context.InputParameters["Target"];
                Guid leadId = lead.Id;
                String NomeLead = String.Empty;
                if (lead.Contains("fullname"))
                {
                    NomeLead =lead["fullname"].ToString();

                }

                EntityReference referenciaLead = new EntityReference(lead.LogicalName, leadId);
                //criar tarefa
                //entities.task novatarefa = new entities.task();
                //novatarefa.scheduledend = datetime.now.adddays(1);
                //novatarefa.subject = " realizar ligação";
                //novatarefa.description = " primeira ligação a ser realizada para este novo cliente potencial";
                //novatarefa.actualdurationminutes = 60;
                //_orgservice.create(novatarefa);


                // Criar tarefa segunda tentativa.
                Entity novaTarefa = new Entity("task");
                novaTarefa["scheduledend"] = (DateTime)DateTime.Now.AddDays(1);
                novaTarefa["subject"] = "Realizar ligação " + NomeLead;
                novaTarefa["description"] = " Primeira ligação a ser realizada para este novo cliente ";
                novaTarefa["regardingobjectid"] = referenciaLead;
                _orgservice.Create(novaTarefa);


            }

        }
    }
}


