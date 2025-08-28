namespace ECS_Equipment_Checkout_System
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEmpID = new Label();
            txtEmpID = new TextBox();
            btnLogin = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            pnlLogin = new Panel();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblEmpID
            // 
            lblEmpID.AutoSize = true;
            lblEmpID.Location = new Point(89, 60);
            lblEmpID.Name = "lblEmpID";
            lblEmpID.Size = new Size(76, 15);
            lblEmpID.TabIndex = 1;
            lblEmpID.Text = "Employee ID:";
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(202, 57);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(115, 23);
            txtEmpID.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(170, 181);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(84, 33);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(89, 116);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(202, 113);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(115, 23);
            txtPassword.TabIndex = 3;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = SystemColors.ActiveCaption;
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(lblEmpID);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtEmpID);
            pnlLogin.Location = new Point(193, 102);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(413, 248);
            pnlLogin.TabIndex = 7;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlLogin);
            Name = "formLogin";
            Text = "Equipment Checkout System - Login Page";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblEmpID;
        private TextBox txtEmpID;
        private Button btnLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private Panel pnlLogin;
    }
}
