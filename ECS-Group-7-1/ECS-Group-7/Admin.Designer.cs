namespace ECS_Equipment_Checkout_System
{
    partial class formAdmin
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
            lstEmployees = new ListBox();
            employeeBindingSource = new BindingSource(components);
            lstUpdatedEquipment = new ListBox();
            equipmentBindingSource = new BindingSource(components);
            lblNewName = new Label();
            lblNewEmpID = new Label();
            lblNewNumber = new Label();
            lblNewRole = new Label();
            txtNewName = new TextBox();
            txtNewID = new TextBox();
            txtNewNumber = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnAddEquipment = new Button();
            btnRemoveEquipment = new Button();
            lblEquipment = new Label();
            lblEquipmentID = new Label();
            lblDescription = new Label();
            txtNewEquipment = new TextBox();
            txtNewEquipmentID = new TextBox();
            txtDescription = new TextBox();
            cmbRole = new ComboBox();
            lblNewEmail = new Label();
            txtNewEmail = new TextBox();
            btnDashboard = new Button();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)equipmentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lstEmployees
            // 
            lstEmployees.DataSource = employeeBindingSource;
            lstEmployees.Font = new Font("Segoe UI", 12F);
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 21;
            lstEmployees.Location = new Point(96, 21);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.ScrollAlwaysVisible = true;
            lstEmployees.Size = new Size(251, 214);
            lstEmployees.Sorted = true;
            lstEmployees.TabIndex = 0;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Models.Employee);
            // 
            // lstUpdatedEquipment
            // 
            lstUpdatedEquipment.DataSource = equipmentBindingSource;
            lstUpdatedEquipment.FormattingEnabled = true;
            lstUpdatedEquipment.ItemHeight = 15;
            lstUpdatedEquipment.Location = new Point(461, 21);
            lstUpdatedEquipment.Name = "lstUpdatedEquipment";
            lstUpdatedEquipment.ScrollAlwaysVisible = true;
            lstUpdatedEquipment.Size = new Size(251, 229);
            lstUpdatedEquipment.Sorted = true;
            lstUpdatedEquipment.TabIndex = 1;
            // 
            // equipmentBindingSource
            // 
            equipmentBindingSource.DataSource = typeof(Models.Equipment);
            // 
            // lblNewName
            // 
            lblNewName.AutoSize = true;
            lblNewName.Location = new Point(108, 268);
            lblNewName.Name = "lblNewName";
            lblNewName.Size = new Size(42, 15);
            lblNewName.TabIndex = 2;
            lblNewName.Text = "Name:";
            // 
            // lblNewEmpID
            // 
            lblNewEmpID.AutoSize = true;
            lblNewEmpID.Location = new Point(108, 297);
            lblNewEmpID.Name = "lblNewEmpID";
            lblNewEmpID.Size = new Size(76, 15);
            lblNewEmpID.TabIndex = 3;
            lblNewEmpID.Text = "Employee ID:";
            // 
            // lblNewNumber
            // 
            lblNewNumber.AutoSize = true;
            lblNewNumber.Location = new Point(108, 328);
            lblNewNumber.Name = "lblNewNumber";
            lblNewNumber.Size = new Size(91, 15);
            lblNewNumber.TabIndex = 4;
            lblNewNumber.Text = "Phone Number:";
            // 
            // lblNewRole
            // 
            lblNewRole.AutoSize = true;
            lblNewRole.Location = new Point(108, 389);
            lblNewRole.Name = "lblNewRole";
            lblNewRole.Size = new Size(33, 15);
            lblNewRole.TabIndex = 5;
            lblNewRole.Text = "Role:";
            // 
            // txtNewName
            // 
            txtNewName.Location = new Point(215, 265);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(100, 23);
            txtNewName.TabIndex = 6;
            // 
            // txtNewID
            // 
            txtNewID.Location = new Point(215, 294);
            txtNewID.Name = "txtNewID";
            txtNewID.Size = new Size(100, 23);
            txtNewID.TabIndex = 7;
            // 
            // txtNewNumber
            // 
            txtNewNumber.Location = new Point(215, 325);
            txtNewNumber.Name = "txtNewNumber";
            txtNewNumber.Size = new Size(100, 23);
            txtNewNumber.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(96, 415);
            button1.Name = "button1";
            button1.Size = new Size(103, 23);
            button1.TabIndex = 10;
            button1.Text = "Add Employee";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(205, 415);
            button2.Name = "button2";
            button2.Size = new Size(119, 23);
            button2.TabIndex = 11;
            button2.Text = "Remove Employee";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAddEquipment
            // 
            btnAddEquipment.Location = new Point(473, 362);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(102, 23);
            btnAddEquipment.TabIndex = 12;
            btnAddEquipment.Text = "Add Equipment";
            btnAddEquipment.UseVisualStyleBackColor = true;
            btnAddEquipment.Click += btnAddEquipment_Click;
            // 
            // btnRemoveEquipment
            // 
            btnRemoveEquipment.Location = new Point(581, 362);
            btnRemoveEquipment.Name = "btnRemoveEquipment";
            btnRemoveEquipment.Size = new Size(120, 23);
            btnRemoveEquipment.TabIndex = 13;
            btnRemoveEquipment.Text = "Remove Equipment";
            btnRemoveEquipment.UseVisualStyleBackColor = true;
            btnRemoveEquipment.Click += btnRemoveEquipment_Click;
            // 
            // lblEquipment
            // 
            lblEquipment.AutoSize = true;
            lblEquipment.Location = new Point(490, 268);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(68, 15);
            lblEquipment.TabIndex = 14;
            lblEquipment.Text = "Equipment:";
            // 
            // lblEquipmentID
            // 
            lblEquipmentID.AutoSize = true;
            lblEquipmentID.Location = new Point(490, 297);
            lblEquipmentID.Name = "lblEquipmentID";
            lblEquipmentID.Size = new Size(82, 15);
            lblEquipmentID.TabIndex = 15;
            lblEquipmentID.Text = "Equipment ID:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(490, 328);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 16;
            lblDescription.Text = "Description:";
            // 
            // txtNewEquipment
            // 
            txtNewEquipment.Location = new Point(592, 265);
            txtNewEquipment.Name = "txtNewEquipment";
            txtNewEquipment.Size = new Size(100, 23);
            txtNewEquipment.TabIndex = 18;
            // 
            // txtNewEquipmentID
            // 
            txtNewEquipmentID.Location = new Point(592, 293);
            txtNewEquipmentID.Name = "txtNewEquipmentID";
            txtNewEquipmentID.Size = new Size(100, 23);
            txtNewEquipmentID.TabIndex = 19;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(592, 322);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 20;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(215, 386);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(100, 23);
            cmbRole.TabIndex = 22;
            // 
            // lblNewEmail
            // 
            lblNewEmail.AutoSize = true;
            lblNewEmail.Location = new Point(108, 362);
            lblNewEmail.Name = "lblNewEmail";
            lblNewEmail.Size = new Size(39, 15);
            lblNewEmail.TabIndex = 23;
            lblNewEmail.Text = "Email:";
            // 
            // txtNewEmail
            // 
            txtNewEmail.Location = new Point(215, 357);
            txtNewEmail.Name = "txtNewEmail";
            txtNewEmail.Size = new Size(100, 23);
            txtNewEmail.TabIndex = 24;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(516, 415);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(120, 23);
            btnDashboard.TabIndex = 25;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // formAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDashboard);
            Controls.Add(txtNewEmail);
            Controls.Add(lblNewEmail);
            Controls.Add(cmbRole);
            Controls.Add(txtDescription);
            Controls.Add(txtNewEquipmentID);
            Controls.Add(txtNewEquipment);
            Controls.Add(lblDescription);
            Controls.Add(lblEquipmentID);
            Controls.Add(lblEquipment);
            Controls.Add(btnRemoveEquipment);
            Controls.Add(btnAddEquipment);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNewNumber);
            Controls.Add(txtNewID);
            Controls.Add(txtNewName);
            Controls.Add(lblNewRole);
            Controls.Add(lblNewNumber);
            Controls.Add(lblNewEmpID);
            Controls.Add(lblNewName);
            Controls.Add(lstUpdatedEquipment);
            Controls.Add(lstEmployees);
            Name = "formAdmin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)equipmentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEmployees;
        private ListBox lstUpdatedEquipment;
        private Label lblNewName;
        private Label lblNewEmpID;
        private Label lblNewNumber;
        private Label lblNewRole;
        private TextBox txtNewName;
        private TextBox txtNewID;
        private TextBox txtNewNumber;
        private Button button1;
        private Button button2;
        private Button btnAddEquipment;
        private Button btnRemoveEquipment;
        private Label lblEquipment;
        private Label lblEquipmentID;
        private Label lblDescription;
        private TextBox txtNewEquipment;
        private TextBox txtNewEquipmentID;
        private TextBox txtDescription;
        private ComboBox cmbRole;
        private Label lblNewEmail;
        private TextBox txtNewEmail;
        private Button btnDashboard;
        private BindingSource equipmentBindingSource;
        private BindingSource employeeBindingSource;
    }
}