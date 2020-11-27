
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
            this.txbItemName = new System.Windows.Forms.TextBox();
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
            this.txbUserNumber.Location = new System.Drawing.Point(424, 125);
            this.txbUserNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.Size = new System.Drawing.Size(154, 25);
            this.txbUserNumber.TabIndex = 2;
            // 
            // txbItemName
            // 
            this.txbItemName.Location = new System.Drawing.Point(424, 195);
            this.txbItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbItemName.Name = "txbItemName";
            this.txbItemName.Size = new System.Drawing.Size(154, 25);
            this.txbItemName.TabIndex = 2;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(424, 266);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(154, 25);
            this.txbPrice.TabIndex = 2;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Location = new System.Drawing.Point(230, 345);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(169, 75);
            this.btnMainMenu.TabIndex = 3;
            this.btnMainMenu.Text = "메인메뉴";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Location = new System.Drawing.Point(414, 345);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(176, 75);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "추가선택";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Location = new System.Drawing.Point(607, 345);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(162, 75);
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
            this.rbtn2Hours.Location = new System.Drawing.Point(7, 24);
            this.rbtn2Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn2Hours.Name = "rbtn2Hours";
            this.rbtn2Hours.Size = new System.Drawing.Size(113, 65);
            this.rbtn2Hours.TabIndex = 4;
            this.rbtn2Hours.TabStop = true;
            this.rbtn2Hours.Text = "2시간";
            this.rbtn2Hours.UseVisualStyleBackColor = false;
            this.rbtn2Hours.CheckedChanged += new System.EventHandler(this.rbtn2Hours_CheckedChanged);
            // 
            // rbtn5Hours
            // 
            this.rbtn5Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn5Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn5Hours.FlatAppearance.BorderSize = 0;
            this.rbtn5Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn5Hours.Location = new System.Drawing.Point(127, 22);
            this.rbtn5Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn5Hours.Name = "rbtn5Hours";
            this.rbtn5Hours.Size = new System.Drawing.Size(117, 66);
            this.rbtn5Hours.TabIndex = 4;
            this.rbtn5Hours.TabStop = true;
            this.rbtn5Hours.Text = "5시간";
            this.rbtn5Hours.UseVisualStyleBackColor = false;
            this.rbtn5Hours.CheckedChanged += new System.EventHandler(this.rbtn5Hours_CheckedChanged);
            // 
            // rbtn12Hours
            // 
            this.rbtn12Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn12Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn12Hours.FlatAppearance.BorderSize = 0;
            this.rbtn12Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn12Hours.Location = new System.Drawing.Point(7, 111);
            this.rbtn12Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn12Hours.Name = "rbtn12Hours";
            this.rbtn12Hours.Size = new System.Drawing.Size(113, 59);
            this.rbtn12Hours.TabIndex = 4;
            this.rbtn12Hours.TabStop = true;
            this.rbtn12Hours.Text = "12시간";
            this.rbtn12Hours.UseVisualStyleBackColor = false;
            this.rbtn12Hours.CheckedChanged += new System.EventHandler(this.rbtn12Hours_CheckedChanged);
            // 
            // rbtn30Hours
            // 
            this.rbtn30Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn30Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn30Hours.FlatAppearance.BorderSize = 0;
            this.rbtn30Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn30Hours.Location = new System.Drawing.Point(127, 111);
            this.rbtn30Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn30Hours.Name = "rbtn30Hours";
            this.rbtn30Hours.Size = new System.Drawing.Size(117, 61);
            this.rbtn30Hours.TabIndex = 4;
            this.rbtn30Hours.TabStop = true;
            this.rbtn30Hours.Text = "30시간";
            this.rbtn30Hours.UseVisualStyleBackColor = false;
            this.rbtn30Hours.CheckedChanged += new System.EventHandler(this.rbtn30Hours_CheckedChanged);
            // 
            // rbtn60Hours
            // 
            this.rbtn60Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn60Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn60Hours.FlatAppearance.BorderSize = 0;
            this.rbtn60Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn60Hours.Location = new System.Drawing.Point(7, 198);
            this.rbtn60Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn60Hours.Name = "rbtn60Hours";
            this.rbtn60Hours.Size = new System.Drawing.Size(113, 58);
            this.rbtn60Hours.TabIndex = 4;
            this.rbtn60Hours.TabStop = true;
            this.rbtn60Hours.Text = "60시간";
            this.rbtn60Hours.UseVisualStyleBackColor = false;
            this.rbtn60Hours.CheckedChanged += new System.EventHandler(this.rbtn60Hours_CheckedChanged);
            // 
            // rbtn100Hours
            // 
            this.rbtn100Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn100Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn100Hours.FlatAppearance.BorderSize = 0;
            this.rbtn100Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn100Hours.Location = new System.Drawing.Point(127, 198);
            this.rbtn100Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn100Hours.Name = "rbtn100Hours";
            this.rbtn100Hours.Size = new System.Drawing.Size(117, 59);
            this.rbtn100Hours.TabIndex = 4;
            this.rbtn100Hours.TabStop = true;
            this.rbtn100Hours.Text = "100시간";
            this.rbtn100Hours.UseVisualStyleBackColor = false;
            this.rbtn100Hours.CheckedChanged += new System.EventHandler(this.rbtn100Hours_CheckedChanged);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(250, 274);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // SeatTimeChargingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.SeatTimeChargingForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbItemName);
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
        private System.Windows.Forms.TextBox txbItemName;
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