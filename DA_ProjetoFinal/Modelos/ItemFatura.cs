using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ProjetoFinal
{
    internal class ItemFatura
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public Fatura Fatura { get; set; }
    }
}
