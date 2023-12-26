namespace ImplementacaoRedesEletricasInteligentes.Forms
{
    partial class FormAtribuirProjeto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtribuirProjeto));
            this.btnPreparacao = new RJCodeAdvance.RJControls.RJButton();
            this.btnAquisicao = new RJCodeAdvance.RJControls.RJButton();
            this.btnInstacao = new RJCodeAdvance.RJControls.RJButton();
            this.btnTestes = new RJCodeAdvance.RJControls.RJButton();
            this.btnTreinamento = new RJCodeAdvance.RJControls.RJButton();
            this.btnConfirmar = new RJCodeAdvance.RJControls.RJButton();
            this.ptbPainelSolar = new System.Windows.Forms.PictureBox();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.lbProjeto = new System.Windows.Forms.Label();
            this.cbProjetos = new RJCodeAdvance.RJControls.RJComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPainelSolar)).BeginInit();
            this.panelFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreparacao
            // 
            this.btnPreparacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreparacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnPreparacao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnPreparacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnPreparacao.BorderRadius = 12;
            this.btnPreparacao.BorderSize = 1;
            this.btnPreparacao.Enabled = false;
            this.btnPreparacao.FlatAppearance.BorderSize = 0;
            this.btnPreparacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreparacao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreparacao.ForeColor = System.Drawing.Color.White;
            this.btnPreparacao.Location = new System.Drawing.Point(23, 12);
            this.btnPreparacao.Name = "btnPreparacao";
            this.btnPreparacao.Size = new System.Drawing.Size(140, 49);
            this.btnPreparacao.TabIndex = 35;
            this.btnPreparacao.Text = "Preparação do Projeto";
            this.btnPreparacao.TextColor = System.Drawing.Color.White;
            this.btnPreparacao.UseVisualStyleBackColor = false;
            this.btnPreparacao.Click += new System.EventHandler(this.btnPreparacao_Click);
            // 
            // btnAquisicao
            // 
            this.btnAquisicao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAquisicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnAquisicao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnAquisicao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnAquisicao.BorderRadius = 12;
            this.btnAquisicao.BorderSize = 1;
            this.btnAquisicao.Enabled = false;
            this.btnAquisicao.FlatAppearance.BorderSize = 0;
            this.btnAquisicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAquisicao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAquisicao.ForeColor = System.Drawing.Color.White;
            this.btnAquisicao.Location = new System.Drawing.Point(179, 12);
            this.btnAquisicao.Name = "btnAquisicao";
            this.btnAquisicao.Size = new System.Drawing.Size(140, 49);
            this.btnAquisicao.TabIndex = 36;
            this.btnAquisicao.Text = "Aquisição de equipamentos";
            this.btnAquisicao.TextColor = System.Drawing.Color.White;
            this.btnAquisicao.UseVisualStyleBackColor = false;
            this.btnAquisicao.Click += new System.EventHandler(this.btnAquisicao_Click);
            // 
            // btnInstacao
            // 
            this.btnInstacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInstacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnInstacao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnInstacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnInstacao.BorderRadius = 12;
            this.btnInstacao.BorderSize = 1;
            this.btnInstacao.Enabled = false;
            this.btnInstacao.FlatAppearance.BorderSize = 0;
            this.btnInstacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstacao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInstacao.ForeColor = System.Drawing.Color.White;
            this.btnInstacao.Location = new System.Drawing.Point(335, 12);
            this.btnInstacao.Name = "btnInstacao";
            this.btnInstacao.Size = new System.Drawing.Size(140, 49);
            this.btnInstacao.TabIndex = 37;
            this.btnInstacao.Text = "Instalação e configuração";
            this.btnInstacao.TextColor = System.Drawing.Color.White;
            this.btnInstacao.UseVisualStyleBackColor = false;
            this.btnInstacao.Click += new System.EventHandler(this.btnInstacao_Click);
            // 
            // btnTestes
            // 
            this.btnTestes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTestes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnTestes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnTestes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnTestes.BorderRadius = 12;
            this.btnTestes.BorderSize = 1;
            this.btnTestes.Enabled = false;
            this.btnTestes.FlatAppearance.BorderSize = 0;
            this.btnTestes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTestes.ForeColor = System.Drawing.Color.White;
            this.btnTestes.Location = new System.Drawing.Point(491, 12);
            this.btnTestes.Name = "btnTestes";
            this.btnTestes.Size = new System.Drawing.Size(140, 49);
            this.btnTestes.TabIndex = 38;
            this.btnTestes.Text = "Testes e validação";
            this.btnTestes.TextColor = System.Drawing.Color.White;
            this.btnTestes.UseVisualStyleBackColor = false;
            this.btnTestes.Click += new System.EventHandler(this.btnTestes_Click);
            // 
            // btnTreinamento
            // 
            this.btnTreinamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTreinamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnTreinamento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnTreinamento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnTreinamento.BorderRadius = 12;
            this.btnTreinamento.BorderSize = 1;
            this.btnTreinamento.Enabled = false;
            this.btnTreinamento.FlatAppearance.BorderSize = 0;
            this.btnTreinamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreinamento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTreinamento.ForeColor = System.Drawing.Color.White;
            this.btnTreinamento.Location = new System.Drawing.Point(647, 12);
            this.btnTreinamento.Name = "btnTreinamento";
            this.btnTreinamento.Size = new System.Drawing.Size(140, 49);
            this.btnTreinamento.TabIndex = 39;
            this.btnTreinamento.Text = "Treinameno e suporte";
            this.btnTreinamento.TextColor = System.Drawing.Color.White;
            this.btnTreinamento.UseVisualStyleBackColor = false;
            this.btnTreinamento.Click += new System.EventHandler(this.btnTreinamento_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnConfirmar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnConfirmar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.btnConfirmar.BorderRadius = 12;
            this.btnConfirmar.BorderSize = 1;
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(802, 12);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(140, 49);
            this.btnConfirmar.TabIndex = 40;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextColor = System.Drawing.Color.White;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // ptbPainelSolar
            // 
            this.ptbPainelSolar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbPainelSolar.BackColor = System.Drawing.Color.Transparent;
            this.ptbPainelSolar.Image = ((System.Drawing.Image)(resources.GetObject("ptbPainelSolar.Image")));
            this.ptbPainelSolar.Location = new System.Drawing.Point(208, 120);
            this.ptbPainelSolar.Name = "ptbPainelSolar";
            this.ptbPainelSolar.Size = new System.Drawing.Size(579, 274);
            this.ptbPainelSolar.TabIndex = 41;
            this.ptbPainelSolar.TabStop = false;
            // 
            // panelFundo
            // 
            this.panelFundo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFundo.BackColor = System.Drawing.SystemColors.Control;
            this.panelFundo.Controls.Add(this.lbProjeto);
            this.panelFundo.Controls.Add(this.cbProjetos);
            this.panelFundo.Location = new System.Drawing.Point(0, 67);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(964, 399);
            this.panelFundo.TabIndex = 42;
            // 
            // lbProjeto
            // 
            this.lbProjeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProjeto.AutoSize = true;
            this.lbProjeto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbProjeto.Location = new System.Drawing.Point(15, 23);
            this.lbProjeto.Name = "lbProjeto";
            this.lbProjeto.Size = new System.Drawing.Size(55, 17);
            this.lbProjeto.TabIndex = 44;
            this.lbProjeto.Text = "Projeto:";
            // 
            // cbProjetos
            // 
            this.cbProjetos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProjetos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbProjetos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.cbProjetos.BorderSize = 1;
            this.cbProjetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbProjetos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProjetos.ForeColor = System.Drawing.Color.DimGray;
            this.cbProjetos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.cbProjetos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbProjetos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbProjetos.ListTextColor = System.Drawing.Color.DimGray;
            this.cbProjetos.Location = new System.Drawing.Point(76, 17);
            this.cbProjetos.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbProjetos.Name = "cbProjetos";
            this.cbProjetos.Padding = new System.Windows.Forms.Padding(1);
            this.cbProjetos.Size = new System.Drawing.Size(212, 30);
            this.cbProjetos.TabIndex = 43;
            this.cbProjetos.Texts = "Selecione o ID do projeto";
            this.cbProjetos.OnSelectedIndexChanged += new System.EventHandler(this.cbProjetos_OnSelectedIndexChanged);
            // 
            // FormAtribuirProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(964, 466);
            this.Controls.Add(this.btnPreparacao);
            this.Controls.Add(this.btnAquisicao);
            this.Controls.Add(this.btnInstacao);
            this.Controls.Add(this.btnTestes);
            this.Controls.Add(this.btnTreinamento);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.ptbPainelSolar);
            this.Controls.Add(this.panelFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAtribuirProjeto";
            this.Text = "FormAtribuirProjeto";
            this.Load += new System.EventHandler(this.FormAtribuirProjeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPainelSolar)).EndInit();
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RJCodeAdvance.RJControls.RJButton btnPreparacao;
        private RJCodeAdvance.RJControls.RJButton btnAquisicao;
        private RJCodeAdvance.RJControls.RJButton btnInstacao;
        private RJCodeAdvance.RJControls.RJButton btnTestes;
        private RJCodeAdvance.RJControls.RJButton btnTreinamento;
        private RJCodeAdvance.RJControls.RJButton btnConfirmar;
        private System.Windows.Forms.PictureBox ptbPainelSolar;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Label lbProjeto;
        public RJCodeAdvance.RJControls.RJComboBox cbProjetos;
    }
}