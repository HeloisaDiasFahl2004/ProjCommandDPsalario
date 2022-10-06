using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCommandDPsalario
{
    internal class Invoke //Garçom
    {
        //passa um pedido pra um receptor indiretamente, através da execução de um comando
        public List<ICommand> Commands { get; set; }
        public ICommand Command { get; set; }
        public Invoke()
        {
            Commands = new List<ICommand>();
        }
        public void DeterminarComando(ICommand command) => Command = command;
        public void Invocar()
        {
            Commands.Add(Command);
            Command.Executar();
        }
       
    }
}
