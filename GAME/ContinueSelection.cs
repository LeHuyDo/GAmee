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
    public partial class ContinueSelection : UserControl
    {
        public ContinueSelection()
        {
            InitializeComponent();
        }

        #region Thêm một số HandleEvent
        [Browsable(true)]
        [Category("CustomAction")]
        [Description("PlayAgain")]
        public event EventHandler PlayAgain;

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            PlayAgain?.Invoke(sender, e);
        }

        [Browsable(true)]
        [Category("CustomAction")]
        [Description("LevelMenuOpen")]
        public event EventHandler LevelMenuOpen;

        private void btn_LevelMenuOpen_Click(object sender, EventArgs e)
        {
            LevelMenuOpen?.Invoke(sender, e);
        }
        #endregion
    }
}
