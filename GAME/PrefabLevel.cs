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


        protected virtual void RightAnswer(EventArgs e)
        {
            EventHandler right = rightAnswer;
            right?.Invoke(this, e);
        }

        protected virtual void WrongAnswer(EventArgs e)
        {
            EventHandler wrong = wrongAnswer;
            wrong?.Invoke(this, e);
        }

        #region Thêm một số HandleEvent
        [Browsable(true)]
        [Category("CustomAction")]
        [Description("Passed")]
        public event EventHandler rightAnswer;

        [Browsable(true)]
        [Category("CustomAction")]
        [Description("Missed")]
        public event EventHandler wrongAnswer;

        #endregion
    }
}
