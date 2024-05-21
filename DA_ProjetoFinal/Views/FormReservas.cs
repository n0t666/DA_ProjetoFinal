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
    public partial class FormReservas : Form
    {
        public FormReservas()
        {
            InitializeComponent();
            comboBoxClientes.Items.Clear();
            comboBoxClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxClientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxClientes.DataSource = ClienteController.GetClientes();         
            comboBoxClientes.SelectedIndex = -1;    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxClientes.DroppedDown = false;
        }


    }
}
