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
        private Dictionary<Levels, bool> levelsStatus;

        private Levels selectedLevel;

        public Dictionary<Levels, bool> LevelsStatus { get => levelsStatus; set => levelsStatus = value; }

        public Levels SelectedLevel { get => selectedLevel; set => selectedLevel = value; }

        public LevelsMenu()
        {
            InitializeComponent();
        }

        public void SetLevelsActivation(Dictionary<Levels, bool> levelsStatus)
        {
            this.levelsStatus = levelsStatus;

            foreach (var item in levelsStatus)
                SetLevelButtonStatus(item.Key, item.Value);
        }

        private void SetLevelButtonStatus(Levels buttonLevel, bool isActive)
        {
            switch (buttonLevel)
            {
                case Levels.L1:
                    btn_Level1.Enabled = isActive;
                    checkbox_Level1.Checked = isActive;

                    break;

                case Levels.L2:
                    btn_Level2.Enabled = isActive;
                    checkbox_Level2.Checked = isActive;

                    break;

                case Levels.L3:
                    btn_Level3.Enabled = isActive;
                    checkbox_Level3.Checked = isActive;

                    break;

                case Levels.L4:
                    btn_Level4.Enabled = isActive;
                    checkbox_Level4.Checked = isActive;

                    break;

                case Levels.L5:
                    btn_Level5.Enabled = isActive;
                    checkbox_Level5.Checked = isActive;

                    break;

                default:
                    break;
            }
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
                    selectedLevel = Levels.L1;
                    break;
                case "btn_Level2":
                    selectedLevel = Levels.L2;
                    break;
                case "btn_Level3":
                    selectedLevel = Levels.L3;
                    break;
                case "btn_Level4":
                    selectedLevel = Levels.L4;
                    break;
                case "btn_Level5":
                    selectedLevel = Levels.L5;
                    break;
                //case "btn_Level6":
                //    selectedLevel = Levels.L6;
                //    break;

                default:
                    break;
            }

            Level_ButtonClick?.Invoke(this, e);
        }
        #endregion
    }
}
