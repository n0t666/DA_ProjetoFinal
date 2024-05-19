using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ProjetoFinal
{
    internal class ClienteController
    {
        public static List<Cliente> GetClientes()
        {
            using (var context = new CantinaContext())
            {
                return context.Clientes.ToList();
            }
        }
    }
}
