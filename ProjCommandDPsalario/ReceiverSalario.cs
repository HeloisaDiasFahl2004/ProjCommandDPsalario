using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCommandDPsalario
{
    internal class ReceiverSalario //Chef
    {
        //executar os pedidos
       
        public void AumentarSalario(string nome,float salario,float valor)
        {
            Console.WriteLine("Salário de " + nome + " atual R$" + salario);
            salario = salario + valor;
            Console.WriteLine("Salário de "+nome+" aumentou em: R$"+valor);
            Console.WriteLine("Salário de "+nome+" reajustado: R$"+salario);
        }
        
    }
}
