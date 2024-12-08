
namespace Bai2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.lstDanhSachTrai = new System.Windows.Forms.ListBox();
            this.btnChuyen1 = new System.Windows.Forms.Button();
            this.btnChuyenLai1 = new System.Windows.Forms.Button();
            this.btnChuyenLaiAll = new System.Windows.Forms.Button();
            this.lstDanhSachPhai = new System.Windows.Forms.ListBox();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnChuyenAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = " Họ Tên:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(420, 70);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(108, 33);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(210, 73);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(190, 22);
            this.txtHoten.TabIndex = 2;
            // 
            // lstDanhSachTrai
            // 
            this.lstDanhSachTrai.FormattingEnabled = true;
            this.lstDanhSachTrai.ItemHeight = 16;
            this.lstDanhSachTrai.Location = new System.Drawing.Point(142, 137);
            this.lstDanhSachTrai.Name = "lstDanhSachTrai";
            this.lstDanhSachTrai.Size = new System.Drawing.Size(137, 180);
            this.lstDanhSachTrai.TabIndex = 3;
            // 
            // btnChuyen1
            // 
            this.btnChuyen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChuyen1.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.btnChuyen1.Font = new System.Drawing.Font("Microsoft PhagsPa", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyen1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChuyen1.Location = new System.Drawing.Point(325, 137);
            this.btnChuyen1.Name = "btnChuyen1";
            this.btnChuyen1.Size = new System.Drawing.Size(85, 50);
            this.btnChuyen1.TabIndex = 5;
            this.btnChuyen1.Text = " >";
            this.btnChuyen1.UseVisualStyleBackColor = true;
            this.btnChuyen1.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnChuyenLai1
            // 
            this.btnChuyenLai1.Location = new System.Drawing.Point(325, 255);
            this.btnChuyenLai1.Name = "btnChuyenLai1";
            this.btnChuyenLai1.Size = new System.Drawing.Size(85, 23);
            this.btnChuyenLai1.TabIndex = 6;
            this.btnChuyenLai1.Text = "<";
            this.btnChuyenLai1.UseVisualStyleBackColor = true;
            this.btnChuyenLai1.Click += new System.EventHandler(this.btnChuyenLai1_Click);
            // 
            // btnChuyenLaiAll
            // 
            this.btnChuyenLaiAll.Location = new System.Drawing.Point(325, 294);
            this.btnChuyenLaiAll.Name = "btnChuyenLaiAll";
            this.btnChuyenLaiAll.Size = new System.Drawing.Size(85, 23);
            this.btnChuyenLaiAll.TabIndex = 7;
            this.btnChuyenLaiAll.Text = "<<";
            this.btnChuyenLaiAll.UseVisualStyleBackColor = true;
            this.btnChuyenLaiAll.Click += new System.EventHandler(this.btnChuyenLaiAll_Click);
            // 
            // lstDanhSachPhai
            // 
            this.lstDanhSachPhai.FormattingEnabled = true;
            this.lstDanhSachPhai.ItemHeight = 16;
            this.lstDanhSachPhai.Location = new System.Drawing.Point(473, 137);
            this.lstDanhSachPhai.Name = "lstDanhSachPhai";
            this.lstDanhSachPhai.Size = new System.Drawing.Size(137, 180);
            this.lstDanhSachPhai.TabIndex = 8;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(285, 344);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(196, 31);
            this.btnKetThuc.TabIndex = 9;
            this.btnKetThuc.Text = "Kết Thúc Chương Trình";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnChuyenAll
            // 
            this.btnChuyenAll.Location = new System.Drawing.Point(325, 209);
            this.btnChuyenAll.Name = "btnChuyenAll";
            this.btnChuyenAll.Size = new System.Drawing.Size(85, 23);
            this.btnChuyenAll.TabIndex = 10;
            this.btnChuyenAll.Text = ">>";
            this.btnChuyenAll.UseVisualStyleBackColor = true;
            this.btnChuyenAll.Click += new System.EventHandler(this.btnChuyenAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChuyenAll);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.lstDanhSachPhai);
            this.Controls.Add(this.btnChuyenLaiAll);
            this.Controls.Add(this.btnChuyenLai1);
            this.Controls.Add(this.btnChuyen1);
            this.Controls.Add(this.lstDanhSachTrai);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Danh Sách Chuyển Lớp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.ListBox lstDanhSachTrai;
        public System.Windows.Forms.Button btnChuyen1;
        private System.Windows.Forms.Button btnChuyenLai1;
        private System.Windows.Forms.Button btnChuyenLaiAll;
        private System.Windows.Forms.ListBox lstDanhSachPhai;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnChuyenAll;
    }
}

