using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME
{
    public partial class SystemControl : UserControl
    {
        bool isMenuShow = false;

        public SystemControl()
        {
            InitializeComponent();
        }

        private void SystemControl_Load(object sender, EventArgs e)
        {
            menuPanel.Hide();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible)
                isMenuShow = true;
            else
            {
                menuPanel.Show();
                isMenuShow = false;
            }

            menuTimer.Start();
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (isMenuShow)
            {
                menuPanel.Width -= 15;

                if (menuPanel.Width <= 0)
                {
                    menuPanel.Hide();
                    menuTimer.Stop();
                }
            }

            else
            {
                menuPanel.Width += 15;

                if (menuPanel.Width >= 300)
                    menuTimer.Stop();
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Thêm một số HandleEvent

        [Browsable(true)]
        [Category("CustomAction")]
        [Description("Minimize button is clicked")]
        public event EventHandler MinimizeButtonClick;
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            MinimizeButtonClick?.Invoke(this, e);
        }

        #endregion
    }
}
