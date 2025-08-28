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

namespace ECS_Equipment_Checkout_System
{
    public partial class formReturnEquipment : Form
    {
        //last update: Melody Motsenbocker: 8/17/2025 11:42am mst(Pheonix)

        //You won't guess this, return Equipment and remove rentedID = make null
        public Employee Employee { get; init; }
        public List<Equipment> RentedItems { get; init; }

        private EquipmentService equipmentService = new EquipmentService();
        public formReturnEquipment()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            equipmentService.ReturnEquipment(txtReturnEquipmentID.Text);
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
    }
}
