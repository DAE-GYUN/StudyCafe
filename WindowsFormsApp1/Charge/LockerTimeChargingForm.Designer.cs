
namespace WindowsFormsApp1
{
    partial class LockerTimeChargingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockerTimeChargingForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnPayMent = new System.Windows.Forms.Button();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbRemainTime = new System.Windows.Forms.TextBox();
            this.txbUserNumber = new System.Windows.Forms.TextBox();
            this.btn1Month = new System.Windows.Forms.Button();
            this.btn3Week = new System.Windows.Forms.Button();
            this.btn1Week = new System.Windows.Forms.Button();
            this.txbLockerRemainTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uscItem = new WindowsFormsApp1.PaymentControl();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(571, 231);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(189, 76);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.BackgroundImage")));
            this.btnAddToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Location = new System.Drawing.Point(381, 231);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(185, 76);
            this.btnAddToCart.TabIndex = 17;
            this.btnAddToCart.Text = "추가선택";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnPayMent
            // 
            this.btnPayMent.BackColor = System.Drawing.Color.Transparent;
            this.btnPayMent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPayMent.BackgroundImage")));
            this.btnPayMent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayMent.FlatAppearance.BorderSize = 0;
            this.btnPayMent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayMent.Location = new System.Drawing.Point(193, 231);
            this.btnPayMent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayMent.Name = "btnPayMent";
            this.btnPayMent.Size = new System.Drawing.Size(179, 76);
            this.btnPayMent.TabIndex = 18;
            this.btnPayMent.Text = "결제";
            this.btnPayMent.UseVisualStyleBackColor = false;
            this.btnPayMent.Click += new System.EventHandler(this.btnPayMent_Click);
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(323, 184);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(154, 25);
            this.txbPrice.TabIndex = 13;
            // 
            // txbRemainTime
            // 
            this.txbRemainTime.Location = new System.Drawing.Point(323, 131);
            this.txbRemainTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbRemainTime.Name = "txbRemainTime";
            this.txbRemainTime.Size = new System.Drawing.Size(154, 25);
            this.txbRemainTime.TabIndex = 14;
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.Location = new System.Drawing.Point(323, 42);
            this.txbUserNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.Size = new System.Drawing.Size(154, 25);
            this.txbUserNumber.TabIndex = 15;
            // 
            // btn1Month
            // 
            this.btn1Month.BackColor = System.Drawing.Color.Transparent;
            this.btn1Month.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1Month.BackgroundImage")));
            this.btn1Month.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1Month.FlatAppearance.BorderSize = 0;
            this.btn1Month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1Month.Location = new System.Drawing.Point(15, 102);
            this.btn1Month.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1Month.Name = "btn1Month";
            this.btn1Month.Size = new System.Drawing.Size(117, 61);
            this.btn1Month.TabIndex = 6;
            this.btn1Month.Tag = "11";
            this.btn1Month.Text = "한달";
            this.btn1Month.UseVisualStyleBackColor = false;
            this.btn1Month.Click += new System.EventHandler(this.btn1Month_Click);
            // 
            // btn3Week
            // 
            this.btn3Week.BackColor = System.Drawing.Color.Transparent;
            this.btn3Week.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3Week.BackgroundImage")));
            this.btn3Week.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3Week.FlatAppearance.BorderSize = 0;
            this.btn3Week.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3Week.Location = new System.Drawing.Point(15, 191);
            this.btn3Week.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3Week.Name = "btn3Week";
            this.btn3Week.Size = new System.Drawing.Size(117, 61);
            this.btn3Week.TabIndex = 8;
            this.btn3Week.Tag = "12";
            this.btn3Week.Text = "3주";
            this.btn3Week.UseVisualStyleBackColor = false;
            this.btn3Week.Click += new System.EventHandler(this.btn3Week_Click);
            // 
            // btn1Week
            // 
            this.btn1Week.BackColor = System.Drawing.Color.Transparent;
            this.btn1Week.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1Week.BackgroundImage")));
            this.btn1Week.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1Week.FlatAppearance.BorderSize = 0;
            this.btn1Week.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1Week.Location = new System.Drawing.Point(15, 21);
            this.btn1Week.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1Week.Name = "btn1Week";
            this.btn1Week.Size = new System.Drawing.Size(117, 61);
            this.btn1Week.TabIndex = 9;
            this.btn1Week.Tag = "10";
            this.btn1Week.Text = "1주일";
            this.btn1Week.UseVisualStyleBackColor = false;
            this.btn1Week.Click += new System.EventHandler(this.btn1Week_Click);
            // 
            // txbLockerRemainTime
            // 
            this.txbLockerRemainTime.Location = new System.Drawing.Point(323, 85);
            this.txbLockerRemainTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLockerRemainTime.Name = "txbLockerRemainTime";
            this.txbLockerRemainTime.Size = new System.Drawing.Size(154, 25);
            this.txbLockerRemainTime.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn1Week);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btn3Week);
            this.groupBox1.Controls.Add(this.btnAddToCart);
            this.groupBox1.Controls.Add(this.btn1Month);
            this.groupBox1.Controls.Add(this.btnPayMent);
            this.groupBox1.Controls.Add(this.txbUserNumber);
            this.groupBox1.Controls.Add(this.txbPrice);
            this.groupBox1.Controls.Add(this.txbRemainTime);
            this.groupBox1.Controls.Add(this.txbLockerRemainTime);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(794, 320);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uscItem, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // uscItem
            // 
            this.uscItem.Location = new System.Drawing.Point(3, 326);
            this.uscItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uscItem.Name = "uscItem";
            this.uscItem.Size = new System.Drawing.Size(793, 120);
            this.uscItem.TabIndex = 20;
            this.uscItem.Load += new System.EventHandler(this.paymentControl1_Load);
            // 
            // LockerTimeChargingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.LockerTimeCharge;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LockerTimeChargingForm";
            this.Text = "LockerTimeChargingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnPayMent;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbRemainTime;
        private System.Windows.Forms.TextBox txbUserNumber;
        private System.Windows.Forms.Button btn1Month;
        private System.Windows.Forms.Button btn3Week;
        private System.Windows.Forms.Button btn1Week;
        private System.Windows.Forms.TextBox txbLockerRemainTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PaymentControl uscItem;
    }
}