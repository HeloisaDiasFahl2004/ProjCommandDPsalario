using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCommandDPsalario
{
    internal interface ICommand
    {
        //assinatura dos métodos
        void Executar();
    }
}
