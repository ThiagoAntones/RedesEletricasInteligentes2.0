using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ImplementacaoRedesEletricasInteligentes.Classes;

namespace ImplementacaoRedesEletricasInteligentes.Forms{
    public partial class FormConsulta : Form{

        public FormConsulta()
        {
            InitializeComponent();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            CarregarProjetos();
            txtPesquisa.Focus();
        }

        //=== EVENTS ==\\

        //Quando o User digitar no textbox
        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(sender, e);
        }

        //Consultando a partir da barra de pesquisa
        private async void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            lblMensagem.Text = "Buscando, aguarde...";
            lblMensagem.Visible = true;
            if (txtPesquisa.Text == "")
            {
                CarregarProjetos();
                txtPesquisa.Clear();
            }
            else
            {
                var projeto = new ProjetoServices();
                var listaProjeto = await projeto.ObterProjetoIDAsync(int.Parse(txtPesquisa.Text));
                if (listaProjeto == null)
                {
                    MessageBox.Show("ID consultado não existe!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CarregarProjetos();
                    txtPesquisa.Clear();
                }
                else
                {
                    dgvProjetos.DataSource = listaProjeto;
                    ConfigGradeDGV();
                    lblMensagem.Visible = false;
                }
            }
        }


        //=== METHODS ==\\

        //Método para carregar os projetos
        public async void CarregarProjetos()
        {
            lblMensagem.Text = "Buscando, aguarde...";
            lblMensagem.Visible = true;

            var projeto = new ProjetoServices();
            var listaProjeto = await projeto.ObterProjetosAsync();

            dgvProjetos.DataSource = listaProjeto;
            ConfigGradeDGV();
            lblMensagem.Visible = false;
        }

        //Método para configurar a exibição dos projetos no DataGridView
        private void ConfigGradeDGV()
        {
            dgvProjetos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvProjetos.RowHeadersWidth = 25;

            dgvProjetos.Columns["id"].HeaderText = "ID";
            dgvProjetos.Columns["id"].Width = 70;
            dgvProjetos.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProjetos.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProjetos.Columns["titulo"].HeaderText = "Título";
            dgvProjetos.Columns["titulo"].Width = 140;
            dgvProjetos.Columns["titulo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProjetos.Columns["titulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProjetos.Columns["descricao"].HeaderText = "Descrição";
            dgvProjetos.Columns["descricao"].Width = 280;
            dgvProjetos.Columns["descricao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProjetos.Columns["descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProjetos.Columns["inicio"].HeaderText = "Início";
            dgvProjetos.Columns["inicio"].Width = 90;
            dgvProjetos.Columns["inicio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProjetos.Columns["inicio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProjetos.Columns["termino"].HeaderText = "Término";
            dgvProjetos.Columns["termino"].Width = 90;
            dgvProjetos.Columns["termino"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProjetos.Columns["termino"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProjetos.Columns["custo"].HeaderText = "Custo";
            dgvProjetos.Columns["custo"].Width = 80;
            dgvProjetos.Columns["custo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProjetos.Columns["custo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
