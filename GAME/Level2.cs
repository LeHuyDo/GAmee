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
    public partial class Level2 : UserControl
    {
        public Level2()
        {
            InitializeComponent();
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(picture_RedPencil, true);
            ControlExtension.Draggable(picture_BluePencil, true);
            ControlExtension.Draggable(picture_YellowPencil, true);
        }

        private void picture_RedPencil_MouseUp(object sender, MouseEventArgs e)
        {
            Point centerRedPencil = GameLogic.CenterOfControl(picture_RedPencil.Location, picture_RedPencil.Size);

            if (GameLogic.IsInArea(centerRedPencil, picture_BluePencil.Location, picture_BluePencil.Size))
            {
                picture_RedPencil.Hide();
                picture_BluePencil.Image = Properties.Resources.object_111;

                //  Right answer
            }
            else
            {
                //  Wrong answer
            }
        }

        private void picture_BluePencil_MouseUp(object sender, MouseEventArgs e)
        {
            Point centerBluePencil = GameLogic.CenterOfControl(picture_BluePencil.Location, picture_RedPencil.Size);

            if (GameLogic.IsInArea(centerBluePencil, picture_RedPencil.Location, picture_RedPencil.Size))
            {
                picture_BluePencil.Hide();
                picture_RedPencil.Image = Properties.Resources.object_111;

                //  Right answer
                Passed?.Invoke(this, e);
            }
            else
            {
                //  Wrong answer
                Missed?.Invoke(this, e);
            }
        }

        private void picture_YellowPencil_MouseUp(object sender, MouseEventArgs e)
        {
            //  Wrong answer
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
