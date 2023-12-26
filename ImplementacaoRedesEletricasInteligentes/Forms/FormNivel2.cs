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

namespace ImplementacaoRedesEletricasInteligentes.Forms{
    public partial class FormNivel2 : Form{

        string projeto, nivel1;
        public FormNivel2(){
            InitializeComponent();
            
        }

        private void FormNivel2_Load(object sender, EventArgs e){
            CarregarNivel2();
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
                CarregarNivel2();
                txtPesquisa.Clear();
                Limpar();
            }
            else
            {
                var nivel2 = new Nivel2();
                var TaskNivel2 = await nivel2.ObterNivel2IDAsync(int.Parse(txtPesquisa.Text));
                if (TaskNivel2 == null)
                {
                    MessageBox.Show("ID consultado não existe!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CarregarNivel2();
                    txtPesquisa.Clear();
                    Limpar();
                }
                else
                {
                    var listaNivel2 = new List<Nivel2>
                    {
                        new Nivel2 {  id = TaskNivel2.id, projeto = TaskNivel2.projeto, nivel1 = TaskNivel2.nivel1, descricao = TaskNivel2.descricao}
                    };

                    dgvNivel2.DataSource = listaNivel2;
                    ConfigGradeDGV();
                    lblMensagem.Visible = false;
                }
            }
        }


        //=== BUTTONS ==\\

        //Cadastrando novo nível 2
        private async void btnCadastrar_Click(object sender, EventArgs e){
            if((txtDescricao.Text == string.Empty)) {
                MessageBox.Show("Preencha a descrição para prosseguir!","Redes elétricas inteligentes",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }else{
                lblMensagem.Text = "Adicionando projeto...";
                lblMensagem.Visible = true;

                var nivel2 = new Nivel2()
                {
                    projeto = int.Parse(txtProjeto.Text),
                    nivel1 = int.Parse(txtNivel1.Text),
                    descricao = txtDescricao.Text
                };
                var BlistaNivel2 = await nivel2.CadastrarNivel2Async(nivel2);

                lblMensagem.Visible = false;
                CarregarNivel2();
                Limpar();
            }
        }

        //Editando nível 2
        private void btnEditProjeto_Click(object sender, EventArgs e){
            
            CarregarNivel2();
            Limpar();
        }

        //Deletando nível 2
        private async void btnDelProjeto_Click(object sender, EventArgs e){
            lblMensagem.Text = "Excluindo projeto...";
            lblMensagem.Visible = true;

            var nivel2 = new Nivel2()
            {
                id = int.Parse(txtAtividade.Text),
                projeto = int.Parse(txtProjeto.Text),
                nivel1 = int.Parse(txtNivel1.Text),
                descricao = txtDescricao.Text
            };
            var BlistaNivel2 = await nivel2.CadastrarNivel2Async(nivel2);

            lblMensagem.Visible = false;
            CarregarNivel2();
            Limpar();
        }

        //Evento quando clicar no botão limpar, chama o método limpar
        private void btnLimparcampo_Click(object sender, EventArgs e){
            Limpar();
        }

        //Evento quando clicar no DGV
        private void dgvNivel2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAtividade.Text = dgvNivel2.CurrentRow.Cells[0].Value.ToString();
            txtProjeto.Text = dgvNivel2.CurrentRow.Cells[1].Value.ToString();
            txtNivel1.Text = dgvNivel2.CurrentRow.Cells[2].Value.ToString();
            txtDescricao.Text = dgvNivel2.CurrentRow.Cells[3].Value.ToString();

            btnCadastrar.Enabled = false;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
        }

        //=== METHODS ==\\

        //Recebendo dados do form nível 1
        public void Dados(string projeto, string nivel1)
        {
            txtProjeto.Text = projeto;
            txtNivel1.Text = nivel1;
        }

        //Método para carregar o Nível 2 no DGV
        public async void CarregarNivel2()
        {
            lblMensagem.Text = "Buscando, aguarde...";
            lblMensagem.Visible = true;

            var nivel2 = new Nivel2();
            var listaNivel2 = await nivel2.ObterNivel2Async();

            dgvNivel2.DataSource = listaNivel2;
            ConfigGradeDGV();
            lblMensagem.Visible = false;
        }

        //Método para limpar os campos do form Nível 2
        public void Limpar()
        {
            txtProjeto.Text = "automático";
            txtAtividade.Text = "automático";
            txtNivel1.Text = "automático";
            txtDescricao.Clear();
            btnCadastrar.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
        }

        //Método para configurar a exibição do Nível 1 no DataGridView
        private void ConfigGradeDGV()
        {
            dgvNivel2.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvNivel2.RowHeadersWidth = 25;

            dgvNivel2.Columns["id"].HeaderText = "ID";
            dgvNivel2.Columns["id"].Width = 65;
            dgvNivel2.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNivel2.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvNivel2.Columns["projeto"].HeaderText = "Projeto";
            dgvNivel2.Columns["projeto"].Width = 65;
            dgvNivel2.Columns["projeto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNivel2.Columns["projeto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvNivel2.Columns["nivel1"].HeaderText = "Nivel1";
            dgvNivel2.Columns["nivel1"].Width = 65;
            dgvNivel2.Columns["nivel1"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNivel2.Columns["nivel1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvNivel2.Columns["descricao"].HeaderText = "Descrição";
            dgvNivel2.Columns["descricao"].Width = 247;
            dgvNivel2.Columns["descricao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNivel2.Columns["descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
