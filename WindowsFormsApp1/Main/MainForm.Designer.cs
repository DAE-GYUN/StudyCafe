
namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUserNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbRemainTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnShiftSeat = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Black;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.Yellow;
            this.btnCheckIn.Location = new System.Drawing.Point(94, 229);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(100, 80);
            this.btnCheckIn.TabIndex = 0;
            this.btnCheckIn.Text = "좌석";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(167, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = "이성혁 법률사무소";
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.Location = new System.Drawing.Point(294, 357);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.ReadOnly = true;
            this.txbUserNumber.Size = new System.Drawing.Size(159, 25);
            this.txbUserNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(134, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "회원번호";
            // 
            // txbRemainTime
            // 
            this.txbRemainTime.Location = new System.Drawing.Point(294, 433);
            this.txbRemainTime.Name = "txbRemainTime";
            this.txbRemainTime.ReadOnly = true;
            this.txbRemainTime.Size = new System.Drawing.Size(159, 25);
            this.txbRemainTime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(134, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "잔여시간";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.ForeColor = System.Drawing.Color.Yellow;
            this.btnLogout.Location = new System.Drawing.Point(503, 420);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(101, 47);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "로그아웃";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Black;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Yellow;
            this.btnCheckOut.Location = new System.Drawing.Point(244, 229);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(100, 80);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "퇴실";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnShiftSeat
            // 
            this.btnShiftSeat.BackColor = System.Drawing.Color.Black;
            this.btnShiftSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnShiftSeat.ForeColor = System.Drawing.Color.Yellow;
            this.btnShiftSeat.Location = new System.Drawing.Point(400, 229);
            this.btnShiftSeat.Name = "btnShiftSeat";
            this.btnShiftSeat.Size = new System.Drawing.Size(100, 80);
            this.btnShiftSeat.TabIndex = 6;
            this.btnShiftSeat.Text = "자리이동";
            this.btnShiftSeat.UseVisualStyleBackColor = false;
            this.btnShiftSeat.Click += new System.EventHandler(this.btnShiftSeat_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Black;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPurchase.ForeColor = System.Drawing.Color.Yellow;
            this.btnPurchase.Location = new System.Drawing.Point(553, 229);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(100, 80);
            this.btnPurchase.TabIndex = 7;
            this.btnPurchase.Text = "구매";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 529);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnShiftSeat);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbRemainTime);
            this.Controls.Add(this.txbUserNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckIn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUserNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbRemainTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnShiftSeat;
        private System.Windows.Forms.Button btnPurchase;
    }
}