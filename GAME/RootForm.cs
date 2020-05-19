using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GAME
{
    public partial class RootForm : Form
    {
        private PrefabLevel currentLevel;
        private Levels currentLevelEnum = Levels.L1;

        //  Tình trạng của từng màn chơi (qua màn/chưa qua)
        private Dictionary<Levels, bool> levelsStatus = new Dictionary<Levels, bool>();

        private int numberOfLife = 5;
        private int coin = 10;

        private bool isMenuShow = false;
        private bool isTicketShow = false;

        ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RootForm));

        SoundPlayer backgroundMusic = new SoundPlayer();
        private bool isPlayingBackgroundMusic = false;

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
            HeartBar_Close();
            ContinueSelection_Close();

            SetCoin();

            SetMusic_MainMenu();

            levelsStatus.Add(Levels.L1, true);
            levelsStatus.Add(Levels.L2, false);
            levelsStatus.Add(Levels.L3, false);
            levelsStatus.Add(Levels.L4, false);
            levelsStatus.Add(Levels.L5, false);
            levelsStatus.Add(Levels.L6, false);
            levelsStatus.Add(Levels.L7, false);
            levelsStatus.Add(Levels.L8, false);
        }

        private void PlayPause_BackgroundMusic()
        {
            if (isPlayingBackgroundMusic)
            {
                backgroundMusic.Stop();
                isPlayingBackgroundMusic = false;
            }
            else
            {
                backgroundMusic.PlayLooping();
                isPlayingBackgroundMusic = true;
            }
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

        private void SetCoin()
        {
            btn_CoinLabel.Text = coin.ToString();
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

        private void btn_Sound_Click(object sender, EventArgs e)
        {
            PlayPause_BackgroundMusic();
        }

        private void btn_HowToPlay_Click(object sender, EventArgs e)
        {
            HowToPlayTable_Open();
        }

        private void btn_Information_Click(object sender, EventArgs e)
        {
            InformationTable_Open();
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
            mainMenu.Hide();

            ToolbarOpen();
            LevelsMenu_Open();
        }

        private void mainMenu_CachchoiButtonClick(object sender, EventArgs e)
        {
            HowToPlayTable_Open();
        }

        private void btn_LevelMenu_Click(object sender, EventArgs e)
        {
            SetMusic_MainMenu();

            ToolbarOpen();
            LevelsMenu_Open();

            //  ContinueSelection vẫn hiện
            try
            {
                if (currentLevel != null)
                    Controls.Remove(currentLevel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btn_Menu_Click(sender, e);
        }

        private void SetMusic_MainMenu()
        {
            backgroundMusic.SoundLocation = "sfx_1.wav";
            backgroundMusic.PlayLooping();
        }
        #endregion

        #region Quản lý LevelsMenu
        private void LevelsMenu_Open()
        {
            levelsMenu.SetLevelsActivation(levelsStatus);
            levelsMenu.Show();
        }

        private void LevelsMenu_Close()
        {
            levelsMenu.Hide();
        }
        #endregion

        #region Màn chơi
        private void RightAnswer(object sender, EventArgs e)
        {
            hallOfFame.SetLevelLabel(currentLevelEnum);
            HallOfFame_Open();

            SetNextLevelActive();
        }

        private void WrongAnswer(object sender, EventArgs e)
        {
            numberOfLife--;

            heartBar.SetHearts(numberOfLife);

            Controls.Remove(currentLevel);
            level_Selection();

            if (numberOfLife <= 0)
            {
                ContinueSelection_Open();
            }
        }

        private void levelsMenu_Level_ButtonClick(object sender, EventArgs e)
        {
            LevelsMenu tempLevelsMenu = (LevelsMenu)sender;
            currentLevelEnum = tempLevelsMenu.SelectedLevel;
            SetMusic_InGame();

            level_Selection();
        }

        private void level_Selection()
        {
            switch (currentLevelEnum)
            {
                case Levels.L1:
                    currentLevel = new Level1();
                    break;
                case Levels.L2:
                    currentLevel = new Level2();
                    break;
                case Levels.L3:
                    currentLevel = new Level3();
                    break;
                case Levels.L4:
                    currentLevel = new Level4();
                    break;
                case Levels.L5:
                    currentLevel = new Level5();
                    break;
                case Levels.L6:
                    currentLevel = new Level6();
                    break;
                case Levels.L7:
                    currentLevel = new Level7();
                    break;
                case Levels.L8:
                    currentLevel = new Level8();
                    break;

                default:
                    break;
            }

            level_Setup();
        }

        private void level_Setup()
        {
            LevelsMenu_Close();
            HeartBar_Open();
            heartBar.SetHearts(numberOfLife);

            btn_Suggestion.Show();

            try
            {
                currentLevel.BackColor = Color.Transparent;

                resources.ApplyResources(currentLevel, "currentLevel");
                currentLevel.Name = "currentLevel";
                Controls.Add(currentLevel);

                currentLevel.rightAnswer += new EventHandler(RightAnswer);
                currentLevel.wrongAnswer += new EventHandler(WrongAnswer);

                TextInput(currentLevel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Mở khóa màn tiếp theo, cộng coin khi qua màn lần đầu
        /// </summary>
        private void SetNextLevelActive()
        {
            bool isFound = false;

            foreach (var item in levelsStatus)
            {
                if (isFound)
                {
                    if (levelsStatus[item.Key] == false)
                    {
                        levelsStatus[item.Key] = true;

                        coin += 2;
                        SetCoin();
                    }

                    break;
                }

                if (item.Key == currentLevelEnum)
                    isFound = true;
            }
        }

        private void SetMusic_InGame()
        {
            backgroundMusic.SoundLocation = "sfx_2.wav";
            backgroundMusic.PlayLooping();
        }
        #endregion

        #region Quản lý bảng HallOfFame
        private void HallOfFame_Open()
        {
            hallOfFame.Location = new Point(90, 200);
            hallOfFame.Show();
            currentLevel.Enabled = false;
        }

        private void HallOfFame_Close()
        {
            hallOfFame.Hide();
        }

        private void hallOfFame_LevelMenuOpen(object sender, EventArgs e)
        {
            SetMusic_MainMenu();

            Controls.Remove(currentLevel);
            HallOfFame_Close();
            LevelsMenu_Open();
        }

        private void hallOfFame_NextLevel(object sender, EventArgs e)
        {
            currentLevelEnum++;

            Controls.Remove(currentLevel);
            level_Selection();

            HallOfFame_Close();
        }

        private void hallOfFame_PlayAgain(object sender, EventArgs e)
        {
            Controls.Remove(currentLevel);
            level_Selection();

            HallOfFame_Close();
        }
        #endregion

        #region Quản lý HeartBar
        private void HeartBar_Open()
        {
            heartBar.Show();
        }

        private void HeartBar_Close()
        {
            heartBar.Hide();
        }
        #endregion

        #region Quản lý ContinueSelection
        private void ContinueSelection_Open()
        {
            continueSelection.Location = new Point(90, 200);
            continueSelection.Show();
            currentLevel.Enabled = false;
        }

        private void ContinueSelection_Close()
        {
            continueSelection.Hide();
        }

        private void continueSelection_LevelMenuOpen(object sender, EventArgs e)
        {
            SetMusic_MainMenu();

            Controls.Remove(currentLevel);
            ContinueSelection_Close();

            Reset_Game();

            LevelsMenu_Open();
        }

        private void continueSelection_PlayAgain(object sender, EventArgs e)
        {
            ContinueSelection_Close();
            Reset_Game();

            Controls.Remove(currentLevel);
            currentLevelEnum = Levels.L1;
            level_Selection();
        }

        private void Reset_Game()
        {
            List<Levels> keys = levelsStatus.Keys.ToList();
            foreach (var item in keys)
                levelsStatus[item] = false;

            levelsStatus[Levels.L1] = true;

            coin = 10;
            SetCoin();

            numberOfLife = 5;
            heartBar.SetHearts(numberOfLife);
        }
        #endregion

        #region Quản lý SuggestionTable

        private void Suggestion_Open()
        {
            suggestionTable.Location = new Point(115, 220);
            suggestionTable.Show();
            currentLevel.Enabled = false;
            btn_Suggestion.Enabled = false;
        }

        private void Suggestion_Close()
        {
            suggestionTable.Hide();
            currentLevel.Enabled = true;
            btn_Suggestion.Enabled = true;
        }

        private void TextInput(PrefabLevel level)
        {
            suggestionTable.SetSuggestionText(level.SuggestionText);
            hallOfFame.SetAnswerText(level.AnwserText);
        }

        private void btn_Suggestion_Click(object sender, EventArgs e)
        {
            if (panel_Ticket.Visible)
                isTicketShow = true;
            else
            {
                panel_Ticket.Show();
                isTicketShow = false;
            }

            ticketTimer.Start();
        }

        private void ticketTimer_Tick(object sender, EventArgs e)
        {
            if (isTicketShow)
            {
                panel_Ticket.Height -= 10;

                if (panel_Ticket.Height <= 0)
                {
                    panel_Ticket.Hide();
                    ticketTimer.Stop();
                }
            }

            else
            {
                panel_Ticket.Height += 10;

                if (panel_Ticket.Height >= 110)
                    ticketTimer.Stop();
            }
        }

        private void pictureTicket_Click(object sender, EventArgs e)
        {
            btn_Suggestion_Click(sender, e);
            suggestionTable_PayToSuggestion(sender, e);
        }


        /// <summary>
        /// Trừ điểm khi chọn gợi ý
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suggestionTable_PayToSuggestion(object sender, EventArgs e)
        {
            if (coin >= 5)
            {
                if (currentLevel.IsBuySuggestion == false)
                {
                    coin -= 5;
                    SetCoin();
                    currentLevel.IsBuySuggestion = true;
                }

                Suggestion_Open();
            }
            else
            {
                if (notificationTimer.Enabled)
                    notificationTimer.Stop();

                label_Notification.Show();
                label_Notification.Location = new Point(456, 120);
                notificationTimer.Start();
            }
        }

        /// <summary>
        /// Hiệu ứng làm mờ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notificationTimer_Tick(object sender, EventArgs e)
        {
            if (label_Notification.Location.Y > -30)
            {
                Point location = label_Notification.Location;
                location.Y -= 4;
                label_Notification.Location = location;
            }
            else
            {
                notificationTimer.Stop();
            }
        }
        #endregion

        #region Quản lý HowToPlayTable

        private void HowToPlayTable_Open()
        {
            howToPlayTable.Location = new Point(115, 180);
            howToPlayTable.Show();

            if (currentLevel != null)
                currentLevel.Enabled = false;

            mainMenu.Enabled = false;
            levelsMenu.Enabled = false;
            menuPanel.Enabled = false;
        }

        private void HowToPlayTable_Close()
        {
            howToPlayTable.Hide();

            if (currentLevel != null)
                currentLevel.Enabled = true;

            mainMenu.Enabled = true;
            levelsMenu.Enabled = true;
            menuPanel.Enabled = true;
        }
        #endregion

        #region Quản lý InformationTable

        private void InformationTable_Open()
        {
            informationTable.Location = new Point(115, 180);
            informationTable.Show();

            if (currentLevel != null)
                currentLevel.Enabled = false;

            levelsMenu.Enabled = false;
            menuPanel.Enabled = false;
        }

        private void InformationTable_Close()
        {
            informationTable.Hide();

            if (currentLevel != null)
                currentLevel.Enabled = true;

            levelsMenu.Enabled = true;
            menuPanel.Enabled = true;
        }
        #endregion

        /// <summary>
        /// Đóng UserControl khi click ra ngoài
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            if (suggestionTable.Visible)
                Suggestion_Close();

            if (informationTable.Visible)
                InformationTable_Close();

            if (howToPlayTable.Visible)
                HowToPlayTable_Close();
        }
    }

    public enum Levels
    {
        L1,
        L2,
        L3,
        L4,
        L5, 
        L6, 
        L7, 
        L8
    }
}
