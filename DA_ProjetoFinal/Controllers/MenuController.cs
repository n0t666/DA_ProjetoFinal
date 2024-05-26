using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ProjetoFinal
{
    internal class MenuController
    {

        public static List<Menu> GetBetweenDates(DateTime inicio, DateTime fim)
        {
            using (var context = new CantinaContext())
            {
                return context.Menus
                    .Where(m => m.DataHora >= inicio && m.DataHora <= fim)
                    .ToList();
            }
        }
    }
}
