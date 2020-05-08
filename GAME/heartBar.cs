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
    public partial class HeartBar : UserControl
    {
        private List<PictureBox> heartArray;// = new List<PictureBox>(5);

        public HeartBar()
        {
            InitializeComponent();
        }

        private void heartBar_Load(object sender, EventArgs e)
        {
            heartArray = new List<PictureBox>(5);
            heartArray.Add(picture_heart1);
            heartArray.Add(picture_heart2);
            heartArray.Add(picture_heart3);
            heartArray.Add(picture_heart4);
            heartArray.Add(picture_heart5);
        }

        public void SetHearts(int numberOfHeart)
        {
            for (int i = 0; i < numberOfHeart; i++)
                heartArray[i].Image = Properties.Resources.heart;
            for (int i = numberOfHeart; i < 5; i++)
                heartArray[i].Image = Properties.Resources.heartDeath;
        }

    }
}
