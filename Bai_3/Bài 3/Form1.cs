using System;
using System.Windows.Forms;

namespace Bài_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int caoVoi = 100000;
            int tayTrang = 1200000;
            int chupHinhRang = 200000;
            int tramRang = 80000;

            // Biến tổng tiền
            int tongTien = 0;

            // Kiểm tra dịch vụ được chọn
            if (chkCaoVoi.Checked)
                tongTien += caoVoi;
            if (chkTayTrang.Checked)
                tongTien += tayTrang;
            if (chkChupHinhRang.Checked)
                tongTien += chupHinhRang;

            // Tính tiền trám răng
            if (cmbTramRang.SelectedItem == null)
            {
                // Nếu không chọn gì trong ComboBox, số tiền không thay đổi
                lblTotal.Text = "Vui lòng chọn số lượng trám răng!";
            }
            else
            {
                // Chuyển giá trị được chọn thành số nguyên và tính toán
                tongTien += int.Parse(cmbTramRang.SelectedItem.ToString()) * tramRang;
            }

            // Hiển thị tổng tiền
            lblTotal.Text = $"{tongTien:N0} đồng";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbTramRang_ValueChanged(object sender, EventArgs e)
        {
            cmbTramRang.Items.AddRange(new string[] { "0", "1", "2", "3", "4", "5" });
            cmbTramRang.SelectedIndex = 0;
        }

        private void cmbTramRang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTramRang.Items.AddRange(new string[] { "0", "1", "2", "3", "4", "5" });
            cmbTramRang.SelectedIndex = 0; // Giá trị mặc định là 0

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
