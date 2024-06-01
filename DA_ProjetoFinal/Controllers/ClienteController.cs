using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ProjetoFinal
{
    internal class ClienteController
    {
        public static List<Cliente> Get()
        {
            using (var context = new CantinaContext())
            {
                return context.Clientes.ToList();
            }
        }

        public static List<Cliente> GetByType(string tipo)
        {
            if(tipo == "Estudante")
            {
                using (var context = new CantinaContext())
                {
                    return context.Clientes
                        .Where(c => c is Estudante)
                        .ToList();
                }
            }
            else if(tipo == "Professor")
            {
                using (var context = new CantinaContext())
                {
                    return context.Clientes
                        .Where(c => c is Professor)
                        .ToList();
                }
            }
            else
            {
                return null;
            }
        }

        public static bool Apagar(int id)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    var cliente = context.Clientes.Find(id);
                    if (cliente == null)
                    {
                        return false;
                    }
                    context.Clientes.Remove(cliente);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool CarregarSaldo(int id, decimal valor)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    var cliente = context.Clientes.Find(id);
                    if (cliente == null)
                    {
                        return false;
                    }
                    cliente.Saldo += valor;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
