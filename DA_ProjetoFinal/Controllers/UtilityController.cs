using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ProjetoFinal
{
    //Controlador que possui funções auxiliares para a aplicação
    public class UtilityController
    {

        // Função que permite obter o número da semana de uma determinada data

        public static int currentUtilizador;

        public static int GetWeekNumber(DateTime date)
        {
            Calendar calendar = CultureInfo.CurrentCulture.Calendar;
            int week = calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            return week;
        }

        
        // Função que permite centrar um controlo no eixo X
        public static void Center(Control control)
        {
            float larguraControl = control.Width;
            float larguraParent = control.Parent.Width;
            float centrado = (larguraParent / 2) - (larguraControl / 2);

            control.Left = Convert.ToInt32(centrado);

        }
    }
}
