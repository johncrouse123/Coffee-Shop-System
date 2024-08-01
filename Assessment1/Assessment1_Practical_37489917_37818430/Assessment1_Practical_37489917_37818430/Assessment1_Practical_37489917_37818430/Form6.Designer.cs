
namespace Assessment1_Practical_37489917_37818430
{
    partial class frmCart
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
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.lstbReceipt = new System.Windows.Forms.ListBox();
            this.dgvBeverages = new System.Windows.Forms.DataGridView();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.lblRemoveBeverage = new System.Windows.Forms.Label();
            this.lblRemoveFood = new System.Windows.Forms.Label();
            this.cmbRemoveBeverage = new System.Windows.Forms.ComboBox();
            this.cmbRemoveFood = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbCoffee = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeverages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCartTitle
            // 
            this.lblCartTitle.AutoSize = true;
            this.lblCartTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCartTitle.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCartTitle.Location = new System.Drawing.Point(322, 26);
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.Size = new System.Drawing.Size(321, 116);
            this.lblCartTitle.TabIndex = 4;
            this.lblCartTitle.Text = "CART";
            // 
            // lstbReceipt
            // 
            this.lstbReceipt.FormattingEnabled = true;
            this.lstbReceipt.ItemHeight = 20;
            this.lstbReceipt.Location = new System.Drawing.Point(1125, 185);
            this.lstbReceipt.Name = "lstbReceipt";
            this.lstbReceipt.Size = new System.Drawing.Size(458, 444);
            this.lstbReceipt.TabIndex = 6;
            // 
            // dgvBeverages
            // 
            this.dgvBeverages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeverages.Location = new System.Drawing.Point(12, 185);
            this.dgvBeverages.Name = "dgvBeverages";
            this.dgvBeverages.RowHeadersWidth = 62;
            this.dgvBeverages.RowTemplate.Height = 28;
            this.dgvBeverages.Size = new System.Drawing.Size(750, 208);
            this.dgvBeverages.TabIndex = 8;
            // 
            // dgvFood
            // 
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(12, 410);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersWidth = 62;
            this.dgvFood.RowTemplate.Height = 28;
            this.dgvFood.Size = new System.Drawing.Size(750, 214);
            this.dgvFood.TabIndex = 11;
            // 
            // btnReceipt
            // 
            this.btnReceipt.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.DarkRed;
            this.btnReceipt.Location = new System.Drawing.Point(1231, 66);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(264, 100);
            this.btnReceipt.TabIndex = 12;
            this.btnReceipt.Text = "Print Receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // lblRemoveBeverage
            // 
            this.lblRemoveBeverage.AutoSize = true;
            this.lblRemoveBeverage.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveBeverage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRemoveBeverage.Location = new System.Drawing.Point(785, 185);
            this.lblRemoveBeverage.Name = "lblRemoveBeverage";
            this.lblRemoveBeverage.Size = new System.Drawing.Size(304, 38);
            this.lblRemoveBeverage.TabIndex = 13;
            this.lblRemoveBeverage.Text = "Remove Beverage:";
            // 
            // lblRemoveFood
            // 
            this.lblRemoveFood.AutoSize = true;
            this.lblRemoveFood.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveFood.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRemoveFood.Location = new System.Drawing.Point(785, 410);
            this.lblRemoveFood.Name = "lblRemoveFood";
            this.lblRemoveFood.Size = new System.Drawing.Size(234, 38);
            this.lblRemoveFood.TabIndex = 14;
            this.lblRemoveFood.Text = "Remove Food:";
            // 
            // cmbRemoveBeverage
            // 
            this.cmbRemoveBeverage.FormattingEnabled = true;
            this.cmbRemoveBeverage.Location = new System.Drawing.Point(792, 244);
            this.cmbRemoveBeverage.Name = "cmbRemoveBeverage";
            this.cmbRemoveBeverage.Size = new System.Drawing.Size(227, 28);
            this.cmbRemoveBeverage.TabIndex = 15;
            this.cmbRemoveBeverage.SelectedIndexChanged += new System.EventHandler(this.cmbRemoveBeverage_SelectedIndexChanged);
            // 
            // cmbRemoveFood
            // 
            this.cmbRemoveFood.FormattingEnabled = true;
            this.cmbRemoveFood.Location = new System.Drawing.Point(792, 468);
            this.cmbRemoveFood.Name = "cmbRemoveFood";
            this.cmbRemoveFood.Size = new System.Drawing.Size(227, 28);
            this.cmbRemoveFood.TabIndex = 16;
            this.cmbRemoveFood.SelectedIndexChanged += new System.EventHandler(this.cmbRemoveFood_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assessment1_Practical_37489917_37818430.Properties.Resources.CoffeeLekker;
            this.pictureBox1.Location = new System.Drawing.Point(676, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pcbCoffee
            // 
            this.pcbCoffee.Image = global::Assessment1_Practical_37489917_37818430.Properties.Resources.CoffeeLekker;
            this.pcbCoffee.Location = new System.Drawing.Point(50, 26);
            this.pcbCoffee.Name = "pcbCoffee";
            this.pcbCoffee.Size = new System.Drawing.Size(255, 140);
            this.pcbCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCoffee.TabIndex = 7;
            this.pcbCoffee.TabStop = false;
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbRemoveFood);
            this.Controls.Add(this.cmbRemoveBeverage);
            this.Controls.Add(this.lblRemoveFood);
            this.Controls.Add(this.lblRemoveBeverage);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.dgvBeverages);
            this.Controls.Add(this.pcbCoffee);
            this.Controls.Add(this.lstbReceipt);
            this.Controls.Add(this.lblCartTitle);
            this.Name = "frmCart";
            this.Text = "CART";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeverages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoffee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.ListBox lstbReceipt;
        private System.Windows.Forms.PictureBox pcbCoffee;
        private System.Windows.Forms.DataGridView dgvBeverages;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Label lblRemoveBeverage;
        private System.Windows.Forms.Label lblRemoveFood;
        public System.Windows.Forms.ComboBox cmbRemoveBeverage;
        public System.Windows.Forms.ComboBox cmbRemoveFood;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}