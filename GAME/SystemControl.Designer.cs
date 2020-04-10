namespace GAME
{
    partial class SystemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemControl));
            this.toolBar = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Menu = new FontAwesome.Sharp.IconButton();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.btn_Size = new FontAwesome.Sharp.IconButton();
            this.btn_Close = new FontAwesome.Sharp.IconButton();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.dragToolBar = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolBar.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.SystemColors.Desktop;
            this.toolBar.Controls.Add(this.bunifuGradientPanel2);
            this.toolBar.Controls.Add(this.bunifuGradientPanel1);
            this.toolBar.Controls.Add(this.btn_Menu);
            this.toolBar.Controls.Add(this.btn_Minimize);
            this.toolBar.Controls.Add(this.btn_Size);
            this.toolBar.Controls.Add(this.btn_Close);
            this.toolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(702, 45);
            this.toolBar.TabIndex = 3;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 46);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(317, 830);
            this.bunifuGradientPanel2.TabIndex = 4;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 46);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(212, 243);
            this.bunifuGradientPanel1.TabIndex = 6;
            // 
            // btn_Menu
            // 
            this.btn_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btn_Menu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btn_Menu.IconColor = System.Drawing.Color.LightGray;
            this.btn_Menu.IconSize = 28;
            this.btn_Menu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Menu.Location = new System.Drawing.Point(3, 5);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Rotation = 0D;
            this.btn_Menu.Size = new System.Drawing.Size(35, 35);
            this.btn_Menu.TabIndex = 5;
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.btn_Minimize.IconColor = System.Drawing.Color.SpringGreen;
            this.btn_Minimize.IconSize = 22;
            this.btn_Minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Minimize.Location = new System.Drawing.Point(618, 5);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Rotation = 0D;
            this.btn_Minimize.Size = new System.Drawing.Size(20, 35);
            this.btn_Minimize.TabIndex = 5;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Size
            // 
            this.btn_Size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btn_Size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Size.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Size.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btn_Size.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.btn_Size.IconColor = System.Drawing.Color.Yellow;
            this.btn_Size.IconSize = 22;
            this.btn_Size.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Size.Location = new System.Drawing.Point(644, 5);
            this.btn_Size.Name = "btn_Size";
            this.btn_Size.Rotation = 0D;
            this.btn_Size.Size = new System.Drawing.Size(20, 35);
            this.btn_Size.TabIndex = 5;
            this.btn_Size.UseVisualStyleBackColor = false;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btn_Close.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.btn_Close.IconColor = System.Drawing.Color.Red;
            this.btn_Close.IconSize = 22;
            this.btn_Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Close.Location = new System.Drawing.Point(670, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Rotation = 0D;
            this.btn_Close.Size = new System.Drawing.Size(20, 35);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuPanel.Controls.Add(this.menuLabel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 45);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(0, 835);
            this.menuPanel.TabIndex = 5;
            // 
            // menuLabel
            // 
            this.menuLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.menuLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuLabel.Location = new System.Drawing.Point(-300, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(300, 86);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "MENU";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuTimer
            // 
            this.menuTimer.Interval = 16;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // dragToolBar
            // 
            this.dragToolBar.Fixed = true;
            this.dragToolBar.Horizontal = true;
            this.dragToolBar.TargetControl = this.toolBar;
            this.dragToolBar.Vertical = true;
            // 
            // SystemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.toolBar);
            this.Name = "SystemControl";
            this.Size = new System.Drawing.Size(702, 880);
            this.Load += new System.EventHandler(this.SystemControl_Load);
            this.toolBar.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolBar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private FontAwesome.Sharp.IconButton btn_Menu;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private FontAwesome.Sharp.IconButton btn_Size;
        private FontAwesome.Sharp.IconButton btn_Close;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Timer menuTimer;
        private Bunifu.Framework.UI.BunifuDragControl dragToolBar;
    }
}
