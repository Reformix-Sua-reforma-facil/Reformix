namespace Reformix
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.gbPerfil = new System.Windows.Forms.GroupBox();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.lblDescricaoPerfil = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.grpTema = new System.Windows.Forms.GroupBox();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.cmbNotificacoes = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNotificacoes = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnSalvarTudo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picEngrenagem = new System.Windows.Forms.PictureBox();
            this.btnExcluirConta = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbPerfil.SuspendLayout();
            this.grpTema.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEngrenagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfiguracoes
            // 
            this.lblConfiguracoes.AutoSize = true;
            this.lblConfiguracoes.BackColor = System.Drawing.Color.White;
            this.lblConfiguracoes.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracoes.Location = new System.Drawing.Point(255, 24);
            this.lblConfiguracoes.Name = "lblConfiguracoes";
            this.lblConfiguracoes.Size = new System.Drawing.Size(130, 18);
            this.lblConfiguracoes.TabIndex = 0;
            this.lblConfiguracoes.Text = "Configurações";
            // 
            // gbPerfil
            // 
            this.gbPerfil.BackColor = System.Drawing.Color.White;
            this.gbPerfil.Controls.Add(this.btnPerfil);
            this.gbPerfil.Controls.Add(this.lblDescricaoPerfil);
            this.gbPerfil.Controls.Add(this.lblPerfil);
            this.gbPerfil.Location = new System.Drawing.Point(18, 52);
            this.gbPerfil.Name = "gbPerfil";
            this.gbPerfil.Size = new System.Drawing.Size(400, 119);
            this.gbPerfil.TabIndex = 1;
            this.gbPerfil.TabStop = false;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(91, 74);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(230, 27);
            this.btnPerfil.TabIndex = 2;
            this.btnPerfil.Text = "Editar";
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // lblDescricaoPerfil
            // 
            this.lblDescricaoPerfil.AutoSize = true;
            this.lblDescricaoPerfil.Font = new System.Drawing.Font("Nirmala Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoPerfil.Location = new System.Drawing.Point(6, 37);
            this.lblDescricaoPerfil.Name = "lblDescricaoPerfil";
            this.lblDescricaoPerfil.Size = new System.Drawing.Size(241, 20);
            this.lblDescricaoPerfil.TabIndex = 1;
            this.lblDescricaoPerfil.Text = "Atualize suas informações pessoais";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(10, 16);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(51, 21);
            this.lblPerfil.TabIndex = 0;
            this.lblPerfil.Text = "Perfil";
            // 
            // grpTema
            // 
            this.grpTema.BackColor = System.Drawing.Color.White;
            this.grpTema.Controls.Add(this.cmbTema);
            this.grpTema.Controls.Add(this.lblTema);
            this.grpTema.Location = new System.Drawing.Point(30, 189);
            this.grpTema.Name = "grpTema";
            this.grpTema.Size = new System.Drawing.Size(400, 91);
            this.grpTema.TabIndex = 2;
            this.grpTema.TabStop = false;
            // 
            // cmbTema
            // 
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Location = new System.Drawing.Point(91, 42);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(230, 21);
            this.cmbTema.TabIndex = 8;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(17, 16);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(51, 21);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Tema";
            // 
            // cmbNotificacoes
            // 
            this.cmbNotificacoes.FormattingEnabled = true;
            this.cmbNotificacoes.Location = new System.Drawing.Point(102, 63);
            this.cmbNotificacoes.Name = "cmbNotificacoes";
            this.cmbNotificacoes.Size = new System.Drawing.Size(230, 21);
            this.cmbNotificacoes.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cmbNotificacoes);
            this.groupBox3.Controls.Add(this.lblNotificacoes);
            this.groupBox3.Location = new System.Drawing.Point(30, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // lblNotificacoes
            // 
            this.lblNotificacoes.AutoSize = true;
            this.lblNotificacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacoes.Location = new System.Drawing.Point(8, 24);
            this.lblNotificacoes.Name = "lblNotificacoes";
            this.lblNotificacoes.Size = new System.Drawing.Size(106, 21);
            this.lblNotificacoes.TabIndex = 7;
            this.lblNotificacoes.Text = "Notificações";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.lblHistorico);
            this.groupBox4.Controls.Add(this.btnHistorico);
            this.groupBox4.Location = new System.Drawing.Point(30, 404);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 103);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.Location = new System.Drawing.Point(9, 16);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(169, 21);
            this.lblHistorico.TabIndex = 1;
            this.lblHistorico.Text = "Histórico de projetos";
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(91, 57);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(230, 27);
            this.btnHistorico.TabIndex = 0;
            this.btnHistorico.Text = "Ver histórico completo";
            this.btnHistorico.UseVisualStyleBackColor = true;
            // 
            // btnSalvarTudo
            // 
            this.btnSalvarTudo.Location = new System.Drawing.Point(310, 522);
            this.btnSalvarTudo.Name = "btnSalvarTudo";
            this.btnSalvarTudo.Size = new System.Drawing.Size(108, 35);
            this.btnSalvarTudo.TabIndex = 5;
            this.btnSalvarTudo.Text = "Salvar Tudo";
            this.btnSalvarTudo.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(18, 522);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(108, 35);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.picEngrenagem);
            this.groupBox1.Controls.Add(this.btnExcluirConta);
            this.groupBox1.Controls.Add(this.btnSalvarTudo);
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Controls.Add(this.lblAppName);
            this.groupBox1.Controls.Add(this.pbLogo);
            this.groupBox1.Controls.Add(this.gbPerfil);
            this.groupBox1.Controls.Add(this.lblConfiguracoes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 601);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // picEngrenagem
            // 
            this.picEngrenagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEngrenagem.BackgroundImage")));
            this.picEngrenagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picEngrenagem.Location = new System.Drawing.Point(382, 24);
            this.picEngrenagem.Name = "picEngrenagem";
            this.picEngrenagem.Size = new System.Drawing.Size(36, 23);
            this.picEngrenagem.TabIndex = 8;
            this.picEngrenagem.TabStop = false;
            // 
            // btnExcluirConta
            // 
            this.btnExcluirConta.Location = new System.Drawing.Point(171, 522);
            this.btnExcluirConta.Name = "btnExcluirConta";
            this.btnExcluirConta.Size = new System.Drawing.Size(94, 35);
            this.btnExcluirConta.TabIndex = 7;
            this.btnExcluirConta.Text = "Excluir conta";
            this.btnExcluirConta.UseVisualStyleBackColor = true;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Nirmala Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(89, 25);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(106, 25);
            this.lblAppName.TabIndex = 3;
            this.lblAppName.Text = "REFORMIX";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(18, 19);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(78, 38);
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(459, 640);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpTema);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Configurações";
            this.gbPerfil.ResumeLayout(false);
            this.gbPerfil.PerformLayout();
            this.grpTema.ResumeLayout(false);
            this.grpTema.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEngrenagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConfiguracoes;
        private System.Windows.Forms.GroupBox gbPerfil;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Label lblDescricaoPerfil;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.GroupBox grpTema;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSalvarTudo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblNotificacoes;
        private System.Windows.Forms.ComboBox cmbNotificacoes;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnExcluirConta;
        private System.Windows.Forms.PictureBox picEngrenagem;
        private System.Windows.Forms.ComboBox cmbTema;
    }
}

