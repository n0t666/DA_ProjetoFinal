using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ProjetoFinal
{
    internal class ClienteController
    {
        private const int numeroMaximoExtrasDiario = 3;
        private const int numeroMaximoPratosDiario = 1;


        public static List<Cliente> Get()
        {
            try
            {

                using (var context = new CantinaContext())
                {
                    return context.Clientes.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static List<Cliente> GetByType(string tipo)
        {
            if (tipo == "Estudante")
            {
                using (var context = new CantinaContext())
                {
                    return context.Clientes
                        .Where(c => c is Estudante)
                        .ToList();
                }
            }
            else if (tipo == "Professor")
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

        public static bool PodeEfetuarReserva(int id, int day)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    var cliente = context.Clientes.Where(c => c.Id == id);
                    var reservas = context.Reservas
                        .Where(r => r.Cliente.Id == id && r.Menu.DataHora.Day == day)
                        .Include(r => r.Prato)
                        .Include(r => r.Extra)
                        .Include(r => r.Menu)
                        .Include(r => r.Cliente)
                        .ToList();
                    var numeroPratosReservados = reservas.Sum(r => r.Prato.Count);
                    var numeroExtrasReservados = reservas.Sum(r => r.Extra.Count);

                

                    if (numeroExtrasReservados < numeroMaximoExtrasDiario && numeroPratosReservados < numeroMaximoPratosDiario)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("O cliente já atingiu o limite de pratos e extras reservados para o dia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao verificar se o cliente pode efetuar a reserva: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;


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

                    var entry = context.Entry(cliente);
                    if (entry.State == EntityState.Modified)
                    {
                        context.SaveChanges();
                    }

                    context.SaveChanges();
                    return true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar o saldo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
