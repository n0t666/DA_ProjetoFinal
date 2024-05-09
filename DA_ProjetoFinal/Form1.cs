using DA_ProjetoFinal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ProjetoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var ctx = new CantinaContext())
            {
               Cliente c = new Cliente();
                c.Nome = "João";
                c.Saldo = 0;
                ctx.Clientes.Add(c);

                Menu m = new Menu();
                m.PrecoProfessor = 2m;
                m.PrecoEstudante = 1m;
                m.Quantidade = 10;
                m.DataHora = DateTime.Now;
                ctx.Menus.Add(m);



                ctx.SaveChanges();
            }

        }
    }
}
