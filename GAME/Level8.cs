using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GAME
{
    public partial class Level8 : PrefabLevel
    {
        public Level8()
        {
            InitializeComponent();
        }

        private void WrongAnswer(object sender, EventArgs e)
        {
            WrongAnswer(EventArgs.Empty);
        }

        private void Level8_Load(object sender, EventArgs e)
        {
            suggestionText = "Nghĩ thoáng ra một chút, hãy dùng những thứ hiển thị trên màn hình !";
            answerText = "Kỳ lạ nhỉ ?";

            ControlExtension.Draggable(label_Dot, true);
        }

        private void label_Dot_MouseUp(object sender, MouseEventArgs e)
        {
            Point centerLabel = GameLogic.CenterOfControl(label_Dot.Location, label_Dot.Size);

            if (GameLogic.IsInArea(centerLabel, picture_Cake.Location, picture_Cake.Size))
            {
                label_Dot.Hide();

                picture_Cake.Image = Properties.Resources.cake2;

                Thread.Sleep(500);

                RightAnswer(EventArgs.Empty);
            }
        }
    }
}
