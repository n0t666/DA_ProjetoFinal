using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
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

        public static DateTime GetWeeKStart(DateTime date)
        {
            DateTime start = date.AddDays(-(int)date.DayOfWeek + (int)DayOfWeek.Monday); 
            return start;
        }

        public static decimal GetDecimal(string value,string valueType)
        {
            decimal result;

            try
            {
                if (decimal.TryParse(value, out result))
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro ao converter o " + valueType + " para decimal", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar ler o " + valueType, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            return 0;
        }

        
        // Função que permite centrar um controlo no eixo X
        public static void Center(Control control)
        {
            float larguraControl = control.Width;
            float larguraParent = control.Parent.Width;
            float centrado = (larguraParent / 2) - (larguraControl / 2);

            control.Left = Convert.ToInt32(centrado);

        }

        public static bool IsEmailValid(string email)
        {
            try
            {
                MailAddress m = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("O email introduzido não é válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
