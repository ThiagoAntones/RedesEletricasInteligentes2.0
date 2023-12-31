using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImplementacaoRedesEletricasInteligentes.Classes;
using ImplementacaoRedesEletricasInteligentes.Models;

namespace ImplementacaoRedesEletricasInteligentes.Forms
{
    public partial class FormNivel1 : Form 
    {

        //Formulário Atual
        private Form currentChildForm;

        public FormNivel1() 
        {
            InitializeComponent();
        }

        public FormNivel1(string projeto) 
        {
            InitializeComponent();
            txtProjeto.Text = projeto;
        }

        private void FormNivel1_Load(object sender, EventArgs e)
        {
            CarregarNivel1();
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
                CarregarNivel1();
                txtPesquisa.Clear();
                Limpar();
            }
            else
            {
                var nivel1Service = new Nivel1Services();
                var listaNivel1 = await nivel1Service.ObterNivel1IDAsync(int.Parse(txtPesquisa.Text));
                if (listaNivel1 == null)
                {
                    MessageBox.Show("ID consultado não existe!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CarregarNivel1();
                    txtPesquisa.Clear();
                    Limpar();
                }
                else
                {
                    dgvNivel1.DataSource = listaNivel1;
                    ConfigGradeDGV();
                    lblMensagem.Visible = false;
                }
            }
        }


        //=== BUTTONS ==\\

        //Cadastrando novo nível 1
        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            if((txtDescricao.Text == string.Empty)) {
                MessageBox.Show("Preencha a descrição para prosseguir!","Redes elétricas inteligentes",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }else{
                lblMensagem.Text = "Adicionando nível 1...";
                lblMensagem.Visible = true;

                var nivel1UI = new Nivel1UI()
                {
                    projeto = int.Parse(txtProjeto.Text),
                    descricao = txtDescricao.Text
                };

                var nivel1Service = new Nivel1Services();
                await nivel1Service.CadastrarNivel1Async(nivel1UI);

                lblMensagem.Visible = false;
                CarregarNivel1();
                Limpar();
            }
        }

        //Editando nível 1
        private async void btnEditProjeto_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Editando nível 1...";
            lblMensagem.Visible = true;

            var nivel1UI = new Nivel1UI()
            {
                id = int.Parse(txtAtividade.Text),
                projeto = int.Parse(txtProjeto.Text),
                descricao = txtDescricao.Text
            };

            var nivel1Service = new Nivel1Services();
            await nivel1Service.EditarNivel1Async(nivel1UI);

            lblMensagem.Visible = false;
            CarregarNivel1();
            Limpar();
        }

        //Deletando nível 1
        private async void btnDelProjeto_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Excluindo projeto...";
            lblMensagem.Visible = true;

            var nivel1UI = new Nivel1UI()
            {
                id = int.Parse(txtAtividade.Text),
                projeto = int.Parse(txtProjeto.Text),
                descricao = txtDescricao.Text
            };

            var nivel1Service = new Nivel1Services();
            await nivel1Service.DeletarNivel1Async(nivel1UI);

            lblMensagem.Visible = false;
            CarregarNivel1();
            Limpar();
        }

        //Limpando campos
        private void btnLimparcampo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        //Abrir o form nível 2 quando clicar no botão do nível 2
        private void Level2_Click(object sender, EventArgs e)
        {
            if (txtProjeto.Text == "automático" || txtAtividade.Text == "automático" || txtDescricao.Text == "")
            {
                MessageBox.Show("Selecione um nível 1 cadastrado para prosseguir ao nível 2!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OpenChildForm(new FormNivel2());
            }
        }

        //Quando clicar no DGV
        private void dgvNivel1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAtividade.Text = dgvNivel1.CurrentRow.Cells[0].Value.ToString();
            txtProjeto.Text = dgvNivel1.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = dgvNivel1.CurrentRow.Cells[2].Value.ToString();

            btnCadastrar.Enabled = false;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
        }

        //=== METHODS ==\\

        //Método para carregar o Nível 1 no DGV 
        public async void CarregarNivel1()
        {
            lblMensagem.Text = "Buscando, aguarde...";
            lblMensagem.Visible = true;

            var nivel1 = new Nivel1Services();
            var listaNivel1 = await nivel1.ObterNivel1Async();

            dgvNivel1.DataSource = listaNivel1;
            ConfigGradeDGV();
            lblMensagem.Visible = false;
        }

        //Método para limpar os campos do form Nível 1
        public void Limpar()
        {
            txtProjeto.Text = "automático";
            txtAtividade.Text = "automático";
            txtDescricao.Clear();
            btnCadastrar.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
        }

        //Método para configurar a exibição do Nível 1 no DataGridView
        private void ConfigGradeDGV()
        {
            dgvNivel1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvNivel1.RowHeadersWidth = 25;

            dgvNivel1.Columns["id"].HeaderText = "ID";
            dgvNivel1.Columns["id"].Width = 70;
            dgvNivel1.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNivel1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvNivel1.Columns["projeto"].HeaderText = "Projeto";
            dgvNivel1.Columns["projeto"].Width = 70;
            dgvNivel1.Columns["projeto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNivel1.Columns["projeto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvNivel1.Columns["descricao"].HeaderText = "Descrição";
            dgvNivel1.Columns["descricao"].Width = 302;
            dgvNivel1.Columns["descricao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNivel1.Columns["descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        //Método para Abertura dos Forms de Cada Botão
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFundo.Visible = true;
            panelFundo.Controls.Add(childForm);
            panelFundo.Tag = childForm;
            (currentChildForm as FormNivel2).Dados(txtProjeto.Text,txtAtividade.Text);
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
