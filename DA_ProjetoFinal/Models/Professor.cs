using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ProjetoFinal
{
    internal class Professor:Cliente
    {
        public string Email { get; set; }

        public override string ToString()
        {
            return "Professor: " + Nome;
        }
    }

}
