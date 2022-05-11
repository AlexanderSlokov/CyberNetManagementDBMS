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
        int oldID;
        string oldUsername;
        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            Init();
            FillGrid();
        }
        void Init()
        {
            dateTimePicker.Value = new DateTime(1999, 1, 1);
            dataGridViewEmployee.DataSource = employeeDB.GetEmployeesDataTable();
        }
        void FillGrid()
        {
            dataGridViewEmployee.RowHeadersVisible = false;
            dataGridViewEmployee.AllowUserToAddRows = false;

            dataGridViewEmployee.Columns[0].Width = 70;
            dataGridViewEmployee.Columns[0].HeaderText = "Student ID";
            dataGridViewEmployee.Columns[1].Width = 100;
            dataGridViewEmployee.Columns[1].HeaderText = "Name";
            dataGridViewEmployee.Columns[2].Width = 70;
            dataGridViewEmployee.Columns[2].HeaderText = "Position";
            dataGridViewEmployee.Columns[3].Width = 70;
            dataGridViewEmployee.Columns[3].HeaderText = "Birthdate";
            dataGridViewEmployee.Columns[4].Width = 50;
            dataGridViewEmployee.Columns[4].HeaderText = "Gender";
            dataGridViewEmployee.Columns[5].Width = 70;
            dataGridViewEmployee.Columns[5].HeaderText = "Phone";
            dataGridViewEmployee.Columns[6].Width = 100;
            dataGridViewEmployee.Columns[6].HeaderText = "Email";
            dataGridViewEmployee.Columns[7].Width = 100;
            dataGridViewEmployee.Columns[7].HeaderText = "Image";
            dataGridViewEmployee.Columns["image"].Visible = false;
            dataGridViewEmployee.Columns[8].Width = 100;
            dataGridViewEmployee.Columns[8].HeaderText = "Salary(VND)";
            dataGridViewEmployee.Columns[9].Width = 100;
            dataGridViewEmployee.Columns[9].HeaderText = "Username";
            dataGridViewEmployee.Columns[10].Width = 100;
            dataGridViewEmployee.Columns[10].HeaderText = "Password";
            dataGridViewEmployee.Columns["password"].Visible = false;

            dataGridViewEmployee.Sort(dataGridViewEmployee.Columns[0], ListSortDirection.Ascending);
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
        void UpdateEmployee()
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


            employeeDB.UpdateEmployee(employee, oldID, oldUsername);
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

       
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';

            }
            else
            {
                textBoxPassword.PasswordChar = '•';

            }
        }

        private void buttonUpdateInformation_Click(object sender, EventArgs e)
        {
            UpdateEmployee();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            Init();
        }
        public void GetDataFromGridView()
        {
            Employee employee = employeeDB.GetEmployeeByID(Int32.Parse(dataGridViewEmployee.CurrentRow.Cells["id"].Value.ToString()));
            oldID = employee.Id;
            textBoxID.Text = employee.Id.ToString();
            textBoxFullName.Text = employee.Name.ToString();
            oldUsername = employee.Username;
            textBoxEMAIL.Text = employee.Email.ToString();
            textBoxPassword.Text = employee.Password.ToString();
            textBoxPhone.Text = employee.PhoneNum.ToString();
            textBoxUsername.Text = employee.Username.ToString();
            comboBoxPosition.Text = employee.Position.ToString();
            if (employee.Gender.ToString() == "female")
            {
                radioButtonFEMALE.Checked = true;
            }
            radioButtonMALE.Checked = true;
            dateTimePicker.Text = employee.BirthDate.ToString();
            dateTimePicker.Value = employee.BirthDate;
            textBoxSalary.Text = employee.Salary_per_hour.ToString();
            textBoxAge.Text = employee.Age.ToString();
        }
        private void dataGridViewEmployee_Click(object sender, EventArgs e)
        {
            GetDataFromGridView();
        }
    }
}

