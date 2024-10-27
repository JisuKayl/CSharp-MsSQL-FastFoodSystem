namespace FastFoodRestaurant
{
    partial class UserControl6
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
            this.itemList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.itemList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(182, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "Customer Overview";
            // 
            // itemList
            // 
            this.itemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemList.Location = new System.Drawing.Point(3, 75);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(573, 248);
            this.itemList.TabIndex = 29;
            this.itemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemList_CellContentClick);
            // 
            // UserControl6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemList);
            this.Name = "UserControl6";
            this.Size = new System.Drawing.Size(594, 349);
            ((System.ComponentModel.ISupportInitialize)(this.itemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView itemList;
    }
}
