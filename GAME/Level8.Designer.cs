namespace GAME
{
    partial class Level8
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
            this.label_Dot = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picture_Cake = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Cake)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Level1
            // 
            this.label_Level1.BackColor = System.Drawing.Color.Transparent;
            this.label_Level1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Level1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Level1.Location = new System.Drawing.Point(229, 233);
            this.label_Level1.Name = "label_Level1";
            this.label_Level1.Size = new System.Drawing.Size(333, 37);
            this.label_Level1.TabIndex = 15;
            this.label_Level1.Text = "nến bánh sinh nhật nào";
            this.label_Level1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Level1.Click += new System.EventHandler(this.WrongAnswer);
            // 
            // label_Dot
            // 
            this.label_Dot.BackColor = System.Drawing.Color.Transparent;
            this.label_Dot.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dot.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Dot.Location = new System.Drawing.Point(181, 233);
            this.label_Dot.Name = "label_Dot";
            this.label_Dot.Size = new System.Drawing.Size(66, 37);
            this.label_Dot.TabIndex = 18;
            this.label_Dot.Text = "Đốt";
            this.label_Dot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture_Cake
            // 
            this.picture_Cake.Image = global::GAME.Properties.Resources.cake1;
            this.picture_Cake.Location = new System.Drawing.Point(208, 452);
            this.picture_Cake.Name = "picture_Cake";
            this.picture_Cake.Size = new System.Drawing.Size(290, 275);
            this.picture_Cake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Cake.TabIndex = 16;
            this.picture_Cake.TabStop = false;
            this.picture_Cake.Click += new System.EventHandler(this.WrongAnswer);
            // 
            // Level8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label_Dot);
            this.Controls.Add(this.picture_Cake);
            this.Controls.Add(this.label_Level1);
            this.Name = "Level8";
            this.Load += new System.EventHandler(this.Level8_Load);
            this.Click += new System.EventHandler(this.WrongAnswer);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Cake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picture_Cake;
        private Bunifu.Framework.UI.BunifuCustomLabel label_Level1;
        private Bunifu.Framework.UI.BunifuCustomLabel label_Dot;
    }
}
