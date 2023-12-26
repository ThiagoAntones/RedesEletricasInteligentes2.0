namespace ImplementacaoRedesEletricasInteligentes.Forms
{
    partial class FormNivel1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtProjeto = new System.Windows.Forms.TextBox();
            this.lblProjeto = new System.Windows.Forms.Label();
            this.txtAtividade = new System.Windows.Forms.TextBox();
            this.lblAtividade = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.dgvNivel1 = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.Level2 = new RJCodeAdvance.RJControls.RJButton();
            this.lblNivel1 = new System.Windows.Forms.Label();
            this.btnLimpar = new FontAwesome.Sharp.IconButton();
            this.btnDel = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnCadastrar = new FontAwesome.Sharp.IconButton();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNivel1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProjeto
            // 
            this.txtProjeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProjeto.Enabled = false;
            this.txtProjeto.Location = new System.Drawing.Point(587, 51);
            this.txtProjeto.Name = "txtProjeto";
            this.txtProjeto.Size = new System.Drawing.Size(100, 20);
            this.txtProjeto.TabIndex = 39;
            this.txtProjeto.Text = "automático";
            this.txtProjeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProjeto
            // 
            this.lblProjeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProjeto.AutoSize = true;
            this.lblProjeto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblProjeto.Location = new System.Drawing.Point(513, 54);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(55, 17);
            this.lblProjeto.TabIndex = 38;
            this.lblProjeto.Text = "Projeto:";
            // 
            // txtAtividade
            // 
            this.txtAtividade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAtividade.Enabled = false;
            this.txtAtividade.Location = new System.Drawing.Point(587, 77);
            this.txtAtividade.Name = "txtAtividade";
            this.txtAtividade.Size = new System.Drawing.Size(100, 20);
            this.txtAtividade.TabIndex = 41;
            this.txtAtividade.Text = "automático";
            this.txtAtividade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAtividade
            // 
            this.lblAtividade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAtividade.AutoSize = true;
            this.lblAtividade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAtividade.Location = new System.Drawing.Point(513, 80);
            this.lblAtividade.Name = "lblAtividade";
            this.lblAtividade.Size = new System.Drawing.Size(68, 17);
            this.lblAtividade.TabIndex = 40;
            this.lblAtividade.Text = "Atividade:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.Location = new System.Drawing.Point(587, 103);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(240, 93);
            this.txtDescricao.TabIndex = 42;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.Location = new System.Drawing.Point(513, 116);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 17);
            this.lblDescricao.TabIndex = 43;
            this.lblDescricao.Text = "Descrição:";
            // 
            // dgvNivel1
            // 
            this.dgvNivel1.AllowUserToAddRows = false;
            this.dgvNivel1.AllowUserToDeleteRows = false;
            this.dgvNivel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvNivel1.BackgroundColor = System.Drawing.Color.White;
            this.dgvNivel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNivel1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvNivel1.Location = new System.Drawing.Point(43, 55);
            this.dgvNivel1.Name = "dgvNivel1";
            this.dgvNivel1.ReadOnly = true;
            this.dgvNivel1.RowHeadersVisible = false;
            this.dgvNivel1.Size = new System.Drawing.Size(445, 196);
            this.dgvNivel1.TabIndex = 46;
            this.dgvNivel1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNivel1_CellClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.Location = new System.Drawing.Point(218, 29);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(147, 20);
            this.txtPesquisa.TabIndex = 45;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPesquisa.Location = new System.Drawing.Point(145, 30);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(64, 17);
            this.lblPesquisa.TabIndex = 44;
            this.lblPesquisa.Text = "Pesquisa:";
            // 
            // Level2
            // 
            this.Level2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Level2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Level2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Level2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Level2.BorderRadius = 5;
            this.Level2.BorderSize = 0;
            this.Level2.FlatAppearance.BorderSize = 0;
            this.Level2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Level2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Level2.ForeColor = System.Drawing.Color.White;
            this.Level2.Location = new System.Drawing.Point(784, 19);
            this.Level2.Name = "Level2";
            this.Level2.Size = new System.Drawing.Size(109, 39);
            this.Level2.TabIndex = 51;
            this.Level2.Text = "Ir para nivel 2";
            this.Level2.TextColor = System.Drawing.Color.White;
            this.Level2.UseVisualStyleBackColor = false;
            this.Level2.Click += new System.EventHandler(this.Level2_Click);
            // 
            // lblNivel1
            // 
            this.lblNivel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNivel1.AutoSize = true;
            this.lblNivel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel1.Location = new System.Drawing.Point(23, 19);
            this.lblNivel1.Name = "lblNivel1";
            this.lblNivel1.Size = new System.Drawing.Size(57, 21);
            this.lblNivel1.TabIndex = 52;
            this.lblNivel1.Text = "Nivel 1";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpar.IconColor = System.Drawing.Color.White;
            this.btnLimpar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpar.IconSize = 32;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(700, 290);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLimpar.Size = new System.Drawing.Size(193, 60);
            this.btnLimpar.TabIndex = 50;
            this.btnLimpar.Tag = "";
            this.btnLimpar.Text = "Limpar campos";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimparcampo_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(98)))), ((int)(((byte)(97)))));
            this.btnDel.Enabled = false;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDel.IconColor = System.Drawing.Color.White;
            this.btnDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDel.IconSize = 32;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(472, 290);
            this.btnDel.Name = "btnDel";
            this.btnDel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDel.Size = new System.Drawing.Size(193, 60);
            this.btnDel.TabIndex = 49;
            this.btnDel.Tag = "";
            this.btnDel.Text = "Excluir";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDelProjeto_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(149)))), ((int)(((byte)(241)))));
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEdit.IconColor = System.Drawing.Color.White;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 32;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(258, 290);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEdit.Size = new System.Drawing.Size(193, 60);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Tag = "";
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEditProjeto_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnCadastrar.IconColor = System.Drawing.Color.White;
            this.btnCadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrar.IconSize = 32;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(27, 290);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(209, 60);
            this.btnCadastrar.TabIndex = 47;
            this.btnCadastrar.Tag = "";
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panelFundo
            // 
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(919, 375);
            this.panelFundo.TabIndex = 69;
            this.panelFundo.Visible = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.ForeColor = System.Drawing.Color.Black;
            this.lblMensagem.Location = new System.Drawing.Point(215, 254);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(133, 17);
            this.lblMensagem.TabIndex = 70;
            this.lblMensagem.Text = "Buscando, aguarde...";
            this.lblMensagem.Visible = false;
            // 
            // FormNivel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 375);
            this.Controls.Add(this.panelFundo);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblNivel1);
            this.Controls.Add(this.Level2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvNivel1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtAtividade);
            this.Controls.Add(this.lblAtividade);
            this.Controls.Add(this.txtProjeto);
            this.Controls.Add(this.lblProjeto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNivel1";
            this.Text = "FormNivel1";
            this.Load += new System.EventHandler(this.FormNivel1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNivel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProjeto;
        private System.Windows.Forms.Label lblProjeto;
        private System.Windows.Forms.TextBox txtAtividade;
        private System.Windows.Forms.Label lblAtividade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.DataGridView dgvNivel1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private FontAwesome.Sharp.IconButton btnLimpar;
        private FontAwesome.Sharp.IconButton btnDel;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnCadastrar;
        private RJCodeAdvance.RJControls.RJButton Level2;
        private System.Windows.Forms.Label lblNivel1;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Label lblMensagem;
    }
}