using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Crm.Sdk;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using Entities;

namespace ProjTreinamento.Plugins
{
    public class AgendaReuniao : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            IPluginExecutionContext context =
                (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            IOrganizationServiceFactory serviceFactory =
                (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            IOrganizationService _orgservice = serviceFactory.CreateOrganizationService(context.UserId);

            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {

                DateTime dataAtual = DateTime.Now;
                DateTime dataReuniao = new DateTime();

                switch (dataAtual.DayOfWeek)
                {
                    case (DayOfWeek.Friday):
                        {
                            dataReuniao = dataAtual.AddDays(3); break;
                        }
                    case (DayOfWeek.Saturday):
                        {
                            dataReuniao = dataAtual.AddDays(2); break;

                        }

                    case (DayOfWeek.Sunday):
                        {
                            dataReuniao = dataAtual.AddDays(1); break;

                        }


                    default:
                        {
                            dataReuniao = dataAtual.AddDays(1);break;
                               
                        }

                }
                Entity oportunidade = (Entity)context.InputParameters["target"];
                EntityReference enrOportunidade = new EntityReference(oportunidade.LogicalName, oportunidade.Id);


                Entity reuniao = new Entity("appointment");
                reuniao["regardinobjectid"] = enrOportunidade;
                reuniao["subject"] = "Apresentação do Produto";
                reuniao["scheduledend"] = dataReuniao;
                _orgservice.Create(reuniao);
            }



        }


    }

        
}

    

