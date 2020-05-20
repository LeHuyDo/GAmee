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
            this.label_Answer = new System.Windows.Forms.Label();
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
            this.btn_NextLevel.Image = global::GAME.Properties.Resources.next;
            this.btn_NextLevel.ImageActive = null;
            this.btn_NextLevel.Location = new System.Drawing.Point(341, 431);
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
            this.btn_LevelMenuOpen.Image = global::GAME.Properties.Resources.menu;
            this.btn_LevelMenuOpen.ImageActive = null;
            this.btn_LevelMenuOpen.Location = new System.Drawing.Point(203, 431);
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
            this.btn_PlayAgain.Image = global::GAME.Properties.Resources.playAgain1;
            this.btn_PlayAgain.ImageActive = null;
            this.btn_PlayAgain.Location = new System.Drawing.Point(65, 431);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(37, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giải thích";
            // 
            // label_Answer
            // 
            this.label_Answer.BackColor = System.Drawing.Color.Transparent;
            this.label_Answer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Answer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_Answer.Location = new System.Drawing.Point(59, 196);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(387, 189);
            this.label_Answer.TabIndex = 5;
            this.label_Answer.Text = "Viết vào đây: ";
            // 
            // HallOfFame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::GAME.Properties.Resources.b4869abd6b3fb22cba3635dab74b6c87_700x394;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label_Answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_NextLevel);
            this.Controls.Add(this.btn_LevelMenuOpen);
            this.Controls.Add(this.btn_PlayAgain);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Label label_Answer;
    }
}
