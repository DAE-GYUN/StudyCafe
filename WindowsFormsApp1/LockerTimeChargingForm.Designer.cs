
namespace WindowsFormsApp1
{
    partial class LockerTimeChargingForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnPayMent = new System.Windows.Forms.Button();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbRemainTime = new System.Windows.Forms.TextBox();
            this.txbUserNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn1Month = new System.Windows.Forms.Button();
            this.btn3Week = new System.Windows.Forms.Button();
            this.btn1Week = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(570, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 58);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(475, 312);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 58);
            this.btnAddToCart.TabIndex = 17;
            this.btnAddToCart.Text = "추가선택";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnPayMent
            // 
            this.btnPayMent.Location = new System.Drawing.Point(377, 312);
            this.btnPayMent.Name = "btnPayMent";
            this.btnPayMent.Size = new System.Drawing.Size(75, 58);
            this.btnPayMent.TabIndex = 18;
            this.btnPayMent.Text = "결제";
            this.btnPayMent.UseVisualStyleBackColor = true;
            this.btnPayMent.Click += new System.EventHandler(this.btnPayMent_Click);
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(491, 190);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(154, 25);
            this.txbPrice.TabIndex = 13;
            // 
            // txbRemainTime
            // 
            this.txbRemainTime.Location = new System.Drawing.Point(491, 155);
            this.txbRemainTime.Name = "txbRemainTime";
            this.txbRemainTime.Size = new System.Drawing.Size(154, 25);
            this.txbRemainTime.TabIndex = 14;
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.Location = new System.Drawing.Point(491, 86);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.Size = new System.Drawing.Size(154, 25);
            this.txbUserNumber.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "결제금액";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "회원번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "이용권";
            // 
            // btn1Month
            // 
            this.btn1Month.Location = new System.Drawing.Point(109, 147);
            this.btn1Month.Name = "btn1Month";
            this.btn1Month.Size = new System.Drawing.Size(75, 61);
            this.btn1Month.TabIndex = 6;
            this.btn1Month.Text = "한달";
            this.btn1Month.UseVisualStyleBackColor = true;
            this.btn1Month.Click += new System.EventHandler(this.btn1Month_Click);
            // 
            // btn3Week
            // 
            this.btn3Week.Location = new System.Drawing.Point(214, 66);
            this.btn3Week.Name = "btn3Week";
            this.btn3Week.Size = new System.Drawing.Size(75, 61);
            this.btn3Week.TabIndex = 8;
            this.btn3Week.Text = "3주";
            this.btn3Week.UseVisualStyleBackColor = true;
            this.btn3Week.Click += new System.EventHandler(this.btn3Week_Click);
            // 
            // btn1Week
            // 
            this.btn1Week.Location = new System.Drawing.Point(109, 66);
            this.btn1Week.Name = "btn1Week";
            this.btn1Week.Size = new System.Drawing.Size(75, 61);
            this.btn1Week.TabIndex = 9;
            this.btn1Week.Text = "1주일";
            this.btn1Week.UseVisualStyleBackColor = true;
            this.btn1Week.Click += new System.EventHandler(this.btn1Week_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "사물함 잔여시간";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(491, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 25);
            this.textBox1.TabIndex = 14;
            // 
            // LockerTimeChargingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnPayMent);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txbRemainTime);
            this.Controls.Add(this.txbUserNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1Month);
            this.Controls.Add(this.btn3Week);
            this.Controls.Add(this.btn1Week);
            this.Name = "LockerTimeChargingForm";
            this.Text = "LockerTimeChargingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnPayMent;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbRemainTime;
        private System.Windows.Forms.TextBox txbUserNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1Month;
        private System.Windows.Forms.Button btn3Week;
        private System.Windows.Forms.Button btn1Week;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}