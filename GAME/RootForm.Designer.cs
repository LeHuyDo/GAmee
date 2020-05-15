namespace GAME
{
    partial class RootForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RootForm));
            this.toolBar = new System.Windows.Forms.Panel();
            this.btn_Menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.btn_Size = new FontAwesome.Sharp.IconButton();
            this.btn_Close = new FontAwesome.Sharp.IconButton();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.menuLabel = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btn_Information = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_LevelMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_HowToPlay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Sound = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_Suggestion = new Bunifu.Framework.UI.BunifuImageButton();
            this.suggestionTable = new GAME.SuggestionTable();
            this.heartBar = new GAME.HeartBar();
            this.levelsMenu = new GAME.LevelsMenu();
            this.continueSelection = new GAME.ContinueSelection();
            this.hallOfFame = new GAME.HallOfFame();
            this.mainMenu = new GAME.MainMenu();
            this.label_Notification = new System.Windows.Forms.Label();
            this.notificationTimer = new System.Windows.Forms.Timer(this.components);
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Suggestion)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.toolBar.Controls.Add(this.btn_Menu);
            this.toolBar.Controls.Add(this.bunifuGradientPanel2);
            this.toolBar.Controls.Add(this.bunifuGradientPanel1);
            this.toolBar.Controls.Add(this.btn_Minimize);
            this.toolBar.Controls.Add(this.btn_Size);
            this.toolBar.Controls.Add(this.btn_Close);
            resources.ApplyResources(this.toolBar, "toolBar");
            this.toolBar.Name = "toolBar";
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_Menu.Image = global::GAME.Properties.Resources.menu_button;
            this.btn_Menu.ImageActive = null;
            resources.ApplyResources(this.btn_Menu, "btn_Menu");
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.TabStop = false;
            this.btn_Menu.Zoom = 10;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // bunifuGradientPanel2
            // 
            resources.ApplyResources(this.bunifuGradientPanel2, "bunifuGradientPanel2");
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            // 
            // bunifuGradientPanel1
            // 
            resources.ApplyResources(this.bunifuGradientPanel1, "bunifuGradientPanel1");
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            // 
            // btn_Minimize
            // 
            resources.ApplyResources(this.btn_Minimize, "btn_Minimize");
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Minimize.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.btn_Minimize.IconColor = System.Drawing.Color.SpringGreen;
            this.btn_Minimize.IconSize = 22;
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Rotation = 0D;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Size
            // 
            resources.ApplyResources(this.btn_Size, "btn_Size");
            this.btn_Size.BackColor = System.Drawing.Color.Transparent;
            this.btn_Size.FlatAppearance.BorderSize = 0;
            this.btn_Size.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Size.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Size.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.btn_Size.IconColor = System.Drawing.Color.Yellow;
            this.btn_Size.IconSize = 22;
            this.btn_Size.Name = "btn_Size";
            this.btn_Size.Rotation = 0D;
            this.btn_Size.UseVisualStyleBackColor = false;
            // 
            // btn_Close
            // 
            resources.ApplyResources(this.btn_Close, "btn_Close");
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Close.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.btn_Close.IconColor = System.Drawing.Color.Red;
            this.btn_Close.IconSize = 22;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Rotation = 0D;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // menuTimer
            // 
            this.menuTimer.Interval = 25;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // menuLabel
            // 
            resources.ApplyResources(this.menuLabel, "menuLabel");
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.menuLabel.Name = "menuLabel";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuPanel.Controls.Add(this.menuLabel);
            this.menuPanel.Controls.Add(this.btn_Information);
            this.menuPanel.Controls.Add(this.btn_LevelMenu);
            this.menuPanel.Controls.Add(this.btn_HowToPlay);
            this.menuPanel.Controls.Add(this.btn_Sound);
            resources.ApplyResources(this.menuPanel, "menuPanel");
            this.menuPanel.Name = "menuPanel";
            // 
            // btn_Information
            // 
            this.btn_Information.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.btn_Information, "btn_Information");
            this.btn_Information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Information.BorderRadius = 0;
            this.btn_Information.ButtonText = "Thông tin trò chơi";
            this.btn_Information.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Information.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Information.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Information.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Information.Iconimage")));
            this.btn_Information.Iconimage_right = null;
            this.btn_Information.Iconimage_right_Selected = null;
            this.btn_Information.Iconimage_Selected = null;
            this.btn_Information.IconMarginLeft = 0;
            this.btn_Information.IconMarginRight = 0;
            this.btn_Information.IconRightVisible = true;
            this.btn_Information.IconRightZoom = 0D;
            this.btn_Information.IconVisible = true;
            this.btn_Information.IconZoom = 90D;
            this.btn_Information.IsTab = false;
            this.btn_Information.Name = "btn_Information";
            this.btn_Information.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Information.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Information.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Information.selected = false;
            this.btn_Information.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Information.Textcolor = System.Drawing.Color.White;
            this.btn_Information.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_LevelMenu
            // 
            this.btn_LevelMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.btn_LevelMenu, "btn_LevelMenu");
            this.btn_LevelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_LevelMenu.BorderRadius = 0;
            this.btn_LevelMenu.ButtonText = "Màn chơi";
            this.btn_LevelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LevelMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btn_LevelMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_LevelMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_LevelMenu.Iconimage")));
            this.btn_LevelMenu.Iconimage_right = null;
            this.btn_LevelMenu.Iconimage_right_Selected = null;
            this.btn_LevelMenu.Iconimage_Selected = null;
            this.btn_LevelMenu.IconMarginLeft = 0;
            this.btn_LevelMenu.IconMarginRight = 0;
            this.btn_LevelMenu.IconRightVisible = true;
            this.btn_LevelMenu.IconRightZoom = 0D;
            this.btn_LevelMenu.IconVisible = true;
            this.btn_LevelMenu.IconZoom = 90D;
            this.btn_LevelMenu.IsTab = false;
            this.btn_LevelMenu.Name = "btn_LevelMenu";
            this.btn_LevelMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_LevelMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_LevelMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_LevelMenu.selected = false;
            this.btn_LevelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LevelMenu.Textcolor = System.Drawing.Color.White;
            this.btn_LevelMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LevelMenu.Click += new System.EventHandler(this.btn_LevelMenu_Click);
            // 
            // btn_HowToPlay
            // 
            this.btn_HowToPlay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.btn_HowToPlay, "btn_HowToPlay");
            this.btn_HowToPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_HowToPlay.BorderRadius = 0;
            this.btn_HowToPlay.ButtonText = "Hướng dẫn";
            this.btn_HowToPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HowToPlay.DisabledColor = System.Drawing.Color.Gray;
            this.btn_HowToPlay.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_HowToPlay.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_HowToPlay.Iconimage")));
            this.btn_HowToPlay.Iconimage_right = null;
            this.btn_HowToPlay.Iconimage_right_Selected = null;
            this.btn_HowToPlay.Iconimage_Selected = null;
            this.btn_HowToPlay.IconMarginLeft = 0;
            this.btn_HowToPlay.IconMarginRight = 0;
            this.btn_HowToPlay.IconRightVisible = true;
            this.btn_HowToPlay.IconRightZoom = 0D;
            this.btn_HowToPlay.IconVisible = true;
            this.btn_HowToPlay.IconZoom = 90D;
            this.btn_HowToPlay.IsTab = false;
            this.btn_HowToPlay.Name = "btn_HowToPlay";
            this.btn_HowToPlay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_HowToPlay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_HowToPlay.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_HowToPlay.selected = false;
            this.btn_HowToPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HowToPlay.Textcolor = System.Drawing.Color.White;
            this.btn_HowToPlay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Sound
            // 
            this.btn_Sound.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.btn_Sound, "btn_Sound");
            this.btn_Sound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Sound.BorderRadius = 0;
            this.btn_Sound.ButtonText = "Âm thanh";
            this.btn_Sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sound.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Sound.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Sound.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Sound.Iconimage")));
            this.btn_Sound.Iconimage_right = null;
            this.btn_Sound.Iconimage_right_Selected = null;
            this.btn_Sound.Iconimage_Selected = null;
            this.btn_Sound.IconMarginLeft = 0;
            this.btn_Sound.IconMarginRight = 0;
            this.btn_Sound.IconRightVisible = true;
            this.btn_Sound.IconRightZoom = 0D;
            this.btn_Sound.IconVisible = true;
            this.btn_Sound.IconZoom = 90D;
            this.btn_Sound.IsTab = false;
            this.btn_Sound.Name = "btn_Sound";
            this.btn_Sound.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Sound.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Sound.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Sound.selected = false;
            this.btn_Sound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sound.Textcolor = System.Drawing.Color.White;
            this.btn_Sound.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.toolBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btn_Suggestion
            // 
            this.btn_Suggestion.BackColor = System.Drawing.Color.Transparent;
            this.btn_Suggestion.Image = global::GAME.Properties.Resources.suggestion_nonActive1;
            this.btn_Suggestion.ImageActive = null;
            resources.ApplyResources(this.btn_Suggestion, "btn_Suggestion");
            this.btn_Suggestion.Name = "btn_Suggestion";
            this.btn_Suggestion.TabStop = false;
            this.btn_Suggestion.Zoom = 10;
            this.btn_Suggestion.Click += new System.EventHandler(this.btn_Suggestion_Click);
            this.btn_Suggestion.MouseLeave += new System.EventHandler(this.btn_Suggestion_MouseLeave);
            this.btn_Suggestion.MouseHover += new System.EventHandler(this.btn_Suggestion_MouseHover);
            // 
            // suggestionTable
            // 
            this.suggestionTable.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.suggestionTable, "suggestionTable");
            this.suggestionTable.Name = "suggestionTable";
            this.suggestionTable.PayToSuggestion += new System.EventHandler(this.suggestionTable_PayToSuggestion);
            // 
            // heartBar
            // 
            this.heartBar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.heartBar, "heartBar");
            this.heartBar.Name = "heartBar";
            // 
            // levelsMenu
            // 
            this.levelsMenu.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.levelsMenu, "levelsMenu");
            this.levelsMenu.Name = "levelsMenu";
            this.levelsMenu.Level_ButtonClick += new System.EventHandler(this.levelsMenu_Level_ButtonClick);
            // 
            // continueSelection
            // 
            this.continueSelection.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.continueSelection, "continueSelection");
            this.continueSelection.Name = "continueSelection";
            // 
            // hallOfFame
            // 
            this.hallOfFame.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.hallOfFame, "hallOfFame");
            this.hallOfFame.CurrentLevel = 1;
            this.hallOfFame.Name = "hallOfFame";
            this.hallOfFame.NextLevel += new System.EventHandler(this.hallOfFame_NextLevel);
            this.hallOfFame.PlayAgain += new System.EventHandler(this.hallOfFame_PlayAgain);
            this.hallOfFame.LevelMenuOpen += new System.EventHandler(this.hallOfFame_LevelMenuOpen);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.ChoiluonButtonClick += new System.EventHandler(this.mainMenu_ChoiluonButtonClick);
            this.mainMenu.ChoitiepButtonClick += new System.EventHandler(this.mainMenu_ChoitiepButtonClick);
            this.mainMenu.CachchoiButtonClick += new System.EventHandler(this.mainMenu_CachchoiButtonClick);
            // 
            // label_Notification
            // 
            resources.ApplyResources(this.label_Notification, "label_Notification");
            this.label_Notification.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Notification.Name = "label_Notification";
            // 
            // notificationTimer
            // 
            this.notificationTimer.Interval = 25;
            this.notificationTimer.Tick += new System.EventHandler(this.notificationTimer_Tick);
            // 
            // RootForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Controls.Add(this.label_Notification);
            this.Controls.Add(this.suggestionTable);
            this.Controls.Add(this.btn_Suggestion);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.continueSelection);
            this.Controls.Add(this.heartBar);
            this.Controls.Add(this.hallOfFame);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.levelsMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RootForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.RootForm_Load);
            this.toolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Suggestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label menuLabel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Information;
        private Bunifu.Framework.UI.BunifuFlatButton btn_LevelMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btn_HowToPlay;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Sound;
        private System.Windows.Forms.Panel toolBar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private FontAwesome.Sharp.IconButton btn_Size;
        private FontAwesome.Sharp.IconButton btn_Close;
        private MainMenu mainMenu;
        private System.Windows.Forms.Timer menuTimer;
        private LevelsMenu levelsMenu;
        private Bunifu.Framework.UI.BunifuImageButton btn_Menu;
        private HallOfFame hallOfFame;
        private HeartBar heartBar;
        private ContinueSelection continueSelection;
        private System.Windows.Forms.Panel menuPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Suggestion;
        private SuggestionTable suggestionTable;
        private System.Windows.Forms.Label label_Notification;
        private System.Windows.Forms.Timer notificationTimer;
    }
}

