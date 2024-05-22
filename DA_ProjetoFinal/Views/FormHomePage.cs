using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ProjetoFinal.Views
{
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            poisonDateTime1.Value = DateTime.Now;
            poisonComboBox1.Text = "Semana Nº" + UtilityController.GetWeekNumber(poisonDateTime1.Value.Date).ToString();
        }

        private void poisonButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
