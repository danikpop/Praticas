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
using Microsoft.Xrm.Sdk.Query;

namespace ProjTreinamento.Plugins
{

    // Esboço padrão para construção de plugin c# for dynamics 
    //sempre declarando na classe : IPlugin  , criando o metodo publico statico de _orgService com IOrganizationService 
    // 
    public class NaoVendaClienteInativo : IPlugin
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
                

                //contexto da venda = criando entydade venda.
                Entity venda = (Entity)context.InputParameters["Target"];


                //obtendo id da conta
                EntityReference enrConta = (EntityReference)venda["smart_lp_conta"];




                //smart_lp_conta = registro de criação do processo do dyncamics , congiguração daquele new_ para smart_ 

                // verificar status da conta 

                //orgService.Retrieve = Retrive recupera dados de um lugar , no caso por conta estar pegando seu nome logico e buscando seu ID , automaticamente ao criar um novo columSet , ao declara statuscode como busca 
                Entity conta = _orgService.Retrieve(enrConta.LogicalName, enrConta.Id, new ColumnSet("statuscode"));
                OptionSetValue statusConta = (OptionSetValue)conta["statuscode"];


                // Entity = Entidade , OptionSetValue = Nome declarado para um conjunto de opções do dynamics 
                // statuscode = nome nativa de um campo do formulario do dynamics
                // columset  é uma coluna , como se ele tivesse criando uma tabela no plugin onde a tabela ja existe no dynamics e acionando somente o campo desejado



                //verificar status da conta , na criação do registro da venda

                if(statusConta.Value ==1)
                {

                    //declarando  invalidação 
                    throw new InvalidPluginExecutionException("A conta está inativa");


                }

            }
        }
    }
}