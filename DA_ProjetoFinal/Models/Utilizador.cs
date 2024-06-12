using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ProjetoFinal
{
    internal class Utilizador
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-ZãáàâéêíóõôúüçÇ ]+$", ErrorMessage = "O nome apenas pode conter letras.")] //Apenas letras permitidas e espaços, incluindo acentos
        public string Nome { get; set; }
        public string Nif { get; set; }

        public string FotoDePerfil { get; set; }
    }
}
