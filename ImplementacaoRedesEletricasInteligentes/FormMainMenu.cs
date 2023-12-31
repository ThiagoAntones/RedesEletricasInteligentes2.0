using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ImplementacaoRedesEletricasInteligentes{
    public partial class Menu : Form {
        //Campos
        private IconButton currentBtn;
        private Form currentChildForm;
        private Panel leftBorderBtn;
        private int TamanhoBorda = 2;
        private Size TamanhoForm;
        private int ButtonAtual;

        public Menu() {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Padding = new Padding(TamanhoBorda);//Tamanho da Borda
            this.BackColor = Color.FromArgb(255, 188, 0);//Cor da Borda
            btnHome_Click(btnHome, EventArgs.Empty);
        }

        private void Menu_Load(object sender, EventArgs e){
            TamanhoForm = this.ClientSize;
        }


        //=== BUTONS ==\\

        //Métodos dos Botões
        private void btnHome_Click(object sender, EventArgs e)
        {
            ButtonAtual = 1;
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Battery;
            iconCurrentChildForm.IconColor = Color.Gold;
            lblTitleChildForm.Text = "Redes Elétricas Inteligentes";
            AtivacaoBtn(sender, RGBcores.CorBackgroundCampo);
            OpenChildForm(new Forms.FormHome());
        }

        private void btnProjeto_Click(object sender, EventArgs e)
        {
            ButtonAtual = 2;
            AtivacaoBtn(sender, RGBcores.CorBackgroundCampo);
            OpenChildForm(new Forms.FormProjeto());
        }

        private void btnAtribuirProjeto_Click(object sender, EventArgs e)
        {
            ButtonAtual = 3;
            AtivacaoBtn(sender, RGBcores.CorBackgroundCampo);
            OpenChildForm(new Forms.FormAtribuirProjeto());
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ButtonAtual = 4;
            AtivacaoBtn(sender, RGBcores.CorBackgroundCampo);
            OpenChildForm(new Forms.FormConsulta());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ButtonAtual = 5;
            DesabilitarBtn();
            btnHome_Click(btnHome, EventArgs.Empty);
        }

        private void btnMenuRecall_Click(object sender, EventArgs e)
        {
            MenuRecolher();
            
            if (ButtonAtual == 1)
            {
                btnHome_Click(btnHome, EventArgs.Empty);
            }
            else if(ButtonAtual== 2)
            {
                AtivacaoBtn(btnProjeto, RGBcores.CorBackgroundCampo);
            }
            if (ButtonAtual == 3)
            {
                AtivacaoBtn(btnAtribuirProjeto, RGBcores.CorBackgroundCampo);
            }
            else if (ButtonAtual == 4)
            {
                AtivacaoBtn(btnConsulta, RGBcores.CorBackgroundCampo);
            }
        }

        //Funcionalidade Expandir e Recolher Menu
        private void MenuRecolher()
        {
            if (this.panelMenu.Width > 200)
            {//Recolher Menu
                panelMenu.Width = 100;
                btnReset.Visible = false;
                btnMenuRecall.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {//Expandir Menu
                panelMenu.Width = 220;
                btnReset.Visible = true;
                btnMenuRecall.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(TamanhoBorda);
                    expandido();
                }
            }
        }

        //=== METHODS ==\\

        //Ativar os botões
        private void AtivacaoBtn(object senderBtn, Color cor){
            if (senderBtn != null) {
                DesabilitarBtn();
                //Botão
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 101, 161);
                currentBtn.ForeColor = cor;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = cor;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Borda esquerda do botão
                leftBorderBtn.BackColor = cor;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Title Form
                lblTitleChildForm.Text = currentBtn.Tag.ToString();
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = cor;
            }
        }

        //Quando a lateral do form estiver expando > 200px
        public void expandido()
        {
            btnHome.BackColor = Color.FromArgb(0, 101, 161);
            btnHome.ForeColor = Color.Gainsboro;
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.IconColor = Color.Gainsboro;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;

            btnProjeto.BackColor = Color.FromArgb(0, 101, 161);
            btnProjeto.ForeColor = Color.Gainsboro;
            btnProjeto.TextAlign = ContentAlignment.MiddleLeft;
            btnProjeto.IconColor = Color.Gainsboro;
            btnProjeto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProjeto.ImageAlign = ContentAlignment.MiddleLeft;

            btnAtribuirProjeto.BackColor = Color.FromArgb(0, 101, 161);
            btnAtribuirProjeto.ForeColor = Color.Gainsboro;
            btnAtribuirProjeto.TextAlign = ContentAlignment.MiddleLeft;
            btnAtribuirProjeto.IconColor = Color.Gainsboro;
            btnAtribuirProjeto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtribuirProjeto.ImageAlign = ContentAlignment.MiddleLeft;

            btnConsulta.BackColor = Color.FromArgb(0, 101, 161);
            btnConsulta.ForeColor = Color.Gainsboro;
            btnConsulta.TextAlign = ContentAlignment.MiddleLeft;
            btnConsulta.IconColor = Color.Gainsboro;
            btnConsulta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsulta.ImageAlign = ContentAlignment.MiddleLeft;
        }

        //Redimensiona os Botões para Quando Recolher o Menu
        private void DesabilitarBtn(){
            if (currentBtn != null){
                if (this.panelMenu.Width == 100){
                    currentBtn.BackColor = Color.FromArgb(0, 101, 161);
                    currentBtn.ForeColor = Color.Gainsboro;
                    currentBtn.Text = "";
                    currentBtn.IconColor = Color.Gainsboro;
                    currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                }else{
                    currentBtn.BackColor = Color.FromArgb(0, 101, 161);
                    currentBtn.ForeColor = Color.Gainsboro;
                    currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                    currentBtn.IconColor = Color.Gainsboro;
                    currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                }
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
        }


        //=== STRUCTURE ==\\

        private struct RGBcores
        {
            public static Color CorBackgroundCampo = Color.FromArgb(255, 188, 0);
        }

        //Arrastar a Janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Método para Redimensionar a Tela
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    TamanhoForm = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = TamanhoForm;
            }
            base.WndProc(ref m);
        }

        //Redimensionar menu após clicar para expandir ou reduzir
        private void Menu_Resize(object sender, EventArgs e)
        {
            AjustarForm();
        }

        private void AjustarForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != TamanhoBorda)
                        this.Padding = new Padding(TamanhoBorda);
                    break;
            }
        }

        //Minimizar Programa
        private void btnMinize_Click(object sender, EventArgs e)
        {
            TamanhoForm = this.ClientSize;
            this.WindowState = FormWindowState.Minimized;
        }

        //Maximizar Programa
        private void btnMaxmize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                TamanhoForm = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = TamanhoForm;
            }
        }

        //Fechar Programa
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
