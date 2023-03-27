namespace OliveiraTaylorOOPFinalProject
{
    partial class Order
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
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lstInventory
            // 
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.ItemHeight = 16;
            this.lstInventory.Location = new System.Drawing.Point(6, 177);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(559, 164);
            this.lstInventory.TabIndex = 0;
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 16;
            this.lstCart.Location = new System.Drawing.Point(13, 21);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(179, 244);
            this.lstCart.TabIndex = 1;
            // 
            // grpCart
            // 
            this.grpCart.Controls.Add(this.btnSubmitOrder);
            this.grpCart.Controls.Add(this.lstCart);
            this.grpCart.Location = new System.Drawing.Point(590, 125);
            this.grpCart.Name = "grpCart";
            this.grpCart.Size = new System.Drawing.Size(198, 313);
            this.grpCart.TabIndex = 2;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Cart";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(61, 271);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(78, 42);
            this.btnSubmitOrder.TabIndex = 2;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(232, 352);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(110, 54);
            this.btnAddToOrder.TabIndex = 3;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 138);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // grpInventory
            // 
            this.grpInventory.Controls.Add(this.pictureBox1);
            this.grpInventory.Controls.Add(this.btnAddToOrder);
            this.grpInventory.Controls.Add(this.lstInventory);
            this.grpInventory.Location = new System.Drawing.Point(13, 13);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Size = new System.Drawing.Size(571, 425);
            this.grpInventory.TabIndex = 4;
            this.grpInventory.TabStop = false;
            this.grpInventory.Text = "Store Inventory";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(620, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 107);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpInventory);
            this.Controls.Add(this.grpCart);
            this.Name = "Order";
            this.Text = "Order";
            this.grpCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}