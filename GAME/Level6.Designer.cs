namespace GAME
{
    partial class Level6
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Ok = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Add = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Sub = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Level1
            // 
            this.label_Level1.BackColor = System.Drawing.Color.Transparent;
            this.label_Level1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Level1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Level1.Location = new System.Drawing.Point(103, 118);
            this.label_Level1.Name = "label_Level1";
            this.label_Level1.Size = new System.Drawing.Size(521, 112);
            this.label_Level1.TabIndex = 8;
            this.label_Level1.Text = "Trong một năm có bao nhiêu \r\ntháng có ngày 28";
            this.label_Level1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(283, 541);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 49);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ok.Image = global::GAME.Properties.Resources.ok;
            this.btn_Ok.ImageActive = null;
            this.btn_Ok.Location = new System.Drawing.Point(274, 670);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(145, 58);
            this.btn_Ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Ok.TabIndex = 10;
            this.btn_Ok.TabStop = false;
            this.btn_Ok.Zoom = 10;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.Image = global::GAME.Properties.Resources.add;
            this.btn_Add.ImageActive = null;
            this.btn_Add.Location = new System.Drawing.Point(489, 670);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(98, 58);
            this.btn_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Add.TabIndex = 10;
            this.btn_Add.TabStop = false;
            this.btn_Add.Zoom = 10;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Sub
            // 
            this.btn_Sub.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sub.Image = global::GAME.Properties.Resources.sub;
            this.btn_Sub.ImageActive = null;
            this.btn_Sub.Location = new System.Drawing.Point(109, 670);
            this.btn_Sub.Name = "btn_Sub";
            this.btn_Sub.Size = new System.Drawing.Size(95, 58);
            this.btn_Sub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Sub.TabIndex = 11;
            this.btn_Sub.TabStop = false;
            this.btn_Sub.Zoom = 10;
            this.btn_Sub.Click += new System.EventHandler(this.btn_Sub_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GAME.Properties.Resources.object_27;
            this.pictureBox1.Location = new System.Drawing.Point(262, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Level6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Sub);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Level1);
            this.Name = "Level6";
            this.Load += new System.EventHandler(this.Level6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_Add;
        private Bunifu.Framework.UI.BunifuImageButton btn_Sub;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel label_Level1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Ok;
        private System.Windows.Forms.TextBox textBox1;
    }
}
