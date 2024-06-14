using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DA_ProjetoFinal
{
    internal class ReservaController
    {
        public static bool Adicionar(int clienteId, int menuId, List<int> pratosIds, List<int> extrasIds)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    Cliente cliente = context.Clientes.Find(clienteId);
                    Menu menu = context.Menus.Find(menuId);
                    List<Prato> pratos = context.Pratos.Where(p => pratosIds.Contains(p.Id)).ToList();
                    List<Extra> extras = context.Extras.Where(e => extrasIds.Contains(e.Id)).ToList();
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
                    }

                    if(total > cliente.Saldo || cliente.Saldo - total < 0)
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
                        Extra = extras
                    };


                    context.Reservas.Add(reserva);
                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

    }
}
