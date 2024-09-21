using Local;
using Sala;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cinema.UserControls
{
    public partial class EditarCinemas : UserControl
    {
        public EditarCinemas()
        {
            InitializeComponent();

            AtualizarListaCinemas();

            // Obtém todos os locais
            List<LocalClass> local = LocalClass.GetLocais();

            // Configura a ComboBoxELocal
            ComboBoxELocal.DataSource = local; // Define a fonte de dados da ComboBox
            ComboBoxELocal.DisplayMember = "Descricao"; // Define a propriedade a ser exibida
            ComboBoxELocal.ValueMember = "Id"; // Define a propriedade que será o valor associado

            // Define a seleção inicial como nenhum item (índice -1)
            ComboBoxELocal.SelectedIndex = -1;
        }

        private void EditarBTN_Click(object sender, EventArgs e)
        {
            // Verifica se um cinema foi selecionado na ComboBox
            if (ComboBoxCinema.SelectedValue == null || ComboBoxCinema.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um cinema para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o ID do cinema selecionado
            int selectedCinemaId = (int)ComboBoxCinema.SelectedValue;

            // Verifica se o nome do cinema foi preenchido
            string nomeCinema = TextBoxNomeCinema.Text;
            if (string.IsNullOrEmpty(nomeCinema))
            {
                MessageBox.Show("Por favor, insira um nome válido para o cinema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o ID do local selecionado na ComboBoxELocal
            if (ComboBoxELocal.SelectedValue == null || ComboBoxELocal.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um local para o cinema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedLocalId = (int)ComboBoxELocal.SelectedValue;

            // Cria um objeto CinemaClass com os dados editados
            CinemaClass cinemaEditado = new CinemaClass
            {
                Id_Cinema = selectedCinemaId,
                Nome = nomeCinema,
                Id_Local = selectedLocalId
            };

            // Chama o método de atualização (supõe-se que existe um método para atualizar o cinema)
            bool sucesso = CinemaClass.AtualizarCinema(cinemaEditado);

            // Verifica se a atualização foi bem-sucedida
            if (sucesso)
            {
                MessageBox.Show("Cinema atualizado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos
                ClearBTN_Click(sender, e);

                // Atualiza a ComboBox de Cinemas após a edição
                AtualizarListaCinemas();

                // Define a seleção inicial como nenhum item (índice -1)
                ComboBoxCinema.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o cinema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para atualizar a ComboBox de Cinemas com a lista mais recente
        private void AtualizarListaCinemas()
        {
            // Desativa temporariamente o evento SelectedIndexChanged
            ComboBoxCinema.SelectedIndexChanged -= ComboBoxCinema_SelectedIndexChanged;

            // Obtém a lista atualizada de cinemas
            List<CinemaClass> cinemas = CinemaClass.GetCinemas();

            // Reconfigura a ComboBoxCinema com a nova lista
            ComboBoxCinema.DataSource = null; // Limpa a fonte de dados atual
            ComboBoxCinema.DataSource = cinemas; // Define a nova fonte de dados
            ComboBoxCinema.DisplayMember = "Nome"; // Propriedade a ser exibida
            ComboBoxCinema.ValueMember = "Id_Cinema"; // Propriedade de valor associado

            // Define a seleção inicial como nenhum item (índice -1)
            ComboBoxCinema.SelectedIndex = -1;

            // Reativa o evento SelectedIndexChanged
            ComboBoxCinema.SelectedIndexChanged += ComboBoxCinema_SelectedIndexChanged;
        }

        private void ComboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se há um valor selecionado e se ele é um número inteiro válido
            if (ComboBoxCinema.SelectedValue != null && int.TryParse(ComboBoxCinema.SelectedValue.ToString(), out int selectedCinemaId))
            {
                // Obtém o cinema selecionado pelo seu ID
                CinemaClass cinemaSelecionado = CinemaClass.GetCinema(selectedCinemaId);

                if (cinemaSelecionado != null)
                {
                    // Preenche o TextBoxNome com o nome do cinema
                    TextBoxNomeCinema.Text = cinemaSelecionado.Nome;

                    // Define o valor selecionado na ComboBoxELocal com base no Id_Local do cinema
                    ComboBoxELocal.SelectedValue = cinemaSelecionado.Id_Local;
                }
            }
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            // Limpa o TextBox do nome do cinema
            TextBoxNomeCinema.Clear();

            // Define as ComboBox para não selecionar nada
            ComboBoxCinema.SelectedIndex = -1;
            ComboBoxELocal.SelectedIndex = -1;
        }
    }
}
