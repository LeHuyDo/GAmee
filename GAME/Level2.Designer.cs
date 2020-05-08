namespace GAME
{
    partial class Level2
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
            this.picture_YellowPencil = new System.Windows.Forms.PictureBox();
            this.picture_RedPencil = new System.Windows.Forms.PictureBox();
            this.picture_BluePencil = new System.Windows.Forms.PictureBox();
            this.label_Level1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picture_YellowPencil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_RedPencil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_BluePencil)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_YellowPencil
            // 
            this.picture_YellowPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture_YellowPencil.Image = global::GAME.Properties.Resources.object_9;
            this.picture_YellowPencil.Location = new System.Drawing.Point(191, 679);
            this.picture_YellowPencil.Name = "picture_YellowPencil";
            this.picture_YellowPencil.Size = new System.Drawing.Size(294, 72);
            this.picture_YellowPencil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_YellowPencil.TabIndex = 2;
            this.picture_YellowPencil.TabStop = false;
            this.picture_YellowPencil.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_YellowPencil_MouseUp);
            // 
            // picture_RedPencil
            // 
            this.picture_RedPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture_RedPencil.Image = global::GAME.Properties.Resources.object_7;
            this.picture_RedPencil.Location = new System.Drawing.Point(191, 357);
            this.picture_RedPencil.Name = "picture_RedPencil";
            this.picture_RedPencil.Size = new System.Drawing.Size(294, 72);
            this.picture_RedPencil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_RedPencil.TabIndex = 2;
            this.picture_RedPencil.TabStop = false;
            this.picture_RedPencil.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_RedPencil_MouseUp);
            // 
            // picture_BluePencil
            // 
            this.picture_BluePencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture_BluePencil.Image = global::GAME.Properties.Resources.object_8;
            this.picture_BluePencil.Location = new System.Drawing.Point(191, 518);
            this.picture_BluePencil.Name = "picture_BluePencil";
            this.picture_BluePencil.Size = new System.Drawing.Size(294, 72);
            this.picture_BluePencil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_BluePencil.TabIndex = 2;
            this.picture_BluePencil.TabStop = false;
            this.picture_BluePencil.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_BluePencil_MouseUp);
            // 
            // label_Level1
            // 
            this.label_Level1.BackColor = System.Drawing.Color.Transparent;
            this.label_Level1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Level1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Level1.Location = new System.Drawing.Point(89, 118);
            this.label_Level1.Name = "label_Level1";
            this.label_Level1.Size = new System.Drawing.Size(537, 93);
            this.label_Level1.TabIndex = 3;
            this.label_Level1.Text = "Chọn chiếc bút chì xanh lục";
            this.label_Level1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label_Level1);
            this.Controls.Add(this.picture_YellowPencil);
            this.Controls.Add(this.picture_RedPencil);
            this.Controls.Add(this.picture_BluePencil);
            this.Name = "Level2";
            this.Load += new System.EventHandler(this.Level2_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Level2_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picture_YellowPencil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_RedPencil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_BluePencil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picture_BluePencil;
        private System.Windows.Forms.PictureBox picture_RedPencil;
        private System.Windows.Forms.PictureBox picture_YellowPencil;
        private Bunifu.Framework.UI.BunifuCustomLabel label_Level1;
    }
}
