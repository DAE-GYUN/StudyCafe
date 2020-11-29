
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            this.btnSeetTimeCharnging = new System.Windows.Forms.Button();
            this.btnStudyRoom = new System.Windows.Forms.Button();
            this.btnLockers = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.paymentControl1 = new WindowsFormsApp1.PaymentControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeetTimeCharnging
            // 
            this.btnSeetTimeCharnging.BackColor = System.Drawing.Color.Transparent;
            this.btnSeetTimeCharnging.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeetTimeCharnging.BackgroundImage")));
            this.btnSeetTimeCharnging.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeetTimeCharnging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeetTimeCharnging.FlatAppearance.BorderSize = 0;
            this.btnSeetTimeCharnging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeetTimeCharnging.Location = new System.Drawing.Point(3, 82);
            this.btnSeetTimeCharnging.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeetTimeCharnging.Name = "btnSeetTimeCharnging";
            this.btnSeetTimeCharnging.Size = new System.Drawing.Size(167, 64);
            this.btnSeetTimeCharnging.TabIndex = 1;
            this.btnSeetTimeCharnging.Text = "시간설정";
            this.btnSeetTimeCharnging.UseVisualStyleBackColor = false;
            this.btnSeetTimeCharnging.Click += new System.EventHandler(this.btnSeetTimeCharnging_Click);
            // 
            // btnStudyRoom
            // 
            this.btnStudyRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnStudyRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStudyRoom.BackgroundImage")));
            this.btnStudyRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudyRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStudyRoom.FlatAppearance.BorderSize = 0;
            this.btnStudyRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudyRoom.Location = new System.Drawing.Point(176, 82);
            this.btnStudyRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudyRoom.Name = "btnStudyRoom";
            this.btnStudyRoom.Size = new System.Drawing.Size(167, 64);
            this.btnStudyRoom.TabIndex = 1;
            this.btnStudyRoom.Text = "스터디룸";
            this.btnStudyRoom.UseVisualStyleBackColor = false;
            this.btnStudyRoom.Click += new System.EventHandler(this.btnStudyRoom_Click);
            // 
            // btnLockers
            // 
            this.btnLockers.BackColor = System.Drawing.Color.Transparent;
            this.btnLockers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLockers.BackgroundImage")));
            this.btnLockers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLockers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLockers.FlatAppearance.BorderSize = 0;
            this.btnLockers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockers.Location = new System.Drawing.Point(349, 82);
            this.btnLockers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLockers.Name = "btnLockers";
            this.btnLockers.Size = new System.Drawing.Size(167, 64);
            this.btnLockers.TabIndex = 1;
            this.btnLockers.Text = "사물함";
            this.btnLockers.UseVisualStyleBackColor = false;
            this.btnLockers.Click += new System.EventHandler(this.btnLockers_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Transparent;
            this.btnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMain.BackgroundImage")));
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Location = new System.Drawing.Point(522, 82);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(169, 64);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "메인화면";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.paymentControl1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.94444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 360);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // paymentControl1
            // 
            this.paymentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentControl1.Location = new System.Drawing.Point(3, 271);
            this.paymentControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentControl1.Name = "paymentControl1";
            this.paymentControl1.Size = new System.Drawing.Size(694, 87);
            this.paymentControl1.TabIndex = 3;
            this.paymentControl1.Load += new System.EventHandler(this.paymentControl1_Load);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnMain, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnSeetTimeCharnging, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnLockers, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnStudyRoom, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 75);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(694, 148);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(694, 66);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Title;
            this.pictureBox1.Location = new System.Drawing.Point(107, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PurchaseForm";
            this.Text = "PurchaseForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSeetTimeCharnging;
        private System.Windows.Forms.Button btnStudyRoom;
        private System.Windows.Forms.Button btnLockers;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PaymentControl paymentControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}