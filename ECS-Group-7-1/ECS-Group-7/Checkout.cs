using ECS_Equipment_Checkout_System.Models;
using EquipmentCheckoutSystem;
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
    public partial class formCheckout : Form
    {
        //last update: Melody Motsenbocker: 8/17/2025 11:40am mst(Pheonix)

        //create a cart and fill with equip wanted then rent to
        //empID
        public Employee Employee { get; init; }
        public List<Equipment> RentedItems { get; init; }
        public Cart Cart = new Cart();
        public formCheckout()
        {
            InitializeComponent();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            Equipment equipment = lstEquipment.SelectedItem as Equipment;
            if (equipment == null)
            {
                System.Windows.Forms.MessageBox.Show("Please select an Item");
            }
            else
            {
                Cart.AddEquipment(equipment);
            }
        }   

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            Equipment equipment = lstCart.SelectedItem as Equipment;
            if (equipment == null)
            {
                System.Windows.Forms.MessageBox.Show("Please select an Item");
            }
            else
            {
                Cart.AddEquipment(equipment);
            }
        }

        private void btnCheckoutCart_Click(object sender, EventArgs e)
        {
            Cart.Checkout(Employee);
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
