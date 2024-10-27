namespace FastFoodRestaurant
{
    partial class purchaseForm
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
            this.item_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.item_quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.final_buy = new System.Windows.Forms.Button();
            this.item_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // item_price
            // 
            this.item_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.item_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.item_price.Cursor = System.Windows.Forms.Cursors.No;
            this.item_price.Enabled = false;
            this.item_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_price.Location = new System.Drawing.Point(187, 118);
            this.item_price.Margin = new System.Windows.Forms.Padding(0);
            this.item_price.Multiline = true;
            this.item_price.Name = "item_price";
            this.item_price.ReadOnly = true;
            this.item_price.Size = new System.Drawing.Size(155, 33);
            this.item_price.TabIndex = 43;
            this.item_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item_price.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(69, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Price:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // item_quantity
            // 
            this.item_quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.item_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.item_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_quantity.Location = new System.Drawing.Point(187, 166);
            this.item_quantity.Margin = new System.Windows.Forms.Padding(0);
            this.item_quantity.Multiline = true;
            this.item_quantity.Name = "item_quantity";
            this.item_quantity.Size = new System.Drawing.Size(155, 33);
            this.item_quantity.TabIndex = 41;
            this.item_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item_quantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(69, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Quantity:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // final_buy
            // 
            this.final_buy.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_buy.Location = new System.Drawing.Point(106, 217);
            this.final_buy.Name = "final_buy";
            this.final_buy.Size = new System.Drawing.Size(84, 51);
            this.final_buy.TabIndex = 37;
            this.final_buy.Text = "Buy";
            this.final_buy.UseVisualStyleBackColor = true;
            this.final_buy.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // item_name
            // 
            this.item_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.item_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.item_name.Cursor = System.Windows.Forms.Cursors.No;
            this.item_name.Enabled = false;
            this.item_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name.Location = new System.Drawing.Point(187, 69);
            this.item_name.Margin = new System.Windows.Forms.Padding(0);
            this.item_name.Multiline = true;
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(155, 33);
            this.item_name.TabIndex = 36;
            this.item_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item_name.TextChanged += new System.EventHandler(this.fullnameIn_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(112, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 27);
            this.label2.TabIndex = 38;
            this.label2.Text = "Purchase Item";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(69, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Item Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Red;
            this.cancel_btn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(196, 217);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(90, 51);
            this.cancel_btn.TabIndex = 40;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.delete1_btn_Click);
            // 
            // purchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 290);
            this.Controls.Add(this.item_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.item_quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.final_buy);
            this.Controls.Add(this.item_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_btn);
            this.Name = "purchaseForm";
            this.Text = "Purchase Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox item_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox item_quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button final_buy;
        private System.Windows.Forms.TextBox item_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel_btn;
    }
}