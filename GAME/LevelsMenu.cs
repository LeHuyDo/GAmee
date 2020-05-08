using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace GAME
{
    public partial class LevelsMenu : UserControl
    {
        public int selectedLevel;
        public LevelsMenu()
        {
            InitializeComponent();
        }

        #region Thêm một số HandleEvent
        [Browsable(true)]
        [Category("CustomAction")]
        [Description("Level button is clicked")]
        public event EventHandler Level_ButtonClick;

        private void btn_Level_Click(object sender, EventArgs e)
        {
            BunifuTileButton button = (BunifuTileButton)sender;

            switch (button.Name)
            {
                case "btn_Level1":
                    selectedLevel = 1;
                    break;
                case "btn_Level2":
                    selectedLevel = 2;
                    break;
                case "btn_Level3":
                    selectedLevel = 3;
                    break;
                case "btn_Level4":
                    selectedLevel = 4;
                    break;
                case "btn_Level5":
                    selectedLevel = 5;
                    break;
                case "btn_Level6":
                    selectedLevel = 6;
                    break;

                default:
                    break;
            }

            Level_ButtonClick?.Invoke(this, e);
        }
        #endregion
    }
}
