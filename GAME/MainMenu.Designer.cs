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
            this.components = new System.ComponentModel.Container();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.dra = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_ChoiLuon = new System.Windows.Forms.Button();
            this.btn_Choitiep = new System.Windows.Forms.Button();
            this.btn_CachChoi = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(702, 54);
            this.menuPanel.TabIndex = 1;
            // 
            // dra
            // 
            this.dra.Fixed = true;
            this.dra.Horizontal = true;
            this.dra.TargetControl = this.menuPanel;
            this.dra.Vertical = true;
            // 
            // btn_ChoiLuon
            // 
            this.btn_ChoiLuon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ChoiLuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChoiLuon.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_ChoiLuon.Location = new System.Drawing.Point(198, 365);
            this.btn_ChoiLuon.Name = "btn_ChoiLuon";
            this.btn_ChoiLuon.Size = new System.Drawing.Size(336, 44);
            this.btn_ChoiLuon.TabIndex = 2;
            this.btn_ChoiLuon.Text = "Chơi luôn";
            this.btn_ChoiLuon.UseVisualStyleBackColor = false;
            this.btn_ChoiLuon.Click += new System.EventHandler(this.btn_ChoiLuon_Click);
            // 
            // btn_Choitiep
            // 
            this.btn_Choitiep.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Choitiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Choitiep.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Choitiep.Location = new System.Drawing.Point(198, 463);
            this.btn_Choitiep.Name = "btn_Choitiep";
            this.btn_Choitiep.Size = new System.Drawing.Size(336, 44);
            this.btn_Choitiep.TabIndex = 2;
            this.btn_Choitiep.Text = "Chơi tiếp";
            this.btn_Choitiep.UseVisualStyleBackColor = false;
            this.btn_Choitiep.Click += new System.EventHandler(this.btn_Choitiep_Click);
            // 
            // btn_CachChoi
            // 
            this.btn_CachChoi.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_CachChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CachChoi.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_CachChoi.Location = new System.Drawing.Point(198, 561);
            this.btn_CachChoi.Name = "btn_CachChoi";
            this.btn_CachChoi.Size = new System.Drawing.Size(336, 44);
            this.btn_CachChoi.TabIndex = 2;
            this.btn_CachChoi.Text = "Cách chơi";
            this.btn_CachChoi.UseVisualStyleBackColor = false;
            this.btn_CachChoi.Click += new System.EventHandler(this.btn_CachChoi_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Thoat.Location = new System.Drawing.Point(198, 659);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(336, 44);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_ThoatTroChoi_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::GAME.Properties.Resources.Background_Cutted;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_CachChoi);
            this.Controls.Add(this.btn_Choitiep);
            this.Controls.Add(this.btn_ChoiLuon);
            this.Controls.Add(this.menuPanel);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(702, 880);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private Bunifu.Framework.UI.BunifuDragControl dra;
        private System.Windows.Forms.Button btn_ChoiLuon;
        private System.Windows.Forms.Button btn_Choitiep;
        private System.Windows.Forms.Button btn_CachChoi;
        private System.Windows.Forms.Button btn_Thoat;
    }
}
