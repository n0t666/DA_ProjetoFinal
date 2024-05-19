﻿using DA_ProjetoFinal.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ProjetoFinal
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
            using (var context = new CantinaContext())
            {
                Cliente cliente = new Estudante();
                cliente.Nome = "João";
                cliente.Nif = 123456789;
                cliente.FotoDePerfil = "foto";
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }
    }
}
