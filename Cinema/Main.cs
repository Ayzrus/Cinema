using Cinema.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            MaximizeBox = false; // Impede que a janela principal seja maximizada
        }

        // Método genérico para mostrar um UserControl e esconder os outros
        private void MostrarUserControl(UserControl userControl)
        {
            // Oculta todos os UserControls no formulário principal
            foreach (Control control in this.Controls)
            {
                if (control is UserControl)
                {
                    control.Visible = false; // Esconde qualquer UserControl que esteja visível
                }
            }

            // Exibe o UserControl passado como parâmetro
            userControl.Visible = true; // Mostra o UserControl especificado
            userControl.BringToFront(); // Traz o UserControl para frente, caso necessário
        }

        // Evento para mostrar o Dashboard
        private void DashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarUserControl(dashboard1); // Mostra o controle de Dashboard
        }

        // Evento para mostrar a listagem de cinemas
        private void ListagemCinemas_Click(object sender, EventArgs e)
        {
            MostrarUserControl(CinemasListagem1); // Mostra o controle de listagem de cinemas
        }

        // Evento para registrar novos cinemas
        private void RegistarCinema_Click(object sender, EventArgs e)
        {
            MostrarUserControl(registarCinemas1); // Mostra o controle de registro de cinemas
        }

        // Evento para editar cinemas existentes
        private void EditarCinema_Click(object sender, EventArgs e)
        {
            MostrarUserControl(editarCinemas1); // Mostra o controle de edição de cinemas
        }

        // Evento para mostrar a listagem de salas
        private void ListagemSalas_Click(object sender, EventArgs e)
        {
            MostrarUserControl(salasListagem1); // Mostra o controle de listagem de salas
        }

        // Evento para registrar novas salas
        private void RegistarSalas_Click(object sender, EventArgs e)
        {
            MostrarUserControl(salasRegistar1); // Mostra o controle de registro de salas
        }

        // Evento para editar salas existentes
        private void EditarSalas_Click(object sender, EventArgs e)
        {
            MostrarUserControl(salasEditar1); // Mostra o controle de edição de salas
        }

        // Evento para mostrar a listagem de filmes
        private void ListagemFilmes_Click(object sender, EventArgs e)
        {
            MostrarUserControl(filmesListagem1); // Mostra o controle de listagem de filmes
        }

        // Evento para registrar novos filmes
        private void RegistarFilmes_Click(object sender, EventArgs e)
        {
            MostrarUserControl(filmesRegistar1); // Mostra o controle de registro de filmes
        }

        // Evento para editar filmes existentes
        private void EditarFilmes_Click(object sender, EventArgs e)
        {
            MostrarUserControl(filmesEditar1); // Mostra o controle de edição de filmes
        }

        // Evento para mostrar a listagem de sessões
        private void ListagemSessoes_Click(object sender, EventArgs e)
        {
            MostrarUserControl(sessoesListagem1); // Mostra o controle de listagem de sessões
        }

        // Evento para registrar novas sessões
        private void RegistarSessoes_Click(object sender, EventArgs e)
        {
            MostrarUserControl(sessoesRegistar1); // Mostra o controle de registro de sessões
        }

        // Evento para editar sessões existentes
        private void EditarSessoes_Click(object sender, EventArgs e)
        {
            MostrarUserControl(sessoesEditar1); // Mostra o controle de edição de sessões
        }
    }
}
