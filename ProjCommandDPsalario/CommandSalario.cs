using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjCommandDPsalario
{
    internal class CommandSalario : ICommand //Bloco de Notas
    {
        //possue os detalhes do pedido
        public ReceiverSalario Receiver { get; set; }
        public string Nome { get; set; }
        public float SalarioAtual { get; set; }
        public float Valor { get; set; }

     
        public CommandSalario(ReceiverSalario receiver,string nome,float salarioAtual, float valor)
        {
            this.Nome = nome;
            this.Receiver = receiver;
            this.SalarioAtual = salarioAtual;
            this.Valor = valor;
        }
        public void Executar()
        {
            this.Receiver.AumentarSalario(Nome,SalarioAtual,Valor);
        }
    }
}
