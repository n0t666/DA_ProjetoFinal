using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ProjetoFinal
{
    internal class Estudante: Cliente
    {

        public string NumEstudante { get; set; }

        public override string ToString()
        {
            return "Estudante: " + Nome + " (" + NumEstudante + ")";
        }
    }
}
