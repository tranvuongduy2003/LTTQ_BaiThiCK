using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTH
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int regionValue()
        {
            if (this.nongthonOption.Checked)
                return 1;
            else if (this.thanhphoOption.Checked)
                return 2;
            else
                return -1;
        }

        private void handleAddNewStudent(object sender, EventArgs e)
        {
            string name = this.name.Text;
            if (string.IsNullOrWhiteSpace(this.name.Text))
                this.nameError.Text = "*Tên sinh viên không được bỏ trống";
            string courseStr = this.course.Text;
            if (string.IsNullOrWhiteSpace(this.course.Text))
                this.courseError.Text = "*Khóa học không được bỏ trống";

            int region = this.regionValue();
            if (region == -1)
                this.regionError.Text = "*Khu vực phải được chọn";

            string tinchiStr = this.tinchi.Text;
            if (string.IsNullOrWhiteSpace(this.tinchi.Text))
                this.tinchiError.Text = "*Số tín chỉ không được bỏ trống";

            if (this.nameError.Text != "" ||
                this.courseError.Text != "" ||
                this.regionError.Text != "" ||
                this.tinchiError.Text != "")
            {
                MessageBox.Show("Thêm sinh viên thất bại");
                return;
            }

            int tinchi = Convert.ToInt32(tinchiStr);

            int dongia = 0;
            int course = Convert.ToInt32(courseStr);
            switch(course)
            {
                case 2014: 
                case 2015:
                    dongia = 1000000;
                    break;
                case 2016:
                case 2017:
                    dongia = 1200000;
                    break;
                default:
                    dongia = 1500000;
                    break;
            }

            int thanhTien = tinchi * dongia;

            double thueVAT = 0.1 * thanhTien;

            double discount = 0;
            string regionStr = "";
            string discountPerStr = "";
            if (region == 1)
            {
                discount = 0.1 * thanhTien;
                regionStr = "Nông thôn";
                discountPerStr = "10%";
            }
            else if (region == 2)
            {
                discount = 0.05 * thanhTien;
                regionStr = "Thành phố";
                discountPerStr = "5%";
            }

            double total = thanhTien + thueVAT - discount;

            this.dongiaLabel.Text = "Đơn giá:";
            this.thanhtienLabel.Text = "Tổng số tiền phải đóng:";
            this.vatLabel.Text = "Thuế VAT:";
            this.discountLabel.Text = "Giảm giá";
            this.tongtienLabel.Text = "Tổng tiền:";

            this.dongiaLabel.Text += " " + dongia.ToString() + " (" + courseStr + ")";
            this.thanhtienLabel.Text += " " + tinchiStr + " x " + dongia.ToString() + " = " + thanhTien.ToString();
            this.vatLabel.Text += " 10% x " + thanhTien.ToString() + " = " + thueVAT.ToString();
            this.discountLabel.Text += " " + discountPerStr + " x " + thanhTien.ToString() + " = " + discount.ToString();
            this.tongtienLabel.Text += " " + thanhTien.ToString() + " + " + thueVAT.ToString() + " - " + discount.ToString() + " = " + total.ToString();

            string[] subItems = { 
                name,
                courseStr,
                regionStr,
                tinchiStr,
                dongia.ToString(),
                thanhTien.ToString(),
                thueVAT.ToString(),
                discount.ToString(),
                total.ToString()
            };
            ListViewItem student = new ListViewItem(subItems);
            this.listView1.Items.Add(student);

            this.name.Text = "";
            this.course.Text = "";
            this.tinchi.Text = "";
            this.nongthonOption.Checked = false;
            this.thanhphoOption.Checked = false;
        }

        private void handleValidateInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Kí tự nhập vào phải là chữ số");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void validateName(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.name.Text))
                this.nameError.Text = "";
        }

        private void validateCourse(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.course.Text))
                this.courseError.Text = "";
        }

        private void validateTinchi(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.tinchi.Text))
                this.tinchiError.Text = "";
        }

        private void handleCheckedChanged(object sender, EventArgs e)
        {
            if (regionValue() != -1)
                this.regionError.Text = "";
        }

        private void handleSortStudents(object sender, EventArgs e)
        {
            if (this.listView1.Items.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên trống");
            }
            else
            {
                ListViewItemStringComparer sortedList = new ListViewItemStringComparer(8, SortOrder.Ascending);
                this.listView1.ListViewItemSorter = sortedList;
            }
        }
        
        private void handleCloseForm(object sender, FormClosingEventArgs e)
        {
            Form2 closeDialog = new Form2();
            DialogResult result = closeDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }

    public class ListViewItemStringComparer : IComparer
    {
        private int col;
        private SortOrder order;
        public ListViewItemStringComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }

        public ListViewItemStringComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                       ((ListViewItem)y).SubItems[col].Text);

            if (order == SortOrder.Descending)
                returnVal *= -1;

            return returnVal;
        }
    }
}
