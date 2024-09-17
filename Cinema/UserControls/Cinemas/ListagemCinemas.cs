using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cinema.UserControls
{
    public partial class ListagemCinemas : UserControl
    {
        public ListagemCinemas()
        {
            InitializeComponent();

            // Faz com que os campos ocupem todo o espaço do DataGridView
            CinemasData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Obtém todos os cinemas
            List<CinemaClass> cinemas = CinemaClass.GetCinemas();

            // Carrega os cinemas na DataGridView
            CinemasData.DataSource = cinemas;

            // Esconde as colunas Id_local
            if (CinemasData.Columns["Id_local"] != null)
            {
                CinemasData.Columns["Id_local"].Visible = false;
            }

            // Adiciona uma coluna de botão para apagar
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Opções",
                Text = "Apagar",
                UseColumnTextForButtonValue = true // Exibe o texto "Apagar" no botão
            };
            CinemasData.Columns.Add(deleteButtonColumn);

            // Associa o evento de clique no botão
            CinemasData.CellContentClick += CinemasData_CellContentClick;
        }

        // Evento para capturar o clique no botão de apagar
        private void CinemasData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o botão "Apagar" foi clicado
            if (CinemasData.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Obtém o cinema da linha correspondente
                var cinemaSelecionado = (CinemaClass)CinemasData.Rows[e.RowIndex].DataBoundItem;

                // Confirmação antes de apagar
                DialogResult result = MessageBox.Show($"Tem certeza que deseja apagar o cinema: {cinemaSelecionado.Nome}?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Lógica para remover o cinema do banco de dados ou da lista
                    CinemaClass.DeletarCinema(cinemaSelecionado.Id_Cinema);

                    // Atualiza a lista de cinemas na DataGridView
                    List<CinemaClass> cinemas = CinemaClass.GetCinemas();
                    CinemasData.DataSource = cinemas;
                }
            }
        }
    }
}
