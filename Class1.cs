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


    public class Class1 : CodeActivity
    {

        [Input("Percentual comissao")]
        public InArgument<Decimal> In_PctComissao { get; set; }


        [Input("Valor total")]
        public InArgument<Money> In_Valor_Total { get; set; }


        [Output("Valor Comissão")]
        public OutArgument<Money> Out_ValorComissao { get; set; }




        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context =
                executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory =
                executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService orgService =
                serviceFactory.CreateOrganizationService(context.InitiatingUserId);


            Money valorTotal = executionContext.GetValue<Money>(In_Valor_Total);
            Decimal pctComissao = executionContext.GetValue<Decimal>(In_PctComissao);
            Money ValorComissao = new Money(0);


            if (pctComissao >= 0)
            {
                ValorComissao.Value = valorTotal.Value * (pctComissao / 100);
            }

            else
            {
                throw new InvalidPluginExecutionException("comissao não pode ser negativa");
            }
            executionContext.SetValue(Out_ValorComissao, ValorComissao);



        }
    }
}