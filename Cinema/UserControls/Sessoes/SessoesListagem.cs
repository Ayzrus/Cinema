using Sala;
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

namespace Cinema.UserControls.Sessoes
{
    public partial class SessoesListagem : UserControl
    {
        public SessoesListagem()
        {
            InitializeComponent();

            // Faz com que os campos ocupem todo o espaço do DataGridView
            SessoesData2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Obtém todas as sessões
            List<SessoesClass> sessoes = SessoesClass.GetSessoes();

            // Carrega as sessões na DataGridView
            SessoesData2.DataSource = sessoes;

            // Esconde as colunas Codigo_sala, Codigo_filme, Ativa
            if (SessoesData2.Columns["Codigo_sala"] != null)
            {
                SessoesData2.Columns["Codigo_sala"].Visible = false;
            }            
            
            if (SessoesData2.Columns["Codigo_filme"] != null)
            {
                SessoesData2.Columns["Codigo_filme"].Visible = false;
            }

            if (SessoesData2.Columns["Ativa"] != null)
            {
                SessoesData2.Columns["Ativa"].Visible = false;
            }

            // Adiciona uma coluna de botão para apagar
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Opções",
                Text = "Apagar",
                UseColumnTextForButtonValue = true // Exibe o texto "Apagar" no botão
            };
            SessoesData2.Columns.Add(deleteButtonColumn);

            // Associa o evento de clique no botão
            SessoesData2.CellContentClick += SessoesData_CellContentClick;

            // Formata a coluna Hora
            if (SessoesData2.Columns["Hora"] != null)
            {
                SessoesData2.Columns["Hora"].HeaderText = "Hora"; // Nome da coluna
                SessoesData2.Columns["Hora"].DefaultCellStyle.Format = "hh'h'mm'm'"; // Formato da hora
            }

            // Adiciona o evento de formatação de célula
            SessoesData2.CellFormatting += SessoesData_CellFormatting;

        }

        // Evento para formatar a hora
        private void SessoesData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Formata a coluna Hora no formato "00h00m"
            if (SessoesData2.Columns[e.ColumnIndex].Name == "Hora" && e.Value != null)
            {
                TimeSpan hora = (TimeSpan)e.Value;
                e.Value = $"{hora.Hours}h{hora.Minutes}m";
                e.FormattingApplied = true; // Marca que a formatação foi aplicada
            }
        }

        // Evento para capturar o clique no botão de apagar
        private void SessoesData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o botão "Apagar" foi clicado
            if (SessoesData2.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Obtém a sessao da linha correspondente
                var sessaoSelecionada = (SessoesClass)SessoesData2.Rows[e.RowIndex].DataBoundItem;

                // Confirmação antes de apagar
                DialogResult result = MessageBox.Show($"Tem certeza que deseja apagar a sessão: {sessaoSelecionada.Id_Sessao}?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Lógica para remover a sessão do banco de dados ou da lista
                    SessoesClass.DeletarSessao(sessaoSelecionada.Id_Sessao);

                    // Atualiza a lista de sessões na DataGridView
                    List<SessoesClass> sessoes = SessoesClass.GetSessoes();
                    SessoesData2.DataSource = sessoes;
                }
            }
        }

    }
}
