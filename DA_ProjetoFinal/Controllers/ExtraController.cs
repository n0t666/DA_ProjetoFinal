using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ProjetoFinal
{
    internal class ExtraController
    {
        public static bool Adicionar(string descricao, decimal preco,bool ativo)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    Extra extra = new Extra()
                    {
                        Descricao = descricao,
                        Preco = preco,
                        Ativo = ativo
                        
                    };

                    context.Extras.Add(extra);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
               MessageBox.Show("Erro ao adicionar o extra");
                return false;
            }
        }

        public static List<Extra> Get()
        {
            using (var context = new CantinaContext())
            {
                return context.Extras.ToList();
            }
        }
    

        public static int ObterNumero()
        {
            using (var context = new CantinaContext())
            {
                return context.Extras.Count();
            }
        }

        public static bool Apagar(int id)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    Extra extra = context.Extras.Find(id);
                    context.Extras.Remove(extra);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao apagar o extra");
                return false;
            }
        }

        public static bool Editar(int id, string descricao, decimal preco, bool ativo)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    Extra extra = context.Extras.Find(id);
                    extra.Descricao = descricao;
                    extra.Preco = preco;
                    extra.Ativo = ativo;
                    var entry = context.Entry(extra);
                    if (entry.State == EntityState.Modified) // Verificar se de facto houve alterações no objeto
                    {
                        context.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception)
            {
               MessageBox.Show("Erro ao editar o extra");
            }
            return false;
        }
    }
}
