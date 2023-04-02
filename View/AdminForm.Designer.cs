namespace PBL3_QLQuanNet.View
{
    partial class AdminForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btn_ThemTKKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btn_ThemTKKhachHang
            // 
            this.btn_ThemTKKhachHang.Animated = true;
            this.btn_ThemTKKhachHang.BorderColor = System.Drawing.Color.Cyan;
            this.btn_ThemTKKhachHang.BorderThickness = 1;
            this.btn_ThemTKKhachHang.CustomBorderColor = System.Drawing.Color.Cyan;
            this.btn_ThemTKKhachHang.CustomizableEdges.BottomLeft = false;
            this.btn_ThemTKKhachHang.CustomizableEdges.BottomRight = false;
            this.btn_ThemTKKhachHang.CustomizableEdges.TopLeft = false;
            this.btn_ThemTKKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemTKKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemTKKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThemTKKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThemTKKhachHang.FillColor = System.Drawing.Color.Black;
            this.btn_ThemTKKhachHang.FocusedColor = System.Drawing.Color.LightGray;
            this.btn_ThemTKKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_ThemTKKhachHang.ForeColor = System.Drawing.Color.Cyan;
            this.btn_ThemTKKhachHang.Location = new System.Drawing.Point(231, 188);
            this.btn_ThemTKKhachHang.Name = "btn_ThemTKKhachHang";
            this.btn_ThemTKKhachHang.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btn_ThemTKKhachHang.Size = new System.Drawing.Size(276, 43);
            this.btn_ThemTKKhachHang.TabIndex = 6;
            this.btn_ThemTKKhachHang.Text = "Thêm Tài Khoản ";
            this.btn_ThemTKKhachHang.Click += new System.EventHandler(this.btn_ThemTKKhachHang_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(751, 518);
            this.Controls.Add(this.btn_ThemTKKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_ThemTKKhachHang;
    }
}