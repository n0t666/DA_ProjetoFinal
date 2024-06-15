    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DA_ProjetoFinal
{
    internal class Reserva
    {

        [Key]
        public int Id { get; set; }

        public Cliente Cliente { get; set; }

        public Multa Multa { get; set; }

        public DateTime Data { get; set; }


        public Menu Menu { get; set; }

        public ICollection<Extra> Extra { get; set; }

        public ICollection<Prato> Prato { get; set; }


        public override string ToString()
        {
            return "Reserva: " + Id + " - " + Data + " - " + Cliente.Nome;
        }
    }
}
