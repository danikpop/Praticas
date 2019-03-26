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
    public class SystemUser
    {
        public static void exibirInformacaoUsuario(Guid _idUsuario)
        {
            Entity entUsuario = new Entity();

            ColumnSet colunas = new ColumnSet(new string[] {"fullname",
                                                            "internalemailaddress",
                                                            "businessunitid" });

            entUsuario = Program._orgService.Retrieve("systemuser", _idUsuario, colunas);

            String nomeUsuario = entUsuario.Attributes["fullname"].ToString();
            String emailUsuario = (String)entUsuario["internalemailaddress"];
            EntityReference unidadeNegocios = (EntityReference)entUsuario["businessunitid"];



            Console.WriteLine(String.Format("Bem-vindo , {0} ({1})", nomeUsuario, emailUsuario));
            Console.WriteLine(unidadeNegocios.Name);
            Console.ReadLine();

        }

        public static void AtualizarTelefoneUsuario(Guid _idUsuario, String _numTelefone)
        {

            Entity entUsuario = new Entity("systemuser");
            entUsuario.Id = _idUsuario;

            //atualizando 
            entUsuario["homephone"] = _numTelefone;
            Program._orgService.Update(entUsuario);
            Console.WriteLine("telefone atualizado");
        }
        public static Guid ObterIdUsuario()
        {
            Guid userid = ((WhoAmIResponse)Program._orgService.Execute(new WhoAmIRequest())).UserId;
            return userid;



        }
    }

    
}
