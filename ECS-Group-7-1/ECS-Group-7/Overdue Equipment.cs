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
    public partial class formOverdue_Equipment : Form
    {
        //last update: Melody Motsenbocker: 8/17/2025 11:42am mst(Pheonix)

        //admin access to overdue equipment master-list. Update/Override/Notify
        public Employee Employee { get; init; }
        public List<Equipment> RentedItems { get; init; }
        public formOverdue_Equipment()
        {
            InitializeComponent();
        }

        private void btnReturnToDashboard_Click(object sender, EventArgs e)
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

        private void btnOverdueNotice_Click(object sender, EventArgs e)
        {
            //need connection for working email service,
            //sends too Employee.email
        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            //refreshes equpmentlist to update lstbox
        }
    }
}
