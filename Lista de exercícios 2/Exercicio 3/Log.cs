using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    public class Log
    {

        private static int codTransacao;
        
        public int CodTransacao
        { get; private set; }

        private DateTime dataHora = DateTime.Now;

        List<string?>? historico;

        public Log()
        {
            historico = new List<string?>();
        }

        public void SaqueLog(Funcionario fun, double valor)
        {
            codTransacao++;
            string logS = $"Saque realizado por: [{fun.Nome} ID: {fun.fId}] \n Dia: {dataHora} \n No valor de R${valor} \n Código da Transação {codTransacao}";

            Console.WriteLine(logS);

            AddLog(logS);
        }

        public void DepositoLog(Funcionario fun, double valor)
        {
            codTransacao++;
            string logD = $"Deposito realizado por: [{fun.Nome} ID: {fun.fId}] \n Dia: {dataHora} \n No valor de R${valor} \n Código da Transação {codTransacao}";
            
            Console.WriteLine(logD);

            AddLog(logD);
        }

        private void AddLog(string log)
        {
            historico.Add(log);
        }

    }
}
