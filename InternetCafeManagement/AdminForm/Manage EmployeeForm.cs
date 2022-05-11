using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetCafeManagement.Database;
using InternetCafeManagement.Model;

namespace InternetCafeManagement.AdminForm
{
    public partial class EmployeeManagementForm : System.Windows.Forms.Form
    {
        public EmployeeManagementForm()
        {
            InitializeComponent();
            
        }
        EmployeeDB employeeDB = new EmployeeDB();
        
        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            dateTimePicker.Value = new DateTime(1999, 1, 1);
            dataGridViewEmployee.DataSource = employeeDB.GetEmployeesDataTable();
        }
        void AddEmployee()
        {
            Employee employee = new Employee();
            try
            {
                employee.Id = Int32.Parse(textBoxID.Text);
            }
            catch
            {
                employee.Id = 0;
            }
            employee.Name = textBoxFullName.Text.Trim();
            employee.Position = comboBoxPosition.Text.ToLower().Trim();
            employee.BirthDate = dateTimePicker.Value;
            string gender = "male";
            if (radioButtonFEMALE.Checked)
            {
                gender = "female";
            }
            employee.Gender = gender;
            employee.PhoneNum = textBoxPhone.Text.Trim();
            employee.Email = textBoxEMAIL.Text.Trim();
            try
            {
                if (pictureBoxEMPLOYEE.Image != null)
                    employee.Image = pictureBoxEMPLOYEE.Image;
                else
                    employee.Image = null;
            }
            catch
            {
                employee.Image = null;
            }
            

            try
            {
                employee.Salary_per_hour = float.Parse(textBoxSalary.Text.Trim());
            }
            catch
            {
                employee.Salary_per_hour = 0;
            }
            employee.Username = textBoxUsername.Text.Trim();
            employee.Password = textBoxPassword.Text.Trim();


            employeeDB.AddEmployee(employee);
        }
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            UploadImage();
        }
        private void UploadImage()
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpfg; *.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxEMPLOYEE.Image = Image.FromFile(opf.FileName);
            }
            else
            {
                pictureBoxEMPLOYEE.Image = null;
            }
        }

        private void buttonSwitchEmployee_Click(object sender, EventArgs e)
        {
            dataGridViewEmployee.DataSource = employeeDB.GetEmployeesDataTable();
        }

        private void buttonSwitchManagers_Click(object sender, EventArgs e)
        {
            dataGridViewEmployee.DataSource = employeeDB.GetManagersDataTable();
        }
    }
}

