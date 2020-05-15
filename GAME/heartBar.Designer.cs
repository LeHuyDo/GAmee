namespace GAME
{
    partial class HeartBar
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
            this.picture_heart5 = new System.Windows.Forms.PictureBox();
            this.picture_heart4 = new System.Windows.Forms.PictureBox();
            this.picture_heart3 = new System.Windows.Forms.PictureBox();
            this.picture_heart2 = new System.Windows.Forms.PictureBox();
            this.picture_heart1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_heart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_heart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_heart1)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_heart5
            // 
            this.picture_heart5.Image = global::GAME.Properties.Resources.heart;
            this.picture_heart5.Location = new System.Drawing.Point(192, 0);
            this.picture_heart5.Name = "picture_heart5";
            this.picture_heart5.Size = new System.Drawing.Size(41, 31);
            this.picture_heart5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_heart5.TabIndex = 0;
            this.picture_heart5.TabStop = false;
            // 
            // picture_heart4
            // 
            this.picture_heart4.Image = global::GAME.Properties.Resources.heart;
            this.picture_heart4.Location = new System.Drawing.Point(144, 0);
            this.picture_heart4.Name = "picture_heart4";
            this.picture_heart4.Size = new System.Drawing.Size(41, 31);
            this.picture_heart4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_heart4.TabIndex = 0;
            this.picture_heart4.TabStop = false;
            // 
            // picture_heart3
            // 
            this.picture_heart3.Image = global::GAME.Properties.Resources.heart;
            this.picture_heart3.Location = new System.Drawing.Point(96, 0);
            this.picture_heart3.Name = "picture_heart3";
            this.picture_heart3.Size = new System.Drawing.Size(41, 31);
            this.picture_heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_heart3.TabIndex = 0;
            this.picture_heart3.TabStop = false;
            // 
            // picture_heart2
            // 
            this.picture_heart2.Image = global::GAME.Properties.Resources.heart;
            this.picture_heart2.Location = new System.Drawing.Point(48, 0);
            this.picture_heart2.Name = "picture_heart2";
            this.picture_heart2.Size = new System.Drawing.Size(41, 31);
            this.picture_heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_heart2.TabIndex = 0;
            this.picture_heart2.TabStop = false;
            // 
            // picture_heart1
            // 
            this.picture_heart1.Image = global::GAME.Properties.Resources.heart;
            this.picture_heart1.Location = new System.Drawing.Point(0, 0);
            this.picture_heart1.Name = "picture_heart1";
            this.picture_heart1.Size = new System.Drawing.Size(41, 31);
            this.picture_heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_heart1.TabIndex = 0;
            this.picture_heart1.TabStop = false;
            // 
            // HeartBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.picture_heart5);
            this.Controls.Add(this.picture_heart4);
            this.Controls.Add(this.picture_heart3);
            this.Controls.Add(this.picture_heart2);
            this.Controls.Add(this.picture_heart1);
            this.Name = "HeartBar";
            this.Size = new System.Drawing.Size(233, 32);
            this.Load += new System.EventHandler(this.heartBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_heart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_heart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_heart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_heart1;
        private System.Windows.Forms.PictureBox picture_heart2;
        private System.Windows.Forms.PictureBox picture_heart3;
        private System.Windows.Forms.PictureBox picture_heart4;
        private System.Windows.Forms.PictureBox picture_heart5;
    }
}
