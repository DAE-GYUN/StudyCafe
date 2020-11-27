
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.paymentControl1 = new WindowsFormsApp1.PaymentControl();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeetTimeCharnging
            // 
            this.btnSeetTimeCharnging.BackColor = System.Drawing.Color.Transparent;
            this.btnSeetTimeCharnging.FlatAppearance.BorderSize = 0;
            this.btnSeetTimeCharnging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeetTimeCharnging.Location = new System.Drawing.Point(79, 107);
            this.btnSeetTimeCharnging.Name = "btnSeetTimeCharnging";
            this.btnSeetTimeCharnging.Size = new System.Drawing.Size(160, 72);
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
            this.btnStudyRoom.Location = new System.Drawing.Point(297, 107);
            this.btnStudyRoom.Name = "btnStudyRoom";
            this.btnStudyRoom.Size = new System.Drawing.Size(161, 72);
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
            this.btnLockers.Location = new System.Drawing.Point(511, 107);
            this.btnLockers.Name = "btnLockers";
            this.btnLockers.Size = new System.Drawing.Size(163, 72);
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
            this.btnMain.Location = new System.Drawing.Point(533, 235);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(163, 71);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "메인화면";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeetTimeCharnging);
            this.groupBox1.Controls.Add(this.btnMain);
            this.groupBox1.Controls.Add(this.btnStudyRoom);
            this.groupBox1.Controls.Add(this.btnLockers);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 312);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.paymentControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // paymentControl1
            // 
            this.paymentControl1.Location = new System.Drawing.Point(3, 321);
            this.paymentControl1.Name = "paymentControl1";
            this.paymentControl1.Size = new System.Drawing.Size(794, 126);
            this.paymentControl1.TabIndex = 3;
            this.paymentControl1.Load += new System.EventHandler(this.paymentControl1_Load);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "PurchaseForm";
            this.Text = "PurchaseForm";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSeetTimeCharnging;
        private System.Windows.Forms.Button btnStudyRoom;
        private System.Windows.Forms.Button btnLockers;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PaymentControl paymentControl1;
    }
}