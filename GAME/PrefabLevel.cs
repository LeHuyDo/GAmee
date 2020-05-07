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
    public partial class PrefabLevel : UserControl
    {
        public PrefabLevel()
        {
            InitializeComponent();
        }

        private void PrefabLevel_Load(object sender, EventArgs e)
        {
            Passed(this, e);
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
