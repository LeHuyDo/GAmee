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
    public partial class Level3 : UserControl
    {
        public Level3()
        {
            InitializeComponent();
        }

        private void WrongAnserEvent(object sender, EventArgs e)
        {
            //  Wrong answer
            Missed?.Invoke(this, e);
        }

        private void btn_West_Click(object sender, EventArgs e)
        {
            //  Right answer
            Passed?.Invoke(this, e);
        }

        #region Thêm một số HandleEvent
        [Browsable(true)]
        [Category("CustomAction")]
        [Description("Passed")]
        public event EventHandler Passed;

        [Browsable(true)]
        [Category("CustomAction")]
        [Description("Missed")]
        public event EventHandler Missed;

        #endregion
    }
}
