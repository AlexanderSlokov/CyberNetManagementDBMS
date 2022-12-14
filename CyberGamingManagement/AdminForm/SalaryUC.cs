using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyberGamingManagement.Database;

namespace CyberGamingManagement.AdminForm
{
    public partial class SalaryUC : UserControl
    {
        public SalaryUC()
        {
            InitializeComponent();
        }
        EmployeeDB employeeDB = new EmployeeDB();
        private void SalaryUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            dataGridViewSalaryCalculator.RowHeadersVisible = false;
            dataGridViewSalaryCalculator.AllowUserToAddRows = false;
            dataGridViewSalaryCalculator.DataSource = employeeDB.GetAllSalaryDataTable();
        }
    }
}
