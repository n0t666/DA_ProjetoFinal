using DA_ProjetoFinal.Controllers;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Extension.Poison;
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
        //-----------------Variáveis relacionadas com a paginação-----------------
        private int tamanhoPagina = 6;
        private int paginaAtual = 2;
        //------------------------------------------------------------------------

        private List<Utilizador> utilizadores;
        private List<Utilizador> utilizadoresPaginados;
        private int numeroFuncionarios;
        private int numeroClientes;
        private bool selectedCliente;
        private int numeroUtilizador;

        private bool firstTime;

        public event EventHandler <int> UtilizadorSelectedChanged;
        public event EventHandler <bool> HomePage_FirsTimeLoad;

        public FormHomePage(bool firstTime)
        {
            InitializeComponent();
            this.firstTime = firstTime;
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            datePickAtual.Value = DateTime.Now;
            carregadorDados();
        }


        private void comboTipoUtilizador_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch(comboTipoUtilizador.SelectedIndex)
            {
                case 0:
                    selectedCliente = false;
                    break;
                case 1:
                    selectedCliente = true;
                    break;
            }
            paginaAtual = 1;
            obterDadosUtilizadores(selectedCliente);
        }

        private void comboUtilizador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updatePagination(int numeroUtilizador)
        {
            btnPaginateAvancar.Enabled = paginaAtual * tamanhoPagina < numeroUtilizador; // Verificar se é possível avançar para a próxima página
            btnPaginateVoltar.Enabled = paginaAtual > 1; // Verificar se é possível voltar para a página anterior
        }

        private void btnPaginateAvancar_Click(object sender, EventArgs e)
        {
                paginaAtual++;
                obterDadosUtilizadores(selectedCliente);
        }

        private void btnPaginateVoltar_Click(object sender, EventArgs e)
        {
            paginaAtual--;
            obterDadosUtilizadores(selectedCliente);
        }

        private void obterDadosUtilizadores(bool isCliente)
        {
            int numeroUtilizadores;

            if(isCliente)
            {
                utilizadoresPaginados = utilizadores.OrderBy(u => u.Nome)
                .Skip((paginaAtual - 1) * tamanhoPagina)
                .Take(tamanhoPagina)
                .Where(u => u is Cliente)
                .ToList();
                numeroUtilizadores = numeroClientes;
            }
            else
            {
                utilizadoresPaginados = utilizadores.OrderBy(u => u.Nome)
                .Skip((paginaAtual - 1) * tamanhoPagina)
                .Take(tamanhoPagina)
                .Where(u => u is Funcionario)
                .ToList();
                numeroUtilizadores = numeroFuncionarios;
            }


            comboUtilizador.DataSource = utilizadoresPaginados;

            updatePagination(numeroUtilizadores);
        }

        private void btnSelecionarUtilizador_Click(object sender, EventArgs e)
        {
            // Verificar se o utilizador selecionado é diferente do anterior, e se também é válido
            if(comboUtilizador.SelectedIndex != -1 && comboUtilizador.SelectedItem != null && comboUtilizador.SelectedItem is Utilizador && numeroUtilizador != ((Utilizador)comboUtilizador.SelectedItem).Id)
            {
                numeroUtilizador = ((Utilizador)comboUtilizador.SelectedItem).Id;
                labelUtilizadorAtual.Text = ((Utilizador)comboUtilizador.SelectedItem).ToString();
            }else
            {
                numeroUtilizador = 0;
                labelUtilizadorAtual.Text = "Utilizador Atual: Nenhum";
            }

            UtilizadorSelectedChanged?.Invoke(this, numeroUtilizador); 
        }

        private async void carregadorDados()
        {
            if (firstTime)
            {
                criarLoading();
            }
            else
            {
                criarLoading(false, true);
            }
            await ObterTodosUtilizadores();
            if (firstTime)
            {
                HomePage_FirsTimeLoad?.Invoke(this, false);
                criarLoading(false, true);
            }


            numeroFuncionarios = utilizadores.Where(u => u is Funcionario).Count();
            numeroClientes = utilizadores.Where(u => u is Cliente).Count();
            btnPaginateAvancar.Enabled = false;
            btnPaginateVoltar.Enabled = false;

        }

        async Task ObterTodosUtilizadores()
        {
            await Task.Run(() => { this.utilizadores = UtilizadorController.Get(); });
            labelLoading.Text = "Dados carregados";
            await Task.Delay(1000);
        }

        private void criarLoading(bool loadingVisible = true,bool controlsVisible = false)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control.Name == "labelLoading" || control.Name == "spinnerLoading")
                {
                    control.Visible = loadingVisible;
                }
                else
                {
                    control.Visible = controlsVisible;
                }
            }

        }

        private void pictureInfoWeek_Click(object sender, EventArgs e)
        {
            UtilityController.GetWeeKStart(datePickAtual.Value.Date);
            Form form = new FormSemana(datePickAtual.Value.Date);
            form.Show();
        }

        private void datePickAtual_ValueChanged(object sender, EventArgs e)
        {
            comboSemana.Text = "Semana Nº" + UtilityController.GetWeekNumber(datePickAtual.Value.Date).ToString();
        }

    }
}
