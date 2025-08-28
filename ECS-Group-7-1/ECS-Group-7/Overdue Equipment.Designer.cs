namespace ECS_Equipment_Checkout_System
{
    partial class formOverdue_Equipment
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
            lstOverdueEquipment = new ListBox();
            cmbOverrideStatus = new ComboBox();
            lblOverrideStatus = new Label();
            btnOverdueNotice = new Button();
            lblSendOverdueNotice = new Label();
            btnUpdateList = new Button();
            btnReturnToDashboard = new Button();
            SuspendLayout();
            // 
            // lstOverdueEquipment
            // 
            lstOverdueEquipment.FormattingEnabled = true;
            lstOverdueEquipment.ItemHeight = 15;
            lstOverdueEquipment.Location = new Point(378, 43);
            lstOverdueEquipment.Name = "lstOverdueEquipment";
            lstOverdueEquipment.ScrollAlwaysVisible = true;
            lstOverdueEquipment.Size = new Size(385, 364);
            lstOverdueEquipment.Sorted = true;
            lstOverdueEquipment.TabIndex = 0;
            // 
            // cmbOverrideStatus
            // 
            cmbOverrideStatus.FormattingEnabled = true;
            cmbOverrideStatus.Location = new Point(179, 130);
            cmbOverrideStatus.Name = "cmbOverrideStatus";
            cmbOverrideStatus.Size = new Size(121, 23);
            cmbOverrideStatus.TabIndex = 1;
            // 
            // lblOverrideStatus
            // 
            lblOverrideStatus.AutoSize = true;
            lblOverrideStatus.Location = new Point(83, 133);
            lblOverrideStatus.Name = "lblOverrideStatus";
            lblOverrideStatus.Size = new Size(90, 15);
            lblOverrideStatus.TabIndex = 2;
            lblOverrideStatus.Text = "Override Status:";
            // 
            // btnOverdueNotice
            // 
            btnOverdueNotice.Location = new Point(225, 179);
            btnOverdueNotice.Name = "btnOverdueNotice";
            btnOverdueNotice.Size = new Size(75, 23);
            btnOverdueNotice.TabIndex = 3;
            btnOverdueNotice.Text = "Overdue";
            btnOverdueNotice.UseVisualStyleBackColor = true;
            btnOverdueNotice.Click += btnOverdueNotice_Click;
            // 
            // lblSendOverdueNotice
            // 
            lblSendOverdueNotice.AutoSize = true;
            lblSendOverdueNotice.Location = new Point(83, 183);
            lblSendOverdueNotice.Name = "lblSendOverdueNotice";
            lblSendOverdueNotice.Size = new Size(122, 15);
            lblSendOverdueNotice.TabIndex = 4;
            lblSendOverdueNotice.Text = "Send Overdue Notice:";
            // 
            // btnUpdateList
            // 
            btnUpdateList.Location = new Point(153, 234);
            btnUpdateList.Name = "btnUpdateList";
            btnUpdateList.Size = new Size(75, 23);
            btnUpdateList.TabIndex = 5;
            btnUpdateList.Text = "Update List";
            btnUpdateList.UseVisualStyleBackColor = true;
            btnUpdateList.Click += btnUpdateList_Click;
            // 
            // btnReturnToDashboard
            // 
            btnReturnToDashboard.Location = new Point(130, 288);
            btnReturnToDashboard.Name = "btnReturnToDashboard";
            btnReturnToDashboard.Size = new Size(129, 23);
            btnReturnToDashboard.TabIndex = 6;
            btnReturnToDashboard.Text = "Return To Dashboard";
            btnReturnToDashboard.UseVisualStyleBackColor = true;
            btnReturnToDashboard.Click += btnReturnToDashboard_Click;
            // 
            // formOverdue_Equipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturnToDashboard);
            Controls.Add(btnUpdateList);
            Controls.Add(lblSendOverdueNotice);
            Controls.Add(btnOverdueNotice);
            Controls.Add(lblOverrideStatus);
            Controls.Add(cmbOverrideStatus);
            Controls.Add(lstOverdueEquipment);
            Name = "formOverdue_Equipment";
            Text = "Overdue Equipment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstOverdueEquipment;
        private ComboBox cmbOverrideStatus;
        private Label lblOverrideStatus;
        private Button btnOverdueNotice;
        private Label lblSendOverdueNotice;
        private Button btnUpdateList;
        private Button btnReturnToDashboard;
    }
}