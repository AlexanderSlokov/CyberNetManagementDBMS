using InternetCafeManagement.Database;
using InternetCafeManagement.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeManagement.Employee_Management_Form
{
    public partial class EmployeeManagementForm : Form
    {
    
        public EmployeeManagementForm()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        EmployeeManagementDB employeeManagementDB;
        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            employeeManagementDB = new EmployeeManagementDB();

            try
            {
                dtgvEmployeeManagement.DataSource = employeeManagementDB.getAllNhanVien();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi: " + ex.Message,"Lỗi",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = this.txbMaNV.Text;
            string name = this.txbTenNV.Text;
            string sex = (rdbNam.Checked ? rdbNam.Text : rdbNu.Text);
            DateTime dateOfBirth = this.dtpNgaySinh.Value;
            string address = this.dudDiaChi.Text;
            string phoneNumber = this.txbSDT.Text;

            NhanVien nhanVien = new NhanVien(id, name, sex, dateOfBirth, address, phoneNumber); 
            if (employeeManagementDB.insertNhanVien(nhanVien))
            {
                dtgvEmployeeManagement.DataSource = employeeManagementDB.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Lỗi: Không thêm vào được! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string id = this.txbMaNV.Text;
            string name = this.txbTenNV.Text;
            string sex = (rdbNam.Checked ? rdbNam.Text : rdbNu.Text);
            DateTime dateOfBirth = this.dtpNgaySinh.Value;
            string address = this.dudDiaChi.Text;
            string phoneNumber = this.txbSDT.Text;

            NhanVien nhanVien = new NhanVien(id, name, sex, dateOfBirth, address, phoneNumber);
            if (employeeManagementDB.updateNhanVien(nhanVien))
            {
                dtgvEmployeeManagement.DataSource = employeeManagementDB.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Lỗi: Không sửa được! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = dtgvEmployeeManagement.SelectedRows[0].Cells[0].Value.ToString();

            if (employeeManagementDB.deleteNhanVien(id))
            {
                dtgvEmployeeManagement.DataSource = employeeManagementDB.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Lỗi: Không xóa được! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
