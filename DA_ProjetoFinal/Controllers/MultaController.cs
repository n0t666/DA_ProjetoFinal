using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ProjetoFinal
{
    internal class MultaController
    {
        public static bool Adicionar(decimal valor, int numeroHoras)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    Multa multa = new Multa
                    {
                        Valor = valor,
                        NumeroHoras = numeroHoras
                    };
                    context.Multas.Add(multa);
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static List<Multa> Get()
        {
            using (var context = new CantinaContext())
            {
                return context.Multas.ToList();
            }
        }

        public static bool Apagar(int id)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    Multa multa = context.Multas.Find(id);
                    context.Multas.Remove(multa);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool Editar(int id, decimal valor, int numeroHoras)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    Multa multa = context.Multas.Find(id);
                    multa.Valor = valor;
                    multa.NumeroHoras = numeroHoras;
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool Exists(int numeroHoras,int ignoreId = -1)
        {
            using (var context = new CantinaContext())
            {
                if(ignoreId != -1)
                    return context.Multas.Any(m => m.NumeroHoras == numeroHoras && m.Id != ignoreId);
                else
                    return context.Multas.Any(m => m.NumeroHoras == numeroHoras);
            }
        }
    }
}
