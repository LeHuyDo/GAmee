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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.dra = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_Thoat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_CachChoi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Choitiep = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_ChoiLuon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
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
            // btn_Thoat
            // 
            this.btn_Thoat.ActiveBorderThickness = 1;
            this.btn_Thoat.ActiveCornerRadius = 20;
            this.btn_Thoat.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Thoat.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Thoat.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Thoat.BackColor = System.Drawing.Color.Maroon;
            this.btn_Thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.BackgroundImage")));
            this.btn_Thoat.ButtonText = "Thoát";
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Thoat.IdleBorderThickness = 1;
            this.btn_Thoat.IdleCornerRadius = 20;
            this.btn_Thoat.IdleFillColor = System.Drawing.Color.White;
            this.btn_Thoat.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Thoat.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Thoat.Location = new System.Drawing.Point(188, 627);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(339, 54);
            this.btn_Thoat.TabIndex = 0;
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_ThoatTroChoi_Click);
            // 
            // btn_CachChoi
            // 
            this.btn_CachChoi.ActiveBorderThickness = 1;
            this.btn_CachChoi.ActiveCornerRadius = 20;
            this.btn_CachChoi.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_CachChoi.ActiveForecolor = System.Drawing.Color.White;
            this.btn_CachChoi.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CachChoi.BackColor = System.Drawing.Color.Maroon;
            this.btn_CachChoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CachChoi.BackgroundImage")));
            this.btn_CachChoi.ButtonText = "Cách chơi";
            this.btn_CachChoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CachChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CachChoi.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_CachChoi.IdleBorderThickness = 1;
            this.btn_CachChoi.IdleCornerRadius = 20;
            this.btn_CachChoi.IdleFillColor = System.Drawing.Color.White;
            this.btn_CachChoi.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_CachChoi.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CachChoi.Location = new System.Drawing.Point(188, 540);
            this.btn_CachChoi.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CachChoi.Name = "btn_CachChoi";
            this.btn_CachChoi.Size = new System.Drawing.Size(339, 54);
            this.btn_CachChoi.TabIndex = 0;
            this.btn_CachChoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CachChoi.Click += new System.EventHandler(this.btn_CachChoi_Click);
            // 
            // btn_Choitiep
            // 
            this.btn_Choitiep.ActiveBorderThickness = 1;
            this.btn_Choitiep.ActiveCornerRadius = 20;
            this.btn_Choitiep.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Choitiep.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Choitiep.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Choitiep.BackColor = System.Drawing.Color.Maroon;
            this.btn_Choitiep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Choitiep.BackgroundImage")));
            this.btn_Choitiep.ButtonText = "Chơi tiếp";
            this.btn_Choitiep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Choitiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Choitiep.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Choitiep.IdleBorderThickness = 1;
            this.btn_Choitiep.IdleCornerRadius = 20;
            this.btn_Choitiep.IdleFillColor = System.Drawing.Color.White;
            this.btn_Choitiep.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Choitiep.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Choitiep.Location = new System.Drawing.Point(188, 453);
            this.btn_Choitiep.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Choitiep.Name = "btn_Choitiep";
            this.btn_Choitiep.Size = new System.Drawing.Size(339, 54);
            this.btn_Choitiep.TabIndex = 0;
            this.btn_Choitiep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Choitiep.Click += new System.EventHandler(this.btn_Choitiep_Click);
            // 
            // btn_ChoiLuon
            // 
            this.btn_ChoiLuon.ActiveBorderThickness = 1;
            this.btn_ChoiLuon.ActiveCornerRadius = 20;
            this.btn_ChoiLuon.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_ChoiLuon.ActiveForecolor = System.Drawing.Color.White;
            this.btn_ChoiLuon.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_ChoiLuon.BackColor = System.Drawing.Color.Maroon;
            this.btn_ChoiLuon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ChoiLuon.BackgroundImage")));
            this.btn_ChoiLuon.ButtonText = "Chơi luôn";
            this.btn_ChoiLuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChoiLuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChoiLuon.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_ChoiLuon.IdleBorderThickness = 1;
            this.btn_ChoiLuon.IdleCornerRadius = 20;
            this.btn_ChoiLuon.IdleFillColor = System.Drawing.Color.White;
            this.btn_ChoiLuon.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_ChoiLuon.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_ChoiLuon.Location = new System.Drawing.Point(188, 366);
            this.btn_ChoiLuon.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ChoiLuon.Name = "btn_ChoiLuon";
            this.btn_ChoiLuon.Size = new System.Drawing.Size(339, 54);
            this.btn_ChoiLuon.TabIndex = 0;
            this.btn_ChoiLuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ChoiLuon.Click += new System.EventHandler(this.btn_ChoiLuon_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_CachChoi);
            this.Controls.Add(this.btn_Choitiep);
            this.Controls.Add(this.btn_ChoiLuon);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(702, 880);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_ChoiLuon;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Choitiep;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_CachChoi;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Thoat;
        private Bunifu.Framework.UI.BunifuDragControl dra;
    }
}
