using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.Classes
{
    internal interface IUsuario
    {
        string Nome { get; set; }
        string Senha { get; set; }
    }
}
