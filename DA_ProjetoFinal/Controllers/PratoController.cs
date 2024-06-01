using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ProjetoFinal.Controllers
{

    // Controlador que permite fazer o CRUD de pratos e outras operações relacionadas
    internal class PratoController
    {

        // Função que permite criar um prato, tendo como parâmetros a descrição, o tipo e o estado do prato
        public static bool Adicionar(string descricao,TipoPrato tipo,bool activo)
        {
            try 
            {
                using (var context = new CantinaContext())
                {
                    Prato prato = new Prato
                    {
                        Descricao = descricao,
                        Tipo = tipo,
                        Ativo = activo
                    };
                    context.Pratos.Add(prato);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Função que permite obter todos os pratos com paginação
        public static List<Prato> Paginar(int paginaAtual,int paginaTamanho)
        {
            using (var context = new CantinaContext())
            {
                return context.Pratos
                    .OrderBy(p => p.Id) // ordenar por id, pois o skip e take não funcionam sem uma ordem específica
                    .Skip((paginaAtual - 1)* paginaTamanho).Take(paginaTamanho).ToList();
            }
        }

        // Função que permite obter todos os tipos de prato, devolve uma lista dos tipos de prato
        public static List<TipoPrato> GetTipos()
        {
            return Enum.GetValues(typeof(TipoPrato)).Cast<TipoPrato>().ToList();
        }

        public static int ObterNumero() // Função que permite obter o número de pratos
        {
            using (var context = new CantinaContext())
            {
                return context.Pratos.Count();
            }
        }

        // Função que recebe como parâmetro o id do prato, depois com o id do prato é feito o delete do prato
        public static bool Apagar(int id)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    Prato prato = context.Pratos.Find(id);
                    context.Pratos.Remove(prato);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Função que permite editar um prato, tendo como parâmetros o id, a descrição, o tipo e o estado do prato
        public static bool Editar(int id, string descricao, TipoPrato tipo, bool activo)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    Prato prato = context.Pratos.Find(id);
                    prato.Descricao = descricao;
                    prato.Tipo = tipo;
                    prato.Ativo = activo;
                    var entry = context.Entry(prato);
                    if (entry.State == EntityState.Modified) // Verificar se de facto houve alterações no objeto
                    {
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

      
}


        


