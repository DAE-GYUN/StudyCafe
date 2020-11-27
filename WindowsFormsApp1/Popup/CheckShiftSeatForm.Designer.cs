
namespace WindowsFormsApp1
{
    partial class CheckShiftSeatForm
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
            this.txbMovedSeatNumber = new System.Windows.Forms.TextBox();
            this.txbNowSeatNumber = new System.Windows.Forms.TextBox();
            this.txbUserNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(599, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 74);
            this.btnCancel.TabIndex = 11;
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
            this.btnCheckIn.Size = new System.Drawing.Size(148, 74);
            this.btnCheckIn.TabIndex = 12;
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // txbRemainTime
            // 
            this.txbRemainTime.BackColor = System.Drawing.Color.White;
            this.txbRemainTime.Location = new System.Drawing.Point(306, 161);
            this.txbRemainTime.Name = "txbRemainTime";
            this.txbRemainTime.ReadOnly = true;
            this.txbRemainTime.Size = new System.Drawing.Size(177, 25);
            this.txbRemainTime.TabIndex = 7;
            // 
            // txbMovedSeatNumber
            // 
            this.txbMovedSeatNumber.BackColor = System.Drawing.Color.White;
            this.txbMovedSeatNumber.Location = new System.Drawing.Point(306, 252);
            this.txbMovedSeatNumber.Name = "txbMovedSeatNumber";
            this.txbMovedSeatNumber.ReadOnly = true;
            this.txbMovedSeatNumber.Size = new System.Drawing.Size(177, 25);
            this.txbMovedSeatNumber.TabIndex = 8;
            // 
            // txbNowSeatNumber
            // 
            this.txbNowSeatNumber.BackColor = System.Drawing.Color.White;
            this.txbNowSeatNumber.Location = new System.Drawing.Point(306, 201);
            this.txbNowSeatNumber.Name = "txbNowSeatNumber";
            this.txbNowSeatNumber.ReadOnly = true;
            this.txbNowSeatNumber.Size = new System.Drawing.Size(177, 25);
            this.txbNowSeatNumber.TabIndex = 9;
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.BackColor = System.Drawing.Color.White;
            this.txbUserNumber.Location = new System.Drawing.Point(306, 112);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.ReadOnly = true;
            this.txbUserNumber.Size = new System.Drawing.Size(177, 25);
            this.txbUserNumber.TabIndex = 10;
            // 
            // CheckShiftSeatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.CheckShiftSeatForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txbRemainTime);
            this.Controls.Add(this.txbMovedSeatNumber);
            this.Controls.Add(this.txbNowSeatNumber);
            this.Controls.Add(this.txbUserNumber);
            this.DoubleBuffered = true;
            this.Name = "CheckShiftSeatForm";
            this.Text = "CheckShiftSeatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.TextBox txbRemainTime;
        private System.Windows.Forms.TextBox txbMovedSeatNumber;
        private System.Windows.Forms.TextBox txbNowSeatNumber;
        private System.Windows.Forms.TextBox txbUserNumber;
    }
}