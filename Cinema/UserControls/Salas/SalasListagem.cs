using Filmes;
using Sala;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.UserControls.Salas
{
    public partial class SalasListagem : UserControl
    {
        public SalasListagem()
        {
            InitializeComponent();

            // Faz com que os campos ocupem todo o espaço do DataGridView
            SalasData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Obtém todas as salas
            List<SalaClass> salas = SalaClass.GetSalas();

            // Carrega as salas na DataGridView
            SalasData.DataSource = salas;

            // Esconde as colunas Id_cinema
            if (SalasData.Columns["Id_cinema"] != null)
            {
                SalasData.Columns["Id_cinema"].Visible = false;
            }

            // Adiciona uma coluna de botão para apagar
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Opções",
                Text = "Apagar",
                UseColumnTextForButtonValue = true // Exibe o texto "Apagar" no botão
            };
            SalasData.Columns.Add(deleteButtonColumn);

            // Associa o evento de clique no botão
            SalasData.CellContentClick += SalasData_CellContentClick;

        }

        // Evento para capturar o clique no botão de apagar
        private void SalasData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o botão "Apagar" foi clicado
            if (SalasData.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Obtém a sala da linha correspondente
                var salaSelecionada = (SalaClass)SalasData.Rows[e.RowIndex].DataBoundItem;

                // Confirmação antes de apagar
                DialogResult result = MessageBox.Show($"Tem certeza que deseja apagar a sala: {salaSelecionada.Descricao}?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Lógica para remover a sala do banco de dados ou da lista
                    SalaClass.DeletarSala(salaSelecionada.Codigo_sala);

                    // Atualiza a lista de salas na DataGridView
                    List<SalaClass> salas = SalaClass.GetSalas();
                    SalasData.DataSource = salas;
                }
            }
        }

    }
}
