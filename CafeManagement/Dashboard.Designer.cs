namespace CafeManagement
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.removeItembtn = new System.Windows.Forms.Button();
            this.updateItemBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uC_AddItems1 = new CafeManagement.AllUserControls.UC_AddItems();
            this.uC_PlaceOrder1 = new CafeManagement.AllUserControls.UC_PlaceOrder();
            this.uC_UpdateItems1 = new CafeManagement.AllUserControls.UC_UpdateItems();
            this.uC_RemoveItem1 = new CafeManagement.AllUserControls.UC_RemoveItem();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeItembtn
            // 
            this.removeItembtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeItembtn.FlatAppearance.BorderSize = 0;
            this.removeItembtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeItembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItembtn.ForeColor = System.Drawing.Color.Black;
            this.removeItembtn.Location = new System.Drawing.Point(8, 338);
            this.removeItembtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeItembtn.Name = "removeItembtn";
            this.removeItembtn.Size = new System.Drawing.Size(122, 41);
            this.removeItembtn.TabIndex = 3;
            this.removeItembtn.Text = "Remove Item";
            this.removeItembtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeItembtn.UseVisualStyleBackColor = true;
            this.removeItembtn.Click += new System.EventHandler(this.removeItembtn_Click);
            // 
            // updateItemBtn
            // 
            this.updateItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateItemBtn.FlatAppearance.BorderSize = 0;
            this.updateItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItemBtn.ForeColor = System.Drawing.Color.Black;
            this.updateItemBtn.Location = new System.Drawing.Point(9, 293);
            this.updateItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateItemBtn.Name = "updateItemBtn";
            this.updateItemBtn.Size = new System.Drawing.Size(121, 41);
            this.updateItemBtn.TabIndex = 2;
            this.updateItemBtn.Text = "Update Item";
            this.updateItemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateItemBtn.UseVisualStyleBackColor = true;
            this.updateItemBtn.Click += new System.EventHandler(this.updateItemBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addItemBtn.FlatAppearance.BorderSize = 0;
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.ForeColor = System.Drawing.Color.Black;
            this.addItemBtn.Location = new System.Drawing.Point(26, 248);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(95, 41);
            this.addItemBtn.TabIndex = 1;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.placeOrderBtn.FlatAppearance.BorderSize = 0;
            this.placeOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderBtn.ForeColor = System.Drawing.Color.Black;
            this.placeOrderBtn.Location = new System.Drawing.Point(11, 203);
            this.placeOrderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(121, 41);
            this.placeOrderBtn.TabIndex = 0;
            this.placeOrderBtn.Text = "Place Order";
            this.placeOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.placeOrderBtn.UseVisualStyleBackColor = true;
            this.placeOrderBtn.Click += new System.EventHandler(this.placeOrderBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.removeItembtn);
            this.panel1.Controls.Add(this.updateItemBtn);
            this.panel1.Controls.Add(this.addItemBtn);
            this.panel1.Controls.Add(this.placeOrderBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogout.Location = new System.Drawing.Point(30, 416);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(78, 25);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 502);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Logout";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(407, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "StarCafe";
            // 
            // uC_AddItems1
            // 
            this.uC_AddItems1.Location = new System.Drawing.Point(135, 0);
            this.uC_AddItems1.Name = "uC_AddItems1";
            this.uC_AddItems1.Size = new System.Drawing.Size(653, 450);
            this.uC_AddItems1.TabIndex = 15;
            this.uC_AddItems1.Load += new System.EventHandler(this.uC_AddItems1_Load);
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(135, 0);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(679, 450);
            this.uC_PlaceOrder1.TabIndex = 16;
            // 
            // uC_UpdateItems1
            // 
            this.uC_UpdateItems1.Location = new System.Drawing.Point(135, 0);
            this.uC_UpdateItems1.Name = "uC_UpdateItems1";
            this.uC_UpdateItems1.Size = new System.Drawing.Size(669, 447);
            this.uC_UpdateItems1.TabIndex = 17;
            // 
            // uC_RemoveItem1
            // 
            this.uC_RemoveItem1.Location = new System.Drawing.Point(135, 0);
            this.uC_RemoveItem1.Name = "uC_RemoveItem1";
            this.uC_RemoveItem1.Size = new System.Drawing.Size(669, 450);
            this.uC_RemoveItem1.TabIndex = 18;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uC_RemoveItem1);
            this.Controls.Add(this.uC_UpdateItems1);
            this.Controls.Add(this.uC_PlaceOrder1);
            this.Controls.Add(this.uC_AddItems1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeItembtn;
        private System.Windows.Forms.Button updateItemBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button placeOrderBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnLogout;
        private System.Windows.Forms.Label label4;
        private AllUserControls.UC_AddItems uC_AddItems1;
        private AllUserControls.UC_PlaceOrder uC_PlaceOrder1;
        private AllUserControls.UC_UpdateItems uC_UpdateItems1;
        private AllUserControls.UC_RemoveItem uC_RemoveItem1;
    }
}