namespace Cinema.UserControls
{
    partial class EditarCinemas
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditarBTN = new System.Windows.Forms.Button();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.ComboBoxELocal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxNomeCinema = new System.Windows.Forms.TextBox();
            this.ComboBoxCinema = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EditarBTN);
            this.panel1.Controls.Add(this.ClearBTN);
            this.panel1.Controls.Add(this.ComboBoxELocal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBoxNomeCinema);
            this.panel1.Controls.Add(this.ComboBoxCinema);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 403);
            this.panel1.TabIndex = 1;
            // 
            // EditarBTN
            // 
            this.EditarBTN.Location = new System.Drawing.Point(973, 368);
            this.EditarBTN.Name = "EditarBTN";
            this.EditarBTN.Size = new System.Drawing.Size(75, 23);
            this.EditarBTN.TabIndex = 12;
            this.EditarBTN.Text = "Editar";
            this.EditarBTN.UseVisualStyleBackColor = true;
            this.EditarBTN.Click += new System.EventHandler(this.EditarBTN_Click);
            // 
            // ClearBTN
            // 
            this.ClearBTN.BackColor = System.Drawing.Color.LightGray;
            this.ClearBTN.Location = new System.Drawing.Point(892, 368);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(75, 23);
            this.ClearBTN.TabIndex = 11;
            this.ClearBTN.Text = "Limpar";
            this.ClearBTN.UseVisualStyleBackColor = false;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // ComboBoxELocal
            // 
            this.ComboBoxELocal.FormattingEnabled = true;
            this.ComboBoxELocal.Location = new System.Drawing.Point(232, 153);
            this.ComboBoxELocal.Name = "ComboBoxELocal";
            this.ComboBoxELocal.Size = new System.Drawing.Size(160, 21);
            this.ComboBoxELocal.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Local";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // TextBoxNomeCinema
            // 
            this.TextBoxNomeCinema.Location = new System.Drawing.Point(19, 153);
            this.TextBoxNomeCinema.Name = "TextBoxNomeCinema";
            this.TextBoxNomeCinema.Size = new System.Drawing.Size(181, 20);
            this.TextBoxNomeCinema.TabIndex = 6;
            // 
            // ComboBoxCinema
            // 
            this.ComboBoxCinema.FormattingEnabled = true;
            this.ComboBoxCinema.Location = new System.Drawing.Point(19, 52);
            this.ComboBoxCinema.Name = "ComboBoxCinema";
            this.ComboBoxCinema.Size = new System.Drawing.Size(288, 21);
            this.ComboBoxCinema.TabIndex = 5;
            this.ComboBoxCinema.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCinema_SelectedIndexChanged);
            // 
            // EditarCinemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1094, 479);
            this.MinimumSize = new System.Drawing.Size(1094, 479);
            this.Name = "EditarCinemas";
            this.Size = new System.Drawing.Size(1094, 479);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ComboBoxCinema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxNomeCinema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxELocal;
        private System.Windows.Forms.Button EditarBTN;
        private System.Windows.Forms.Button ClearBTN;
    }
}
