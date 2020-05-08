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
    public partial class Level4 : PrefabLevel
    {
        public Level4()
        {
            InitializeComponent();
        }

        private void RightAnswerHandle(object sender, EventArgs e)
        {
            RightAnswer(EventArgs.Empty);
        }

        private void WrongAnswerHandle(object sender, EventArgs e)
        {
            WrongAnswer(EventArgs.Empty);
        }
    }
}
