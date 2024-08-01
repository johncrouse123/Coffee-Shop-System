
namespace Assessment1_Practical_37489917_37818430
{
    partial class frmReports
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
            this.lblReportsTitle = new System.Windows.Forms.Label();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.hsbProfit = new System.Windows.Forms.HScrollBar();
            this.hsbQuantity = new System.Windows.Forms.HScrollBar();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReportsTitle
            // 
            this.lblReportsTitle.AutoSize = true;
            this.lblReportsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportsTitle.Location = new System.Drawing.Point(295, 9);
            this.lblReportsTitle.Name = "lblReportsTitle";
            this.lblReportsTitle.Size = new System.Drawing.Size(714, 82);
            this.lblReportsTitle.TabIndex = 10;
            this.lblReportsTitle.Text = "CUSTOM REPORTS";
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(26, 94);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersWidth = 62;
            this.dgvReports.RowTemplate.Height = 28;
            this.dgvReports.Size = new System.Drawing.Size(1249, 347);
            this.dgvReports.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(52, 481);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(249, 29);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Search by Item Name:";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.Location = new System.Drawing.Point(52, 539);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(188, 29);
            this.lblProfit.TabIndex = 13;
            this.lblProfit.Text = "Search by Profit:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(690, 481);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(219, 29);
            this.lblQuantity.TabIndex = 14;
            this.lblQuantity.Text = "Search by Quantity:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(690, 536);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(188, 29);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Search by Time:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(332, 481);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 26);
            this.txtName.TabIndex = 16;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(946, 536);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(217, 26);
            this.txtTime.TabIndex = 17;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // hsbProfit
            // 
            this.hsbProfit.Location = new System.Drawing.Point(332, 539);
            this.hsbProfit.Name = "hsbProfit";
            this.hsbProfit.Size = new System.Drawing.Size(217, 26);
            this.hsbProfit.TabIndex = 18;
            this.hsbProfit.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbProfit_Scroll);
            // 
            // hsbQuantity
            // 
            this.hsbQuantity.Location = new System.Drawing.Point(946, 481);
            this.hsbQuantity.Name = "hsbQuantity";
            this.hsbQuantity.Size = new System.Drawing.Size(217, 26);
            this.hsbQuantity.TabIndex = 19;
            this.hsbQuantity.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbQuantity_Scroll);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(568, 546);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(51, 20);
            this.lblNum1.TabIndex = 20;
            this.lblNum1.Text = "label1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(1194, 484);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(51, 20);
            this.lblNum2.TabIndex = 21;
            this.lblNum2.Text = "label2";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 624);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.hsbQuantity);
            this.Controls.Add(this.hsbProfit);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.lblReportsTitle);
            this.Name = "frmReports";
            this.Text = "Custom Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportsTitle;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.HScrollBar hsbProfit;
        private System.Windows.Forms.HScrollBar hsbQuantity;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
    }
}