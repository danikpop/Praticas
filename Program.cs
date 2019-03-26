using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OperacaoBancaria
{
    class Program
    {

        public static String caminhoExtrato;




        static void Main(string[] args)
        {
            conta conta = new conta("7662/7", "Daniel C. Ruy");

            caminhoExtrato = conta.CriarArquivoExtrato("C:\\Users\\daniel.ruy\\Desktop\\");

            //conta.numeroConta = "7662/7";
            //conta.nomeCorrentista = "Daniel C. Ruy";
            //conta.saldo = 0.00M;
            Console.WriteLine(String.Format("Bem-Vindo , {0} \nConta número: {1}",
            conta.nomeCorrentista, conta.numeroConta));
            Console.WriteLine(String.Format("\nSeu saldo atual é de : {0}", conta.saldo));

            // usuario seleciona operaçãp

            int resposta = 0;

            do
            {
                Console.WriteLine("Selecione a opção que deseja realizar \n1 Fazer saque  \n2 Fazer deposito  \n3 Fazer aplicação  \n4 Fazer resgate");
                resposta = int.Parse(Console.ReadLine());
                //while (resposta != 5)
                switch (resposta)
                {
                    case 1:
                        {
                            Console.WriteLine("insira o valor de saque.");
                            Decimal valor = 0.0M;
                            Decimal saldo = 0.0M;
                            
                            try
                            {
                               valor = Decimal.Parse(Console.ReadLine());
                                saldo = conta.Saque(valor);
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                conta.RegistrarMovimentacao(caminhoExtrato, ex.Message);

                            }
                            Console.WriteLine(saldo.ToString());
                            // saldo = conta.Saque(valor); 

                            conta.RegistrarMovimentacao(caminhoExtrato, String.Format("saque realizado no valor de {0}\t\t\t{01}", valor, saldo));

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("insira o valor de deposito.");
                            Decimal valor = Decimal.Parse(Console.ReadLine());
                            Decimal saldo = conta.Deposito(valor);
                            Console.WriteLine(saldo.ToString());
                            // conta.Deposito(valor);
                            conta.RegistrarMovimentacao(caminhoExtrato, String.Format("deposito realizado no valor de {0}\t\t\t{01}", valor, saldo));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Insira o valor da sua aplicação Conta corrente / Conta poupança");
                            Decimal valor = Decimal.Parse(Console.ReadLine());
                            Decimal saldo = conta.Aplicação(valor);
                            Console.WriteLine(saldo.ToString());
                            conta.RegistrarMovimentacao(caminhoExtrato, String.Format("aplicãção realizado no valor de {0}\t\t\t{01}", valor, saldo));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Insira o valor do seu Resgate\n" +
                            "Conta poupança/Conta corrente");
                            Decimal valor = Decimal.Parse(Console.ReadLine());
                            Decimal saldo = conta.Resgate(valor);
                            Console.WriteLine(saldo.ToString());
                            conta.RegistrarMovimentacao(caminhoExtrato, String.Format("resgate realizado no valor de {0}\t\t\t{01}", valor, saldo));
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("opção invalida!");
                            break;
                        }
                }
            } while (resposta != 6);

        }
    }
}
