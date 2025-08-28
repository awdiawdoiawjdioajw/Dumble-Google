namespace ECS_Equipment_Checkout_System
{
    partial class formReturnEquipment
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
            lstEquipmentReturned = new ListBox();
            btnReturn = new Button();
            lblReturnEquipment = new Label();
            lblReturnEquipmentID = new Label();
            label3 = new Label();
            txtReturnEquipment = new TextBox();
            txtReturnEquipmentID = new TextBox();
            btnReturnToDashboard = new Button();
            SuspendLayout();
            // 
            // lstEquipmentReturned
            // 
            lstEquipmentReturned.FormattingEnabled = true;
            lstEquipmentReturned.ItemHeight = 15;
            lstEquipmentReturned.Location = new Point(434, 61);
            lstEquipmentReturned.Name = "lstEquipmentReturned";
            lstEquipmentReturned.ScrollAlwaysVisible = true;
            lstEquipmentReturned.Size = new Size(254, 289);
            lstEquipmentReturned.Sorted = true;
            lstEquipmentReturned.TabIndex = 0;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(197, 233);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Return Equipment";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblReturnEquipment
            // 
            lblReturnEquipment.AutoSize = true;
            lblReturnEquipment.Location = new Point(145, 144);
            lblReturnEquipment.Name = "lblReturnEquipment";
            lblReturnEquipment.Size = new Size(68, 15);
            lblReturnEquipment.TabIndex = 2;
            lblReturnEquipment.Text = "Equipment:";
            // 
            // lblReturnEquipmentID
            // 
            lblReturnEquipmentID.AutoSize = true;
            lblReturnEquipmentID.Location = new Point(145, 182);
            lblReturnEquipmentID.Name = "lblReturnEquipmentID";
            lblReturnEquipmentID.Size = new Size(82, 15);
            lblReturnEquipmentID.TabIndex = 3;
            lblReturnEquipmentID.Text = "Equipment ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 219);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // txtReturnEquipment
            // 
            txtReturnEquipment.Location = new Point(233, 141);
            txtReturnEquipment.Name = "txtReturnEquipment";
            txtReturnEquipment.Size = new Size(100, 23);
            txtReturnEquipment.TabIndex = 5;
            // 
            // txtReturnEquipmentID
            // 
            txtReturnEquipmentID.Location = new Point(233, 179);
            txtReturnEquipmentID.Name = "txtReturnEquipmentID";
            txtReturnEquipmentID.Size = new Size(100, 23);
            txtReturnEquipmentID.TabIndex = 6;
            // 
            // btnReturnToDashboard
            // 
            btnReturnToDashboard.Location = new Point(175, 296);
            btnReturnToDashboard.Name = "btnReturnToDashboard";
            btnReturnToDashboard.Size = new Size(126, 23);
            btnReturnToDashboard.TabIndex = 7;
            btnReturnToDashboard.Text = "Return To Dashboard";
            btnReturnToDashboard.UseVisualStyleBackColor = true;
            btnReturnToDashboard.Click += btnReturnToDashboard_Click;
            // 
            // formReturnEquipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturnToDashboard);
            Controls.Add(txtReturnEquipmentID);
            Controls.Add(txtReturnEquipment);
            Controls.Add(label3);
            Controls.Add(lblReturnEquipmentID);
            Controls.Add(lblReturnEquipment);
            Controls.Add(btnReturn);
            Controls.Add(lstEquipmentReturned);
            Name = "formReturnEquipment";
            Text = "Return Equipment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEquipmentReturned;
        private Button btnReturn;
        private Label lblReturnEquipment;
        private Label lblReturnEquipmentID;
        private Label label3;
        private TextBox txtReturnEquipment;
        private TextBox txtReturnEquipmentID;
        private Button btnReturnToDashboard;
    }
}