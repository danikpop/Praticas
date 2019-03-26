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
using Microsoft.Xrm.Sdk.Workflow;


namespace ProjTreinamento.Workflows
{

    
    public class ObterProximoDiaUtil  : CodeActivity
    {

        [Input("Data Inicial")]
        public InArgument<DateTime> In_DataInicial { get; set; }




        [Output("Data calculada")]
        public OutArgument<DateTime> Out_DataCalculada { get; set; }




        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context =
                executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory =
                executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService orgService =
                serviceFactory.CreateOrganizationService(context.InitiatingUserId);


            DateTime dataInicial = executionContext.GetValue<DateTime>(In_DataInicial);
            
           
            DateTime dataCalculada = new DateTime();

            switch (dataInicial.DayOfWeek)
            {
                case (DayOfWeek.Friday):
                    {
                        dataCalculada = dataInicial.AddDays(2); break;
                    }
                case (DayOfWeek.Saturday):
                    {
                        dataCalculada = dataInicial.AddDays(2); break;

                    }

                default:
                    {
                        dataCalculada = dataInicial.AddDays(1); break;

                    }




            }

            DateTime dataHoraCalculada = new DateTime(dataCalculada.Year,
                                                        dataCalculada.Month,
                                                        dataCalculada.Day,
                                                        9, 0, 0);

            executionContext.SetValue(Out_DataCalculada, dataHoraCalculada);

        }

    }
}

