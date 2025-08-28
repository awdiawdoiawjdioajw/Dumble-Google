using ECS_Equipment_Checkout_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECS_Equipment_Checkout_System
{
    public partial class formDashboard : Form
    {
        //last update: Melody Motsenbocker: 8/17/2025 11:40am mst(Pheonix)

        //manage navigation to needed pages, while showing the rented items
        //an employee has, and if they are overdue
        public Employee Employee { get; init; }
        public List<Equipment> RentedItems { get; init; }
        public formDashboard()
        {
            InitializeComponent();
            //lstOverdueEquipment.Items.Add(RentedItems);
        }

        private void btnAdminPage_Click(object sender, EventArgs e)
        {
            //admin only
            if (Employee.IsAdmin.GetValueOrDefault())
            {
                this.Hide();
                Form formAdmin = new formAdmin()
                {
                    Employee = Employee,
                    RentedItems = RentedItems
                };
                formAdmin.ShowDialog();
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Not Admin");
            }
        }

        private void btnRentEquipment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formCheckout = new formCheckout()
            {
                Employee = Employee,
                RentedItems = RentedItems
            };
            formCheckout.ShowDialog();
            this.Close();
        }

        private void btnOverdueEquipmentPage_Click(object sender, EventArgs e)
        {
            //admin only
            if (Employee.IsAdmin.GetValueOrDefault())
            {
                this.Hide();
                Form formOverdueEquipment = new formOverdue_Equipment()
                {
                    Employee = Employee,
                    RentedItems = RentedItems
                };
                formOverdueEquipment.ShowDialog();
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Not Admin");
            }

        }

        private void btnReturnEquipment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formReturnEquipment = new formReturnEquipment()
            {
                Employee = Employee,
                RentedItems = RentedItems
            };
            formReturnEquipment.ShowDialog();
            this.Close();
        }
    }
}
