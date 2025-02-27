﻿using System;
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
    public partial class HallOfFame : UserControl
    {
        private Levels currentLevel = Levels.L1;

        public Levels CurrentLevel { get => currentLevel; set => currentLevel = value; }

        public HallOfFame()
        {
            InitializeComponent();
        }

        public void SetLevelLabel(Levels level)
        {
            currentLevel = level;
            levelLabel.Text = "Màn " + currentLevel.ToString();
        }

        public void SetAnswerText(string text)
        {
            label_Answer.Text = text;
        }

        #region Thêm một số HandleEvent
        [Browsable(true)]
        [Category("CustomAction")]
        [Description("NextLevel")]
        public event EventHandler NextLevel;

        private void btn_NextLevel_Click(object sender, EventArgs e)
        {
            NextLevel?.Invoke(sender, e);
        }

        [Browsable(true)]
        [Category("CustomAction")]
        [Description("PlayAgain")]
        public event EventHandler PlayAgain;

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            PlayAgain?.Invoke(sender, e);
        }

        [Browsable(true)]
        [Category("CustomAction")]
        [Description("LevelMenuOpen")]
        public event EventHandler LevelMenuOpen;

        private void btn_LevelMenuOpen_Click(object sender, EventArgs e)
        {
            LevelMenuOpen?.Invoke(sender, e);
        }
        #endregion
    }
}
