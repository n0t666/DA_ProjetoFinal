using DA_ProjetoFinal.Controllers;
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

        public event EventHandler <int> UtilizadorSelectedChanged;

        public FormHomePage()
        {
            InitializeComponent();
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            datePickAtual.Value = DateTime.Now;
            comboSemana.Text = "Semana Nº" + UtilityController.GetWeekNumber(datePickAtual.Value.Date).ToString();
            utilizadores = UtilizadorController.GetUtilizadores();
            numeroFuncionarios = utilizadores.Where(u => u is Funcionario).Count();
            numeroClientes = utilizadores.Where(u => u is Cliente).Count();
            btnPaginateAvancar.Enabled = false;
            btnPaginateVoltar.Enabled = false;
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
    }
}
