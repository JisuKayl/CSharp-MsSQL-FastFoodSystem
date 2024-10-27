namespace FastFoodRestaurant
{
    partial class UserControl5
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.orderHistory = new System.Windows.Forms.DataGridView();
            this.print_btn = new System.Windows.Forms.Button();
            this.del_his = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(84, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Order History";
            // 
            // orderHistory
            // 
            this.orderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderHistory.Location = new System.Drawing.Point(3, 75);
            this.orderHistory.Name = "orderHistory";
            this.orderHistory.Size = new System.Drawing.Size(572, 248);
            this.orderHistory.TabIndex = 15;
            this.orderHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderHistory_CellContentClick);
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.Color.Blue;
            this.print_btn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.ForeColor = System.Drawing.Color.White;
            this.print_btn.Location = new System.Drawing.Point(323, 16);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(108, 50);
            this.print_btn.TabIndex = 16;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // del_his
            // 
            this.del_his.BackColor = System.Drawing.Color.Red;
            this.del_his.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_his.ForeColor = System.Drawing.Color.White;
            this.del_his.Location = new System.Drawing.Point(446, 16);
            this.del_his.Name = "del_his";
            this.del_his.Size = new System.Drawing.Size(108, 51);
            this.del_his.TabIndex = 18;
            this.del_his.Text = "Delete History";
            this.del_his.UseVisualStyleBackColor = false;
            this.del_his.Click += new System.EventHandler(this.del_his_Click);
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.del_his);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderHistory);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(594, 349);
            ((System.ComponentModel.ISupportInitialize)(this.orderHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView orderHistory;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button del_his;
    }
}
