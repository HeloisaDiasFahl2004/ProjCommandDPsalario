using System;

namespace ProjCommandDPsalario
{
    internal class Program
    {
        static void Main(string[] args) //client 
        {
            //parâmetros fixos
            var receiver = new ReceiverSalario();
            CommandSalario command = new CommandSalario(receiver,"Heloísa", 1200,200);
            Invoke invoke = new Invoke();
            ExecutaInvoke(receiver, command, invoke);

          //parâmetros digitados
            receiver = new ReceiverSalario();
            Console.Write("Nome: ");
            string n= Console.ReadLine();
            Console.Write("Salário Atual: ");
            float s = float.Parse(Console.ReadLine());
            Console.Write("Valor reajuste: ");
            float v = float.Parse(Console.ReadLine());  
            command = new CommandSalario(receiver, n,s, v);
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
