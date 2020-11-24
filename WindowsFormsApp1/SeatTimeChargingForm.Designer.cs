
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
            this.btn2Hours = new System.Windows.Forms.Button();
            this.btn5Hours = new System.Windows.Forms.Button();
            this.btn30Hours = new System.Windows.Forms.Button();
            this.btn12Hours = new System.Windows.Forms.Button();
            this.btn60Hours = new System.Windows.Forms.Button();
            this.btn100Hours = new System.Windows.Forms.Button();
            this.txbUserNumber = new System.Windows.Forms.TextBox();
            this.txbRemainTime = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2Hours
            // 
            this.btn2Hours.Location = new System.Drawing.Point(38, 23);
            this.btn2Hours.Name = "btn2Hours";
            this.btn2Hours.Size = new System.Drawing.Size(86, 63);
            this.btn2Hours.TabIndex = 0;
            this.btn2Hours.Text = " 2시간  4,000원";
            this.btn2Hours.UseVisualStyleBackColor = true;
            // 
            // btn5Hours
            // 
            this.btn5Hours.Location = new System.Drawing.Point(156, 23);
            this.btn5Hours.Name = "btn5Hours";
            this.btn5Hours.Size = new System.Drawing.Size(86, 63);
            this.btn5Hours.TabIndex = 0;
            this.btn5Hours.Text = " 5시간  5,000원";
            this.btn5Hours.UseVisualStyleBackColor = true;
            // 
            // btn30Hours
            // 
            this.btn30Hours.Location = new System.Drawing.Point(156, 115);
            this.btn30Hours.Name = "btn30Hours";
            this.btn30Hours.Size = new System.Drawing.Size(86, 63);
            this.btn30Hours.TabIndex = 0;
            this.btn30Hours.Text = " 30시간  30,000원";
            this.btn30Hours.UseVisualStyleBackColor = true;
            // 
            // btn12Hours
            // 
            this.btn12Hours.Location = new System.Drawing.Point(38, 115);
            this.btn12Hours.Name = "btn12Hours";
            this.btn12Hours.Size = new System.Drawing.Size(86, 63);
            this.btn12Hours.TabIndex = 0;
            this.btn12Hours.Text = " 12시간  10,000원";
            this.btn12Hours.UseVisualStyleBackColor = true;
            // 
            // btn60Hours
            // 
            this.btn60Hours.Location = new System.Drawing.Point(38, 206);
            this.btn60Hours.Name = "btn60Hours";
            this.btn60Hours.Size = new System.Drawing.Size(86, 63);
            this.btn60Hours.TabIndex = 0;
            this.btn60Hours.Text = " 60시간  60,000원";
            this.btn60Hours.UseVisualStyleBackColor = true;
            // 
            // btn100Hours
            // 
            this.btn100Hours.Location = new System.Drawing.Point(156, 206);
            this.btn100Hours.Name = "btn100Hours";
            this.btn100Hours.Size = new System.Drawing.Size(86, 63);
            this.btn100Hours.TabIndex = 0;
            this.btn100Hours.Text = " 100시간  100,000원";
            this.btn100Hours.UseVisualStyleBackColor = true;
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.Location = new System.Drawing.Point(395, 40);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.Size = new System.Drawing.Size(176, 25);
            this.txbUserNumber.TabIndex = 1;
            // 
            // txbRemainTime
            // 
            this.txbRemainTime.Location = new System.Drawing.Point(395, 89);
            this.txbRemainTime.Name = "txbRemainTime";
            this.txbRemainTime.Size = new System.Drawing.Size(176, 25);
            this.txbRemainTime.TabIndex = 1;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(395, 136);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(176, 25);
            this.txbPrice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "회원번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "이용권 잔여시간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "결제금액";
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(485, 230);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(86, 49);
            this.btnMain.TabIndex = 3;
            this.btnMain.Text = "메인으로";
            this.btnMain.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(344, 334);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(101, 49);
            this.btnPurchase.TabIndex = 3;
            this.btnPurchase.Text = "결제";
            this.btnPurchase.UseVisualStyleBackColor = true;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(470, 334);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(101, 49);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "추가선택";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // SeatTimeChargingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 546);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbRemainTime);
            this.Controls.Add(this.txbUserNumber);
            this.Controls.Add(this.btn100Hours);
            this.Controls.Add(this.btn60Hours);
            this.Controls.Add(this.btn12Hours);
            this.Controls.Add(this.btn30Hours);
            this.Controls.Add(this.btn5Hours);
            this.Controls.Add(this.btn2Hours);
            this.Name = "SeatTimeChargingForm";
            this.Text = "SeatTimeChargingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2Hours;
        private System.Windows.Forms.Button btn5Hours;
        private System.Windows.Forms.Button btn30Hours;
        private System.Windows.Forms.Button btn12Hours;
        private System.Windows.Forms.Button btn60Hours;
        private System.Windows.Forms.Button btn100Hours;
        private System.Windows.Forms.TextBox txbUserNumber;
        private System.Windows.Forms.TextBox txbRemainTime;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnAddToCart;
    }
}