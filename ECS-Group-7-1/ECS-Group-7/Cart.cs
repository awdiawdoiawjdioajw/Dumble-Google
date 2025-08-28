using ECS_Equipment_Checkout_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace EquipmentCheckoutSystem
{
    public class Cart
    {
        List<Equipment> EquipmentList;

        public DatabaseContext Context = new DatabaseContext();

        //placeholder boolean to check for added items
        private bool Added = false;

        //handeling cart services, adding and removing items from a temporary list
        //and appending the rented id to the employee currently logged in

        //currently not working because of listbox implementation failing
        public List<Equipment> AddEquipment(Equipment equipment)
        {
            EquipmentList.Add(equipment);
            return EquipmentList;
            Added = true;
        }

        public List<Equipment> RemoveEquipment(Equipment equipment)
        {
            EquipmentList.Remove(equipment);
            return EquipmentList;   
            Added = true;
        }

        public void Checkout(Employee employee)
        {
            if (!Added)
            {
                System.Windows.Forms.MessageBox.Show("Please add an Item to the cart");
                return;
            }
            else
            {
                for (int i = 0; i < EquipmentList.Count; i++)
                {
                    var foundEquipment = EquipmentList[i];
                    foundEquipment.RentingEmployee = employee.EmployeeId;
                    Context.Equipment.Update(foundEquipment);
                    Context.SaveChangesAsync().GetAwaiter().GetResult();
                }
            }
        }
    }
}
