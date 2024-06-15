using DA_ProjetoFinal.Controllers;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Extension.Poison;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private int paginaAtual = 1;
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
        public event EventHandler <DateTime> SemanaDataSelected;
        

        public FormHomePage(bool firstTime,int id)
        {
            InitializeComponent();
            this.firstTime = firstTime;
            this.numeroUtilizador = id;
            if(numeroUtilizador > 0)
            {
                labelUtilizadorAtual.Text = "Utilizador Atual: " + UtilizadorController.GetById(numeroUtilizador).Nome;
            }
            else
            {
                labelUtilizadorAtual.Text = "Utilizador Atual: Nenhum";
            }
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            datePickAtual.Value = DateTime.Now;
            setImage();
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
            comboUtilizador.ResetText();
            comboUtilizador.DataSource = null;
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
            int numeroUtilizadores =0;


            if(isCliente)
            {
                utilizadoresPaginados = utilizadores
                    .Where(u => u is Cliente) 
                    .OrderBy(u => u.Nome)
                    .Skip((paginaAtual - 1) * tamanhoPagina)
                    .Take(tamanhoPagina)
                    .ToList();
                numeroUtilizadores = numeroClientes; 

            }
            else
            {
                utilizadoresPaginados = utilizadores
                    .Where(u => u is Funcionario)
                    .OrderBy(u => u.Nome)
                    .Skip((paginaAtual - 1) * tamanhoPagina)
                    .Take(tamanhoPagina)
                    .ToList();
                numeroUtilizadores = numeroFuncionarios;
            }


            comboUtilizador.DataSource = utilizadoresPaginados;
            comboUtilizador.Refresh();

            updatePagination(numeroUtilizadores);
        }

        private void btnSelecionarUtilizador_Click(object sender, EventArgs e)
        {
            // Verificar se o utilizador selecionado é diferente do anterior, e se também é válido
            if(comboUtilizador.SelectedIndex != -1 && comboUtilizador.SelectedItem != null && comboUtilizador.SelectedItem is Utilizador && numeroUtilizador != ((Utilizador)comboUtilizador.SelectedItem).Id)
            {
                numeroUtilizador = ((Utilizador)comboUtilizador.SelectedItem).Id;
                labelUtilizadorAtual.Text = ((Utilizador)comboUtilizador.SelectedItem).ToString();
                setImage();
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
            UtilityController.Center(labelLoading);
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
            FormSemana form = new FormSemana(datePickAtual.Value.Date);
            form.SemanaDataSelected += semanaSelected;
            form.Show();
        }

        private void datePickAtual_ValueChanged(object sender, EventArgs e)
        {
            comboSemana.Text = "Semana Nº" + UtilityController.GetWeekNumber(datePickAtual.Value.Date).ToString();
            this.Refresh();
        }

        private void semanaSelected(object sender,DateTime data)
        {
            SemanaDataSelected?.Invoke(this, data);
        }

        private void picUtilizadorPfp_Click(object sender, EventArgs e)
        {
            if (numeroUtilizador > 0)
            {

                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                openFileDialog1.Title = "Selecione a imagem de perfil";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    Guid guid = Guid.NewGuid();
                    string nome = guid.ToString();

                    string caminho = openFileDialog1.FileName;

                    string rootDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

                    string root = Path.Combine(rootDirectory, "resources", "images", "users", "pfps", numeroUtilizador.ToString());


                    if (!Directory.Exists(root))
                    {
                        Directory.CreateDirectory(root);
                    }

                    string destino = Path.Combine(root, nome + ".png");

                    try
                    {
                        File.Copy(caminho, destino, true);
                        if (UtilizadorController.AdicionarFotoDePerfil(numeroUtilizador, destino))
                        {
                            picUtilizadorPfp.Image = Image.FromFile(destino);
                            MessageBox.Show("Foto de perfil atualizada com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao atualizar a foto de perfil");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao copiar a imagem: " + ex.Message);
                    }
                }
            }
        }

        private void setImage()
        {
            if(numeroUtilizador > 0)
            {
                Utilizador utilizador = UtilizadorController.GetById(numeroUtilizador);
                if (utilizador.FotoDePerfil != null && utilizador.FotoDePerfil !=null)
                {
                    picUtilizadorPfp.Image = Image.FromFile(utilizador.FotoDePerfil);
                }
            }

        }

        private void btnApagarFoto_Click(object sender, EventArgs e)
        {
            if(numeroUtilizador > 0)
            {
                if(UtilizadorController.AdicionarFotoDePerfil(numeroUtilizador, null))
                {
                    picUtilizadorPfp.Image = null;
                    picUtilizadorPfp.Image = Properties.Resources.default_user;

                    MessageBox.Show("Foto de perfil apagada com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao apagar a foto de perfil");
                }
            }
        }
    }
}
