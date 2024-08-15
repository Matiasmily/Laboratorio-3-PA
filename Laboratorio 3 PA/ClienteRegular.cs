using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3_PA
{
    public class Cliente_Regular : Clientes
    {
        public Cliente_Regular(string nombre, string correo, string telefono) : base(nombre, correo, telefono)
        {
        }
    }
}
