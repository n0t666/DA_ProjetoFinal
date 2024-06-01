using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ProjetoFinal
{
    internal class ProfessorController
    {
        public static bool Adicionar(string nome, string nif,string email)
        {
            try { 
            using (var context = new CantinaContext())
            {
                var professor = new Professor
                {
                    Nome = nome,
                    Nif = nif,
                    Email = email,
    
                };

                context.Professores.Add(professor);
                context.SaveChanges();
                return true;
            }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return false;
            }
        }

        public static bool Editar(int id, string nome, string nif, string email)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    var professor = context.Professores.Find(id);
                    if (professor == null)
                    {
                        return false;
                    }

                    professor.Nome = nome;
                    professor.Nif = nif;
                    professor.Email = email;

                    var entry = context.Entry(professor); 
                    if (entry.State == EntityState.Modified) // Verificar se de facto houve alterações no objeto
                    {
                        context.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return false;
            }
        }

    }
}
