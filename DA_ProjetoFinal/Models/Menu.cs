using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DA_ProjetoFinal
{
    internal class Menu
    {

        [Key]
        public int Id { get; set; }
        public DateTime DataHora { get; set; }

        public int Quantidade { get; set; }

        public decimal PrecoEstudante { get; set; }

        public decimal PrecoProfessor { get; set; }

        public virtual ICollection<Extra> Extra { get; set; }

        public virtual ICollection<Fatura> Fatura { get; set; }

        public virtual ICollection<Prato> Prato { get; set; }
    }
}
