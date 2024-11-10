namespace FastFoodRestaurant
{
    partial class UserControl4
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
            this.itemList1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.itemSearch = new System.Windows.Forms.TextBox();
            this.buy1_btn = new System.Windows.Forms.Button();
            this.refresh1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.itemList1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(132, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Please Select Your Order";
            // 
            // itemList1
            // 
            this.itemList1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemList1.Location = new System.Drawing.Point(17, 150);
            this.itemList1.Name = "itemList1";
            this.itemList1.Size = new System.Drawing.Size(559, 177);
            this.itemList1.TabIndex = 10;
            this.itemList1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemList1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Menu Item:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.search_btn);
            this.panel4.Controls.Add(this.itemSearch);
            this.panel4.Location = new System.Drawing.Point(124, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(338, 51);
            this.panel4.TabIndex = 12;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(250, 0);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(88, 51);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // itemSearch
            // 
            this.itemSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.itemSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSearch.Location = new System.Drawing.Point(13, 9);
            this.itemSearch.Margin = new System.Windows.Forms.Padding(0);
            this.itemSearch.Multiline = true;
            this.itemSearch.Name = "itemSearch";
            this.itemSearch.Size = new System.Drawing.Size(222, 33);
            this.itemSearch.TabIndex = 0;
            this.itemSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemSearch.TextChanged += new System.EventHandler(this.fullnameIn_TextChanged);
            // 
            // buy1_btn
            // 
            this.buy1_btn.BackColor = System.Drawing.Color.Red;
            this.buy1_btn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy1_btn.ForeColor = System.Drawing.Color.White;
            this.buy1_btn.Location = new System.Drawing.Point(468, 78);
            this.buy1_btn.Name = "buy1_btn";
            this.buy1_btn.Size = new System.Drawing.Size(108, 51);
            this.buy1_btn.TabIndex = 13;
            this.buy1_btn.Text = "Buy";
            this.buy1_btn.UseVisualStyleBackColor = false;
            this.buy1_btn.Click += new System.EventHandler(this.buy1_btn_Click);
            // 
            // refresh1
            // 
            this.refresh1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh1.Location = new System.Drawing.Point(468, 21);
            this.refresh1.Name = "refresh1";
            this.refresh1.Size = new System.Drawing.Size(108, 51);
            this.refresh1.TabIndex = 2;
            this.refresh1.Text = "Refresh";
            this.refresh1.UseVisualStyleBackColor = true;
            this.refresh1.Click += new System.EventHandler(this.refresh1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(17, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 51);
            this.panel1.TabIndex = 14;
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.refresh1);
            this.Controls.Add(this.buy1_btn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemList1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(594, 349);
            ((System.ComponentModel.ISupportInitialize)(this.itemList1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView itemList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox itemSearch;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button buy1_btn;
        private System.Windows.Forms.Button refresh1;
        private System.Windows.Forms.Panel panel1;
    }
}
