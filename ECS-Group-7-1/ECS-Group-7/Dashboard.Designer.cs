namespace ECS_Equipment_Checkout_System
{
    partial class formDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lstOverdueEquipment = new ListBox();
            equipmentBindingSource = new BindingSource(components);
            btnAdminPage = new Button();
            btnRentEquipment = new Button();
            btnOverdueEquipmentPage = new Button();
            btnReturnEquipment = new Button();
            equipmentBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)equipmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)equipmentBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lstOverdueEquipment
            // 
            lstOverdueEquipment.FormattingEnabled = true;
            lstOverdueEquipment.ItemHeight = 15;
            lstOverdueEquipment.Location = new Point(410, 51);
            lstOverdueEquipment.MultiColumn = true;
            lstOverdueEquipment.Name = "lstOverdueEquipment";
            lstOverdueEquipment.ScrollAlwaysVisible = true;
            lstOverdueEquipment.Size = new Size(270, 334);
            lstOverdueEquipment.TabIndex = 10;
            // 
            // equipmentBindingSource
            // 
            equipmentBindingSource.DataSource = typeof(Models.Equipment);
            // 
            // btnAdminPage
            // 
            btnAdminPage.Location = new Point(217, 101);
            btnAdminPage.Name = "btnAdminPage";
            btnAdminPage.Size = new Size(75, 23);
            btnAdminPage.TabIndex = 0;
            btnAdminPage.Text = "Admin";
            btnAdminPage.UseVisualStyleBackColor = true;
            btnAdminPage.Click += btnAdminPage_Click;
            // 
            // btnRentEquipment
            // 
            btnRentEquipment.Location = new Point(217, 159);
            btnRentEquipment.Name = "btnRentEquipment";
            btnRentEquipment.Size = new Size(75, 39);
            btnRentEquipment.TabIndex = 1;
            btnRentEquipment.Text = "Rent Equipment";
            btnRentEquipment.UseVisualStyleBackColor = true;
            btnRentEquipment.Click += btnRentEquipment_Click;
            // 
            // btnOverdueEquipmentPage
            // 
            btnOverdueEquipmentPage.Location = new Point(217, 234);
            btnOverdueEquipmentPage.Name = "btnOverdueEquipmentPage";
            btnOverdueEquipmentPage.Size = new Size(75, 39);
            btnOverdueEquipmentPage.TabIndex = 2;
            btnOverdueEquipmentPage.Text = "Overdue Equipment";
            btnOverdueEquipmentPage.UseVisualStyleBackColor = true;
            btnOverdueEquipmentPage.Click += btnOverdueEquipmentPage_Click;
            // 
            // btnReturnEquipment
            // 
            btnReturnEquipment.Location = new Point(217, 312);
            btnReturnEquipment.Name = "btnReturnEquipment";
            btnReturnEquipment.Size = new Size(75, 38);
            btnReturnEquipment.TabIndex = 3;
            btnReturnEquipment.Text = "Return Equipment";
            btnReturnEquipment.UseVisualStyleBackColor = true;
            btnReturnEquipment.Click += btnReturnEquipment_Click;
            // 
            // equipmentBindingSource1
            // 
            equipmentBindingSource1.DataSource = typeof(Models.Equipment);
            // 
            // formDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturnEquipment);
            Controls.Add(btnOverdueEquipmentPage);
            Controls.Add(btnRentEquipment);
            Controls.Add(btnAdminPage);
            Controls.Add(lstOverdueEquipment);
            Name = "formDashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)equipmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)equipmentBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstOverdueEquipment;
        private Button btnAdminPage;
        private Button btnRentEquipment;
        private Button btnOverdueEquipmentPage;
        private Button btnReturnEquipment;
        private BindingSource equipmentBindingSource;
        private BindingSource equipmentBindingSource1;
    }
}