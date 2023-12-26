namespace ImplementacaoRedesEletricasInteligentes.Forms
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.lblNumeroProjetos = new System.Windows.Forms.Label();
            this.lbProjetosRegistrados = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.Relogio24h = new System.Windows.Forms.Timer(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDashboard
            // 
            this.panelDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.panelDashboard.Controls.Add(this.lblMensagem);
            this.panelDashboard.Controls.Add(this.lblNumeroProjetos);
            this.panelDashboard.Controls.Add(this.lbProjetosRegistrados);
            this.panelDashboard.Controls.Add(this.iconPictureBox1);
            this.panelDashboard.Location = new System.Drawing.Point(12, 12);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(225, 110);
            this.panelDashboard.TabIndex = 0;
            // 
            // lblNumeroProjetos
            // 
            this.lblNumeroProjetos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroProjetos.AutoSize = true;
            this.lblNumeroProjetos.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroProjetos.ForeColor = System.Drawing.Color.White;
            this.lblNumeroProjetos.Location = new System.Drawing.Point(159, 37);
            this.lblNumeroProjetos.Name = "lblNumeroProjetos";
            this.lblNumeroProjetos.Size = new System.Drawing.Size(33, 37);
            this.lblNumeroProjetos.TabIndex = 2;
            this.lblNumeroProjetos.Text = "0";
            // 
            // lbProjetosRegistrados
            // 
            this.lbProjetosRegistrados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProjetosRegistrados.AutoSize = true;
            this.lbProjetosRegistrados.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProjetosRegistrados.ForeColor = System.Drawing.Color.White;
            this.lbProjetosRegistrados.Location = new System.Drawing.Point(19, 4);
            this.lbProjetosRegistrados.Name = "lbProjetosRegistrados";
            this.lbProjetosRegistrados.Size = new System.Drawing.Size(178, 23);
            this.lbProjetosRegistrados.TabIndex = 1;
            this.lbProjetosRegistrados.Text = "Projetos Cadastrados";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Stream;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 34;
            this.iconPictureBox1.Location = new System.Drawing.Point(24, 39);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(45, 34);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(442, 321);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(97, 30);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "00:00:00";
            // 
            // Relogio24h
            // 
            this.Relogio24h.Tick += new System.EventHandler(this.Relogio24h_Tick);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.Image = global::ImplementacaoRedesEletricasInteligentes.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(365, 118);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(234, 172);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(361, 351);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(112, 23);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "dd/MM/yyyy";
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.ForeColor = System.Drawing.Color.White;
            this.lblMensagem.Location = new System.Drawing.Point(48, 93);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(133, 17);
            this.lblMensagem.TabIndex = 41;
            this.lblMensagem.Text = "Buscando, aguarde...";
            this.lblMensagem.Visible = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(964, 466);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.panelDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDashboard;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lbProjetosRegistrados;
        private System.Windows.Forms.Label lblNumeroProjetos;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Timer Relogio24h;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblMensagem;
    }
}