using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ProjetoFinal.Controllers
{
    internal class FuncionarioController
    {
        public static bool Unique(string username,int id = -1)
        {
            List<Funcionario> usernames;
            using (var context = new CantinaContext())
            {
                if (id > 0) 
                {
                    usernames = context.Funcionarios
                    .Where(f => f.Username == username && f.Id != id)
                    .ToList();
                }
                else
                {
                    usernames = context.Funcionarios
                    .Where(f => f.Username == username)
                    .ToList();
                }
          
            }
            if(usernames.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static bool Adicionar(string nome, string username,string nif)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    Funcionario funcionario = new Funcionario()
                    {
                        Username = username,
                        Nif = nif,
                        Nome = nome
                        

                    };

                    context.Funcionarios.Add(funcionario);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors) // Percorrer os erros de validação do modelo Funcionario 
                    {
                        MessageBox.Show(" Erro: " + validationError.ErrorMessage);
                    }
                }
                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Funcionario> Get()
        {
            using (var context = new CantinaContext())
            {
                return context.Funcionarios.ToList();
            }
        }

        public static bool Editar(int id, string nome, string nif, string username)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    var funcionario = context.Funcionarios.Find(id);
                    if (funcionario == null)
                    {
                        return false;
                    }

                    funcionario.Nome = nome;
                    funcionario.Nif = nif;
                    funcionario.Username = username;

                    var entry = context.Entry(funcionario);
                    if (entry.State == EntityState.Modified) // Verificar se de facto houve alterações no objeto
                    {
                        context.SaveChanges();
                    }
                    return true;
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors) // Percorrer os erros de validação do modelo Funcionario 
                    {
                        MessageBox.Show(" Erro: " + validationError.ErrorMessage);
                    }
                }
                return false;

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return false;
            }
        }

        public static bool Apagar(int id)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    Funcionario funcionario = context.Funcionarios.Find(id);
                    context.Funcionarios.Remove(funcionario);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
