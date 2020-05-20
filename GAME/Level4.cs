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

        private void Level4_Load(object sender, EventArgs e)
        {
            suggestionText = "Tầng mà mọi người phải xuất hiện nhiều nhất ấy";
            answerText = "Muốn đi thang máy lên chắc chắn phải qua tầng 1 (không tính tầng hầm nha :v)";
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
