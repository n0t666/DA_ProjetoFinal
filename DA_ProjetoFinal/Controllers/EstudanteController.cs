using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ProjetoFinal
{
    internal class EstudanteController
    {
        public static bool Adicionar(string nome, string nif,string numEstudante)
        {
            try
            {
            using (var context = new CantinaContext())
                {
                var estudante = new Estudante
                {
                    Nome = nome,
                    Nif = nif,
                    NumEstudante = numEstudante,
    
                };

                context.Estudantes.Add(estudante);
                context.SaveChanges();
                return true;
            }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Os dados que introduziu não são válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool Editar(int id, string nome, string nif, string numEstudante)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    var estudante = context.Estudantes.Find(id);
                    if (estudante == null)
                    {
                        return false;
                    }

                    estudante.Nome = nome;
                    estudante.Nif = nif;
                    estudante.NumEstudante = numEstudante;
                    var entry = context.Entry(estudante);
                    if (entry.State == EntityState.Modified) // Verificar se de facto houve alterações no objeto
                    {
                        context.SaveChanges();
                    }
                    return true;
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Os dados que introduziu não são válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

    }
}
