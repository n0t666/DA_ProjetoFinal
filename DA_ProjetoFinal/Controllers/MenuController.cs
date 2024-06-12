using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ProjetoFinal
{
    internal class MenuController
    {

        public static List<Menu> Get()
        {
            try
            {
            using (var context = new CantinaContext())
                {
                    return context.Menus
                         .Include(m => m.Prato)  
                         .Include(m => m.Extra)  
                         .ToList();
                }
            }catch (Exception)
            {
                return null;
            }
        }

        public static List<Menu> GetBetweenDates(DateTime inicio, DateTime fim)
        {
            try { 
            using (var context = new CantinaContext())
            {
                return context.Menus
                    .Where(m => m.DataHora >= inicio && m.DataHora <= fim)
                    .Include(m => m.Prato)
                    .Include(m => m.Extra)
                    .OrderBy(m => m.DataHora)
                    .ToList();
            }
            }catch (Exception)
            {
                return null;
            }
        }

        public static bool Adicionar(DateTime dataHora,int quantidade,decimal precoEstudante,decimal precoProfessor,List<Extra>Extras,List<Prato>Pratos)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    foreach (var extra in Extras)
                    {
                        context.Extras.Attach(extra);
                    }

                    foreach (var prato in Pratos)
                    {
                        context.Pratos.Attach(prato);
                    }

                    Menu menu = new Menu
                    {
                        DataHora = dataHora,
                        Quantidade = quantidade,
                        PrecoEstudante = precoEstudante,
                        PrecoProfessor = precoProfessor,
                        Extra = Extras,
                        Prato = Pratos
                    };
                    context.Menus.Add(menu);
                    context.SaveChanges();
                }
                return true;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Os dados que introduziu não são válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool Editar(int id, DateTime dataHora, int quantidade, decimal precoEstudante, decimal precoProfessor, List<Extra> Extras, List<Prato> Pratos)
        {
            try
            {
                using (var context = new CantinaContext())
                {

                    Menu menu = context.Menus
                        .Include(m => m.Extra)
                        .Include(m => m.Prato)
                        .FirstOrDefault(m => m.Id == id);
                    menu.DataHora = dataHora;
                    menu.Quantidade = quantidade;
                    menu.PrecoEstudante = precoEstudante;
                    menu.PrecoProfessor = precoProfessor;

                    menu.Extra.Clear();
                    foreach (var extra in Extras)
                    {
                        var existingExtra = context.Extras.Find(extra.Id);
                        if (existingExtra != null)
                            menu.Extra.Add(existingExtra);
                    }

                    menu.Prato.Clear();
                    foreach (var prato in Pratos)
                    {
                        var existingPrato = context.Pratos.Find(prato.Id);
                        if (existingPrato != null)
                            menu.Prato.Add(existingPrato);
                    }

                    context.SaveChanges();
                }
                return true;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Os dados que introduziu não são válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool Apagar(int id)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    Menu menu = context.Menus.Find(id);
                    context.Menus.Remove(menu);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado ao apagar o menu", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;

        }

    }
}
