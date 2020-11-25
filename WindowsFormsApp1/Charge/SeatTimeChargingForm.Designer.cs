
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "잔여시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "회원번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "결제금액";
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.Location = new System.Drawing.Point(414, 52);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.Size = new System.Drawing.Size(154, 25);
            this.txbUserNumber.TabIndex = 2;
            // 
            // txbRemainTime
            // 
            this.txbRemainTime.Location = new System.Drawing.Point(414, 121);
            this.txbRemainTime.Name = "txbRemainTime";
            this.txbRemainTime.Size = new System.Drawing.Size(154, 25);
            this.txbRemainTime.TabIndex = 2;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(414, 172);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(154, 25);
            this.txbPrice.TabIndex = 2;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(300, 278);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(75, 58);
            this.btnMainMenu.TabIndex = 3;
            this.btnMainMenu.Text = "메인메뉴";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(398, 278);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 58);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "추가선택";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(493, 278);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(75, 58);
            this.btnPurchase.TabIndex = 3;
            this.btnPurchase.Text = "결제";
            this.btnPurchase.UseVisualStyleBackColor = true;
            // 
            // rbtn2Hours
            // 
            this.rbtn2Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn2Hours.Location = new System.Drawing.Point(6, 24);
            this.rbtn2Hours.Name = "rbtn2Hours";
            this.rbtn2Hours.Size = new System.Drawing.Size(78, 59);
            this.rbtn2Hours.TabIndex = 4;
            this.rbtn2Hours.TabStop = true;
            this.rbtn2Hours.Text = "2시간";
            this.rbtn2Hours.UseVisualStyleBackColor = true;
            // 
            // rbtn5Hours
            // 
            this.rbtn5Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn5Hours.Location = new System.Drawing.Point(107, 24);
            this.rbtn5Hours.Name = "rbtn5Hours";
            this.rbtn5Hours.Size = new System.Drawing.Size(78, 59);
            this.rbtn5Hours.TabIndex = 4;
            this.rbtn5Hours.TabStop = true;
            this.rbtn5Hours.Text = "5시간";
            this.rbtn5Hours.UseVisualStyleBackColor = true;
            // 
            // rbtn12Hours
            // 
            this.rbtn12Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn12Hours.Location = new System.Drawing.Point(6, 100);
            this.rbtn12Hours.Name = "rbtn12Hours";
            this.rbtn12Hours.Size = new System.Drawing.Size(78, 59);
            this.rbtn12Hours.TabIndex = 4;
            this.rbtn12Hours.TabStop = true;
            this.rbtn12Hours.Text = "12시간";
            this.rbtn12Hours.UseVisualStyleBackColor = true;
            // 
            // rbtn30Hours
            // 
            this.rbtn30Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn30Hours.Location = new System.Drawing.Point(107, 100);
            this.rbtn30Hours.Name = "rbtn30Hours";
            this.rbtn30Hours.Size = new System.Drawing.Size(78, 59);
            this.rbtn30Hours.TabIndex = 4;
            this.rbtn30Hours.TabStop = true;
            this.rbtn30Hours.Text = "30시간";
            this.rbtn30Hours.UseVisualStyleBackColor = true;
            // 
            // rbtn60Hours
            // 
            this.rbtn60Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn60Hours.Location = new System.Drawing.Point(6, 178);
            this.rbtn60Hours.Name = "rbtn60Hours";
            this.rbtn60Hours.Size = new System.Drawing.Size(78, 59);
            this.rbtn60Hours.TabIndex = 4;
            this.rbtn60Hours.TabStop = true;
            this.rbtn60Hours.Text = "60시간";
            this.rbtn60Hours.UseVisualStyleBackColor = true;
            // 
            // rbtn100Hours
            // 
            this.rbtn100Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn100Hours.Location = new System.Drawing.Point(107, 178);
            this.rbtn100Hours.Name = "rbtn100Hours";
            this.rbtn100Hours.Size = new System.Drawing.Size(78, 59);
            this.rbtn100Hours.TabIndex = 4;
            this.rbtn100Hours.TabStop = true;
            this.rbtn100Hours.Text = "100시간";
            this.rbtn100Hours.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn2Hours);
            this.groupBox1.Controls.Add(this.rbtn100Hours);
            this.groupBox1.Controls.Add(this.rbtn5Hours);
            this.groupBox1.Controls.Add(this.rbtn60Hours);
            this.groupBox1.Controls.Add(this.rbtn12Hours);
            this.groupBox1.Controls.Add(this.rbtn30Hours);
            this.groupBox1.Location = new System.Drawing.Point(25, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 289);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // SeatTimeChargingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbRemainTime);
            this.Controls.Add(this.txbUserNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SeatTimeChargingForm";
            this.Text = "SeatTimeChargingForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
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