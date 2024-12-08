
namespace Bài_3
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.chkCaoVoi = new System.Windows.Forms.CheckBox();
            this.chkTayTrang = new System.Windows.Forms.CheckBox();
            this.chkChupHinhRang = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.cmbTramRang = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(132, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "DeTal Payment Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(230, 87);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(191, 22);
            this.txtKhachHang.TabIndex = 2;
            // 
            // chkCaoVoi
            // 
            this.chkCaoVoi.AutoSize = true;
            this.chkCaoVoi.Location = new System.Drawing.Point(93, 145);
            this.chkCaoVoi.Name = "chkCaoVoi";
            this.chkCaoVoi.Size = new System.Drawing.Size(79, 21);
            this.chkCaoVoi.TabIndex = 3;
            this.chkCaoVoi.Text = "Cạo Vôi";
            this.chkCaoVoi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.chkCaoVoi.UseVisualStyleBackColor = true;
            // 
            // chkTayTrang
            // 
            this.chkTayTrang.AutoSize = true;
            this.chkTayTrang.Location = new System.Drawing.Point(93, 186);
            this.chkTayTrang.Name = "chkTayTrang";
            this.chkTayTrang.Size = new System.Drawing.Size(96, 21);
            this.chkTayTrang.TabIndex = 4;
            this.chkTayTrang.Text = "Tẩy Trắng";
            this.chkTayTrang.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.chkTayTrang.UseVisualStyleBackColor = true;
            // 
            // chkChupHinhRang
            // 
            this.chkChupHinhRang.AutoSize = true;
            this.chkChupHinhRang.Location = new System.Drawing.Point(93, 226);
            this.chkChupHinhRang.Name = "chkChupHinhRang";
            this.chkChupHinhRang.Size = new System.Drawing.Size(138, 21);
            this.chkChupHinhRang.TabIndex = 5;
            this.chkChupHinhRang.Text = " Chụp Hình Răng";
            this.chkChupHinhRang.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.chkChupHinhRang.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trám Răng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = " Total:";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(230, 352);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 33);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.Location = new System.Drawing.Point(361, 352);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(100, 34);
            this.btnTinhTien.TabIndex = 11;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Info;
            this.lblTotal.Location = new System.Drawing.Point(312, 312);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(149, 22);
            this.lblTotal.TabIndex = 9;
            // 
            // cmbTramRang
            // 
            this.cmbTramRang.FormattingEnabled = true;
            this.cmbTramRang.Location = new System.Drawing.Point(175, 277);
            this.cmbTramRang.Name = "cmbTramRang";
            this.cmbTramRang.Size = new System.Drawing.Size(121, 24);
            this.cmbTramRang.TabIndex = 13;
            this.cmbTramRang.SelectedIndexChanged += new System.EventHandler(this.cmbTramRang_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.cmbTramRang);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkChupHinhRang);
            this.Controls.Add(this.chkTayTrang);
            this.Controls.Add(this.chkCaoVoi);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DeTal Payment Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.CheckBox chkCaoVoi;
        private System.Windows.Forms.CheckBox chkTayTrang;
        private System.Windows.Forms.CheckBox chkChupHinhRang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.ComboBox cmbTramRang;
    }
}

