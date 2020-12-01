
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
            this.btnPhoneNumberCheck = new System.Windows.Forms.Button();
            this.bgwDuplicateCheck = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.Enabled = false;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Location = new System.Drawing.Point(446, 350);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(148, 75);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(600, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 75);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(404, 166);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(167, 25);
            this.txbUserName.TabIndex = 0;
            // 
            // txbUserPhoneNumber
            // 
            this.txbUserPhoneNumber.Location = new System.Drawing.Point(404, 230);
            this.txbUserPhoneNumber.MaxLength = 11;
            this.txbUserPhoneNumber.Name = "txbUserPhoneNumber";
            this.txbUserPhoneNumber.Size = new System.Drawing.Size(167, 25);
            this.txbUserPhoneNumber.TabIndex = 1;
            this.txbUserPhoneNumber.Text = "010";
            // 
            // pbUserImage
            // 
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
            // btnPhoneNumberCheck
            // 
            this.btnPhoneNumberCheck.Location = new System.Drawing.Point(600, 232);
            this.btnPhoneNumberCheck.Name = "btnPhoneNumberCheck";
            this.btnPhoneNumberCheck.Size = new System.Drawing.Size(75, 23);
            this.btnPhoneNumberCheck.TabIndex = 5;
            this.btnPhoneNumberCheck.Text = "중복확인";
            this.btnPhoneNumberCheck.UseVisualStyleBackColor = true;
            this.btnPhoneNumberCheck.Click += new System.EventHandler(this.btnPhoneNumberCheck_Click);
            // 
            // bgwDuplicateCheck
            // 
            this.bgwDuplicateCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDuplicateCheck_DoWork);
            this.bgwDuplicateCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDuplicateCheck_RunWorkerCompleted);
            // 
            // SignUpForm
            // 
            this.AcceptButton = this.btnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.SignUp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPhoneNumberCheck);
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
        private System.Windows.Forms.Button btnPhoneNumberCheck;
        private System.ComponentModel.BackgroundWorker bgwDuplicateCheck;
    }
}