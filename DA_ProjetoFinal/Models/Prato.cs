using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ProjetoFinal
{
    public enum TipoPrato
    {
        Carne,
        Peixe,
        Vegetariano
    }

    [Table("Pratos")] // Especificar o nome da table para evitar que fique com o nome de Pratoes
    internal class Prato
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public TipoPrato Tipo { get; set; }

        public bool Ativo { get; set; }

        public ICollection<Reserva> Reserva { get; set;}

        public virtual ICollection<Menu> Menu { get; set; }

        public override string ToString()
        {
            return Descricao + " - " + Tipo;
        }

    }

    


}
