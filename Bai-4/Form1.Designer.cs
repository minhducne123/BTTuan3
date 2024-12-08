namespace Bai_4
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
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKhoaiTayChien = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.btnLipton = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btn7Up = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnComGa = new System.Windows.Forms.Button();
            this.btnGaRan = new System.Windows.Forms.Button();
            this.btnGaVien = new System.Windows.Forms.Button();
            this.btnTomVien = new System.Windows.Forms.Button();
            this.btnBuggerCa = new System.Windows.Forms.Button();
            this.btnBuggerTom = new System.Windows.Forms.Button();
            this.btnBuggerGa = new System.Windows.Forms.Button();
            this.btnBuggerBo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgrChonmon = new System.Windows.Forms.DataGridView();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChonmon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(321, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = " E-Order Application";
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(386, 362);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(178, 24);
            this.cbTable.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bai_4.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(12, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 202);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKhoaiTayChien);
            this.groupBox1.Controls.Add(this.btnCam);
            this.groupBox1.Controls.Add(this.btnLipton);
            this.groupBox1.Controls.Add(this.btnCola);
            this.groupBox1.Controls.Add(this.btnCafe);
            this.groupBox1.Controls.Add(this.btn7Up);
            this.groupBox1.Controls.Add(this.btnPepsi);
            this.groupBox1.Controls.Add(this.btnComGa);
            this.groupBox1.Controls.Add(this.btnGaRan);
            this.groupBox1.Controls.Add(this.btnGaVien);
            this.groupBox1.Controls.Add(this.btnTomVien);
            this.groupBox1.Controls.Add(this.btnBuggerCa);
            this.groupBox1.Controls.Add(this.btnBuggerTom);
            this.groupBox1.Controls.Add(this.btnBuggerGa);
            this.groupBox1.Controls.Add(this.btnBuggerBo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " DANH MỤC MÓN ĂN";
            // 
            // btnKhoaiTayChien
            // 
            this.btnKhoaiTayChien.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoaiTayChien.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnKhoaiTayChien.Location = new System.Drawing.Point(374, 131);
            this.btnKhoaiTayChien.Name = "btnKhoaiTayChien";
            this.btnKhoaiTayChien.Size = new System.Drawing.Size(232, 29);
            this.btnKhoaiTayChien.TabIndex = 14;
            this.btnKhoaiTayChien.Text = " Khoai Tây Chiên";
            this.btnKhoaiTayChien.UseVisualStyleBackColor = true;
            // 
            // btnCam
            // 
            this.btnCam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCam.Location = new System.Drawing.Point(498, 96);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(108, 29);
            this.btnCam.TabIndex = 13;
            this.btnCam.Text = " Cam";
            this.btnCam.UseVisualStyleBackColor = true;
            // 
            // btnLipton
            // 
            this.btnLipton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLipton.Location = new System.Drawing.Point(498, 61);
            this.btnLipton.Name = "btnLipton";
            this.btnLipton.Size = new System.Drawing.Size(108, 29);
            this.btnLipton.TabIndex = 12;
            this.btnLipton.Text = " Lipton";
            this.btnLipton.UseVisualStyleBackColor = true;
            // 
            // btnCola
            // 
            this.btnCola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCola.Location = new System.Drawing.Point(498, 26);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(108, 29);
            this.btnCola.TabIndex = 11;
            this.btnCola.Text = " Cola";
            this.btnCola.UseVisualStyleBackColor = true;
            // 
            // btnCafe
            // 
            this.btnCafe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCafe.Location = new System.Drawing.Point(374, 96);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(108, 29);
            this.btnCafe.TabIndex = 10;
            this.btnCafe.Text = " Cafe";
            this.btnCafe.UseVisualStyleBackColor = true;
            // 
            // btn7Up
            // 
            this.btn7Up.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn7Up.Location = new System.Drawing.Point(374, 61);
            this.btn7Up.Name = "btn7Up";
            this.btn7Up.Size = new System.Drawing.Size(108, 29);
            this.btn7Up.TabIndex = 9;
            this.btn7Up.Text = " 7Up";
            this.btn7Up.UseVisualStyleBackColor = true;
            // 
            // btnPepsi
            // 
            this.btnPepsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPepsi.Location = new System.Drawing.Point(374, 26);
            this.btnPepsi.Name = "btnPepsi";
            this.btnPepsi.Size = new System.Drawing.Size(108, 29);
            this.btnPepsi.TabIndex = 8;
            this.btnPepsi.Text = " Pepsi";
            this.btnPepsi.UseVisualStyleBackColor = true;
            // 
            // btnComGa
            // 
            this.btnComGa.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComGa.ForeColor = System.Drawing.Color.Blue;
            this.btnComGa.Location = new System.Drawing.Point(190, 131);
            this.btnComGa.Name = "btnComGa";
            this.btnComGa.Size = new System.Drawing.Size(151, 29);
            this.btnComGa.TabIndex = 7;
            this.btnComGa.Text = " Cơm Gà Tender";
            this.btnComGa.UseVisualStyleBackColor = true;
            // 
            // btnGaRan
            // 
            this.btnGaRan.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaRan.ForeColor = System.Drawing.Color.Blue;
            this.btnGaRan.Location = new System.Drawing.Point(190, 96);
            this.btnGaRan.Name = "btnGaRan";
            this.btnGaRan.Size = new System.Drawing.Size(151, 29);
            this.btnGaRan.TabIndex = 6;
            this.btnGaRan.Text = " Gà Rán Phần";
            this.btnGaRan.UseVisualStyleBackColor = true;
            // 
            // btnGaVien
            // 
            this.btnGaVien.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaVien.ForeColor = System.Drawing.Color.Blue;
            this.btnGaVien.Location = new System.Drawing.Point(190, 61);
            this.btnGaVien.Name = "btnGaVien";
            this.btnGaVien.Size = new System.Drawing.Size(151, 29);
            this.btnGaVien.TabIndex = 5;
            this.btnGaVien.Text = " Gà Viên Cola";
            this.btnGaVien.UseVisualStyleBackColor = true;
            // 
            // btnTomVien
            // 
            this.btnTomVien.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomVien.ForeColor = System.Drawing.Color.Blue;
            this.btnTomVien.Location = new System.Drawing.Point(190, 26);
            this.btnTomVien.Name = "btnTomVien";
            this.btnTomVien.Size = new System.Drawing.Size(151, 29);
            this.btnTomVien.TabIndex = 4;
            this.btnTomVien.Text = " Tôm Viên Cola";
            this.btnTomVien.UseVisualStyleBackColor = true;
            // 
            // btnBuggerCa
            // 
            this.btnBuggerCa.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuggerCa.ForeColor = System.Drawing.Color.Green;
            this.btnBuggerCa.Location = new System.Drawing.Point(6, 131);
            this.btnBuggerCa.Name = "btnBuggerCa";
            this.btnBuggerCa.Size = new System.Drawing.Size(169, 29);
            this.btnBuggerCa.TabIndex = 3;
            this.btnBuggerCa.Text = "Bugger Phô Mai Cá";
            this.btnBuggerCa.UseVisualStyleBackColor = true;
            // 
            // btnBuggerTom
            // 
            this.btnBuggerTom.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuggerTom.ForeColor = System.Drawing.Color.Green;
            this.btnBuggerTom.Location = new System.Drawing.Point(6, 96);
            this.btnBuggerTom.Name = "btnBuggerTom";
            this.btnBuggerTom.Size = new System.Drawing.Size(169, 29);
            this.btnBuggerTom.TabIndex = 2;
            this.btnBuggerTom.Text = "Bugger Phô Mai Tôm";
            this.btnBuggerTom.UseVisualStyleBackColor = true;
            // 
            // btnBuggerGa
            // 
            this.btnBuggerGa.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuggerGa.ForeColor = System.Drawing.Color.Green;
            this.btnBuggerGa.Location = new System.Drawing.Point(6, 61);
            this.btnBuggerGa.Name = "btnBuggerGa";
            this.btnBuggerGa.Size = new System.Drawing.Size(169, 29);
            this.btnBuggerGa.TabIndex = 1;
            this.btnBuggerGa.Text = "Bugger Phô Mai Gà";
            this.btnBuggerGa.UseVisualStyleBackColor = true;
            // 
            // btnBuggerBo
            // 
            this.btnBuggerBo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuggerBo.ForeColor = System.Drawing.Color.Green;
            this.btnBuggerBo.Location = new System.Drawing.Point(6, 26);
            this.btnBuggerBo.Name = "btnBuggerBo";
            this.btnBuggerBo.Size = new System.Drawing.Size(169, 29);
            this.btnBuggerBo.TabIndex = 0;
            this.btnBuggerBo.Text = "Bugger Phô Mai Bò";
            this.btnBuggerBo.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 355);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 37);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = " Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(570, 355);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(70, 38);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = " Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = " Tên Bàn:";
            // 
            // dgrChonmon
            // 
            this.dgrChonmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrChonmon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName,
            this.Quantily});
            this.dgrChonmon.Location = new System.Drawing.Point(55, 427);
            this.dgrChonmon.Name = "dgrChonmon";
            this.dgrChonmon.RowHeadersWidth = 51;
            this.dgrChonmon.RowTemplate.Height = 24;
            this.dgrChonmon.Size = new System.Drawing.Size(628, 153);
            this.dgrChonmon.TabIndex = 7;
            this.dgrChonmon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // FoodName
            // 
            this.FoodName.HeaderText = "FoodName";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            this.FoodName.Width = 125;
            // 
            // Quantily
            // 
            this.Quantily.HeaderText = "Quantily";
            this.Quantily.MinimumWidth = 6;
            this.Quantily.Name = "Quantily";
            this.Quantily.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 581);
            this.Controls.Add(this.dgrChonmon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrChonmon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKhoaiTayChien;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnLipton;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btn7Up;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.Button btnComGa;
        private System.Windows.Forms.Button btnGaRan;
        private System.Windows.Forms.Button btnGaVien;
        private System.Windows.Forms.Button btnTomVien;
        private System.Windows.Forms.Button btnBuggerCa;
        private System.Windows.Forms.Button btnBuggerTom;
        private System.Windows.Forms.Button btnBuggerGa;
        private System.Windows.Forms.Button btnBuggerBo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgrChonmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantily;
    }
}

