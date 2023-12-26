namespace ImplementacaoRedesEletricasInteligentes
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnConsulta = new FontAwesome.Sharp.IconButton();
            this.btnAtribuirProjeto = new FontAwesome.Sharp.IconButton();
            this.btnProjeto = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMenuRecall = new FontAwesome.Sharp.IconButton();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinize = new FontAwesome.Sharp.IconButton();
            this.btnMaxmize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelSombra = new System.Windows.Forms.Panel();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(161)))));
            this.panelMenu.Controls.Add(this.btnConsulta);
            this.panelMenu.Controls.Add(this.btnAtribuirProjeto);
            this.panelMenu.Controls.Add(this.btnProjeto);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 535);
            this.panelMenu.TabIndex = 0;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConsulta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConsulta.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnConsulta.IconColor = System.Drawing.Color.Gainsboro;
            this.btnConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsulta.IconSize = 32;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(0, 320);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConsulta.Size = new System.Drawing.Size(220, 60);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Tag = "Consulta";
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnAtribuirProjeto
            // 
            this.btnAtribuirProjeto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtribuirProjeto.FlatAppearance.BorderSize = 0;
            this.btnAtribuirProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtribuirProjeto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAtribuirProjeto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAtribuirProjeto.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btnAtribuirProjeto.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAtribuirProjeto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtribuirProjeto.IconSize = 32;
            this.btnAtribuirProjeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtribuirProjeto.Location = new System.Drawing.Point(0, 260);
            this.btnAtribuirProjeto.Name = "btnAtribuirProjeto";
            this.btnAtribuirProjeto.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAtribuirProjeto.Size = new System.Drawing.Size(220, 60);
            this.btnAtribuirProjeto.TabIndex = 3;
            this.btnAtribuirProjeto.Tag = "Atribuir Projeto";
            this.btnAtribuirProjeto.Text = "Atribuir Projeto";
            this.btnAtribuirProjeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtribuirProjeto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtribuirProjeto.UseVisualStyleBackColor = true;
            this.btnAtribuirProjeto.Click += new System.EventHandler(this.btnAtribuirProjeto_Click);
            // 
            // btnProjeto
            // 
            this.btnProjeto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjeto.FlatAppearance.BorderSize = 0;
            this.btnProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjeto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnProjeto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProjeto.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnProjeto.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProjeto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProjeto.IconSize = 32;
            this.btnProjeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjeto.Location = new System.Drawing.Point(0, 200);
            this.btnProjeto.Name = "btnProjeto";
            this.btnProjeto.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProjeto.Size = new System.Drawing.Size(220, 60);
            this.btnProjeto.TabIndex = 2;
            this.btnProjeto.Tag = "Projeto";
            this.btnProjeto.Text = "Projeto";
            this.btnProjeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjeto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjeto.UseVisualStyleBackColor = true;
            this.btnProjeto.Click += new System.EventHandler(this.btnProjeto_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 140);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(220, 60);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "Home";
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnMenuRecall);
            this.panelLogo.Controls.Add(this.btnReset);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnMenuRecall
            // 
            this.btnMenuRecall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuRecall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(161)))));
            this.btnMenuRecall.FlatAppearance.BorderSize = 0;
            this.btnMenuRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRecall.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuRecall.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnMenuRecall.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMenuRecall.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMenuRecall.IconSize = 30;
            this.btnMenuRecall.Location = new System.Drawing.Point(160, 0);
            this.btnMenuRecall.Name = "btnMenuRecall";
            this.btnMenuRecall.Size = new System.Drawing.Size(60, 60);
            this.btnMenuRecall.TabIndex = 4;
            this.btnMenuRecall.UseVisualStyleBackColor = false;
            this.btnMenuRecall.Click += new System.EventHandler(this.btnMenuRecall_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::ImplementacaoRedesEletricasInteligentes.Properties.Resources.logo;
            this.btnReset.Location = new System.Drawing.Point(12, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(177, 106);
            this.btnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReset.TabIndex = 0;
            this.btnReset.TabStop = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(161)))));
            this.panelTitleBar.Controls.Add(this.btnMinize);
            this.panelTitleBar.Controls.Add(this.btnMaxmize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(964, 60);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinize
            // 
            this.btnMinize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.btnMinize.FlatAppearance.BorderSize = 0;
            this.btnMinize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinize.IconColor = System.Drawing.Color.White;
            this.btnMinize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinize.IconSize = 20;
            this.btnMinize.Location = new System.Drawing.Point(829, 0);
            this.btnMinize.Name = "btnMinize";
            this.btnMinize.Size = new System.Drawing.Size(45, 25);
            this.btnMinize.TabIndex = 3;
            this.btnMinize.UseVisualStyleBackColor = false;
            this.btnMinize.Click += new System.EventHandler(this.btnMinize_Click);
            // 
            // btnMaxmize
            // 
            this.btnMaxmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxmize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(254)))));
            this.btnMaxmize.FlatAppearance.BorderSize = 0;
            this.btnMaxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxmize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMaxmize.IconColor = System.Drawing.Color.White;
            this.btnMaxmize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMaxmize.IconSize = 20;
            this.btnMaxmize.Location = new System.Drawing.Point(874, 0);
            this.btnMaxmize.Name = "btnMaxmize";
            this.btnMaxmize.Size = new System.Drawing.Size(45, 25);
            this.btnMaxmize.TabIndex = 2;
            this.btnMaxmize.UseVisualStyleBackColor = false;
            this.btnMaxmize.Click += new System.EventHandler(this.btnMaxmize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(919, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(58, 20);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(172, 17);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Redes Elétricas Inteligentes";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(161)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Gold;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Battery;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Gold;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(20, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelSombra
            // 
            this.panelSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(161)))));
            this.panelSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSombra.Location = new System.Drawing.Point(220, 60);
            this.panelSombra.Name = "panelSombra";
            this.panelSombra.Size = new System.Drawing.Size(964, 9);
            this.panelSombra.TabIndex = 2;
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(161)))));
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(220, 69);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(964, 466);
            this.panelFundo.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 535);
            this.Controls.Add(this.panelFundo);
            this.Controls.Add(this.panelSombra);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Redes Elétricas Inteligentes";
            this.Resize += new System.EventHandler(this.Menu_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnAtribuirProjeto;
        private FontAwesome.Sharp.IconButton btnProjeto;
        private System.Windows.Forms.PictureBox btnReset;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinize;
        private FontAwesome.Sharp.IconButton btnMaxmize;
        private FontAwesome.Sharp.IconButton btnMenuRecall;
        private System.Windows.Forms.Panel panelSombra;
        private System.Windows.Forms.Panel panelFundo;
        private FontAwesome.Sharp.IconButton btnConsulta;
    }
}

