﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbUserNumber = new System.Windows.Forms.TextBox();
            this.txbRemainTime = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2Hours
            // 
            this.btn2Hours.Location = new System.Drawing.Point(32, 32);
            this.btn2Hours.Name = "btn2Hours";
            this.btn2Hours.Size = new System.Drawing.Size(75, 61);
            this.btn2Hours.TabIndex = 0;
            this.btn2Hours.Text = "2시간";
            this.btn2Hours.UseVisualStyleBackColor = true;
            // 
            // btn5Hours
            // 
            this.btn5Hours.Location = new System.Drawing.Point(137, 32);
            this.btn5Hours.Name = "btn5Hours";
            this.btn5Hours.Size = new System.Drawing.Size(75, 61);
            this.btn5Hours.TabIndex = 0;
            this.btn5Hours.Text = "5시간";
            this.btn5Hours.UseVisualStyleBackColor = true;
            // 
            // btn30Hours
            // 
            this.btn30Hours.Location = new System.Drawing.Point(137, 113);
            this.btn30Hours.Name = "btn30Hours";
            this.btn30Hours.Size = new System.Drawing.Size(75, 61);
            this.btn30Hours.TabIndex = 0;
            this.btn30Hours.Text = "30시간";
            this.btn30Hours.UseVisualStyleBackColor = true;
            // 
            // btn12Hours
            // 
            this.btn12Hours.Location = new System.Drawing.Point(32, 113);
            this.btn12Hours.Name = "btn12Hours";
            this.btn12Hours.Size = new System.Drawing.Size(75, 61);
            this.btn12Hours.TabIndex = 0;
            this.btn12Hours.Text = "12시간";
            this.btn12Hours.UseVisualStyleBackColor = true;
            // 
            // btn60Hours
            // 
            this.btn60Hours.Location = new System.Drawing.Point(32, 201);
            this.btn60Hours.Name = "btn60Hours";
            this.btn60Hours.Size = new System.Drawing.Size(75, 61);
            this.btn60Hours.TabIndex = 0;
            this.btn60Hours.Text = "60시간";
            this.btn60Hours.UseVisualStyleBackColor = true;
            // 
            // btn100Hours
            // 
            this.btn100Hours.Location = new System.Drawing.Point(137, 201);
            this.btn100Hours.Name = "btn100Hours";
            this.btn100Hours.Size = new System.Drawing.Size(75, 61);
            this.btn100Hours.TabIndex = 0;
            this.btn100Hours.Text = "100시간";
            this.btn100Hours.UseVisualStyleBackColor = true;
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
            // SeatTimeChargingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbRemainTime);
            this.Controls.Add(this.txbUserNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbUserNumber;
        private System.Windows.Forms.TextBox txbRemainTime;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnPurchase;
    }
}