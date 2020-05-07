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
    public partial class Level4 : UserControl
    {
        public Level4()
        {
            InitializeComponent();
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
