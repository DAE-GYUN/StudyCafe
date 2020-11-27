
namespace WindowsFormsApp1.Popup
{
    partial class SnapshotForm
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
            this.UserImage = new System.Windows.Forms.PictureBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnTakeSnapshot = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserImage
            // 
            this.UserImage.BackColor = System.Drawing.Color.Transparent;
            this.UserImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserImage.Location = new System.Drawing.Point(25, 33);
            this.UserImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserImage.Name = "UserImage";
            this.UserImage.Size = new System.Drawing.Size(514, 294);
            this.UserImage.TabIndex = 1;
            this.UserImage.TabStop = false;
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitch.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Button_Style2;
            this.btnSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSwitch.FlatAppearance.BorderSize = 0;
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Location = new System.Drawing.Point(3, 2);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(249, 70);
            this.btnSwitch.TabIndex = 0;
            this.btnSwitch.Text = "Start";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnTakeSnapshot
            // 
            this.btnTakeSnapshot.BackColor = System.Drawing.Color.Transparent;
            this.btnTakeSnapshot.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Button_Style3;
            this.btnTakeSnapshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTakeSnapshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTakeSnapshot.FlatAppearance.BorderSize = 0;
            this.btnTakeSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeSnapshot.Location = new System.Drawing.Point(258, 2);
            this.btnTakeSnapshot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeSnapshot.Name = "btnTakeSnapshot";
            this.btnTakeSnapshot.Size = new System.Drawing.Size(253, 70);
            this.btnTakeSnapshot.TabIndex = 0;
            this.btnTakeSnapshot.Text = "Take Snapshot";
            this.btnTakeSnapshot.UseVisualStyleBackColor = false;
            this.btnTakeSnapshot.Click += new System.EventHandler(this.btnTakeSnapshot_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.123711F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.87629F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Controls.Add(this.UserImage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.422492F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.57751F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(603, 430);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.75124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.24876F));
            this.tableLayoutPanel2.Controls.Add(this.btnSwitch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTakeSnapshot, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(25, 332);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(514, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // SnapshotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.PopupBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 430);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SnapshotForm";
            this.Text = "Snapshot";
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox UserImage;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnTakeSnapshot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}