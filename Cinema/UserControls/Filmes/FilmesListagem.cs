using Filmes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.UserControls.Filmes
{
    public partial class FilmesListagem : UserControl
    {
        public FilmesListagem()
        {
            InitializeComponent();

            // Faz com que os campos ocupem todo o espaço do DataGridView
            FilmesData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Obtém todos os filmes
            List<FilmesClass> filmes = FilmesClass.GetFilmes();

            // Carrega os filmes na DataGridView
            FilmesData.DataSource = filmes;

            // Esconde as colunas Id_tipo, TotalFilmesEmExibicao
            if (FilmesData.Columns["Id_tipo"] != null)
            {
                FilmesData.Columns["Id_tipo"].Visible = false;
            }

            if (FilmesData.Columns["TotalFilmesEmExibicao"] != null)
            {
                FilmesData.Columns["TotalFilmesEmExibicao"].Visible = false;
            }

            // Adiciona uma coluna de botão para apagar
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Opções",
                Text = "Apagar",
                UseColumnTextForButtonValue = true // Exibe o texto "Apagar" no botão
            };
            FilmesData.Columns.Add(deleteButtonColumn);

            // Associa o evento de clique no botão
            FilmesData.CellContentClick += FilmesData_CellContentClick;

        }

        // Evento para capturar o clique no botão de apagar
        private void FilmesData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o botão "Apagar" foi clicado
            if (FilmesData.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Obtém o filme da linha correspondente
                var filmeSelecionado = (FilmesClass)FilmesData.Rows[e.RowIndex].DataBoundItem;

                // Confirmação antes de apagar
                DialogResult result = MessageBox.Show($"Tem certeza que deseja apagar o filme: {filmeSelecionado.Nome}?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Lógica para remover o filme do banco de dados ou da lista
                    FilmesClass.DeletarFilme(filmeSelecionado.Codigo_filme);

                    // Atualiza a lista de filmes na DataGridView
                    List<FilmesClass> filmes = FilmesClass.GetFilmes();
                    FilmesData.DataSource = filmes;
                }
            }
        }

    }
}
