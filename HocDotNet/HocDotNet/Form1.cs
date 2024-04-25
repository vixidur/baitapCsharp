using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocDotNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();

            // id 
            item.Text = txtMaKhachHang.Text;

            // ho ten
            item.SubItems.Add(txtHoTen.Text);

            // gioi tinh 
            if(cbGioiTinh.SelectedText.Equals("Nam"))
            {
                item.SubItems.Add(cbGioiTinh.SelectedItem.ToString());
            } else
            {
                item.SubItems.Add(cbGioiTinh.SelectedItem.ToString());
            }

            // dia chi
            item.SubItems.Add(txtDiaChi.Text);

            // dien thoai
            item.SubItems.Add(txtDienThoai.Text);
            lsDsKhachHang.Items.Add(item);  
        }

        private void lsDsKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void goiData()
        {
            for (int i = 0; i < 10; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "KH_2024_076" + i.ToString();
                item.SubItems.Add("Khách hàng " + i.ToString()); //  họ tên
                // dùng toString vì i là int nên phải chuỗi + chuỗi
                string gioitinh = "";
                if (i % 2 == 0)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "Nữ";
                }

                item.SubItems.Add(gioitinh);
                item.SubItems.Add("Ngõ 21" + i.ToString() + ", Lĩnh Nam");
                item.SubItems.Add("086258722" + i.ToString());
                lsDsKhachHang.Items.Add(item);
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            goiData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lsDsKhachHang.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lsDsKhachHang.Items.Remove(lsDsKhachHang.SelectedItems[0]);
        }
    }
}
