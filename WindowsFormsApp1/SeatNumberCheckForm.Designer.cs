
namespace WindowsFormsApp1
{
    partial class SeatNumberCheckForm
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
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.txbRemainTime = new System.Windows.Forms.TextBox();
            this.txbSelectSeatNumber = new System.Windows.Forms.TextBox();
            this.txbUserNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(387, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 42);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(194, 291);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(87, 42);
            this.btnCheckIn.TabIndex = 22;
            this.btnCheckIn.Text = "입실";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // txbRemainTime
            // 
            this.txbRemainTime.Location = new System.Drawing.Point(301, 196);
            this.txbRemainTime.Name = "txbRemainTime";
            this.txbRemainTime.ReadOnly = true;
            this.txbRemainTime.Size = new System.Drawing.Size(177, 25);
            this.txbRemainTime.TabIndex = 17;
            // 
            // txbSelectSeatNumber
            // 
            this.txbSelectSeatNumber.Location = new System.Drawing.Point(301, 124);
            this.txbSelectSeatNumber.Name = "txbSelectSeatNumber";
            this.txbSelectSeatNumber.ReadOnly = true;
            this.txbSelectSeatNumber.Size = new System.Drawing.Size(177, 25);
            this.txbSelectSeatNumber.TabIndex = 19;
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.Location = new System.Drawing.Point(301, 61);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.ReadOnly = true;
            this.txbUserNumber.Size = new System.Drawing.Size(177, 25);
            this.txbUserNumber.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "잔여시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "좌석번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "회원번호";
            // 
            // SeatNumberCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txbRemainTime);
            this.Controls.Add(this.txbSelectSeatNumber);
            this.Controls.Add(this.txbUserNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SeatNumberCheckForm";
            this.Text = "SeatNumberCheckForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.TextBox txbRemainTime;
        private System.Windows.Forms.TextBox txbSelectSeatNumber;
        private System.Windows.Forms.TextBox txbUserNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}