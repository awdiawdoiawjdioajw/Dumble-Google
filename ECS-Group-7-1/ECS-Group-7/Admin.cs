using ECS_Equipment_Checkout_System.Models;
using ECS_Equipment_Checkout_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ECS_Equipment_Checkout_System
{
    public partial class formAdmin : Form
    {
        //last update: Melody Motsenbocker: 8/17/2025 11:42am mst(Pheonix)

        //manage inventory and employees. Add/Remove
        public Employee Employee { get; init; }
        public List<Equipment> RentedItems { get; init; }
        private EmployeeService employeeService = new EmployeeService();
        private EquipmentService equipmentService = new EquipmentService();
        public formAdmin()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formDash = new formDashboard()
            {
                Employee = Employee,
                RentedItems = RentedItems
            };
            formDash.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add Employee
            string name = txtNewName.Text;
            string employeeID = txtNewID.Text;
            string phoneNumber = txtNewNumber.Text;
            string email = txtNewEmail.Text;
            string role = cmbRole.Text;
            employeeService.AddEmployee(name, employeeID, phoneNumber, email, role);
            //missing password
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Remove Employee

            //input manually for now, will add compatibility with lstbox
            // when box can draw Employees
            employeeService.DeleteEmployee(txtNewID.Text);
        }

        //Future melody, reformat Equipment table in SQLite to equpid, name, renterid, date rented, description?
        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            //in progress
            equipmentService.AddEquipment(txtNewEquipmentID.Text, txtNewEquipment.Text);
        }

        private void btnRemoveEquipment_Click(object sender, EventArgs e)
        {
            //in progress
            equipmentService.DeleteEquipment(txtNewEquipmentID.Text);
        }
    }
}
