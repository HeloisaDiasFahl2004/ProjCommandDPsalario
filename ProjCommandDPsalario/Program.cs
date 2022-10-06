using System;

namespace ProjCommandDPsalario
{
    internal class Program
    {
        static void Main(string[] args) //client 
        {
            
            var receiver = new ReceiverSalario();
            CommandSalario command = new CommandSalario(receiver,"Heloísa", 1200,200);
            Invoke invoke = new Invoke();
            ExecutaInvoke(receiver, command, invoke);

            receiver = new ReceiverSalario();
            command = new CommandSalario(receiver, "Roberta", 1200, 800);
            invoke = new Invoke();
            ExecutaInvoke(receiver, command, invoke);
        }
        static void ExecutaInvoke(ReceiverSalario receiver, CommandSalario command, Invoke invoke)
        {
            invoke.DeterminarComando(command);
            invoke.Invocar();
        }
    }
}
