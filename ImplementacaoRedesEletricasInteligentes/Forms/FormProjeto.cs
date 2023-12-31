using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using ImplementacaoRedesEletricasInteligentes.Classes;
using ImplementacaoRedesEletricasInteligentes.Models;

namespace ImplementacaoRedesEletricasInteligentes.Forms{
    public partial class FormProjeto : Form{

        public FormProjeto(){
            InitializeComponent();
        }

        private void FormProjeto_Load(object sender, EventArgs e){
            CarregarProjetos();
            txtTitulo.Focus();
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
            Limpar();
            lblMensagem.Text = "Buscando, aguarde...";
            lblMensagem.Visible = true;
            if (txtPesquisa.Text == "")
            {
                CarregarProjetos();
                txtPesquisa.Clear();
                Limpar();
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
                    Limpar();
                }
                else
                {
                    dgvProjetos.DataSource = listaProjeto;
                    ConfigGradeDGV();
                    lblMensagem.Visible = false;
                }
            }
        }

        //Quando o User digitar no textbox
        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DoubleNumber(sender, e);
        }

        //Quando a textbox sair da seleção ela formata o valor para duas casas decimais depois da vírgula
        private void txtCusto_Leave(object sender, EventArgs e)
        {
            var num = Convert.ToDouble(txtCusto.Text);
            txtCusto.Text = num.ToString("N2");
        }


        //=== BUTTONS ==\\

        //Cadastrando novo projeto
        private async void btnAddProjeto_Click(object sender, EventArgs e){
            if((txtTitulo.Text == string.Empty)||(txtDescricao.Text == string.Empty)||(txtCusto.Text == string.Empty)) {
                MessageBox.Show("Preencha todos os campos!","Redes elétricas inteligentes",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }else{
                lblMensagem.Text = "Adicionando projeto...";
                lblMensagem.Visible = true;

                var projetoUI = new ProjetoUI()
                { 
                    titulo = txtTitulo.Text,
                    descricao = txtDescricao.Text,
                    inicio = dtInicio.Value.ToString("yyyy-MM-dd"),
                    termino = dtTermino.Value.ToString("yyyy-MM-dd"),
                    custo = double.Parse(txtCusto.Text)

                };

                var projetoService = new ProjetoServices();
                await projetoService.CadastrarProjetoAsync(projetoUI);

                lblMensagem.Visible = false;
                CarregarProjetos();
                Limpar();
            }
        }
        
        //Editando projeto
        private async void btnEditProjeto_Click(object sender, EventArgs e){
            lblMensagem.Text = "Editando projeto...";
            lblMensagem.Visible = true;

            var projetoUI = new ProjetoUI()
            {
                id = int.Parse(txtCodigo.Text),
                titulo = txtTitulo.Text,
                descricao = txtDescricao.Text,
                inicio = dtInicio.Value.ToString("yyyy-MM-dd"),
                termino = dtTermino.Value.ToString("yyyy-MM-dd"),
                custo = double.Parse(txtCusto.Text)
            };

            var projetoService = new ProjetoServices();
            await projetoService.EditarProjetoAsync(projetoUI);

            lblMensagem.Visible = false;
            CarregarProjetos();
            Limpar();
        }

        //Deletando projeto
        private async void btnDelProjeto_Click(object sender, EventArgs e){
            lblMensagem.Text = "Excluindo projeto...";
            lblMensagem.Visible = true;

            var projetoUI = new ProjetoUI()
            {
                id = int.Parse(txtCodigo.Text),
                titulo = txtTitulo.Text,
                descricao = txtDescricao.Text,
                inicio = dtInicio.Value.ToString("yyyy-MM-dd"),
                termino = dtTermino.Value.ToString("yyyy-MM-dd"),
                custo = double.Parse(txtCusto.Text)
            };

            var projetoService = new ProjetoServices();
            await projetoService.DeletarProjetoAsync(projetoUI);

            lblMensagem.Visible = false;
            CarregarProjetos();
            Limpar();
        }

        //Quando clicar no botão limpar, chama o método limpar
        private void btnLimparcampo_Click(object sender, EventArgs e){
            Limpar();
        }

        //Quando clicar no DGV
        private void dgvProjetos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvProjetos.CurrentRow.Cells[0].Value.ToString();
            txtTitulo.Text = dgvProjetos.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = dgvProjetos.CurrentRow.Cells[2].Value.ToString();
            dtInicio.Text = dgvProjetos.CurrentRow.Cells[3].Value.ToString();
            dtTermino.Text = dgvProjetos.CurrentRow.Cells[4].Value.ToString();
            txtCusto.Text = dgvProjetos.CurrentRow.Cells[5].Value.ToString();

            btnAddProjeto.Enabled = false;
            btnEditProjeto.Enabled = true;
            btnDelProjeto.Enabled = true;
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

        //Método para limpar os campos do form Projeto
        public void Limpar()
        {
            txtCodigo.Text = "automático";
            txtTitulo.Clear();
            txtDescricao.Clear();
            txtCusto.Clear();
            dtInicio.Value = DateTime.Now;
            dtTermino.Value = DateTime.Now;
            btnAddProjeto.Enabled = true;
            btnEditProjeto.Enabled = false;
            btnDelProjeto.Enabled = false;
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
