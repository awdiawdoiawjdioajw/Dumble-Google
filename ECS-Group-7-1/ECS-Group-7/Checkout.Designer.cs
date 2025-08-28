namespace ECS_Equipment_Checkout_System
{
    partial class formCheckout
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
            btnAddToCart = new Button();
            btnRemoveFromCart = new Button();
            btnCheckoutCart = new Button();
            lstEquipment = new ListBox();
            lstCart = new ListBox();
            btnReturnToDashboard = new Button();
            SuspendLayout();
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(166, 415);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(89, 23);
            btnAddToCart.TabIndex = 0;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new Point(156, 454);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(114, 23);
            btnRemoveFromCart.TabIndex = 1;
            btnRemoveFromCart.Text = "Remove From Cart";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // btnCheckoutCart
            // 
            btnCheckoutCart.Location = new Point(531, 415);
            btnCheckoutCart.Name = "btnCheckoutCart";
            btnCheckoutCart.Size = new Size(94, 23);
            btnCheckoutCart.TabIndex = 2;
            btnCheckoutCart.Text = "Checkout Cart";
            btnCheckoutCart.UseVisualStyleBackColor = true;
            btnCheckoutCart.Click += btnCheckoutCart_Click;
            // 
            // lstEquipment
            // 
            lstEquipment.FormattingEnabled = true;
            lstEquipment.ItemHeight = 15;
            lstEquipment.Location = new Point(82, 50);
            lstEquipment.Name = "lstEquipment";
            lstEquipment.ScrollAlwaysVisible = true;
            lstEquipment.Size = new Size(264, 334);
            lstEquipment.Sorted = true;
            lstEquipment.TabIndex = 3;
            // 
            // lstCart
            // 
            lstCart.FormattingEnabled = true;
            lstCart.ItemHeight = 15;
            lstCart.Location = new Point(445, 50);
            lstCart.Name = "lstCart";
            lstCart.ScrollAlwaysVisible = true;
            lstCart.Size = new Size(264, 334);
            lstCart.Sorted = true;
            lstCart.TabIndex = 4;
            // 
            // btnReturnToDashboard
            // 
            btnReturnToDashboard.Location = new Point(517, 454);
            btnReturnToDashboard.Name = "btnReturnToDashboard";
            btnReturnToDashboard.Size = new Size(126, 23);
            btnReturnToDashboard.TabIndex = 5;
            btnReturnToDashboard.Text = "Return To Dashboard";
            btnReturnToDashboard.UseVisualStyleBackColor = true;
            btnReturnToDashboard.Click += btnReturnToDashboard_Click;
            // 
            // formCheckout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(btnReturnToDashboard);
            Controls.Add(lstCart);
            Controls.Add(lstEquipment);
            Controls.Add(btnCheckoutCart);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(btnAddToCart);
            Name = "formCheckout";
            Text = "Checkout";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddToCart;
        private Button btnRemoveFromCart;
        private Button btnCheckoutCart;
        private ListBox lstEquipment;
        private ListBox lstCart;
        private Button btnReturnToDashboard;
    }
}