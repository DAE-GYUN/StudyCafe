
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
            this.rbtn2Hours = new System.Windows.Forms.RadioButton();
            this.rbtn4Hours = new System.Windows.Forms.RadioButton();
            this.rbtn6Hours = new System.Windows.Forms.RadioButton();
            this.txbRoomNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            this.btnPurchase.Location = new System.Drawing.Point(521, 2);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(160, 54);
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
            this.btnAddToCart.Location = new System.Drawing.Point(354, 2);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(161, 54);
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
            this.btnBack.Location = new System.Drawing.Point(188, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 54);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txbPrice
            // 
            this.txbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPrice.Location = new System.Drawing.Point(3, 119);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(129, 21);
            this.txbPrice.TabIndex = 7;
            // 
            // txbChargingTime
            // 
            this.txbChargingTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbChargingTime.Location = new System.Drawing.Point(3, 45);
            this.txbChargingTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbChargingTime.Name = "txbChargingTime";
            this.txbChargingTime.Size = new System.Drawing.Size(129, 21);
            this.txbChargingTime.TabIndex = 8;
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbUserNumber.Location = new System.Drawing.Point(3, 11);
            this.txbUserNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.Size = new System.Drawing.Size(129, 21);
            this.txbUserNumber.TabIndex = 9;
            // 
            // rbtn2Hours
            // 
            this.rbtn2Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn2Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn2Hours.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtn2Hours.BackgroundImage")));
            this.rbtn2Hours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtn2Hours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn2Hours.FlatAppearance.BorderSize = 0;
            this.rbtn2Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn2Hours.Location = new System.Drawing.Point(3, 2);
            this.rbtn2Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn2Hours.Name = "rbtn2Hours";
            this.rbtn2Hours.Size = new System.Drawing.Size(83, 43);
            this.rbtn2Hours.TabIndex = 4;
            this.rbtn2Hours.TabStop = true;
            this.rbtn2Hours.Tag = "15000";
            this.rbtn2Hours.Text = "2시간";
            this.rbtn2Hours.UseVisualStyleBackColor = false;
            this.rbtn2Hours.Click += new System.EventHandler(this.btnSelectItem_Click);
            // 
            // rbtn4Hours
            // 
            this.rbtn4Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn4Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn4Hours.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtn4Hours.BackgroundImage")));
            this.rbtn4Hours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtn4Hours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn4Hours.FlatAppearance.BorderSize = 0;
            this.rbtn4Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn4Hours.Location = new System.Drawing.Point(3, 65);
            this.rbtn4Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn4Hours.Name = "rbtn4Hours";
            this.rbtn4Hours.Size = new System.Drawing.Size(83, 46);
            this.rbtn4Hours.TabIndex = 4;
            this.rbtn4Hours.TabStop = true;
            this.rbtn4Hours.Tag = "50000";
            this.rbtn4Hours.Text = "4시간";
            this.rbtn4Hours.UseVisualStyleBackColor = false;
            this.rbtn4Hours.Click += new System.EventHandler(this.btnSelectItem_Click);
            // 
            // rbtn6Hours
            // 
            this.rbtn6Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn6Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn6Hours.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtn6Hours.BackgroundImage")));
            this.rbtn6Hours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtn6Hours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn6Hours.FlatAppearance.BorderSize = 0;
            this.rbtn6Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn6Hours.Location = new System.Drawing.Point(3, 131);
            this.rbtn6Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn6Hours.Name = "rbtn6Hours";
            this.rbtn6Hours.Size = new System.Drawing.Size(83, 42);
            this.rbtn6Hours.TabIndex = 4;
            this.rbtn6Hours.TabStop = true;
            this.rbtn6Hours.Tag = "30000";
            this.rbtn6Hours.Text = "6시간";
            this.rbtn6Hours.UseVisualStyleBackColor = false;
            this.rbtn6Hours.Click += new System.EventHandler(this.btnSelectItem_Click);
            // 
            // txbRoomNumber
            // 
            this.txbRoomNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbRoomNumber.Location = new System.Drawing.Point(3, 83);
            this.txbRoomNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbRoomNumber.Name = "txbRoomNumber";
            this.txbRoomNumber.Size = new System.Drawing.Size(129, 21);
            this.txbRoomNumber.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.16667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.94444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.833333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 360);
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 90);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(694, 181);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.rbtn2Hours, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rbtn4Hours, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.rbtn6Hours, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(27, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.85714F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.142858F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.142858F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.14286F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(89, 175);
            this.tableLayoutPanel3.TabIndex = 0;
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(288, 3);
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
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(135, 175);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.04678F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.26901F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.41521F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.26901F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.Controls.Add(this.btnBack, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnPurchase, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnAddToCart, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 277);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(694, 58);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // StudyRoomTimeChargingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.StudyRoomCharge2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudyRoomTimeChargingForm";
            this.Text = "StudyRoomTimeChargingForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton rbtn2Hours;
        private System.Windows.Forms.RadioButton rbtn4Hours;
        private System.Windows.Forms.RadioButton rbtn6Hours;
        private System.Windows.Forms.TextBox txbRoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}