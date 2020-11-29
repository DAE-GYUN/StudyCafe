
namespace WindowsFormsApp1
{
    partial class StudyRoomTimeChargingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyRoomTimeChargingForm));
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbChargingTime = new System.Windows.Forms.TextBox();
            this.txbUserNumber = new System.Windows.Forms.TextBox();
            this.txbRoomNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn6Hour = new System.Windows.Forms.Button();
            this.btn4Hour = new System.Windows.Forms.Button();
            this.btn2Hour = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.uscItem = new WindowsFormsApp1.PaymentControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPurchase.BackgroundImage")));
            this.btnPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Location = new System.Drawing.Point(582, 2);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(179, 46);
            this.btnPurchase.TabIndex = 10;
            this.btnPurchase.Text = "결제";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.BackgroundImage")));
            this.btnAddToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddToCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Location = new System.Drawing.Point(395, 2);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(181, 46);
            this.btnAddToCart.TabIndex = 11;
            this.btnAddToCart.Text = "추가선택";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(210, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(179, 46);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txbPrice
            // 
            this.txbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPrice.Location = new System.Drawing.Point(3, 147);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(148, 25);
            this.txbPrice.TabIndex = 7;
            // 
            // txbChargingTime
            // 
            this.txbChargingTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbChargingTime.Location = new System.Drawing.Point(3, 56);
            this.txbChargingTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbChargingTime.Name = "txbChargingTime";
            this.txbChargingTime.Size = new System.Drawing.Size(148, 25);
            this.txbChargingTime.TabIndex = 8;
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbUserNumber.Location = new System.Drawing.Point(3, 14);
            this.txbUserNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.Size = new System.Drawing.Size(148, 25);
            this.txbUserNumber.TabIndex = 9;
            // 
            // txbRoomNumber
            // 
            this.txbRoomNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbRoomNumber.Location = new System.Drawing.Point(3, 103);
            this.txbRoomNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbRoomNumber.Name = "txbRoomNumber";
            this.txbRoomNumber.Size = new System.Drawing.Size(148, 25);
            this.txbRoomNumber.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "스터디룸번호";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.303725F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.91404F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.833333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 329);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.602305F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.83285F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.0634F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.4611F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.47262F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 222);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txbUserNumber, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txbChargingTime, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txbPrice, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.txbRoomNumber, 0, 6);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(327, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 9;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.517242F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.142858F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42857F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.571429F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.714286F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.42857F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.142857F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(154, 218);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn6Hour);
            this.groupBox1.Controls.Add(this.btn4Hour);
            this.groupBox1.Controls.Add(this.btn2Hour);
            this.groupBox1.Location = new System.Drawing.Point(31, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn6Hour
            // 
            this.btn6Hour.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn6Hour.Location = new System.Drawing.Point(6, 135);
            this.btn6Hour.Name = "btn6Hour";
            this.btn6Hour.Size = new System.Drawing.Size(75, 23);
            this.btn6Hour.TabIndex = 0;
            this.btn6Hour.Text = "6시간";
            this.btn6Hour.UseVisualStyleBackColor = true;
            this.btn6Hour.Click += new System.EventHandler(this.btn6Hour_Click);
            // 
            // btn4Hour
            // 
            this.btn4Hour.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn4Hour.Location = new System.Drawing.Point(6, 81);
            this.btn4Hour.Name = "btn4Hour";
            this.btn4Hour.Size = new System.Drawing.Size(75, 23);
            this.btn4Hour.TabIndex = 0;
            this.btn4Hour.Text = "4시간";
            this.btn4Hour.UseVisualStyleBackColor = true;
            this.btn4Hour.Click += new System.EventHandler(this.btn4Hour_Click);
            // 
            // btn2Hour
            // 
            this.btn2Hour.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn2Hour.Location = new System.Drawing.Point(6, 36);
            this.btn2Hour.Name = "btn2Hour";
            this.btn2Hour.Size = new System.Drawing.Size(75, 23);
            this.btn2Hour.TabIndex = 0;
            this.btn2Hour.Text = "2시간";
            this.btn2Hour.UseVisualStyleBackColor = true;
            this.btn2Hour.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.04678F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.26901F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.41521F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.26901F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel5.Controls.Add(this.btnBack, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnPurchase, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnAddToCart, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 254);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(788, 50);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.uscItem, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.11111F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.88889F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel6.TabIndex = 17;
            // 
            // uscItem
            // 
            this.uscItem.Location = new System.Drawing.Point(3, 340);
            this.uscItem.Name = "uscItem";
            this.uscItem.Size = new System.Drawing.Size(794, 106);
            this.uscItem.TabIndex = 17;
            // 
            // StudyRoomTimeChargingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.StudyRoomCharge2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudyRoomTimeChargingForm";
            this.Text = "StudyRoomTimeChargingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbChargingTime;
        private System.Windows.Forms.TextBox txbUserNumber;
        private System.Windows.Forms.TextBox txbRoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private PaymentControl uscItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn2Hour;
        private System.Windows.Forms.Button btn6Hour;
        private System.Windows.Forms.Button btn4Hour;
    }
}