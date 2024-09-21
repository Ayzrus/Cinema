using Filmes;
using Sessoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.UserControls
{
    public partial class Dashboard : UserControl
    {
        private readonly List<SessoesClass> sessoes; // Lista para armazenar todas as sessões

        public Dashboard()
        {
            InitializeComponent();

            // Obtém todos os cinemas
            List<CinemaClass> cinemas = CinemaClass.GetCinemas();

            // Conta quantos cinemas existem
            CinemasData.Text = cinemas.Count.ToString();

            // Obtém todos os filmes em exibição
            int totalFilmes = FilmesClass.GetTotalFilmesEmExibicao();

            // Conta quantos filmes em exibição há naquele momento
            FilmesData.Text = totalFilmes.ToString();

            // Adiciona um item para mostrar todas as sessões
            cinemas.Insert(0, new CinemaClass { Id_Cinema = -1, Nome = "Mostrar Todos" });

            // Configura a ComboBoxFiltro
            ComboBoxFiltro.DataSource = cinemas; // Define a fonte de dados da ComboBox
            ComboBoxFiltro.DisplayMember = "Nome"; // Define a propriedade a ser exibida
            ComboBoxFiltro.ValueMember = "Id_Cinema"; // Define a propriedade que será o valor associado

            // Obtém todas as sessões ativas
            sessoes = SessoesClass.GetSessoesAtivas();

            // Faz com que os campos ocupem todo o espaço do DataGridView
            SessoesData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Carrega as sessões na DataGridView
            SessoesData.DataSource = sessoes;

            // Renomeia a coluna Id_Sessao para ID
            if (SessoesData.Columns["Id_Sessao"] != null)
            {
                SessoesData.Columns["Id_Sessao"].HeaderText = "ID";
            }

            // Esconde as colunas Codigo_sala, Codigo_filme e Ativa
            if (SessoesData.Columns["Codigo_sala"] != null)
            {
                SessoesData.Columns["Codigo_sala"].Visible = false;
            }

            if (SessoesData.Columns["Codigo_filme"] != null)
            {
                SessoesData.Columns["Codigo_filme"].Visible = false;
            }

            if (SessoesData.Columns["Ativa"] != null)
            {
                SessoesData.Columns["Ativa"].Visible = false;
            }

            // Formata a coluna Hora
            if (SessoesData.Columns["Hora"] != null)
            {
                SessoesData.Columns["Hora"].HeaderText = "Hora"; // Nome da coluna
                SessoesData.Columns["Hora"].DefaultCellStyle.Format = "hh'h'mm'm'"; // Formato da hora
            }

            // Adiciona o evento de formatação de célula
            SessoesData.CellFormatting += SessoesData_CellFormatting;
        }

        // Evento para formatar a hora
        private void SessoesData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Formata a coluna Hora no formato "00h00m"
            if (SessoesData.Columns[e.ColumnIndex].Name == "Hora" && e.Value != null)
            {
                TimeSpan hora = (TimeSpan)e.Value;
                e.Value = $"{hora.Hours}h{hora.Minutes}m";
                e.FormattingApplied = true; // Marca que a formatação foi aplicada
            }
        }

        // Evento para captar a troca de item na combobox
        private void ComboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se a ComboBox tem um valor selecionado válido
            if (ComboBoxFiltro.SelectedValue != null && int.TryParse(ComboBoxFiltro.SelectedValue.ToString(), out int selectedCinemaId))
            {
                // Verifica se a opção "Mostrar Todos" está selecionada
                if (selectedCinemaId == -1)
                {
                    // Mostra todas as sessões
                    SessoesData.DataSource = sessoes;
                }
                else
                {
                    // Filtra as sessões com base no cinema selecionado
                    var filteredSessoes = sessoes.Where(sessao => sessao.Id_Cinema == selectedCinemaId).ToList();

                    // Atualiza o DataGridView com as sessões filtradas
                    SessoesData.DataSource = filteredSessoes;
                }
            }
        }

    }
}
