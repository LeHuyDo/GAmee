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
            this.menuPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.continueSelection = new GAME.ContinueSelection();
            this.heartBar = new GAME.HeartBar();
            this.hallOfFame = new GAME.HallOfFame();
            this.mainMenu = new GAME.MainMenu();
            this.levelsMenu = new GAME.LevelsMenu();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            this.menuPanel.SuspendLayout();
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
            this.menuTimer.Interval = 16;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // menuPanel
            // 
            resources.ApplyResources(this.menuPanel, "menuPanel");
            this.menuPanel.Controls.Add(this.menuLabel);
            this.menuPanel.Controls.Add(this.bunifuFlatButton4);
            this.menuPanel.Controls.Add(this.bunifuFlatButton1);
            this.menuPanel.Controls.Add(this.bunifuFlatButton3);
            this.menuPanel.Controls.Add(this.bunifuFlatButton2);
            this.menuPanel.GradientBottomLeft = System.Drawing.Color.Cyan;
            this.menuPanel.GradientBottomRight = System.Drawing.Color.Chartreuse;
            this.menuPanel.GradientTopLeft = System.Drawing.Color.DarkGreen;
            this.menuPanel.GradientTopRight = System.Drawing.Color.Purple;
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Quality = 1;
            // 
            // menuLabel
            // 
            resources.ApplyResources(this.menuLabel, "menuLabel");
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.Name = "menuLabel";
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton4, "bunifuFlatButton4");
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton1, "bunifuFlatButton1");
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton3, "bunifuFlatButton3");
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton2, "bunifuFlatButton2");
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // continueSelection
            // 
            this.continueSelection.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.continueSelection, "continueSelection");
            this.continueSelection.Name = "continueSelection";
            // 
            // heartBar
            // 
            this.heartBar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.heartBar, "heartBar");
            this.heartBar.Name = "heartBar";
            // 
            // hallOfFame
            // 
            this.hallOfFame.BackColor = System.Drawing.Color.DimGray;
            this.hallOfFame.CurrentLevel = 1;
            resources.ApplyResources(this.hallOfFame, "hallOfFame");
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
            // levelsMenu
            // 
            this.levelsMenu.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.levelsMenu, "levelsMenu");
            this.levelsMenu.Name = "levelsMenu";
            this.levelsMenu.Level_ButtonClick += new System.EventHandler(this.levelsMenu_Level_ButtonClick);
            // 
            // RootForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
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
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel menuPanel;
        private System.Windows.Forms.Label menuLabel;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
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
    }
}

