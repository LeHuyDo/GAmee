namespace GAME
{
    partial class Level5
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
            this.btn_Ok = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Level1
            // 
            this.label_Level1.BackColor = System.Drawing.Color.Transparent;
            this.label_Level1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Level1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Level1.Location = new System.Drawing.Point(197, 186);
            this.label_Level1.Name = "label_Level1";
            this.label_Level1.Size = new System.Drawing.Size(283, 37);
            this.label_Level1.TabIndex = 12;
            this.label_Level1.Text = "Đơn giản, nhấn vào    ";
            this.label_Level1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Level1.Click += new System.EventHandler(this.WrongAnswer);
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ok.Image = global::GAME.Properties.Resources.ok1;
            this.btn_Ok.ImageActive = null;
            this.btn_Ok.Location = new System.Drawing.Point(282, 661);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(145, 58);
            this.btn_Ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Ok.TabIndex = 14;
            this.btn_Ok.TabStop = false;
            this.btn_Ok.Zoom = 10;
            this.btn_Ok.Click += new System.EventHandler(this.WrongAnswer);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GAME.Properties.Resources.arr;
            this.pictureBox1.Location = new System.Drawing.Point(282, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.WrongAnswer);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(458, 186);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(66, 37);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "OK";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.TrueAnswer);
            // 
            // Level5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.label_Level1);
            this.Name = "Level5";
            this.Load += new System.EventHandler(this.Level5_Load);
            this.Click += new System.EventHandler(this.WrongAnswer);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_Ok;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel label_Level1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
