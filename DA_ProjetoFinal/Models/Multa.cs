﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ProjetoFinal
{
    internal class Multa
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }

        public int NumeroHoras { get; set; }

        public ICollection<Reserva> Reserva { get; set; }
    }
}