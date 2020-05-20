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
    public partial class Level3 : PrefabLevel
    {
        public Level3()
        {
            InitializeComponent();
        }

        private void WrongAnserHandle(object sender, EventArgs e)
        {
            WrongAnswer(EventArgs.Empty);
        }

        private void Level3_KeyUp(object sender, KeyEventArgs e)
        {
            WrongAnswer(EventArgs.Empty);
        }

        private void btn_West_Click(object sender, EventArgs e)
        {
            RightAnswer(EventArgs.Empty);
        }

        private void Level3_Load(object sender, EventArgs e)
        {
            suggestionText = "Chú ý hướng kim la bàn đang chỉ.";
            answerText = "Trên màn hình rõ ràng la bàn đang chỉ nút West đúng không :)";
        }
    }
}
