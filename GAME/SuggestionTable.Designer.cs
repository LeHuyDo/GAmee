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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuggestionTable));
            this.label_Suggestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_SuggestionText = new System.Windows.Forms.Panel();
            this.btn_PayForSuggestion = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_SuggestionText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PayForSuggestion)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Suggestion
            // 
            this.label_Suggestion.BackColor = System.Drawing.Color.DimGray;
            this.label_Suggestion.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Suggestion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Suggestion.Location = new System.Drawing.Point(23, 82);
            this.label_Suggestion.Name = "label_Suggestion";
            this.label_Suggestion.Size = new System.Drawing.Size(357, 170);
            this.label_Suggestion.TabIndex = 0;
            this.label_Suggestion.Text = "Viết vào đây";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gợi ý: ";
            // 
            // panel_SuggestionText
            // 
            this.panel_SuggestionText.Controls.Add(this.label1);
            this.panel_SuggestionText.Controls.Add(this.label_Suggestion);
            this.panel_SuggestionText.Location = new System.Drawing.Point(42, 103);
            this.panel_SuggestionText.Name = "panel_SuggestionText";
            this.panel_SuggestionText.Size = new System.Drawing.Size(418, 395);
            this.panel_SuggestionText.TabIndex = 1;
            this.panel_SuggestionText.Visible = false;
            // 
            // btn_PayForSuggestion
            // 
            this.btn_PayForSuggestion.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_PayForSuggestion.Image = ((System.Drawing.Image)(resources.GetObject("btn_PayForSuggestion.Image")));
            this.btn_PayForSuggestion.ImageActive = null;
            this.btn_PayForSuggestion.Location = new System.Drawing.Point(71, 408);
            this.btn_PayForSuggestion.Name = "btn_PayForSuggestion";
            this.btn_PayForSuggestion.Size = new System.Drawing.Size(351, 59);
            this.btn_PayForSuggestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_PayForSuggestion.TabIndex = 1;
            this.btn_PayForSuggestion.TabStop = false;
            this.btn_PayForSuggestion.Zoom = 4;
            this.btn_PayForSuggestion.Click += new System.EventHandler(this.btn_PayForSuggestion_Click);
            // 
            // SuggestionTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.btn_PayForSuggestion);
            this.Controls.Add(this.panel_SuggestionText);
            this.Name = "SuggestionTable";
            this.Size = new System.Drawing.Size(497, 571);
            this.panel_SuggestionText.ResumeLayout(false);
            this.panel_SuggestionText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PayForSuggestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Suggestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_SuggestionText;
        private Bunifu.Framework.UI.BunifuImageButton btn_PayForSuggestion;
    }
}
