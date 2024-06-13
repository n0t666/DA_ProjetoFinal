using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ProjetoFinal
{
    internal class UtilizadorController
    {
        public static List<Utilizador> Get()
        {
            using (var context = new CantinaContext())
            {
                return context.Utilizadores.ToList();
            }

        }

        public static List<Utilizador> Paginar(int pagina, int tamanhoPagina)
        {
            using (var context = new CantinaContext())
            {
                return context.Utilizadores
                    .OrderBy(u => u.Nome)
                    .Skip((pagina - 1) * tamanhoPagina)
                    .Take(tamanhoPagina)
                    .ToList();
            }
        }

        public static int ObterNumero()
        {
            using (var context = new CantinaContext())
            {
                return context.Utilizadores.Count();
            }
        }

        public static Utilizador GetById(int id)
        {
            using (var context = new CantinaContext())
            {
                return context.Utilizadores.Find(id);
            }
        }

        public static bool AdicionarFotoDePerfil(int id, string caminho)
        {
            try {
            using (var context = new CantinaContext())
            {
                var utilizador = context.Utilizadores.Find(id);
                utilizador.FotoDePerfil = caminho;
                context.SaveChanges();
                return true;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Erro ao adicionar a foto de perfil");
                return false;
            }
           
        }
    }
}
