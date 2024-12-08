
namespace Bai1
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
            this.txt1 = new System.Windows.Forms.Label();
            this.txtSonguyen = new System.Windows.Forms.TextBox();
            this.btCapnhat = new System.Windows.Forms.Button();
            this.btTang2 = new System.Windows.Forms.Button();
            this.btChonchandau = new System.Windows.Forms.Button();
            this.btLecuoi = new System.Windows.Forms.Button();
            this.btXoaphantudangchon = new System.Windows.Forms.Button();
            this.btXoaphantudau = new System.Windows.Forms.Button();
            this.btXoaphantucuoi = new System.Windows.Forms.Button();
            this.btKetthuc = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(62, 52);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(116, 17);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "Nhập Số Nguyên";
            this.txt1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSonguyen
            // 
            this.txtSonguyen.Location = new System.Drawing.Point(197, 52);
            this.txtSonguyen.Name = "txtSonguyen";
            this.txtSonguyen.Size = new System.Drawing.Size(196, 22);
            this.txtSonguyen.TabIndex = 1;
            // 
            // btCapnhat
            // 
            this.btCapnhat.Location = new System.Drawing.Point(417, 44);
            this.btCapnhat.Name = "btCapnhat";
            this.btCapnhat.Size = new System.Drawing.Size(92, 38);
            this.btCapnhat.TabIndex = 3;
            this.btCapnhat.Text = "Cập nhật";
            this.btCapnhat.UseVisualStyleBackColor = true;
            this.btCapnhat.Click += new System.EventHandler(this.btCapnhat_Click);
            // 
            // btTang2
            // 
            this.btTang2.Location = new System.Drawing.Point(0, 21);
            this.btTang2.Name = "btTang2";
            this.btTang2.Size = new System.Drawing.Size(185, 31);
            this.btTang2.TabIndex = 4;
            this.btTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btTang2.UseVisualStyleBackColor = true;
            this.btTang2.Click += new System.EventHandler(this.btTang2_Click);
            // 
            // btChonchandau
            // 
            this.btChonchandau.Location = new System.Drawing.Point(0, 58);
            this.btChonchandau.Name = "btChonchandau";
            this.btChonchandau.Size = new System.Drawing.Size(185, 33);
            this.btChonchandau.TabIndex = 5;
            this.btChonchandau.Text = "Chọn số chằn đầu";
            this.btChonchandau.UseVisualStyleBackColor = true;
            this.btChonchandau.Click += new System.EventHandler(this.btChonchandau_Click);
            // 
            // btLecuoi
            // 
            this.btLecuoi.Location = new System.Drawing.Point(0, 97);
            this.btLecuoi.Name = "btLecuoi";
            this.btLecuoi.Size = new System.Drawing.Size(185, 34);
            this.btLecuoi.TabIndex = 6;
            this.btLecuoi.Text = "Chọn số lẻ cuối";
            this.btLecuoi.UseVisualStyleBackColor = true;
            this.btLecuoi.Click += new System.EventHandler(this.btLecuoi_Click);
            // 
            // btXoaphantudangchon
            // 
            this.btXoaphantudangchon.AccessibleDescription = " ";
            this.btXoaphantudangchon.Location = new System.Drawing.Point(0, 137);
            this.btXoaphantudangchon.Name = "btXoaphantudangchon";
            this.btXoaphantudangchon.Size = new System.Drawing.Size(185, 33);
            this.btXoaphantudangchon.TabIndex = 7;
            this.btXoaphantudangchon.Text = "Xóa phần tử đang chọn";
            this.btXoaphantudangchon.UseVisualStyleBackColor = true;
            this.btXoaphantudangchon.Click += new System.EventHandler(this.btXoaphantudangchon_Click);
            // 
            // btXoaphantudau
            // 
            this.btXoaphantudau.Location = new System.Drawing.Point(1, 176);
            this.btXoaphantudau.Name = "btXoaphantudau";
            this.btXoaphantudau.Size = new System.Drawing.Size(185, 29);
            this.btXoaphantudau.TabIndex = 8;
            this.btXoaphantudau.Text = "Xóa phần tử đầu";
            this.btXoaphantudau.UseVisualStyleBackColor = true;
            this.btXoaphantudau.Click += new System.EventHandler(this.btXoaphantudau_Click);
            // 
            // btXoaphantucuoi
            // 
            this.btXoaphantucuoi.Location = new System.Drawing.Point(0, 207);
            this.btXoaphantucuoi.Name = "btXoaphantucuoi";
            this.btXoaphantucuoi.Size = new System.Drawing.Size(185, 27);
            this.btXoaphantucuoi.TabIndex = 9;
            this.btXoaphantucuoi.Text = "Xóa phần tử cuối";
            this.btXoaphantucuoi.UseVisualStyleBackColor = true;
            this.btXoaphantucuoi.Click += new System.EventHandler(this.btXoaphantucuoi_Click);
            // 
            // btKetthuc
            // 
            this.btKetthuc.Location = new System.Drawing.Point(160, 359);
            this.btKetthuc.Name = "btKetthuc";
            this.btKetthuc.Size = new System.Drawing.Size(302, 29);
            this.btKetthuc.TabIndex = 10;
            this.btKetthuc.Text = "Kết thúc";
            this.btKetthuc.UseVisualStyleBackColor = true;
            this.btKetthuc.Click += new System.EventHandler(this.btKetthuc_Click);
            // 
            // l
            // 
            this.l.FormattingEnabled = true;
            this.l.ItemHeight = 16;
            this.l.Location = new System.Drawing.Point(117, 103);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(176, 244);
            this.l.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTang2);
            this.groupBox1.Controls.Add(this.btChonchandau);
            this.groupBox1.Controls.Add(this.btXoaphantucuoi);
            this.groupBox1.Controls.Add(this.btLecuoi);
            this.groupBox1.Controls.Add(this.btXoaphantudau);
            this.groupBox1.Controls.Add(this.btXoaphantudangchon);
            this.groupBox1.Location = new System.Drawing.Point(354, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 240);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btKetthuc);
            this.Controls.Add(this.btCapnhat);
            this.Controls.Add(this.txtSonguyen);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.l);
            this.Name = "Form1";
            this.Text = "Thao Tác Trên ListBox";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.TextBox txtSonguyen;
        private System.Windows.Forms.Button btCapnhat;
        private System.Windows.Forms.Button btTang2;
        private System.Windows.Forms.Button btChonchandau;
        private System.Windows.Forms.Button btLecuoi;
        private System.Windows.Forms.Button btXoaphantudangchon;
        private System.Windows.Forms.Button btXoaphantudau;
        private System.Windows.Forms.Button btXoaphantucuoi;
        private System.Windows.Forms.Button btKetthuc;
        private System.Windows.Forms.ListBox l;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

