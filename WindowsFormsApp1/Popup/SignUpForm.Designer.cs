﻿
namespace WindowsFormsApp1
{
    partial class SignUpForm
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbUserPhoneNumber = new System.Windows.Forms.TextBox();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.btnSnapshot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Location = new System.Drawing.Point(446, 350);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(148, 75);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(600, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 75);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(404, 166);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(167, 25);
            this.txbUserName.TabIndex = 3;
            this.txbUserName.Text = "010";
            // 
            // txbUserPhoneNumber
            // 
            this.txbUserPhoneNumber.Location = new System.Drawing.Point(404, 230);
            this.txbUserPhoneNumber.MaxLength = 11;
            this.txbUserPhoneNumber.Name = "txbUserPhoneNumber";
            this.txbUserPhoneNumber.Size = new System.Drawing.Size(167, 25);
            this.txbUserPhoneNumber.TabIndex = 3;
            // 
            // pbUserImage
            // 
            this.pbUserImage.Image = global::WindowsFormsApp1.Properties.Resources.iconfinder_229_woman_gesturing_OK_2_3099350;
            this.pbUserImage.Location = new System.Drawing.Point(57, 136);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(164, 152);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserImage.TabIndex = 2;
            this.pbUserImage.TabStop = false;
            // 
            // btnSnapshot
            // 
            this.btnSnapshot.Location = new System.Drawing.Point(57, 310);
            this.btnSnapshot.Name = "btnSnapshot";
            this.btnSnapshot.Size = new System.Drawing.Size(164, 37);
            this.btnSnapshot.TabIndex = 4;
            this.btnSnapshot.Text = "사진촬영";
            this.btnSnapshot.UseVisualStyleBackColor = true;
            this.btnSnapshot.Click += new System.EventHandler(this.btnSnapshot_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.SignUp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSnapshot);
            this.Controls.Add(this.txbUserPhoneNumber);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.pbUserImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSignUp);
            this.DoubleBuffered = true;
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbUserImage;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbUserPhoneNumber;
        private System.Windows.Forms.Button btnSnapshot;
    }
}