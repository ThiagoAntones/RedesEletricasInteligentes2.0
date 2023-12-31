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

namespace ImplementacaoRedesEletricasInteligentes.Forms
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            CarregarQTDprojetos();
            Relogio24h.Start();
        }

        //Lê a lista dos projetos cadastrados na tabela projetos e retorna a quantidade
        public async void CarregarQTDprojetos()
        {
            lblMensagem.Visible = true;
            var projeto = new ProjetoServices();
            var listaProjeto = await projeto.ObterProjetosAsync();
            lblNumeroProjetos.Text = listaProjeto.Count.ToString();
            lblMensagem.Visible = false;
        }

        //Carregar data e hora de brasília
        private void Relogio24h_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow;
            TimeZoneInfo horaBrasilia = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            lblTime.Text = TimeZoneInfo.ConvertTimeFromUtc(dateTime, horaBrasilia).ToString("HH:mm:ss");
            lblData.Text = TimeZoneInfo.ConvertTimeFromUtc(dateTime, horaBrasilia).ToLongDateString();
        }
    }
}
