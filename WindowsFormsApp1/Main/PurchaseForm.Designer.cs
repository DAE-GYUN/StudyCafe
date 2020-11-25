
namespace WindowsFormsApp1
{
    partial class PurchaseForm
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
            this.btnSeetTimeCharnging = new System.Windows.Forms.Button();
            this.btnStudyRoom = new System.Windows.Forms.Button();
            this.btnLockers = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSeetTimeCharnging
            // 
            this.btnSeetTimeCharnging.BackColor = System.Drawing.Color.Transparent;
            this.btnSeetTimeCharnging.FlatAppearance.BorderSize = 0;
            this.btnSeetTimeCharnging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeetTimeCharnging.Location = new System.Drawing.Point(102, 195);
            this.btnSeetTimeCharnging.Name = "btnSeetTimeCharnging";
            this.btnSeetTimeCharnging.Size = new System.Drawing.Size(180, 81);
            this.btnSeetTimeCharnging.TabIndex = 1;
            this.btnSeetTimeCharnging.Text = "시간설정";
            this.btnSeetTimeCharnging.UseVisualStyleBackColor = false;
            this.btnSeetTimeCharnging.Click += new System.EventHandler(this.btnSeetTimeCharnging_Click);
            // 
            // btnStudyRoom
            // 
            this.btnStudyRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnStudyRoom.FlatAppearance.BorderSize = 0;
            this.btnStudyRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudyRoom.Location = new System.Drawing.Point(325, 195);
            this.btnStudyRoom.Name = "btnStudyRoom";
            this.btnStudyRoom.Size = new System.Drawing.Size(181, 81);
            this.btnStudyRoom.TabIndex = 1;
            this.btnStudyRoom.Text = "스터디룸";
            this.btnStudyRoom.UseVisualStyleBackColor = false;
            this.btnStudyRoom.Click += new System.EventHandler(this.btnStudyRoom_Click);
            // 
            // btnLockers
            // 
            this.btnLockers.BackColor = System.Drawing.Color.Transparent;
            this.btnLockers.FlatAppearance.BorderSize = 0;
            this.btnLockers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockers.Location = new System.Drawing.Point(546, 195);
            this.btnLockers.Name = "btnLockers";
            this.btnLockers.Size = new System.Drawing.Size(183, 81);
            this.btnLockers.TabIndex = 1;
            this.btnLockers.Text = "사물함";
            this.btnLockers.UseVisualStyleBackColor = false;
            this.btnLockers.Click += new System.EventHandler(this.btnLockers_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Transparent;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Location = new System.Drawing.Point(592, 358);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(183, 80);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "메인화면";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.purchaseform;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnLockers);
            this.Controls.Add(this.btnStudyRoom);
            this.Controls.Add(this.btnSeetTimeCharnging);
            this.DoubleBuffered = true;
            this.Name = "PurchaseForm";
            this.Text = "PurchaseForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSeetTimeCharnging;
        private System.Windows.Forms.Button btnStudyRoom;
        private System.Windows.Forms.Button btnLockers;
        private System.Windows.Forms.Button btnMain;
    }
}