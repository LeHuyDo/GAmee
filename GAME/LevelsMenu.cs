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
    public partial class LevelsMenu : UserControl
    {
        public LevelsMenu()
        {
            InitializeComponent();
        }

        #region Thêm một số HandleEvent
        [Browsable(true)]
        [Category("CustomAction")]
        [Description("Level1 button is clicked")]
        public event EventHandler Level1_ButtonClick;
        private void btn_Level1_Click(object sender, EventArgs e)
        {
            Level1_ButtonClick?.Invoke(this, e);
        }

        [Browsable(true)]
        [Category("CustomAction")]
        [Description("Level2 button is clicked")]
        public event EventHandler Level2_ButtonClick;
        private void btn_Level2_Click(object sender, EventArgs e)
        {
            Level2_ButtonClick?.Invoke(this, e);
        }

        [Browsable(true)]
        [Category("CustomAction")]
        [Description("Level1 button is clicked")]
        public event EventHandler Level3_ButtonClick;
        private void btn_Level3_Click(object sender, EventArgs e)
        {
            Level3_ButtonClick?.Invoke(this, e);
        }
        #endregion
    }
}
