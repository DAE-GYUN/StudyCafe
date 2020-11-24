
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
            this.btnStudyRoom2Hours = new System.Windows.Forms.Button();
            this.btnStudyRoom4Hours = new System.Windows.Forms.Button();
            this.btnStudyRoom6Hours = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbChargingTime = new System.Windows.Forms.TextBox();
            this.txbUserNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStudyRoom2Hours
            // 
            this.btnStudyRoom2Hours.Location = new System.Drawing.Point(40, 29);
            this.btnStudyRoom2Hours.Name = "btnStudyRoom2Hours";
            this.btnStudyRoom2Hours.Size = new System.Drawing.Size(90, 71);
            this.btnStudyRoom2Hours.TabIndex = 0;
            this.btnStudyRoom2Hours.Text = "2시간";
            this.btnStudyRoom2Hours.UseVisualStyleBackColor = true;
            // 
            // btnStudyRoom4Hours
            // 
            this.btnStudyRoom4Hours.Location = new System.Drawing.Point(150, 29);
            this.btnStudyRoom4Hours.Name = "btnStudyRoom4Hours";
            this.btnStudyRoom4Hours.Size = new System.Drawing.Size(90, 71);
            this.btnStudyRoom4Hours.TabIndex = 0;
            this.btnStudyRoom4Hours.Text = "4시간";
            this.btnStudyRoom4Hours.UseVisualStyleBackColor = true;
            // 
            // btnStudyRoom6Hours
            // 
            this.btnStudyRoom6Hours.Location = new System.Drawing.Point(40, 130);
            this.btnStudyRoom6Hours.Name = "btnStudyRoom6Hours";
            this.btnStudyRoom6Hours.Size = new System.Drawing.Size(90, 71);
            this.btnStudyRoom6Hours.TabIndex = 0;
            this.btnStudyRoom6Hours.Text = "6시간";
            this.btnStudyRoom6Hours.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(480, 265);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(75, 58);
            this.btnPurchase.TabIndex = 10;
            this.btnPurchase.Text = "결제";
            this.btnPurchase.UseVisualStyleBackColor = true;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(385, 265);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 58);
            this.btnAddToCart.TabIndex = 11;
            this.btnAddToCart.Text = "추가선택";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(287, 265);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(75, 58);
            this.btnMainMenu.TabIndex = 12;
            this.btnMainMenu.Text = "메인메뉴";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(401, 159);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(154, 25);
            this.txbPrice.TabIndex = 7;
            // 
            // txbChargingTime
            // 
            this.txbChargingTime.Location = new System.Drawing.Point(401, 108);
            this.txbChargingTime.Name = "txbChargingTime";
            this.txbChargingTime.Size = new System.Drawing.Size(154, 25);
            this.txbChargingTime.TabIndex = 8;
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.Location = new System.Drawing.Point(401, 39);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.Size = new System.Drawing.Size(154, 25);
            this.txbUserNumber.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "결제금액";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "회원번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "이용권종류";
            // 
            // StudyRoomTimeChargingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbChargingTime);
            this.Controls.Add(this.txbUserNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStudyRoom6Hours);
            this.Controls.Add(this.btnStudyRoom4Hours);
            this.Controls.Add(this.btnStudyRoom2Hours);
            this.Name = "StudyRoomTimeChargingForm";
            this.Text = "StudyRoomTimeChargingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudyRoom2Hours;
        private System.Windows.Forms.Button btnStudyRoom4Hours;
        private System.Windows.Forms.Button btnStudyRoom6Hours;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbChargingTime;
        private System.Windows.Forms.TextBox txbUserNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}