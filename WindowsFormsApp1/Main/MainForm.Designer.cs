
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
            this.btnCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.Yellow;
            this.btnCheckIn.Location = new System.Drawing.Point(14, 182);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(143, 74);
            this.btnCheckIn.TabIndex = 0;
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.Location = new System.Drawing.Point(257, 286);
            this.txbUserNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.ReadOnly = true;
            this.txbUserNumber.Size = new System.Drawing.Size(140, 21);
            this.txbUserNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gulim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(117, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "회원번호";
            // 
            // txbRemainTime
            // 
            this.txbRemainTime.Location = new System.Drawing.Point(257, 346);
            this.txbRemainTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbRemainTime.Name = "txbRemainTime";
            this.txbRemainTime.ReadOnly = true;
            this.txbRemainTime.Size = new System.Drawing.Size(140, 21);
            this.txbRemainTime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gulim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(117, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "잔여시간";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Yellow;
            this.btnLogout.Location = new System.Drawing.Point(451, 337);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(146, 75);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Yellow;
            this.btnCheckOut.Location = new System.Drawing.Point(163, 183);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(147, 73);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnShiftSeat
            // 
            this.btnShiftSeat.BackColor = System.Drawing.Color.Transparent;
            this.btnShiftSeat.FlatAppearance.BorderSize = 0;
            this.btnShiftSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShiftSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnShiftSeat.ForeColor = System.Drawing.Color.Yellow;
            this.btnShiftSeat.Location = new System.Drawing.Point(316, 183);
            this.btnShiftSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShiftSeat.Name = "btnShiftSeat";
            this.btnShiftSeat.Size = new System.Drawing.Size(138, 73);
            this.btnShiftSeat.TabIndex = 6;
            this.btnShiftSeat.UseVisualStyleBackColor = false;
            this.btnShiftSeat.Click += new System.EventHandler(this.btnShiftSeat_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPurchase.ForeColor = System.Drawing.Color.Yellow;
            this.btnPurchase.Location = new System.Drawing.Point(460, 183);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(146, 73);
            this.btnPurchase.TabIndex = 7;
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(618, 423);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnShiftSeat);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbRemainTime);
            this.Controls.Add(this.txbUserNumber);
            this.Controls.Add(this.btnCheckIn);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckIn;
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