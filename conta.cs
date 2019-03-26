using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OperacaoBancaria
{
    class conta

    {   //atributos
        public String numeroConta;
        public String nomeCorrentista;
        public Decimal saldo;
        public Decimal saldoPoupanca;
        public conta(String _nunConta, String _nomeCorrentista)
        {
            this.numeroConta = _nunConta;
            this.nomeCorrentista = _nomeCorrentista;
            this.saldo = 0.0M;
            this.saldoPoupanca = 0.0M;
        }
        //metodos
        public Decimal Saque(Decimal _valorSaque)

        {
            if (_valorSaque > this.saldo)
            {
                throw new Exception("saldo insuficiente");

            }
            this.saldo -= _valorSaque;
            return this.saldo;

        }
        public Decimal Deposito(Decimal _valorDeposito)
        {
            this.saldo += _valorDeposito;
            return this.saldo;
        }
        public decimal Aplicação(Decimal _valorAplicação)
        {
            this.saldo -= _valorAplicação;
            this.saldoPoupanca += _valorAplicação;
            return this.saldo;
        }
        public decimal Resgate(Decimal _valorResgate)
        {
            this.saldo += _valorResgate;
            this.saldo -= _valorResgate;
            return this.saldo;
        }







        public String CriarArquivoExtrato(String caminho)
        {
            String nomeArquivo = caminho + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + "extrato.txt";


            Stream extrato = File.Open(nomeArquivo, FileMode.Create);

            extrato.Close();

            return nomeArquivo;


        }

        public void RegistrarMovimentacao(String caminho, String _movimento)
        {
            if (File.Exists(caminho))
            {


                try
                {
                    Stream extrato = File.Open(caminho, FileMode.Append);

                    StreamWriter writer = new StreamWriter(extrato);
                    writer.WriteLine(String.Format("{0} {1}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), _movimento));

                    writer.Close();

                    extrato.Close();



                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("Diretório não encontrado");

                }
                catch (AccessViolationException)
                {
                    Console.WriteLine("Acesso negado ao arquivo");


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

                //finally
                //{
                    //writer.Close();

                    //extrato.Close();

               // }




            }


        }
    }
}
