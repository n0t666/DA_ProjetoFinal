using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
