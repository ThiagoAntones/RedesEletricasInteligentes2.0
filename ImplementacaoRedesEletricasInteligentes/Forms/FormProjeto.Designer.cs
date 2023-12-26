namespace ImplementacaoRedesEletricasInteligentes.Forms
{
    partial class FormProjeto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblTermino = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.dtTermino = new RJCodeAdvance.RJControls.RJDatePicker();
            this.dtInicio = new RJCodeAdvance.RJControls.RJDatePicker();
            this.btnDelProjeto = new FontAwesome.Sharp.IconButton();
            this.btnEditProjeto = new FontAwesome.Sharp.IconButton();
            this.btnAddProjeto = new FontAwesome.Sharp.IconButton();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dgvProjetos = new System.Windows.Forms.DataGridView();
            this.btnLimparcampo = new FontAwesome.Sharp.IconButton();
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(592, 74);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(54, 17);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(654, 72);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.Text = "automático";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.Location = new System.Drawing.Point(580, 151);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 17);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblInicio.Location = new System.Drawing.Point(605, 204);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(43, 17);
            this.lblInicio.TabIndex = 6;
            this.lblInicio.Text = "Início:";
            // 
            // lblTermino
            // 
            this.lblTermino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTermino.AutoSize = true;
            this.lblTermino.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTermino.Location = new System.Drawing.Point(593, 253);
            this.lblTermino.Name = "lblTermino";
            this.lblTermino.Size = new System.Drawing.Size(60, 17);
            this.lblTermino.TabIndex = 7;
            this.lblTermino.Text = "Termíno:";
            // 
            // lblCusto
            // 
            this.lblCusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCusto.AutoSize = true;
            this.lblCusto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCusto.Location = new System.Drawing.Point(589, 300);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(65, 17);
            this.lblCusto.TabIndex = 8;
            this.lblCusto.Text = "Custo R$:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.Location = new System.Drawing.Point(654, 138);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(118, 42);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtCusto
            // 
            this.txtCusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCusto.Location = new System.Drawing.Point(654, 298);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(100, 20);
            this.txtCusto.TabIndex = 5;
            this.txtCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusto_KeyPress);
            this.txtCusto.Leave += new System.EventHandler(this.txtCusto_Leave);
            // 
            // dtTermino
            // 
            this.dtTermino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtTermino.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtTermino.BorderSize = 0;
            this.dtTermino.CustomFormat = "yyyy-MM-dd";
            this.dtTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtTermino.Location = new System.Drawing.Point(654, 243);
            this.dtTermino.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Size = new System.Drawing.Size(254, 35);
            this.dtTermino.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtTermino.TabIndex = 4;
            this.dtTermino.TextColor = System.Drawing.Color.White;
            // 
            // dtInicio
            // 
            this.dtInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtInicio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtInicio.BorderSize = 0;
            this.dtInicio.CustomFormat = "yyyy-MM-dd";
            this.dtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtInicio.Location = new System.Drawing.Point(654, 194);
            this.dtInicio.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(254, 35);
            this.dtInicio.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtInicio.TabIndex = 3;
            this.dtInicio.TextColor = System.Drawing.Color.White;
            // 
            // btnDelProjeto
            // 
            this.btnDelProjeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelProjeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(98)))), ((int)(((byte)(97)))));
            this.btnDelProjeto.Enabled = false;
            this.btnDelProjeto.FlatAppearance.BorderSize = 0;
            this.btnDelProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelProjeto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelProjeto.ForeColor = System.Drawing.Color.White;
            this.btnDelProjeto.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelProjeto.IconColor = System.Drawing.Color.White;
            this.btnDelProjeto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelProjeto.IconSize = 32;
            this.btnDelProjeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelProjeto.Location = new System.Drawing.Point(466, 369);
            this.btnDelProjeto.Name = "btnDelProjeto";
            this.btnDelProjeto.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDelProjeto.Size = new System.Drawing.Size(193, 60);
            this.btnDelProjeto.TabIndex = 18;
            this.btnDelProjeto.Tag = "";
            this.btnDelProjeto.Text = "Excluir projeto";
            this.btnDelProjeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelProjeto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelProjeto.UseVisualStyleBackColor = false;
            this.btnDelProjeto.Click += new System.EventHandler(this.btnDelProjeto_Click);
            // 
            // btnEditProjeto
            // 
            this.btnEditProjeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditProjeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(149)))), ((int)(((byte)(241)))));
            this.btnEditProjeto.Enabled = false;
            this.btnEditProjeto.FlatAppearance.BorderSize = 0;
            this.btnEditProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProjeto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEditProjeto.ForeColor = System.Drawing.Color.White;
            this.btnEditProjeto.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditProjeto.IconColor = System.Drawing.Color.White;
            this.btnEditProjeto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditProjeto.IconSize = 32;
            this.btnEditProjeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProjeto.Location = new System.Drawing.Point(252, 369);
            this.btnEditProjeto.Name = "btnEditProjeto";
            this.btnEditProjeto.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEditProjeto.Size = new System.Drawing.Size(193, 60);
            this.btnEditProjeto.TabIndex = 17;
            this.btnEditProjeto.Tag = "";
            this.btnEditProjeto.Text = "Editar projeto";
            this.btnEditProjeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProjeto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditProjeto.UseVisualStyleBackColor = false;
            this.btnEditProjeto.Click += new System.EventHandler(this.btnEditProjeto_Click);
            // 
            // btnAddProjeto
            // 
            this.btnAddProjeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProjeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.btnAddProjeto.FlatAppearance.BorderSize = 0;
            this.btnAddProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProjeto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddProjeto.ForeColor = System.Drawing.Color.White;
            this.btnAddProjeto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddProjeto.IconColor = System.Drawing.Color.White;
            this.btnAddProjeto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddProjeto.IconSize = 32;
            this.btnAddProjeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProjeto.Location = new System.Drawing.Point(37, 369);
            this.btnAddProjeto.Name = "btnAddProjeto";
            this.btnAddProjeto.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAddProjeto.Size = new System.Drawing.Size(193, 60);
            this.btnAddProjeto.TabIndex = 2;
            this.btnAddProjeto.Tag = "";
            this.btnAddProjeto.Text = "Adicionar projeto";
            this.btnAddProjeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProjeto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProjeto.UseVisualStyleBackColor = false;
            this.btnAddProjeto.Click += new System.EventHandler(this.btnAddProjeto_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.Location = new System.Drawing.Point(654, 105);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(604, 107);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(45, 17);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Título:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.Location = new System.Drawing.Point(250, 28);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(147, 20);
            this.txtPesquisa.TabIndex = 23;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPesquisa.Location = new System.Drawing.Point(177, 29);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(64, 17);
            this.lblPesquisa.TabIndex = 22;
            this.lblPesquisa.Text = "Pesquisa:";
            // 
            // dgvProjetos
            // 
            this.dgvProjetos.AllowUserToAddRows = false;
            this.dgvProjetos.AllowUserToDeleteRows = false;
            this.dgvProjetos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProjetos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjetos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjetos.Location = new System.Drawing.Point(37, 54);
            this.dgvProjetos.Name = "dgvProjetos";
            this.dgvProjetos.ReadOnly = true;
            this.dgvProjetos.RowHeadersVisible = false;
            this.dgvProjetos.Size = new System.Drawing.Size(520, 278);
            this.dgvProjetos.TabIndex = 24;
            this.dgvProjetos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjetos_CellClick);
            // 
            // btnLimparcampo
            // 
            this.btnLimparcampo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimparcampo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnLimparcampo.FlatAppearance.BorderSize = 0;
            this.btnLimparcampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparcampo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLimparcampo.ForeColor = System.Drawing.Color.White;
            this.btnLimparcampo.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimparcampo.IconColor = System.Drawing.Color.White;
            this.btnLimparcampo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimparcampo.IconSize = 32;
            this.btnLimparcampo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparcampo.Location = new System.Drawing.Point(710, 369);
            this.btnLimparcampo.Name = "btnLimparcampo";
            this.btnLimparcampo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLimparcampo.Size = new System.Drawing.Size(193, 60);
            this.btnLimparcampo.TabIndex = 25;
            this.btnLimparcampo.Tag = "";
            this.btnLimparcampo.Text = "Limpar campos";
            this.btnLimparcampo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparcampo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimparcampo.UseVisualStyleBackColor = false;
            this.btnLimparcampo.Click += new System.EventHandler(this.btnLimparcampo_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.ForeColor = System.Drawing.Color.Black;
            this.lblMensagem.Location = new System.Drawing.Point(237, 335);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(133, 17);
            this.lblMensagem.TabIndex = 40;
            this.lblMensagem.Text = "Buscando, aguarde...";
            this.lblMensagem.Visible = false;
            // 
            // FormProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 466);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnLimparcampo);
            this.Controls.Add(this.dgvProjetos);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnDelProjeto);
            this.Controls.Add(this.btnEditProjeto);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.dtTermino);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.lblTermino);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAddProjeto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProjeto";
            this.Text = "FormProjeto";
            this.Load += new System.EventHandler(this.FormProjeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjetos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAddProjeto;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblTermino;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCusto;
        private RJCodeAdvance.RJControls.RJDatePicker dtTermino;
        private RJCodeAdvance.RJControls.RJDatePicker dtInicio;
        private FontAwesome.Sharp.IconButton btnEditProjeto;
        private FontAwesome.Sharp.IconButton btnDelProjeto;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridView dgvProjetos;
        private FontAwesome.Sharp.IconButton btnLimparcampo;
        private System.Windows.Forms.Label lblMensagem;
    }
}