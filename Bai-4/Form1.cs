using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class Form1 : Form
    {
        private DataTable tbOrder;
        private string foodName;
        private Dictionary<int, DataTable> tableOrders = new Dictionary<int, DataTable>();
        private int selectedTable = 1;
        public Form1()
        {
            InitializeComponent();
            tbOrder = new DataTable();
           

            // Liên kết DataTable với DataGridView để hiển thị dữ liệu
            dgrChonmon.DataSource = tbOrder;
           
        }
        private int FindRowIndex(string foodName)
        {
            for (int i = 0; i < tbOrder.Rows.Count; i++)
            {
                if (tbOrder.Rows[i]["FoodName"].ToString() == foodName)
                {
                    return i; // Trả về chỉ số dòng nếu tìm thấy món ăn
                }
            }
            return -1; // Trả về -1 nếu không tìm thấy món ăn
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (dgrChonmon.SelectedRows.Count > 0)
            {
                string foodName = dgrChonmon.SelectedRows[0].Cells[0].Value.ToString(); // Lấy tên món đã chọn
                int rowIndex = FindRowIndex(foodName); // Tìm kiếm món trong DataTable

                if (rowIndex != -1)
                {
                    int quantity = Convert.ToInt32(tbOrder.Rows[rowIndex]["Quantity"]);
                    if (quantity == 1)
                    {
                        tbOrder.Rows.RemoveAt(rowIndex); // Nếu số lượng = 1, xóa món khỏi DataTable
                    }
                    else
                    {
                        tbOrder.Rows[rowIndex]["Quantity"] = quantity - 1; // Giảm số lượng món đi 1
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn món cần xóa!");
            }

            // Cập nhật lại DataGridView sau khi thay đổi
            dgrChonmon.DataSource = tbOrder;
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            if (tbOrder.Rows.Count > 0)
            {
                string orderSummary = "Đơn đặt món:\n";
                foreach (DataRow row in tbOrder.Rows)
                {
                    orderSummary += $"{row["FoodName"]}: {row["Quantity"]} món\n";
                }
                MessageBox.Show(orderSummary); // Hiển thị đơn đặt món
            }
            else
            {
                MessageBox.Show("Danh sách món ăn trống!");
            }

        }

        private void BtnBuggerBo_Click(object sender, EventArgs e)
        {
            AddToOrder("Bugger Phô mai Bò");
        }

        private void AddToOrder(string v)
        {
             bool found = false;
    foreach (DataRow row in tableOrders[selectedTable].Rows)
    {
        if (row["FoodName"].ToString() == foodName)
        {
            row["Quantity"] = Convert.ToInt32(row["Quantity"]) + 1;
            found = true;
            break;
        }
    }

    // Nếu món ăn chưa có trong đơn hàng, thêm mới
    if (!found)
    {
        tableOrders[selectedTable].Rows.Add(foodName, 1);
    }

    // Cập nhật lại DataGridView sau khi thay đổi
    dgrChonmon.DataSource = tableOrders[selectedTable];

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


    

