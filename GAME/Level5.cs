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
    public partial class Level5 : PrefabLevel
    {
        public Level5()
        {
            InitializeComponent();
        }

        private void TrueAnswer(object sender, EventArgs e)
        {
            RightAnswer(EventArgs.Empty);
        }

        private void WrongAnswer(object sender, EventArgs e)
        {
            WrongAnswer(EventArgs.Empty);
        }

        private void Level5_Load(object sender, EventArgs e)
        {
            suggestionText = "Trên màn hình có mấy OK vậy ? ";
            answerText = "Chọn hay lắm !";
        }
    }
}
