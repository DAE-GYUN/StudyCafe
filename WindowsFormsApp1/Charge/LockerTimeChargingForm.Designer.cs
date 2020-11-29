
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
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnPayMent = new System.Windows.Forms.Button();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbUserNumber = new System.Windows.Forms.TextBox();
            this.btn1Month = new System.Windows.Forms.Button();
            this.btn3Week = new System.Windows.Forms.Button();
            this.btn1Week = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbRemainTime = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txbLockerRemainTime = new System.Windows.Forms.TextBox();
            this.uscItem = new WindowsFormsApp1.PaymentControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 

            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.BackgroundImage")));
            this.btnAddToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddToCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnAddToCart.Location = new System.Drawing.Point(181, 2);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(172, 62);
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
            this.btnPayMent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPayMent.FlatAppearance.BorderSize = 0;
            this.btnPayMent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnPayMent.Location = new System.Drawing.Point(3, 2);
            this.btnPayMent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayMent.Name = "btnPayMent";
            this.btnPayMent.Size = new System.Drawing.Size(172, 62);

            this.btnPayMent.TabIndex = 18;
            this.btnPayMent.Text = "결제";
            this.btnPayMent.UseVisualStyleBackColor = false;
            this.btnPayMent.Click += new System.EventHandler(this.btnPayMent_Click);
            // 
            // txbPrice
            // 
            this.txbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPrice.Location = new System.Drawing.Point(134, 143);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(97, 21);
            this.txbPrice.TabIndex = 13;
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbUserNumber.Location = new System.Drawing.Point(134, 22);
            this.txbUserNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.Size = new System.Drawing.Size(97, 21);

            this.txbUserNumber.TabIndex = 15;
            // 
            // btn1Month
            // 
            this.btn1Month.BackColor = System.Drawing.Color.Transparent;
            this.btn1Month.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1Month.BackgroundImage")));
            this.btn1Month.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1Month.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1Month.FlatAppearance.BorderSize = 0;
            this.btn1Month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1Month.Location = new System.Drawing.Point(3, 166);
            this.btn1Month.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1Month.Name = "btn1Month";
            this.btn1Month.Size = new System.Drawing.Size(125, 79);

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
            this.btn3Week.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3Week.FlatAppearance.BorderSize = 0;
            this.btn3Week.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3Week.Location = new System.Drawing.Point(3, 84);
            this.btn3Week.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3Week.Name = "btn3Week";
            this.btn3Week.Size = new System.Drawing.Size(125, 78);

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
            this.btn1Week.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1Week.FlatAppearance.BorderSize = 0;
            this.btn1Week.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1Week.Location = new System.Drawing.Point(3, 2);
            this.btn1Week.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1Week.Name = "btn1Week";
            this.btn1Week.Size = new System.Drawing.Size(125, 78);

            this.btn1Week.TabIndex = 9;
            this.btn1Week.Tag = "10";
            this.btn1Week.Text = "1주일";
            this.btn1Week.UseVisualStyleBackColor = false;
            this.btn1Week.Click += new System.EventHandler(this.btn1Week_Click);
            //
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.uscItem, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.03746F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.96254F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(694, 253);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.714286F));
            this.tableLayoutPanel3.Controls.Add(this.btn1Week, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn3Week, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn1Month, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(140, 247);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(149, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.8502F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.1498F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(542, 247);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnPayMent, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnAddToCart, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 178);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(536, 66);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(359, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(174, 62);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbRemainTime
            // 
            this.txbRemainTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbRemainTime.Location = new System.Drawing.Point(134, 96);
            this.txbRemainTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbRemainTime.Name = "txbRemainTime";
            this.txbRemainTime.Size = new System.Drawing.Size(97, 21);
            this.txbRemainTime.TabIndex = 14;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.62687F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.40298F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.54478F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.79851F));
            this.tableLayoutPanel6.Controls.Add(this.txbPrice, 1, 7);
            this.tableLayoutPanel6.Controls.Add(this.txbRemainTime, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.txbLockerRemainTime, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.txbUserNumber, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 8;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.56805F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.508876F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.20118F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.87574F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.20118F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.7929F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.97633F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(536, 169);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // txbLockerRemainTime
            // 
            this.txbLockerRemainTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbLockerRemainTime.Location = new System.Drawing.Point(134, 59);
            this.txbLockerRemainTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLockerRemainTime.Name = "txbLockerRemainTime";
            this.txbLockerRemainTime.Size = new System.Drawing.Size(97, 21);
            this.txbLockerRemainTime.TabIndex = 16;
            // 
            // uscItem
            // 
            this.uscItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscItem.Location = new System.Drawing.Point(3, 261);
            this.uscItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uscItem.Name = "uscItem";
            this.uscItem.Size = new System.Drawing.Size(694, 97);
            this.uscItem.TabIndex = 20;
            this.uscItem.Load += new System.EventHandler(this.paymentControl1_Load);
            // 
            // LockerTimeChargingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.LockerTimeCharge__2_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LockerTimeChargingForm";
            this.Text = "LockerTimeChargingForm";

            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnPayMent;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbUserNumber;
        private System.Windows.Forms.Button btn1Month;
        private System.Windows.Forms.Button btn3Week;
        private System.Windows.Forms.Button btn1Week;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PaymentControl uscItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox txbRemainTime;
        private System.Windows.Forms.TextBox txbLockerRemainTime;
    }
}