using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace DA_ProjetoFinal
{
    internal class ReservaController
    {
        public static bool Adicionar(int clienteId, int menuId, List<int> pratosIds, List<int> extrasIds, int multaId = -1)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    Cliente cliente = context.Clientes.Find(clienteId);
                    Menu menu = context.Menus
                        .Include(m => m.Prato)
                        .Include(m => m.Extra)
                        .Where(m => m.Id == menuId).FirstOrDefault();
                    List<Prato> pratos = context.Pratos.Where(p => pratosIds.Contains(p.Id)).ToList();
                    List<Extra> extras = context.Extras.Where(e => extrasIds.Contains(e.Id)).ToList();
                    List<ItemFatura> items = new List<ItemFatura>();
                    Multa multa = null;
                    decimal total;

                    if (cliente is Estudante)
                    {
                        total = menu.PrecoEstudante;
                    }
                    else
                    {
                        total = menu.PrecoProfessor;
                    }

                    foreach (var extra in extras)
                    {
                        total += extra.Preco;
                        ItemFatura item = new ItemFatura()
                        {
                            Descricao = extra.Descricao, 
                            Preco = extra.Preco
                        };
                        items.Add(item);
                    }

                    if (multaId != -1)
                    {
                        multa = context.Multas.Find(multaId);
                        total += multa.Valor;
                    }

                    if (total > cliente.Saldo || cliente.Saldo - total < 0)
                    {
                        MessageBox.Show("Saldo insuficiente");
                        return false;
                    }
                    else 
                    {
                        cliente.Saldo -= total;
                        menu.Quantidade -= 1;
                    }



                    Reserva reserva = new Reserva()
                    {
                        Cliente = cliente,
                        Menu = menu,
                        Prato = pratos,
                        Extra = extras,
                        Data = DateTime.Now
                    };

                    if (multa != null)
                    {
                        reserva.Multa = multa;
                    }


                    if(MessageBox.Show("Deseja obter a fatura da reserva?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if(multa!=null)
                        {
                            FaturaController.Adicionar(total, menuId, DateTime.Now, clienteId, extras, multaId);
                        }
                        else
                        {
                            FaturaController.Adicionar(total, menuId, DateTime.Now, clienteId, extras);
                        }
                    }



                    context.Reservas.Add(reserva);
                    context.SaveChanges();

                    return true;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar reserva " + ex.Message);
            }

            return false;
        }

        public static List<Reserva> GetUser(int id)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    return context.Reservas
                        .Include(r => r.Cliente)
                        .Include(r => r.Menu)
                        .Include(r => r.Prato)
                        .Include(r => r.Extra)
                        .Include(r => r.Multa)
                        .Where(r => r.Cliente.Id == id).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter reservas do utilizador " + ex.Message);
            }

            return null;
        }

        public static bool MarcarReserva(int id)
        {

            try
            {
                using (var context = new CantinaContext())
                {
                    Reserva reserva = context.Reservas.Find(id);
                    if(reserva == null)
                    {
                        MessageBox.Show("Reserva não encontrada");
                        return false;
                    }
                    context.Reservas.Remove(reserva);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao marcar reserva " + ex.Message);
            }
            return false;
        }

    }
}
