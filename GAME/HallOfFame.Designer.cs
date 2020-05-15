namespace GAME
{
    partial class HallOfFame
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
            this.levelLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_NextLevel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_LevelMenuOpen = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_PlayAgain = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_NextLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LevelMenuOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PlayAgain)).BeginInit();
            this.SuspendLayout();
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.levelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.levelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(225)))), ((int)(((byte)(15)))));
            this.levelLabel.Location = new System.Drawing.Point(199, 44);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(98, 32);
            this.levelLabel.TabIndex = 2;
            this.levelLabel.Text = "Màn 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GAME.Properties.Resources.redRibbon;
            this.pictureBox1.Location = new System.Drawing.Point(78, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_NextLevel
            // 
            this.btn_NextLevel.BackColor = System.Drawing.Color.Transparent;
            this.btn_NextLevel.Image = global::GAME.Properties.Resources.nextLevel;
            this.btn_NextLevel.ImageActive = null;
            this.btn_NextLevel.Location = new System.Drawing.Point(342, 370);
            this.btn_NextLevel.Name = "btn_NextLevel";
            this.btn_NextLevel.Size = new System.Drawing.Size(71, 71);
            this.btn_NextLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_NextLevel.TabIndex = 0;
            this.btn_NextLevel.TabStop = false;
            this.btn_NextLevel.Zoom = 10;
            this.btn_NextLevel.Click += new System.EventHandler(this.btn_NextLevel_Click);
            // 
            // btn_LevelMenuOpen
            // 
            this.btn_LevelMenuOpen.BackColor = System.Drawing.Color.Transparent;
            this.btn_LevelMenuOpen.Image = global::GAME.Properties.Resources.menuIcon;
            this.btn_LevelMenuOpen.ImageActive = null;
            this.btn_LevelMenuOpen.Location = new System.Drawing.Point(214, 370);
            this.btn_LevelMenuOpen.Name = "btn_LevelMenuOpen";
            this.btn_LevelMenuOpen.Size = new System.Drawing.Size(71, 71);
            this.btn_LevelMenuOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_LevelMenuOpen.TabIndex = 0;
            this.btn_LevelMenuOpen.TabStop = false;
            this.btn_LevelMenuOpen.Zoom = 10;
            this.btn_LevelMenuOpen.Click += new System.EventHandler(this.btn_LevelMenuOpen_Click);
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlayAgain.Image = global::GAME.Properties.Resources.playAgain;
            this.btn_PlayAgain.ImageActive = null;
            this.btn_PlayAgain.Location = new System.Drawing.Point(78, 370);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(71, 71);
            this.btn_PlayAgain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_PlayAgain.TabIndex = 0;
            this.btn_PlayAgain.TabStop = false;
            this.btn_PlayAgain.Zoom = 10;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(73, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giải thích";
            // 
            // HallOfFame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::GAME.Properties.Resources.Blue_Green_Circle_Gradient_Android_Wallpaper_360x640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_NextLevel);
            this.Controls.Add(this.btn_LevelMenuOpen);
            this.Controls.Add(this.btn_PlayAgain);
            this.Name = "HallOfFame";
            this.Size = new System.Drawing.Size(497, 571);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_NextLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LevelMenuOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PlayAgain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_PlayAgain;
        private Bunifu.Framework.UI.BunifuImageButton btn_LevelMenuOpen;
        private Bunifu.Framework.UI.BunifuImageButton btn_NextLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label label1;
    }
}
