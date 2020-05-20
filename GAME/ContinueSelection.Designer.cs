namespace GAME
{
    partial class ContinueSelection
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_PlayAgain = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_LevelMenuOpen = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PlayAgain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LevelMenuOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GAME.Properties.Resources.coffinguys;
            this.pictureBox1.Location = new System.Drawing.Point(95, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(148, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Over";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(70, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cay quá làm ván nữa ?";
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlayAgain.Image = global::GAME.Properties.Resources.playAgain1;
            this.btn_PlayAgain.ImageActive = null;
            this.btn_PlayAgain.Location = new System.Drawing.Point(332, 354);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(71, 71);
            this.btn_PlayAgain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_PlayAgain.TabIndex = 2;
            this.btn_PlayAgain.TabStop = false;
            this.btn_PlayAgain.Zoom = 10;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // btn_LevelMenuOpen
            // 
            this.btn_LevelMenuOpen.BackColor = System.Drawing.Color.Transparent;
            this.btn_LevelMenuOpen.Image = global::GAME.Properties.Resources.menu;
            this.btn_LevelMenuOpen.ImageActive = null;
            this.btn_LevelMenuOpen.Location = new System.Drawing.Point(128, 354);
            this.btn_LevelMenuOpen.Name = "btn_LevelMenuOpen";
            this.btn_LevelMenuOpen.Size = new System.Drawing.Size(71, 71);
            this.btn_LevelMenuOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_LevelMenuOpen.TabIndex = 3;
            this.btn_LevelMenuOpen.TabStop = false;
            this.btn_LevelMenuOpen.Zoom = 10;
            this.btn_LevelMenuOpen.Click += new System.EventHandler(this.btn_LevelMenuOpen_Click);
            // 
            // ContinueSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::GAME.Properties.Resources.desert;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_LevelMenuOpen);
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ContinueSelection";
            this.Size = new System.Drawing.Size(497, 571);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PlayAgain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LevelMenuOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btn_PlayAgain;
        private Bunifu.Framework.UI.BunifuImageButton btn_LevelMenuOpen;
    }
}
