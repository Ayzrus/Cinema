namespace Cinema
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListagemCinemas = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistarCinema = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarCinema = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListagemSalas = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistarSalas = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarSalas = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListagemFilmes = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistarFilmes = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarFilmes = new System.Windows.Forms.ToolStripMenuItem();
            this.sessõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListagemSessoes = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistarSessoes = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarSessoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CinemasListagem1 = new Cinema.UserControls.ListagemCinemas();
            this.dashboard1 = new Cinema.UserControls.Dashboard();
            this.editarCinemas1 = new Cinema.UserControls.EditarCinemas();
            this.registarCinemas1 = new Cinema.UserControls.RegistarCinemas();
            this.filmesEditar1 = new Cinema.UserControls.Filmes.FilmesEditar();
            this.filmesListagem1 = new Cinema.UserControls.Filmes.FilmesListagem();
            this.filmesRegistar1 = new Cinema.UserControls.Filmes.FilmesRegistar();
            this.salasEditar1 = new Cinema.UserControls.Salas.SalasEditar();
            this.salasListagem1 = new Cinema.UserControls.Salas.SalasListagem();
            this.salasRegistar1 = new Cinema.UserControls.Salas.SalasRegistar();
            this.sessoesEditar1 = new Cinema.UserControls.Sessoes.SessoesEditar();
            this.sessoesListagem1 = new Cinema.UserControls.Sessoes.SessoesListagem();
            this.sessoesRegistar1 = new Cinema.UserControls.Sessoes.SessoesRegistar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardToolStripMenuItem
            // 
            this.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem";
            this.DashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.DashboardToolStripMenuItem.Text = "Dashboard";
            this.DashboardToolStripMenuItem.Click += new System.EventHandler(this.DashboardToolStripMenuItem_Click);
            // 
            // cinemasToolStripMenuItem
            // 
            this.cinemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListagemCinemas,
            this.RegistarCinema,
            this.EditarCinema});
            this.cinemasToolStripMenuItem.Name = "cinemasToolStripMenuItem";
            this.cinemasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.cinemasToolStripMenuItem.Text = "Cinemas";
            // 
            // ListagemCinemas
            // 
            this.ListagemCinemas.Name = "ListagemCinemas";
            this.ListagemCinemas.Size = new System.Drawing.Size(180, 22);
            this.ListagemCinemas.Text = "Listagem";
            this.ListagemCinemas.Click += new System.EventHandler(this.ListagemCinemas_Click);
            // 
            // RegistarCinema
            // 
            this.RegistarCinema.Name = "RegistarCinema";
            this.RegistarCinema.Size = new System.Drawing.Size(180, 22);
            this.RegistarCinema.Text = "Registar";
            this.RegistarCinema.Click += new System.EventHandler(this.RegistarCinema_Click);
            // 
            // EditarCinema
            // 
            this.EditarCinema.Name = "EditarCinema";
            this.EditarCinema.Size = new System.Drawing.Size(180, 22);
            this.EditarCinema.Text = "Editar";
            this.EditarCinema.Click += new System.EventHandler(this.EditarCinema_Click);
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListagemSalas,
            this.RegistarSalas,
            this.EditarSalas});
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salasToolStripMenuItem.Text = "Salas";
            // 
            // ListagemSalas
            // 
            this.ListagemSalas.Name = "ListagemSalas";
            this.ListagemSalas.Size = new System.Drawing.Size(180, 22);
            this.ListagemSalas.Text = "Listagem";
            this.ListagemSalas.Click += new System.EventHandler(this.ListagemSalas_Click);
            // 
            // RegistarSalas
            // 
            this.RegistarSalas.Name = "RegistarSalas";
            this.RegistarSalas.Size = new System.Drawing.Size(180, 22);
            this.RegistarSalas.Text = "Registar";
            this.RegistarSalas.Click += new System.EventHandler(this.RegistarSalas_Click);
            // 
            // EditarSalas
            // 
            this.EditarSalas.Name = "EditarSalas";
            this.EditarSalas.Size = new System.Drawing.Size(180, 22);
            this.EditarSalas.Text = "Editar";
            this.EditarSalas.Click += new System.EventHandler(this.EditarSalas_Click);
            // 
            // filmesToolStripMenuItem
            // 
            this.filmesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListagemFilmes,
            this.RegistarFilmes,
            this.EditarFilmes});
            this.filmesToolStripMenuItem.Name = "filmesToolStripMenuItem";
            this.filmesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.filmesToolStripMenuItem.Text = "Filmes";
            // 
            // ListagemFilmes
            // 
            this.ListagemFilmes.Name = "ListagemFilmes";
            this.ListagemFilmes.Size = new System.Drawing.Size(180, 22);
            this.ListagemFilmes.Text = "Listagem";
            this.ListagemFilmes.Click += new System.EventHandler(this.ListagemFilmes_Click);
            // 
            // RegistarFilmes
            // 
            this.RegistarFilmes.Name = "RegistarFilmes";
            this.RegistarFilmes.Size = new System.Drawing.Size(180, 22);
            this.RegistarFilmes.Text = "Registar";
            this.RegistarFilmes.Click += new System.EventHandler(this.RegistarFilmes_Click);
            // 
            // EditarFilmes
            // 
            this.EditarFilmes.Name = "EditarFilmes";
            this.EditarFilmes.Size = new System.Drawing.Size(180, 22);
            this.EditarFilmes.Text = "Editar";
            this.EditarFilmes.Click += new System.EventHandler(this.EditarFilmes_Click);
            // 
            // sessõesToolStripMenuItem
            // 
            this.sessõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListagemSessoes,
            this.RegistarSessoes,
            this.EditarSessoes});
            this.sessõesToolStripMenuItem.Name = "sessõesToolStripMenuItem";
            this.sessõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sessõesToolStripMenuItem.Text = "Sessões";
            // 
            // ListagemSessoes
            // 
            this.ListagemSessoes.Name = "ListagemSessoes";
            this.ListagemSessoes.Size = new System.Drawing.Size(180, 22);
            this.ListagemSessoes.Text = "Listagem";
            this.ListagemSessoes.Click += new System.EventHandler(this.ListagemSessoes_Click);
            // 
            // RegistarSessoes
            // 
            this.RegistarSessoes.Name = "RegistarSessoes";
            this.RegistarSessoes.Size = new System.Drawing.Size(180, 22);
            this.RegistarSessoes.Text = "Registar";
            this.RegistarSessoes.Click += new System.EventHandler(this.RegistarSessoes_Click);
            // 
            // EditarSessoes
            // 
            this.EditarSessoes.Name = "EditarSessoes";
            this.EditarSessoes.Size = new System.Drawing.Size(180, 22);
            this.EditarSessoes.Text = "Editar";
            this.EditarSessoes.Click += new System.EventHandler(this.EditarSessoes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DashboardToolStripMenuItem,
            this.cinemasToolStripMenuItem,
            this.salasToolStripMenuItem,
            this.filmesToolStripMenuItem,
            this.sessõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1118, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CinemasListagem1
            // 
            this.CinemasListagem1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CinemasListagem1.Location = new System.Drawing.Point(12, 39);
            this.CinemasListagem1.MaximumSize = new System.Drawing.Size(1094, 479);
            this.CinemasListagem1.MinimumSize = new System.Drawing.Size(1094, 479);
            this.CinemasListagem1.Name = "CinemasListagem1";
            this.CinemasListagem1.Size = new System.Drawing.Size(1094, 479);
            this.CinemasListagem1.TabIndex = 2;
            this.CinemasListagem1.Visible = false;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dashboard1.Location = new System.Drawing.Point(12, 39);
            this.dashboard1.MaximumSize = new System.Drawing.Size(1094, 479);
            this.dashboard1.MinimumSize = new System.Drawing.Size(1094, 479);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1094, 479);
            this.dashboard1.TabIndex = 1;
            // 
            // editarCinemas1
            // 
            this.editarCinemas1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editarCinemas1.Location = new System.Drawing.Point(12, 39);
            this.editarCinemas1.MaximumSize = new System.Drawing.Size(1094, 479);
            this.editarCinemas1.MinimumSize = new System.Drawing.Size(1094, 479);
            this.editarCinemas1.Name = "editarCinemas1";
            this.editarCinemas1.Size = new System.Drawing.Size(1094, 479);
            this.editarCinemas1.TabIndex = 3;
            this.editarCinemas1.Visible = false;
            // 
            // registarCinemas1
            // 
            this.registarCinemas1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.registarCinemas1.Location = new System.Drawing.Point(12, 39);
            this.registarCinemas1.MaximumSize = new System.Drawing.Size(1094, 479);
            this.registarCinemas1.MinimumSize = new System.Drawing.Size(1094, 479);
            this.registarCinemas1.Name = "registarCinemas1";
            this.registarCinemas1.Size = new System.Drawing.Size(1094, 479);
            this.registarCinemas1.TabIndex = 4;
            this.registarCinemas1.Visible = false;
            // 
            // filmesEditar1
            // 
            this.filmesEditar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.filmesEditar1.Location = new System.Drawing.Point(12, 39);
            this.filmesEditar1.MaximumSize = new System.Drawing.Size(1094, 479);
            this.filmesEditar1.MinimumSize = new System.Drawing.Size(1094, 479);
            this.filmesEditar1.Name = "filmesEditar1";
            this.filmesEditar1.Size = new System.Drawing.Size(1094, 479);
            this.filmesEditar1.TabIndex = 5;
            this.filmesEditar1.Visible = false;
            // 
            // filmesListagem1
            // 
            this.filmesListagem1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.filmesListagem1.Location = new System.Drawing.Point(12, 39);
            this.filmesListagem1.MaximumSize = new System.Drawing.Size(1094, 479);
            this.filmesListagem1.MinimumSize = new System.Drawing.Size(1094, 479);
            this.filmesListagem1.Name = "filmesListagem1";
            this.filmesListagem1.Size = new System.Drawing.Size(1094, 479);
            this.filmesListagem1.TabIndex = 6;
            this.filmesListagem1.Visible = false;
            // 
            // filmesRegistar1
            // 
            this.filmesRegistar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.filmesRegistar1.Location = new System.Drawing.Point(12, 39);
            this.filmesRegistar1.MaximumSize = new System.Drawing.Size(1094, 479);
            this.filmesRegistar1.MinimumSize = new System.Drawing.Size(1094, 479);
            this.filmesRegistar1.Name = "filmesRegistar1";
            this.filmesRegistar1.Size = new System.Drawing.Size(1094, 479);
            this.filmesRegistar1.TabIndex = 7;
            this.filmesRegistar1.Visible = false;
            // 
            // salasEditar1
            // 
            this.salasEditar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.salasEditar1.Location = new System.Drawing.Point(12, 39);
            this.salasEditar1.MaximumSize = new System.Drawing.Size(1094, 479);
            this.salasEditar1.MinimumSize = new System.Drawing.Size(1094, 479);
            this.salasEditar1.Name = "salasEditar1";
            this.salasEditar1.Size = new System.Drawing.Size(1094, 479);
            this.salasEditar1.TabIndex = 8;
            this.salasEditar1.Visible = false;
            // 
            // salasListagem1
            // 
            this.salasListagem1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.salasListagem1.Location = new System.Drawing.Point(12, 39);
            this.salasListagem1.MaximumSize = new System.Drawing.Size(1094, 479);
            this.salasListagem1.MinimumSize = new System.Drawing.Size(1094, 479);
            this.salasListagem1.Name = "salasListagem1";
            this.salasListagem1.Size = new System.Drawing.Size(1094, 479);
            this.salasListagem1.TabIndex = 9;
            this.salasListagem1.Visible = false;
            // 
            // salasRegistar1
            // 
            this.salasRegistar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.salasRegistar1.Location = new System.Drawing.Point(12, 39);
            this.salasRegistar1.MaximumSize = new System.Drawing.Size(1094, 479);
            this.salasRegistar1.MinimumSize = new System.Drawing.Size(1094, 479);
            this.salasRegistar1.Name = "salasRegistar1";
            this.salasRegistar1.Size = new System.Drawing.Size(1094, 479);
            this.salasRegistar1.TabIndex = 10;
            this.salasRegistar1.Visible = false;
            // 
            // sessoesEditar1
            // 
            this.sessoesEditar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sessoesEditar1.Location = new System.Drawing.Point(12, 39);
            this.sessoesEditar1.MaximumSize = new System.Drawing.Size(1094, 479);
            this.sessoesEditar1.MinimumSize = new System.Drawing.Size(1094, 479);
            this.sessoesEditar1.Name = "sessoesEditar1";
            this.sessoesEditar1.Size = new System.Drawing.Size(1094, 479);
            this.sessoesEditar1.TabIndex = 11;
            this.sessoesEditar1.Visible = false;
            // 
            // sessoesListagem1
            // 
            this.sessoesListagem1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sessoesListagem1.Location = new System.Drawing.Point(12, 39);
            this.sessoesListagem1.MaximumSize = new System.Drawing.Size(1094, 479);
            this.sessoesListagem1.MinimumSize = new System.Drawing.Size(1094, 479);
            this.sessoesListagem1.Name = "sessoesListagem1";
            this.sessoesListagem1.Size = new System.Drawing.Size(1094, 479);
            this.sessoesListagem1.TabIndex = 12;
            this.sessoesListagem1.Visible = false;
            // 
            // sessoesRegistar1
            // 
            this.sessoesRegistar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sessoesRegistar1.Location = new System.Drawing.Point(12, 39);
            this.sessoesRegistar1.MaximumSize = new System.Drawing.Size(1094, 479);
            this.sessoesRegistar1.MinimumSize = new System.Drawing.Size(1094, 479);
            this.sessoesRegistar1.Name = "sessoesRegistar1";
            this.sessoesRegistar1.Size = new System.Drawing.Size(1094, 479);
            this.sessoesRegistar1.TabIndex = 13;
            this.sessoesRegistar1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 530);
            this.Controls.Add(this.sessoesRegistar1);
            this.Controls.Add(this.sessoesListagem1);
            this.Controls.Add(this.sessoesEditar1);
            this.Controls.Add(this.salasRegistar1);
            this.Controls.Add(this.salasListagem1);
            this.Controls.Add(this.salasEditar1);
            this.Controls.Add(this.filmesRegistar1);
            this.Controls.Add(this.filmesListagem1);
            this.Controls.Add(this.filmesEditar1);
            this.Controls.Add(this.registarCinemas1);
            this.Controls.Add(this.editarCinemas1);
            this.Controls.Add(this.CinemasListagem1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(1134, 569);
            this.MinimumSize = new System.Drawing.Size(1134, 569);
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem DashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListagemCinemas;
        private System.Windows.Forms.ToolStripMenuItem RegistarCinema;
        private System.Windows.Forms.ToolStripMenuItem EditarCinema;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListagemSalas;
        private System.Windows.Forms.ToolStripMenuItem RegistarSalas;
        private System.Windows.Forms.ToolStripMenuItem EditarSalas;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListagemFilmes;
        private System.Windows.Forms.ToolStripMenuItem RegistarFilmes;
        private System.Windows.Forms.ToolStripMenuItem EditarFilmes;
        private System.Windows.Forms.ToolStripMenuItem sessõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListagemSessoes;
        private System.Windows.Forms.ToolStripMenuItem RegistarSessoes;
        private System.Windows.Forms.ToolStripMenuItem EditarSessoes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private UserControls.Dashboard dashboard1;
        private UserControls.ListagemCinemas CinemasListagem1;
        private UserControls.EditarCinemas editarCinemas1;
        private UserControls.RegistarCinemas registarCinemas1;
        private UserControls.Filmes.FilmesEditar filmesEditar1;
        private UserControls.Filmes.FilmesListagem filmesListagem1;
        private UserControls.Filmes.FilmesRegistar filmesRegistar1;
        private UserControls.Salas.SalasEditar salasEditar1;
        private UserControls.Salas.SalasListagem salasListagem1;
        private UserControls.Salas.SalasRegistar salasRegistar1;
        private UserControls.Sessoes.SessoesEditar sessoesEditar1;
        private UserControls.Sessoes.SessoesListagem sessoesListagem1;
        private UserControls.Sessoes.SessoesRegistar sessoesRegistar1;
    }
}

