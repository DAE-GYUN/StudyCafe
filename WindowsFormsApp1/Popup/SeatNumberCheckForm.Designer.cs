
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
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(595, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 74);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Location = new System.Drawing.Point(445, 352);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(144, 74);
            this.btnCheckIn.TabIndex = 22;
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // txbRemainTime
            // 
            this.txbRemainTime.BackColor = System.Drawing.Color.White;
            this.txbRemainTime.Location = new System.Drawing.Point(303, 156);
            this.txbRemainTime.Name = "txbRemainTime";
            this.txbRemainTime.ReadOnly = true;
            this.txbRemainTime.Size = new System.Drawing.Size(177, 25);
            this.txbRemainTime.TabIndex = 17;
            // 
            // txbSelectSeatNumber
            // 
            this.txbSelectSeatNumber.BackColor = System.Drawing.Color.White;
            this.txbSelectSeatNumber.Location = new System.Drawing.Point(303, 201);
            this.txbSelectSeatNumber.Name = "txbSelectSeatNumber";
            this.txbSelectSeatNumber.ReadOnly = true;
            this.txbSelectSeatNumber.Size = new System.Drawing.Size(177, 25);
            this.txbSelectSeatNumber.TabIndex = 19;
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.BackColor = System.Drawing.Color.White;
            this.txbUserNumber.Location = new System.Drawing.Point(303, 114);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.ReadOnly = true;
            this.txbUserNumber.Size = new System.Drawing.Size(177, 25);
            this.txbUserNumber.TabIndex = 20;
            // 
            // SeatNumberCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.SeatNumberCheckForm1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txbRemainTime);
            this.Controls.Add(this.txbSelectSeatNumber);
            this.Controls.Add(this.txbUserNumber);
            this.DoubleBuffered = true;
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
    }
}