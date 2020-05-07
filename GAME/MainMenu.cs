using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GAME
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        #region Thêm một số HandleEvent

        [Browsable(true)]
        [Category("CustomAction")]
        [Description("Choiluon button is clicked")]
        public event EventHandler ChoiluonButtonClick;
        private void btn_ChoiLuon_Click(object sender, EventArgs e)
        {
            ChoiluonButtonClick?.Invoke(this, e);
        }

        [Browsable(true)]
        [Category("CustomAction")]
        [Description("Choitiep button is clicked")]
        public event EventHandler ChoitiepButtonClick;
        private void btn_Choitiep_Click(object sender, EventArgs e)
        {
            ChoitiepButtonClick?.Invoke(this, e);
        }

        [Browsable(true)]
        [Category("CustomAction")]
        [Description("Cachchoi button is clicked")]
        public event EventHandler CachchoiButtonClick;
        private void btn_CachChoi_Click(object sender, EventArgs e)
        {
            CachchoiButtonClick?.Invoke(this, e);
        }

        private void btn_ThoatTroChoi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Thanh kéo Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

    }
}