﻿
namespace WindowsFormsApp1
{
    partial class SeatTimeChargingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeatTimeChargingForm));
            this.txbUserNumber = new System.Windows.Forms.TextBox();
            this.txbItemName = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSeattimeCart = new System.Windows.Forms.Button();
            this.rbtn2Hours = new System.Windows.Forms.RadioButton();
            this.rbtn5Hours = new System.Windows.Forms.RadioButton();
            this.rbtn12Hours = new System.Windows.Forms.RadioButton();
            this.rbtn30Hours = new System.Windows.Forms.RadioButton();
            this.rbtn60Hours = new System.Windows.Forms.RadioButton();
            this.rbtn100Hours = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbUserNumber.Location = new System.Drawing.Point(149, 10);
            this.txbUserNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.Size = new System.Drawing.Size(175, 25);
            this.txbUserNumber.TabIndex = 2;
            // 
            // txbItemName
            // 
            this.txbItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbItemName.Location = new System.Drawing.Point(149, 73);
            this.txbItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbItemName.Name = "txbItemName";
            this.txbItemName.Size = new System.Drawing.Size(175, 25);
            this.txbItemName.TabIndex = 2;
            // 
            // txbPrice
            // 
            this.txbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPrice.Location = new System.Drawing.Point(149, 136);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(175, 25);
            this.txbPrice.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(409, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(167, 41);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSeattimeCart
            // 
            this.btnSeattimeCart.BackColor = System.Drawing.Color.Transparent;
            this.btnSeattimeCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeattimeCart.BackgroundImage")));
            this.btnSeattimeCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeattimeCart.FlatAppearance.BorderSize = 0;
            this.btnSeattimeCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeattimeCart.Location = new System.Drawing.Point(593, 2);
            this.btnSeattimeCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeattimeCart.Name = "btnSeattimeCart";
            this.btnSeattimeCart.Size = new System.Drawing.Size(159, 41);
            this.btnSeattimeCart.TabIndex = 3;
            this.btnSeattimeCart.Text = "담기";
            this.btnSeattimeCart.UseVisualStyleBackColor = false;
            this.btnSeattimeCart.Click += new System.EventHandler(this.btnPurchase_Click);
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
            this.rbtn2Hours.ForeColor = System.Drawing.Color.Black;
            this.rbtn2Hours.Location = new System.Drawing.Point(3, 2);
            this.rbtn2Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn2Hours.Name = "rbtn2Hours";
            this.rbtn2Hours.Size = new System.Drawing.Size(124, 65);
            this.rbtn2Hours.TabIndex = 4;
            this.rbtn2Hours.TabStop = true;
            this.rbtn2Hours.Tag = "1";
            this.rbtn2Hours.Text = "2시간";
            this.rbtn2Hours.UseVisualStyleBackColor = false;
            this.rbtn2Hours.Click += new System.EventHandler(this.btn_Click);
            // 
            // rbtn5Hours
            // 
            this.rbtn5Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn5Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn5Hours.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtn5Hours.BackgroundImage")));
            this.rbtn5Hours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtn5Hours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn5Hours.FlatAppearance.BorderSize = 0;
            this.rbtn5Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn5Hours.ForeColor = System.Drawing.Color.Black;
            this.rbtn5Hours.Location = new System.Drawing.Point(133, 2);
            this.rbtn5Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn5Hours.Name = "rbtn5Hours";
            this.rbtn5Hours.Size = new System.Drawing.Size(121, 65);
            this.rbtn5Hours.TabIndex = 4;
            this.rbtn5Hours.TabStop = true;
            this.rbtn5Hours.Tag = "2";
            this.rbtn5Hours.Text = "5시간";
            this.rbtn5Hours.UseVisualStyleBackColor = false;
            this.rbtn5Hours.Click += new System.EventHandler(this.btn_Click);
            // 
            // rbtn12Hours
            // 
            this.rbtn12Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn12Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn12Hours.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtn12Hours.BackgroundImage")));
            this.rbtn12Hours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtn12Hours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn12Hours.FlatAppearance.BorderSize = 0;
            this.rbtn12Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn12Hours.ForeColor = System.Drawing.Color.Black;
            this.rbtn12Hours.Location = new System.Drawing.Point(3, 71);
            this.rbtn12Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn12Hours.Name = "rbtn12Hours";
            this.rbtn12Hours.Size = new System.Drawing.Size(124, 65);
            this.rbtn12Hours.TabIndex = 4;
            this.rbtn12Hours.TabStop = true;
            this.rbtn12Hours.Tag = "3";
            this.rbtn12Hours.Text = "12시간";
            this.rbtn12Hours.UseVisualStyleBackColor = false;
            this.rbtn12Hours.Click += new System.EventHandler(this.btn_Click);
            // 
            // rbtn30Hours
            // 
            this.rbtn30Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn30Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn30Hours.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtn30Hours.BackgroundImage")));
            this.rbtn30Hours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtn30Hours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn30Hours.FlatAppearance.BorderSize = 0;
            this.rbtn30Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn30Hours.ForeColor = System.Drawing.Color.Black;
            this.rbtn30Hours.Location = new System.Drawing.Point(133, 71);
            this.rbtn30Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn30Hours.Name = "rbtn30Hours";
            this.rbtn30Hours.Size = new System.Drawing.Size(121, 65);
            this.rbtn30Hours.TabIndex = 4;
            this.rbtn30Hours.TabStop = true;
            this.rbtn30Hours.Tag = "4";
            this.rbtn30Hours.Text = "30시간";
            this.rbtn30Hours.UseVisualStyleBackColor = false;
            this.rbtn30Hours.Click += new System.EventHandler(this.btn_Click);
            // 
            // rbtn60Hours
            // 
            this.rbtn60Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn60Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn60Hours.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtn60Hours.BackgroundImage")));
            this.rbtn60Hours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtn60Hours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn60Hours.FlatAppearance.BorderSize = 0;
            this.rbtn60Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn60Hours.ForeColor = System.Drawing.Color.Black;
            this.rbtn60Hours.Location = new System.Drawing.Point(3, 140);
            this.rbtn60Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn60Hours.Name = "rbtn60Hours";
            this.rbtn60Hours.Size = new System.Drawing.Size(124, 66);
            this.rbtn60Hours.TabIndex = 4;
            this.rbtn60Hours.TabStop = true;
            this.rbtn60Hours.Tag = "5";
            this.rbtn60Hours.Text = "60시간";
            this.rbtn60Hours.UseVisualStyleBackColor = false;
            this.rbtn60Hours.Click += new System.EventHandler(this.btn_Click);
            // 
            // rbtn100Hours
            // 
            this.rbtn100Hours.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn100Hours.BackColor = System.Drawing.Color.Transparent;
            this.rbtn100Hours.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtn100Hours.BackgroundImage")));
            this.rbtn100Hours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtn100Hours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn100Hours.FlatAppearance.BorderSize = 0;
            this.rbtn100Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn100Hours.ForeColor = System.Drawing.Color.Black;
            this.rbtn100Hours.Location = new System.Drawing.Point(133, 140);
            this.rbtn100Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn100Hours.Name = "rbtn100Hours";
            this.rbtn100Hours.Size = new System.Drawing.Size(121, 66);
            this.rbtn100Hours.TabIndex = 4;
            this.rbtn100Hours.TabStop = true;
            this.rbtn100Hours.Tag = "6";
            this.rbtn100Hours.Text = "100시간";
            this.rbtn100Hours.UseVisualStyleBackColor = false;
            this.rbtn100Hours.Click += new System.EventHandler(this.btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.611111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.235294F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.88235F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.83333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.111111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 339);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.08069F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.585014F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.62248F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.440922F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.04611F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.440922F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.18156F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.478261F));
            this.tableLayoutPanel2.Controls.Add(this.btnSeattimeCart, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBack, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 268);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 45);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.42939F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.5706F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 44);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(788, 216);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.91743F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.08257F));
            this.tableLayoutPanel4.Controls.Add(this.rbtn100Hours, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.rbtn30Hours, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.rbtn12Hours, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.rbtn5Hours, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.rbtn2Hours, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rbtn60Hours, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(257, 208);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.22757F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.01094F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.76149F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txbUserNumber, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.txbPrice, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.txbItemName, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(266, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.255319F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.42553F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.42553F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.42553F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.978724F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6383F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(519, 208);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "UserNumber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "ItemName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Price";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.33334F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.66667F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // SeatTimeChargingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.SeatTimeChargingForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel6);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SeatTimeChargingForm";
            this.Text = "SeatTimeChargingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbUserNumber;
        private System.Windows.Forms.TextBox txbItemName;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSeattimeCart;
        private System.Windows.Forms.RadioButton rbtn2Hours;
        private System.Windows.Forms.RadioButton rbtn5Hours;
        private System.Windows.Forms.RadioButton rbtn12Hours;
        private System.Windows.Forms.RadioButton rbtn30Hours;
        private System.Windows.Forms.RadioButton rbtn60Hours;
        private System.Windows.Forms.RadioButton rbtn100Hours;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}