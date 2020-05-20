namespace GAME
{
    partial class SuggestionTable
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
            this.label_Suggestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_SuggestionText = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_SuggestionText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Suggestion
            // 
            this.label_Suggestion.BackColor = System.Drawing.Color.Transparent;
            this.label_Suggestion.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Suggestion.ForeColor = System.Drawing.Color.SpringGreen;
            this.label_Suggestion.Location = new System.Drawing.Point(3, 82);
            this.label_Suggestion.Name = "label_Suggestion";
            this.label_Suggestion.Size = new System.Drawing.Size(376, 273);
            this.label_Suggestion.TabIndex = 0;
            this.label_Suggestion.Text = "Viết vào đây";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gợi ý: ";
            // 
            // panel_SuggestionText
            // 
            this.panel_SuggestionText.BackColor = System.Drawing.Color.Transparent;
            this.panel_SuggestionText.Controls.Add(this.label1);
            this.panel_SuggestionText.Controls.Add(this.label_Suggestion);
            this.panel_SuggestionText.Location = new System.Drawing.Point(25, 95);
            this.panel_SuggestionText.Name = "panel_SuggestionText";
            this.panel_SuggestionText.Size = new System.Drawing.Size(382, 290);
            this.panel_SuggestionText.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GAME.Properties.Resources.dice;
            this.pictureBox2.Location = new System.Drawing.Point(288, 390);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::GAME.Properties.Resources.object_10;
            this.pictureBox3.Location = new System.Drawing.Point(25, 391);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // SuggestionTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::GAME.Properties.Resources.maxresdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel_SuggestionText);
            this.Name = "SuggestionTable";
            this.Size = new System.Drawing.Size(442, 514);
            this.panel_SuggestionText.ResumeLayout(false);
            this.panel_SuggestionText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Suggestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_SuggestionText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
