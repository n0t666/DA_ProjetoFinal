using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ProjetoFinal
{
    internal class UtilizadorController
    {
        public static List<Utilizador> GetUtilizadores()
        {
            using (var context = new CantinaContext())
            {
                return context.Utilizadores.ToList();
            }

        }

        public static List<Utilizador> PaginacaoUtilizadores(int pagina, int tamanhoPagina)
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

        public static int ObterNumeroUtilizadores()
        {
            using (var context = new CantinaContext())
            {
                return context.Utilizadores.Count();
            }
        }
    }
}
