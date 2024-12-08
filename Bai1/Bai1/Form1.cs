using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSonguyen.Text, out int so))
            {
                l.Items.Clear();
                l.Items.Add(1);
                l.Items.Add(12);
                l.Items.Add(4);
                l.Items.Add(5);
                l.Items.Add(6);
                l.Items.Add(so);

                // Xóa text trong ô nhập liệu và đưa con trỏ về đó
                txtSonguyen.Clear();
                txtSonguyen.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi nhập liệu");
            }
        }

        private void btTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < l.Items.Count; i++)
            {
                int so = (int)l.Items[i];
                l.Items[i] = so + 2;
            }
        }

        private void btChonchandau_Click(object sender, EventArgs e)
        {
            foreach (int so in l.Items)
            {
                if (so % 2 == 0)
                {
                    l.SelectedItem = so;
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy số chẵn trong danh sách!", "Thông báo");
        }

        private void btLecuoi_Click(object sender, EventArgs e)
        {
            for (int i = l.Items.Count - 1; i >= 0; i--)
            {
                int so = (int)l.Items[i];
                if (so % 2 != 0)
                {
                    l.SelectedItem = so;
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy số lẻ trong danh sách!", "Thông báo");
        }

        private void btXoaphantudangchon_Click(object sender, EventArgs e)
        {
            if (l.SelectedIndex != -1)
            {
                l.Items.RemoveAt(l.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phần tử để xóa!", "Thông báo");
            }
        }

        private void btXoaphantudau_Click(object sender, EventArgs e)
        {
            if (l.Items.Count > 0)
            {
                l.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Danh sách rỗng!", "Thông báo");
            }
        }

        private void btXoaphantucuoi_Click(object sender, EventArgs e)
        {
            if (l.Items.Count > 0)
            {
                l.Items.RemoveAt(l.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Danh sách rỗng!", "Thông báo");
            }
        }

        private void btKetthuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
