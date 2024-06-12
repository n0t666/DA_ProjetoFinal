using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DA_ProjetoFinal
{
    internal class Fatura
    {
        [Key]
        public int Id { get; set; }
        public decimal Total { get; set; }
        public DateTime Data { get; set; }

        public Cliente Cliente { get; set; }

        public ICollection<ItemFatura> ItemFatura { get; set; }

        public Menu Menu { get; set; }
    }
}
