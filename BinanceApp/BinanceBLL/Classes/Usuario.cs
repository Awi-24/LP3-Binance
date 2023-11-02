using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Binance.Classes;

namespace Binance
{
    internal class Usuario : IUsuario
    {
        private string Nome { get; set; }
        string IUsuario.Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Senha { get; set; }
        string IUsuario.Senha { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static bool RegisterUser(string nome, string senha)
        {
            return false;
        }

        public static bool LoginUser(string nome, string senha)
        {
            return false;
        }
    }
}
