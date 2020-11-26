
namespace WindowsFormsApp1
{
    partial class PaymentForm
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
            this.txbUserNumber = new System.Windows.Forms.TextBox();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.txbCart = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbUserNumber
            // 
            this.txbUserNumber.Location = new System.Drawing.Point(303, 122);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.Size = new System.Drawing.Size(198, 25);
            this.txbUserNumber.TabIndex = 0;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(303, 298);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(198, 25);
            this.txbTotalPrice.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(600, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 73);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Location = new System.Drawing.Point(445, 352);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(149, 73);
            this.btnPurchase.TabIndex = 2;
            this.btnPurchase.UseVisualStyleBackColor = false;
            // 
            // txbCart
            // 
            this.txbCart.Location = new System.Drawing.Point(303, 167);
            this.txbCart.Multiline = true;
            this.txbCart.Name = "txbCart";
            this.txbCart.Size = new System.Drawing.Size(198, 79);
            this.txbCart.TabIndex = 3;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.PaymentForm1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbCart);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txbTotalPrice);
            this.Controls.Add(this.txbUserNumber);
            this.DoubleBuffered = true;
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUserNumber;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.TextBox txbCart;
    }
}