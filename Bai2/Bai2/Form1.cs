using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstDanhSachTrai.SelectedItem != null)
            {
                lstDanhSachPhai.Items.Add(lstDanhSachTrai.SelectedItem);
                lstDanhSachTrai.Items.Remove(lstDanhSachTrai.SelectedItem);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtHoten.Text))
            {
                lstDanhSachTrai.Items.Add(txtHoten.Text);
                txtHoten.Clear();
                txtHoten.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo");
            }
        }

        private void btnChuyenLai1_Click(object sender, EventArgs e)
        {
            if (lstDanhSachPhai.SelectedItem != null)
            {
                lstDanhSachTrai.Items.Add(lstDanhSachPhai.SelectedItem);
                lstDanhSachPhai.Items.Remove(lstDanhSachPhai.SelectedItem);
            }
        }

        private void btnChuyenLaiAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstDanhSachPhai.Items)
            {
                lstDanhSachTrai.Items.Add(item);
            }
            lstDanhSachPhai.Items.Clear();
        }

        private void btnChuyenAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstDanhSachTrai.Items)
            {
                lstDanhSachPhai.Items.Add(item);
            }
            lstDanhSachTrai.Items.Clear();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
