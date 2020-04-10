namespace GAME
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btn_ChoiLuon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_ThoatTroChoi = new System.Windows.Forms.Button();
            this.btn_CachChoi = new System.Windows.Forms.Button();
            this.btn_Choitiep = new System.Windows.Forms.Button();
            this.toolBar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_ChoiLuon
            // 
            this.btn_ChoiLuon.ActiveBorderThickness = 12;
            this.btn_ChoiLuon.ActiveCornerRadius = 20;
            this.btn_ChoiLuon.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btn_ChoiLuon.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_ChoiLuon.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btn_ChoiLuon.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChoiLuon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ChoiLuon.BackgroundImage")));
            this.btn_ChoiLuon.ButtonText = "Chơi luôn";
            this.btn_ChoiLuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChoiLuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ChoiLuon.ForeColor = System.Drawing.Color.Black;
            this.btn_ChoiLuon.IdleBorderThickness = 1;
            this.btn_ChoiLuon.IdleCornerRadius = 20;
            this.btn_ChoiLuon.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_ChoiLuon.IdleForecolor = System.Drawing.Color.Gray;
            this.btn_ChoiLuon.IdleLineColor = System.Drawing.Color.Maroon;
            this.btn_ChoiLuon.Location = new System.Drawing.Point(203, 383);
            this.btn_ChoiLuon.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ChoiLuon.Name = "btn_ChoiLuon";
            this.btn_ChoiLuon.Size = new System.Drawing.Size(300, 41);
            this.btn_ChoiLuon.TabIndex = 8;
            this.btn_ChoiLuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ChoiLuon.DoubleClick += new System.EventHandler(this.btn_ChoiLuon_Click);
            // 
            // btn_ThoatTroChoi
            // 
            this.btn_ThoatTroChoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ThoatTroChoi.Location = new System.Drawing.Point(203, 653);
            this.btn_ThoatTroChoi.Name = "btn_ThoatTroChoi";
            this.btn_ThoatTroChoi.Size = new System.Drawing.Size(300, 41);
            this.btn_ThoatTroChoi.TabIndex = 6;
            this.btn_ThoatTroChoi.Text = "Thoát trò chơi";
            this.btn_ThoatTroChoi.UseVisualStyleBackColor = true;
            this.btn_ThoatTroChoi.Click += new System.EventHandler(this.btn_ThoatTroChoi_Click);
            // 
            // btn_CachChoi
            // 
            this.btn_CachChoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_CachChoi.Location = new System.Drawing.Point(203, 541);
            this.btn_CachChoi.Name = "btn_CachChoi";
            this.btn_CachChoi.Size = new System.Drawing.Size(300, 41);
            this.btn_CachChoi.TabIndex = 7;
            this.btn_CachChoi.Text = "Cách chơi";
            this.btn_CachChoi.UseVisualStyleBackColor = true;
            this.btn_CachChoi.Click += new System.EventHandler(this.btn_CachChoi_Click);
            // 
            // btn_Choitiep
            // 
            this.btn_Choitiep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Choitiep.Location = new System.Drawing.Point(203, 459);
            this.btn_Choitiep.Name = "btn_Choitiep";
            this.btn_Choitiep.Size = new System.Drawing.Size(300, 41);
            this.btn_Choitiep.TabIndex = 7;
            this.btn_Choitiep.Text = "Chơi tiếp";
            this.btn_Choitiep.UseVisualStyleBackColor = true;
            this.btn_Choitiep.Click += new System.EventHandler(this.btn_Choitiep_Click);
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.Black;
            this.toolBar.Location = new System.Drawing.Point(172, 238);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(200, 53);
            this.toolBar.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::GAME.Properties.Resources.Background_Cutted;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.btn_ChoiLuon);
            this.Controls.Add(this.btn_ThoatTroChoi);
            this.Controls.Add(this.btn_Choitiep);
            this.Controls.Add(this.btn_CachChoi);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(702, 880);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_ChoiLuon;
        private System.Windows.Forms.Button btn_ThoatTroChoi;
        private System.Windows.Forms.Button btn_CachChoi;
        private System.Windows.Forms.Button btn_Choitiep;
        private System.Windows.Forms.Panel toolBar;
    }
}
