using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME
{
    public partial class RootForm : Form
    {
        private int heart = 5;

        private bool isMenuShow = false;
        private int currentLevelNumber = 1;

        public RootForm()
        {
            InitializeComponent();
        }

        private void RootForm_Load(object sender, EventArgs e)
        {
            mainMenu.Dock = DockStyle.Fill;
            levelsMenu.Dock = DockStyle.Fill;

            ToolbarClose();
            LevelsMenu_Close();
            HallOfFame_Close();
        }

        #region Quản lý Toolbar
        private void ToolbarOpen()
        {
            toolBar.Show();
            levelsMenu.Show();
        }
        private void ToolbarClose()
        {
            toolBar.Hide();
            menuPanel.Hide();
            levelsMenu.Hide();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible)
                isMenuShow = true;
            else
            {
                menuPanel.Show();
                isMenuShow = false;
            }

            menuTimer.Start();
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (isMenuShow)
            {
                menuPanel.Width -= 25;

                if (menuPanel.Width <= 0)
                {
                    menuPanel.Hide();
                    menuTimer.Stop();
                }
            }

            else
            {
                menuPanel.Width += 25;

                if (menuPanel.Width >= 350)
                    menuTimer.Stop();
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Quản lý MainMenu
        private void MainMenu_Load(object sender, EventArgs e)
        {
            mainMenu.Dock = DockStyle.Fill;
        }


        private void mainMenu_ChoiluonButtonClick(object sender, EventArgs e)
        {
            mainMenu.Hide();

            ToolbarOpen();
            LevelsMenu_Open();
        }

        private void mainMenu_ChoitiepButtonClick(object sender, EventArgs e)
        {

        }

        private void mainMenu_CachchoiButtonClick(object sender, EventArgs e)
        {

        }
        #endregion

        #region Màn chơi
        //  Màn 1
        private void levelsMenu_Level1_ButtonClick(object sender, EventArgs e)
        {
            LevelsMenu_Close();

            Level1 level1 = new Level1();

            level1.BackColor = System.Drawing.Color.Transparent;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RootForm));
            resources.ApplyResources(level1, "level1");
            level1.Name = "level1";
            Controls.Add(level1);

            level1.Passed += new EventHandler(Level1_Passed);
            level1.Missed += new EventHandler(Level1_Missed);
        }

        private void Level1_Passed(object sender, EventArgs e)
        {
            hallOfFame.SetLevelLabel(currentLevelNumber);
            hallOfFame.Show();
        }

        private void Level1_Missed(object sender, EventArgs e)
        {
            heart--;
            hallOfFame.Show();
        }

        //  Màn 2
        private void levelsMenu_Level2_ButtonClick(object sender, EventArgs e)
        {
            LevelsMenu_Close();

            Level2 level2 = new Level2();

            level2.BackColor = System.Drawing.Color.Transparent;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RootForm));
            resources.ApplyResources(level2, "level2");
            level2.Name = "level2";
            Controls.Add(level2);

            level2.Passed += new EventHandler(Level2_Passed);
            level2.Missed += new EventHandler(Level2_Missed);
        }

        private void Level2_Passed(object sender, EventArgs e)
        {
            hallOfFame.SetLevelLabel(currentLevelNumber);
            hallOfFame.Show();
        }

        private void Level2_Missed(object sender, EventArgs e)
        {
            heart--;
            hallOfFame.Show();
        }

        //  Màn 3
        private void levelsMenu_Level3_ButtonClick(object sender, EventArgs e)
        {
            LevelsMenu_Close();

            Level3 level3 = new Level3();

            level3.BackColor = System.Drawing.Color.Transparent;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RootForm));
            resources.ApplyResources(level3, "level3");
            level3.Name = "level3";
            Controls.Add(level3);

            level3.Passed += new EventHandler(Level3_Passed);
            level3.Missed += new EventHandler(Level3_Missed);
        }

        private void Level3_Passed(object sender, EventArgs e)
        {
            hallOfFame.SetLevelLabel(currentLevelNumber);
            hallOfFame.Show();
        }

        private void Level3_Missed(object sender, EventArgs e)
        {
            heart--;
            hallOfFame.Show();
        }
        #endregion

        #region Quản lý LevelsMenu
        //  Mở table màn chơi
        private void LevelsMenu_Open()
        {
            levelsMenu.Show();
        }

        //  Đóng table màn chơi
        private void LevelsMenu_Close()
        {
            levelsMenu.Hide();
        }
        #endregion

        #region Quản lý bảng HallOfFame
        private void HallOfFame_Open()
        {
            hallOfFame.Show();
        }

        private void HallOfFame_Close()
        {
            hallOfFame.Hide();
        }

        private void hallOfFame_LevelMenuOpen(object sender, EventArgs e)
        {
            HallOfFame_Close();
        }

        private void hallOfFame_NextLevel(object sender, EventArgs e)
        {
            currentLevelNumber++;

            HallOfFame_Close();
        }

        private void hallOfFame_PlayAgain(object sender, EventArgs e)
        {


            HallOfFame_Close();
        }
        #endregion

    }
}
