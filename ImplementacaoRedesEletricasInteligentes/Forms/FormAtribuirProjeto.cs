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
using Newtonsoft.Json.Bson;
using RJCodeAdvance.RJControls;

namespace ImplementacaoRedesEletricasInteligentes.Forms{
    public partial class FormAtribuirProjeto:Form{

        //Campos
        private RJButton currentBtn;
        private Form currentChildForm;

        public FormAtribuirProjeto(){
            InitializeComponent();
        }
        private void FormAtribuirProjeto_Load(object sender, EventArgs e){
            CarregarProjetos();
        }

        //=== EVENTS ==\\

        private void cbProjetos_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            btnPreparacao.Enabled = true;
        }


        //=== BUTTONS ==\\

        private void btnPreparacao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNivel1(cbProjetos.Texts));
            AtivacaoBtn(sender, RGBcores.CorBackgroundCampo);
            btnAquisicao.Enabled = true;
        }

        private void btnAquisicao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNivel1(cbProjetos.Texts));
            AtivacaoBtn(sender, RGBcores.CorBackgroundCampo);
            btnInstacao.Enabled = true;
        }

        private void btnInstacao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNivel1(cbProjetos.Texts));
            AtivacaoBtn(sender, RGBcores.CorBackgroundCampo);
            btnTestes.Enabled = true;
        }

        private void btnTestes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNivel1(cbProjetos.Texts));
            AtivacaoBtn(sender, RGBcores.CorBackgroundCampo);
            btnTreinamento.Enabled = true;
        }

        private void btnTreinamento_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNivel1(cbProjetos.Texts));
            AtivacaoBtn(sender, RGBcores.CorBackgroundCampo);
            btnConfirmar.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DesabilitarBtn();
            currentChildForm.Close();
            cbProjetos.SelectedIndex = -1;
            cbProjetos.Texts = "Selecione o ID do projeto";
            ptbPainelSolar.Visible = true;
            btnPreparacao.Enabled = false;
            btnConfirmar.Enabled = false;
            btnTreinamento.Enabled = false;
            btnTestes.Enabled = false;
            btnInstacao.Enabled = false;
            btnAquisicao.Enabled = false;
        }


        //=== METHODS ==\\

        //Método para carregar os projetos
        public async void CarregarProjetos() {
            var projeto = new Projeto();
            var ListaProjeto = await projeto.ObterProjetosAsync();

            cbProjetos.ValueMember = "id";
            cbProjetos.DisplayMember = "id";
            cbProjetos.DataSource = ListaProjeto;
            cbProjetos.SelectedIndex = -1;
            cbProjetos.Texts = "Selecione o ID do projeto";
        }

        //Estrutura
        private struct RGBcores{
            public static Color CorBackgroundCampo = Color.FromArgb(255, 188, 0);
        }

        //Habilitar e desabilitar background color do botão
        private void AtivacaoBtn(object senderBtn, Color cor){
            if (senderBtn != null) {
                DesabilitarBtn();
                currentBtn = (RJButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 101, 161);
            }
        }
        private void DesabilitarBtn(){
            if (currentBtn != null){
                currentBtn.BackColor = Color.FromArgb(12, 139, 228);
            }
        }

        //Método para Abertura dos Forms de Cada Botão
        private void OpenChildForm(Form childForm){
            if (currentChildForm != null){
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFundo.Controls.Add(childForm);
            panelFundo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            ptbPainelSolar.Visible = false;
        }
    }
}
