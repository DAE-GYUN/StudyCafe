
namespace WindowsFormsApp1
{
    partial class SeatTimeChargingForm
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
            this.txbUserNumber = new System.Windows.Forms.TextBox();
            this.txbRemainTime = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.rbtn2Hours = new System.Windows.Forms.RadioButton();
            this.rbtn5Hours = new System.Windows.Forms.RadioButton();
            this.rbtn12Hours = new System.Windows.Forms.RadioButton();
            this.rbtn30Hours = new System.Windows.Forms.RadioButton();
            this.rbtn60Hours = new System.Windows.Forms.RadioButton();
            this.rbtn100Hours = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.Location = new System.Drawing.Point(371, 100);
            this.txbUserNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.Size = new System.Drawing.Size(135, 21);
            this.txbUserNumber.TabIndex = 2;
            // 
            // txbRemainTime
            // 
            this.txbRemainTime.Location = new System.Drawing.Point(371, 156);
            this.txbRemainTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbRemainTime.Name = "txbRemainTime";
            this.txbRemainTime.Size = new System.Drawing.Size(135, 21);
            this.txbRemainTime.TabIndex = 2;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(371, 213);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(135, 21);
            this.txbPrice.TabIndex = 2;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Location = new System.Drawing.Point(201, 276);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(148, 60);
            this.btnMainMenu.TabIndex = 3;
            this.btnMainMenu.Text = "메인메뉴";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Location = new System.Drawing.Point(362, 276);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(154, 60);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "추가선택";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Location = new System.Drawing.Point(531, 276);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(142, 60);
            this.btnPurchase.TabIndex = 3;
            this.btnPurchase.Text = "결제";
            this.btnPurchase.UseVisualStyleBackColor = false;
            // 
            // rbtn2Hours
            // 
            this.rbtn2Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn2Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn2Hours.FlatAppearance.BorderSize = 0;
            this.rbtn2Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn2Hours.Location = new System.Drawing.Point(6, 19);
            this.rbtn2Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn2Hours.Name = "rbtn2Hours";
            this.rbtn2Hours.Size = new System.Drawing.Size(99, 52);
            this.rbtn2Hours.TabIndex = 4;
            this.rbtn2Hours.TabStop = true;
            this.rbtn2Hours.Text = "2시간";
            this.rbtn2Hours.UseVisualStyleBackColor = false;
            // 
            // rbtn5Hours
            // 
            this.rbtn5Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn5Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn5Hours.FlatAppearance.BorderSize = 0;
            this.rbtn5Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn5Hours.Location = new System.Drawing.Point(111, 18);
            this.rbtn5Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn5Hours.Name = "rbtn5Hours";
            this.rbtn5Hours.Size = new System.Drawing.Size(102, 53);
            this.rbtn5Hours.TabIndex = 4;
            this.rbtn5Hours.TabStop = true;
            this.rbtn5Hours.Text = "5시간";
            this.rbtn5Hours.UseVisualStyleBackColor = false;
            // 
            // rbtn12Hours
            // 
            this.rbtn12Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn12Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn12Hours.FlatAppearance.BorderSize = 0;
            this.rbtn12Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn12Hours.Location = new System.Drawing.Point(6, 89);
            this.rbtn12Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn12Hours.Name = "rbtn12Hours";
            this.rbtn12Hours.Size = new System.Drawing.Size(99, 47);
            this.rbtn12Hours.TabIndex = 4;
            this.rbtn12Hours.TabStop = true;
            this.rbtn12Hours.Text = "12시간";
            this.rbtn12Hours.UseVisualStyleBackColor = false;
            // 
            // rbtn30Hours
            // 
            this.rbtn30Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn30Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn30Hours.FlatAppearance.BorderSize = 0;
            this.rbtn30Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn30Hours.Location = new System.Drawing.Point(111, 89);
            this.rbtn30Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn30Hours.Name = "rbtn30Hours";
            this.rbtn30Hours.Size = new System.Drawing.Size(102, 49);
            this.rbtn30Hours.TabIndex = 4;
            this.rbtn30Hours.TabStop = true;
            this.rbtn30Hours.Text = "30시간";
            this.rbtn30Hours.UseVisualStyleBackColor = false;
            // 
            // rbtn60Hours
            // 
            this.rbtn60Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn60Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn60Hours.FlatAppearance.BorderSize = 0;
            this.rbtn60Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn60Hours.Location = new System.Drawing.Point(6, 158);
            this.rbtn60Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn60Hours.Name = "rbtn60Hours";
            this.rbtn60Hours.Size = new System.Drawing.Size(99, 46);
            this.rbtn60Hours.TabIndex = 4;
            this.rbtn60Hours.TabStop = true;
            this.rbtn60Hours.Text = "60시간";
            this.rbtn60Hours.UseVisualStyleBackColor = false;
            // 
            // rbtn100Hours
            // 
            this.rbtn100Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn100Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn100Hours.FlatAppearance.BorderSize = 0;
            this.rbtn100Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn100Hours.Location = new System.Drawing.Point(111, 158);
            this.rbtn100Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn100Hours.Name = "rbtn100Hours";
            this.rbtn100Hours.Size = new System.Drawing.Size(102, 47);
            this.rbtn100Hours.TabIndex = 4;
            this.rbtn100Hours.TabStop = true;
            this.rbtn100Hours.Text = "100시간";
            this.rbtn100Hours.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtn2Hours);
            this.groupBox1.Controls.Add(this.rbtn100Hours);
            this.groupBox1.Controls.Add(this.rbtn5Hours);
            this.groupBox1.Controls.Add(this.rbtn60Hours);
            this.groupBox1.Controls.Add(this.rbtn12Hours);
            this.groupBox1.Controls.Add(this.rbtn30Hours);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(219, 219);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // SeatTimeChargingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.SeatTimeChargingForm1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbRemainTime);
            this.Controls.Add(this.txbUserNumber);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SeatTimeChargingForm";
            this.Text = "SeatTimeChargingForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbUserNumber;
        private System.Windows.Forms.TextBox txbRemainTime;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.RadioButton rbtn2Hours;
        private System.Windows.Forms.RadioButton rbtn5Hours;
        private System.Windows.Forms.RadioButton rbtn12Hours;
        private System.Windows.Forms.RadioButton rbtn30Hours;
        private System.Windows.Forms.RadioButton rbtn60Hours;
        private System.Windows.Forms.RadioButton rbtn100Hours;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}