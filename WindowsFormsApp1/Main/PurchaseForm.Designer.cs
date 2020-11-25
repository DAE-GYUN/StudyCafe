
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeetTimeCharnging = new System.Windows.Forms.Button();
            this.btnStudyRoom = new System.Windows.Forms.Button();
            this.btnLockers = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(229, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "이성혁 법률사무소";
            // 
            // btnSeetTimeCharnging
            // 
            this.btnSeetTimeCharnging.Location = new System.Drawing.Point(237, 209);
            this.btnSeetTimeCharnging.Name = "btnSeetTimeCharnging";
            this.btnSeetTimeCharnging.Size = new System.Drawing.Size(75, 67);
            this.btnSeetTimeCharnging.TabIndex = 1;
            this.btnSeetTimeCharnging.Text = "시간설정";
            this.btnSeetTimeCharnging.UseVisualStyleBackColor = true;
            this.btnSeetTimeCharnging.Click += new System.EventHandler(this.btnSeetTimeCharnging_Click);
            // 
            // btnStudyRoom
            // 
            this.btnStudyRoom.Location = new System.Drawing.Point(369, 209);
            this.btnStudyRoom.Name = "btnStudyRoom";
            this.btnStudyRoom.Size = new System.Drawing.Size(75, 67);
            this.btnStudyRoom.TabIndex = 1;
            this.btnStudyRoom.Text = "스터디룸";
            this.btnStudyRoom.UseVisualStyleBackColor = true;
            this.btnStudyRoom.Click += new System.EventHandler(this.btnStudyRoom_Click);
            // 
            // btnLockers
            // 
            this.btnLockers.Location = new System.Drawing.Point(507, 209);
            this.btnLockers.Name = "btnLockers";
            this.btnLockers.Size = new System.Drawing.Size(75, 67);
            this.btnLockers.TabIndex = 1;
            this.btnLockers.Text = "사물함";
            this.btnLockers.UseVisualStyleBackColor = true;
            this.btnLockers.Click += new System.EventHandler(this.btnLockers_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(621, 352);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 67);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "메인화면";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnLockers);
            this.Controls.Add(this.btnStudyRoom);
            this.Controls.Add(this.btnSeetTimeCharnging);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseForm";
            this.Text = "PurchaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeetTimeCharnging;
        private System.Windows.Forms.Button btnStudyRoom;
        private System.Windows.Forms.Button btnLockers;
        private System.Windows.Forms.Button btnMain;
    }
}