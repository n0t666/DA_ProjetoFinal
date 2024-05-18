using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ProjetoFinal
{
    internal class Reserva
    {
        public int Id { get; set; }

        public Cliente Cliente { get; set; }

        public Multa Multa { get; set; }


        public Menu Menu { get; set; }

        public ICollection<Extra> Extra { get; set; }
    }
}
