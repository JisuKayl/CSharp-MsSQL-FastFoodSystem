
using System.Windows.Forms;

namespace FastFoodRestaurant
{
    partial class homeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.home_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.order_btn = new System.Windows.Forms.Button();
            this.item_btn = new System.Windows.Forms.Button();
            this.drinks_btn = new System.Windows.Forms.Button();
            this.meal_btn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.displayName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.userControl51 = new FastFoodRestaurant.UserControl5();
            this.userControl41 = new FastFoodRestaurant.UserControl4(userControl51);
            this.userControl31 = new FastFoodRestaurant.UserControl3();
            this.userControl21 = new FastFoodRestaurant.UserControl2();
            this.userControl11 = new FastFoodRestaurant.UserControl1();
            this.ord = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 17);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(268, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 144);
            this.panel3.TabIndex = 999;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fast Food";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "JisuBee";
            // 
            // home_btn
            // 
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.Color.White;
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.Location = new System.Drawing.Point(25, 71);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(159, 47);
            this.home_btn.TabIndex = 0;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.sidepanel);
            this.panel2.Controls.Add(this.order_btn);
            this.panel2.Controls.Add(this.item_btn);
            this.panel2.Controls.Add(this.drinks_btn);
            this.panel2.Controls.Add(this.meal_btn);
            this.panel2.Controls.Add(this.home_btn);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 494);
            this.panel2.TabIndex = 15;
            // 
            // logout_btn
            // 
            this.logout_btn.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(47, 429);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(100, 34);
            this.logout_btn.TabIndex = 28;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.Red;
            this.sidepanel.Location = new System.Drawing.Point(1, 71);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(18, 47);
            this.sidepanel.TabIndex = 3;
            // 
            // order_btn
            // 
            this.order_btn.FlatAppearance.BorderSize = 0;
            this.order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_btn.ForeColor = System.Drawing.Color.White;
            this.order_btn.Image = ((System.Drawing.Image)(resources.GetObject("order_btn.Image")));
            this.order_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.order_btn.Location = new System.Drawing.Point(25, 283);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(159, 47);
            this.order_btn.TabIndex = 6;
            this.order_btn.Text = "Order History";
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.customers_btn_Click);
            // 
            // item_btn
            // 
            this.item_btn.FlatAppearance.BorderSize = 0;
            this.item_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn.ForeColor = System.Drawing.Color.White;
            this.item_btn.Image = ((System.Drawing.Image)(resources.GetObject("item_btn.Image")));
            this.item_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.item_btn.Location = new System.Drawing.Point(24, 230);
            this.item_btn.Name = "item_btn";
            this.item_btn.Size = new System.Drawing.Size(160, 47);
            this.item_btn.TabIndex = 5;
            this.item_btn.Text = "Order Here";
            this.item_btn.UseVisualStyleBackColor = true;
            this.item_btn.Click += new System.EventHandler(this.Driver_btn_Click);
            // 
            // drinks_btn
            // 
            this.drinks_btn.FlatAppearance.BorderSize = 0;
            this.drinks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinks_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinks_btn.ForeColor = System.Drawing.Color.White;
            this.drinks_btn.Image = ((System.Drawing.Image)(resources.GetObject("drinks_btn.Image")));
            this.drinks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drinks_btn.Location = new System.Drawing.Point(25, 177);
            this.drinks_btn.Name = "drinks_btn";
            this.drinks_btn.Size = new System.Drawing.Size(160, 47);
            this.drinks_btn.TabIndex = 2;
            this.drinks_btn.Text = "Drinks";
            this.drinks_btn.UseVisualStyleBackColor = true;
            this.drinks_btn.Click += new System.EventHandler(this.collection_btn_Click);
            // 
            // meal_btn
            // 
            this.meal_btn.FlatAppearance.BorderSize = 0;
            this.meal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.meal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meal_btn.ForeColor = System.Drawing.Color.White;
            this.meal_btn.Image = ((System.Drawing.Image)(resources.GetObject("meal_btn.Image")));
            this.meal_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.meal_btn.Location = new System.Drawing.Point(25, 124);
            this.meal_btn.Name = "meal_btn";
            this.meal_btn.Size = new System.Drawing.Size(159, 47);
            this.meal_btn.TabIndex = 1;
            this.meal_btn.Text = "Meals ";
            this.meal_btn.UseVisualStyleBackColor = true;
            this.meal_btn.Click += new System.EventHandler(this.eat_btn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.displayName);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(196, 53);
            this.panel5.TabIndex = 6;
            // 
            // displayName
            // 
            this.displayName.AutoSize = true;
            this.displayName.BackColor = System.Drawing.Color.White;
            this.displayName.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayName.ForeColor = System.Drawing.Color.Black;
            this.displayName.Location = new System.Drawing.Point(54, 20);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(138, 14);
            this.displayName.TabIndex = 5;
            this.displayName.Text = "Jerson Kyle Bonifacio";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(758, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(717, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // userControl51
            // 
            this.userControl51.BackColor = System.Drawing.Color.Transparent;
            this.userControl51.Location = new System.Drawing.Point(208, 145);
            this.userControl51.Name = "userControl51";
            this.userControl51.Size = new System.Drawing.Size(594, 349);
            this.userControl51.TabIndex = 1004;
            // 
            // userControl41
            // 
            this.userControl41.BackColor = System.Drawing.Color.Transparent;
            this.userControl41.Location = new System.Drawing.Point(202, 145);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(594, 349);
            this.userControl41.TabIndex = 1003;
            this.userControl41.Load += new System.EventHandler(this.userControl41_Load);
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.Transparent;
            this.userControl31.Location = new System.Drawing.Point(202, 135);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(594, 359);
            this.userControl31.TabIndex = 1002;
            this.userControl31.Load += new System.EventHandler(this.userControl31_Load);
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.Transparent;
            this.userControl21.Location = new System.Drawing.Point(203, 154);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(594, 349);
            this.userControl21.TabIndex = 1001;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Transparent;
            this.userControl11.Location = new System.Drawing.Point(203, 177);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(585, 276);
            this.userControl11.TabIndex = 1000;
            // 
            // ord
            // 
            this.ord.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ord.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ord.ForeColor = System.Drawing.SystemColors.Control;
            this.ord.Location = new System.Drawing.Point(442, 92);
            this.ord.Name = "ord";
            this.ord.Size = new System.Drawing.Size(158, 61);
            this.ord.TabIndex = 1005;
            this.ord.Text = "Order Now!";
            this.ord.UseVisualStyleBackColor = false;
            this.ord.Click += new System.EventHandler(this.ord_Click);
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.ord);
            this.Controls.Add(this.userControl51);
            this.Controls.Add(this.userControl41);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Name = "homeForm";
            this.Text = "JisuBee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Button item_btn;
        private System.Windows.Forms.Button drinks_btn;
        private System.Windows.Forms.Button meal_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label displayName;
        private UserControl3 userControl31;
        private UserControl4 userControl41;
        private System.Windows.Forms.Button logout_btn;
        private UserControl5 userControl51;
        private Button ord;
    }
}

