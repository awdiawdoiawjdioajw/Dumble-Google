using ECS_Equipment_Checkout_System.Models;
using ECS_Equipment_Checkout_System.Services;
using System.Runtime.ConstrainedExecution;

namespace ECS_Equipment_Checkout_System
{
    public partial class formLogin : Form
    {
        //last update: Melody Motsenbocker: 8/17/2025 11:40am mst(Pheonix)

        private EmployeeService employeeService = new EmployeeService();
        private EquipmentService equipmentService = new EquipmentService();
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string curPass = txtPassword.Text;
            string curID = txtEmpID.Text;
            var Employee = employeeService.LoginEmployee(curPass, curID);
            // employee service login
            if (Employee != null)
            { //continue for with login
                List<Equipment> RentedItems = equipmentService.GenerateEmpEquipmentList(Employee);
                this.Hide();
                Form formDash = new formDashboard()
                {
                   Employee = Employee,
                   RentedItems = RentedItems
                };
                formDash.ShowDialog();
                this.Close();
            }
            else
            { // delete text in txtPassword, popup saying invalid login
                txtPassword.Text = "";
                System.Windows.Forms.MessageBox.Show("Invalid login");
            }
        }
    }
}
