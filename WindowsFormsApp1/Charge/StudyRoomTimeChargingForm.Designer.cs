
namespace WindowsFormsApp1
{
    partial class StudyRoomTimeChargingForm
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
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbChargingTime = new System.Windows.Forms.TextBox();
            this.txbUserNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn2Hours = new System.Windows.Forms.RadioButton();
            this.rbtn4Hours = new System.Windows.Forms.RadioButton();
            this.rbtn6Hours = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Location = new System.Drawing.Point(522, 275);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(166, 60);
            this.btnPurchase.TabIndex = 10;
            this.btnPurchase.Text = "결제";
            this.btnPurchase.UseVisualStyleBackColor = false;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Location = new System.Drawing.Point(357, 275);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(159, 60);
            this.btnAddToCart.TabIndex = 11;
            this.btnAddToCart.Text = "추가선택";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Location = new System.Drawing.Point(191, 275);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(160, 60);
            this.btnMainMenu.TabIndex = 12;
            this.btnMainMenu.Text = "메인메뉴";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(298, 221);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(135, 21);
            this.txbPrice.TabIndex = 7;
            // 
            // txbChargingTime
            // 
            this.txbChargingTime.Location = new System.Drawing.Point(298, 158);
            this.txbChargingTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbChargingTime.Name = "txbChargingTime";
            this.txbChargingTime.Size = new System.Drawing.Size(135, 21);
            this.txbChargingTime.TabIndex = 8;
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.Location = new System.Drawing.Point(298, 101);
            this.txbUserNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.Size = new System.Drawing.Size(135, 21);
            this.txbUserNumber.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtn2Hours);
            this.groupBox1.Controls.Add(this.rbtn4Hours);
            this.groupBox1.Controls.Add(this.rbtn6Hours);
            this.groupBox1.Location = new System.Drawing.Point(28, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(98, 231);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // rbtn2Hours
            // 
            this.rbtn2Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn2Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn2Hours.FlatAppearance.BorderSize = 0;
            this.rbtn2Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn2Hours.Location = new System.Drawing.Point(0, 24);
            this.rbtn2Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn2Hours.Name = "rbtn2Hours";
            this.rbtn2Hours.Size = new System.Drawing.Size(98, 47);
            this.rbtn2Hours.TabIndex = 4;
            this.rbtn2Hours.TabStop = true;
            this.rbtn2Hours.Text = "2시간";
            this.rbtn2Hours.UseVisualStyleBackColor = false;
            // 
            // rbtn4Hours
            // 
            this.rbtn4Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn4Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn4Hours.FlatAppearance.BorderSize = 0;
            this.rbtn4Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn4Hours.Location = new System.Drawing.Point(0, 162);
            this.rbtn4Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn4Hours.Name = "rbtn4Hours";
            this.rbtn4Hours.Size = new System.Drawing.Size(98, 47);
            this.rbtn4Hours.TabIndex = 4;
            this.rbtn4Hours.TabStop = true;
            this.rbtn4Hours.Text = "4시간";
            this.rbtn4Hours.UseVisualStyleBackColor = false;
            // 
            // rbtn6Hours
            // 
            this.rbtn6Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn6Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn6Hours.FlatAppearance.BorderSize = 0;
            this.rbtn6Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn6Hours.Location = new System.Drawing.Point(0, 90);
            this.rbtn6Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn6Hours.Name = "rbtn6Hours";
            this.rbtn6Hours.Size = new System.Drawing.Size(98, 47);
            this.rbtn6Hours.TabIndex = 4;
            this.rbtn6Hours.TabStop = true;
            this.rbtn6Hours.Text = "6시간";
            this.rbtn6Hours.UseVisualStyleBackColor = false;
            // 
            // StudyRoomTimeChargingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.StudyRoomTimeChargingForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbChargingTime);
            this.Controls.Add(this.txbUserNumber);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudyRoomTimeChargingForm";
            this.Text = "StudyRoomTimeChargingForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbChargingTime;
        private System.Windows.Forms.TextBox txbUserNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn2Hours;
        private System.Windows.Forms.RadioButton rbtn4Hours;
        private System.Windows.Forms.RadioButton rbtn6Hours;
    }
}