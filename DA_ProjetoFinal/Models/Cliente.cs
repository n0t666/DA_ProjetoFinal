using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ProjetoFinal
{
    internal class Cliente: Utilizador
    {
        public decimal Saldo { get; set; }
        
        public ICollection<Reserva> Reserva { get; set; }

        public ICollection<Fatura> Fatura { get; set; }

    }
}
