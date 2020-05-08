namespace GAME
{
    partial class Level1
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
            this.btn_QuaTao = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_CaRot = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_QuaDua = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Xo = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_QuaTao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CaRot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_QuaDua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Xo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Level1
            // 
            this.label_Level1.BackColor = System.Drawing.Color.Transparent;
            this.label_Level1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Level1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Level1.Location = new System.Drawing.Point(91, 122);
            this.label_Level1.Name = "label_Level1";
            this.label_Level1.Size = new System.Drawing.Size(537, 93);
            this.label_Level1.TabIndex = 1;
            this.label_Level1.Text = "Cho tất cả hoa quả vào trong xô";
            this.label_Level1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_QuaTao
            // 
            this.btn_QuaTao.BackColor = System.Drawing.Color.Transparent;
            this.btn_QuaTao.Image = global::GAME.Properties.Resources.object_5;
            this.btn_QuaTao.ImageActive = null;
            this.btn_QuaTao.Location = new System.Drawing.Point(501, 616);
            this.btn_QuaTao.Name = "btn_QuaTao";
            this.btn_QuaTao.Size = new System.Drawing.Size(88, 107);
            this.btn_QuaTao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_QuaTao.TabIndex = 0;
            this.btn_QuaTao.TabStop = false;
            this.btn_QuaTao.Zoom = 10;
            this.btn_QuaTao.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_QuaTao_MouseUp);
            // 
            // btn_CaRot
            // 
            this.btn_CaRot.BackColor = System.Drawing.Color.Transparent;
            this.btn_CaRot.Image = global::GAME.Properties.Resources.object_4;
            this.btn_CaRot.ImageActive = null;
            this.btn_CaRot.Location = new System.Drawing.Point(302, 607);
            this.btn_CaRot.Name = "btn_CaRot";
            this.btn_CaRot.Size = new System.Drawing.Size(102, 116);
            this.btn_CaRot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_CaRot.TabIndex = 0;
            this.btn_CaRot.TabStop = false;
            this.btn_CaRot.Zoom = 10;
            this.btn_CaRot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_CaRot_MouseUp);
            // 
            // btn_QuaDua
            // 
            this.btn_QuaDua.BackColor = System.Drawing.Color.Transparent;
            this.btn_QuaDua.Image = global::GAME.Properties.Resources.object_3;
            this.btn_QuaDua.ImageActive = null;
            this.btn_QuaDua.Location = new System.Drawing.Point(117, 607);
            this.btn_QuaDua.Name = "btn_QuaDua";
            this.btn_QuaDua.Size = new System.Drawing.Size(74, 107);
            this.btn_QuaDua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_QuaDua.TabIndex = 0;
            this.btn_QuaDua.TabStop = false;
            this.btn_QuaDua.Zoom = 10;
            this.btn_QuaDua.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_QuaDua_MouseUp);
            // 
            // btn_Xo
            // 
            this.btn_Xo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xo.Image = global::GAME.Properties.Resources.object_11;
            this.btn_Xo.ImageActive = null;
            this.btn_Xo.Location = new System.Drawing.Point(216, 304);
            this.btn_Xo.Name = "btn_Xo";
            this.btn_Xo.Size = new System.Drawing.Size(274, 172);
            this.btn_Xo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Xo.TabIndex = 0;
            this.btn_Xo.TabStop = false;
            this.btn_Xo.Zoom = 0;
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_QuaTao);
            this.Controls.Add(this.btn_CaRot);
            this.Controls.Add(this.btn_QuaDua);
            this.Controls.Add(this.label_Level1);
            this.Controls.Add(this.btn_Xo);
            this.Font = new System.Drawing.Font("Lunchtime Doubly So", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Level1";
            this.Load += new System.EventHandler(this.Level1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_QuaTao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CaRot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_QuaDua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Xo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_QuaDua;
        private Bunifu.Framework.UI.BunifuImageButton btn_Xo;
        private Bunifu.Framework.UI.BunifuImageButton btn_CaRot;
        private Bunifu.Framework.UI.BunifuImageButton btn_QuaTao;
        private Bunifu.Framework.UI.BunifuCustomLabel label_Level1;
    }
}
