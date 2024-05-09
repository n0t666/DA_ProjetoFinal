using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ProjetoFinal
{
    internal class Extra
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        
        public bool Ativo { get; set; }

        public virtual ICollection<Menu> Menu { get; set; }
    }
}
