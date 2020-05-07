namespace GAME
{
    partial class Level3
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
            this.label_Level1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_West = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_East = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_South = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_North = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_West)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_East)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_South)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_North)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Level1
            // 
            this.label_Level1.BackColor = System.Drawing.Color.Transparent;
            this.label_Level1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Level1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Level1.Location = new System.Drawing.Point(89, 118);
            this.label_Level1.Name = "label_Level1";
            this.label_Level1.Size = new System.Drawing.Size(537, 93);
            this.label_Level1.TabIndex = 4;
            this.label_Level1.Text = "La bàn đang chỉ hướng:";
            this.label_Level1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_West
            // 
            this.btn_West.BackColor = System.Drawing.Color.Transparent;
            this.btn_West.Image = global::GAME.Properties.Resources.bWest;
            this.btn_West.ImageActive = null;
            this.btn_West.Location = new System.Drawing.Point(402, 641);
            this.btn_West.Name = "btn_West";
            this.btn_West.Size = new System.Drawing.Size(224, 81);
            this.btn_West.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_West.TabIndex = 5;
            this.btn_West.TabStop = false;
            this.btn_West.Zoom = 10;
            this.btn_West.Click += new System.EventHandler(this.btn_West_Click);
            // 
            // btn_East
            // 
            this.btn_East.BackColor = System.Drawing.Color.Transparent;
            this.btn_East.Image = global::GAME.Properties.Resources.bEast;
            this.btn_East.ImageActive = null;
            this.btn_East.Location = new System.Drawing.Point(402, 510);
            this.btn_East.Name = "btn_East";
            this.btn_East.Size = new System.Drawing.Size(224, 81);
            this.btn_East.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_East.TabIndex = 5;
            this.btn_East.TabStop = false;
            this.btn_East.Zoom = 10;
            this.btn_East.Click += new System.EventHandler(this.WrongAnserEvent);
            // 
            // btn_South
            // 
            this.btn_South.BackColor = System.Drawing.Color.Transparent;
            this.btn_South.Image = global::GAME.Properties.Resources.bSouth;
            this.btn_South.ImageActive = null;
            this.btn_South.Location = new System.Drawing.Point(402, 379);
            this.btn_South.Name = "btn_South";
            this.btn_South.Size = new System.Drawing.Size(224, 81);
            this.btn_South.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_South.TabIndex = 5;
            this.btn_South.TabStop = false;
            this.btn_South.Zoom = 10;
            this.btn_South.Click += new System.EventHandler(this.WrongAnserEvent);
            // 
            // btn_North
            // 
            this.btn_North.BackColor = System.Drawing.Color.Transparent;
            this.btn_North.Image = global::GAME.Properties.Resources.bNorth;
            this.btn_North.ImageActive = null;
            this.btn_North.Location = new System.Drawing.Point(402, 248);
            this.btn_North.Name = "btn_North";
            this.btn_North.Size = new System.Drawing.Size(224, 81);
            this.btn_North.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_North.TabIndex = 5;
            this.btn_North.TabStop = false;
            this.btn_North.Zoom = 10;
            this.btn_North.Click += new System.EventHandler(this.WrongAnserEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GAME.Properties.Resources.laban;
            this.pictureBox1.Location = new System.Drawing.Point(78, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Level3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_West);
            this.Controls.Add(this.btn_East);
            this.Controls.Add(this.btn_South);
            this.Controls.Add(this.btn_North);
            this.Controls.Add(this.label_Level1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Level3";
            this.Size = new System.Drawing.Size(702, 880);
            ((System.ComponentModel.ISupportInitialize)(this.btn_West)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_East)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_South)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_North)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel label_Level1;
        private Bunifu.Framework.UI.BunifuImageButton btn_North;
        private Bunifu.Framework.UI.BunifuImageButton btn_South;
        private Bunifu.Framework.UI.BunifuImageButton btn_East;
        private Bunifu.Framework.UI.BunifuImageButton btn_West;
    }
}
