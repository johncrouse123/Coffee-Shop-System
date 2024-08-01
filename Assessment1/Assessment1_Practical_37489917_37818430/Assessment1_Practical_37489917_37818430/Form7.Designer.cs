
namespace Assessment1_Practical_37489917_37818430
{
    partial class frmAccounting
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
            this.lblAccountingTitle = new System.Windows.Forms.Label();
            this.dgvAccounting = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounting)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountingTitle
            // 
            this.lblAccountingTitle.AutoSize = true;
            this.lblAccountingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountingTitle.Location = new System.Drawing.Point(375, 25);
            this.lblAccountingTitle.Name = "lblAccountingTitle";
            this.lblAccountingTitle.Size = new System.Drawing.Size(519, 82);
            this.lblAccountingTitle.TabIndex = 9;
            this.lblAccountingTitle.Text = "ACCOUNTING";
            // 
            // dgvAccounting
            // 
            this.dgvAccounting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounting.Location = new System.Drawing.Point(12, 109);
            this.dgvAccounting.Name = "dgvAccounting";
            this.dgvAccounting.RowHeadersWidth = 62;
            this.dgvAccounting.RowTemplate.Height = 28;
            this.dgvAccounting.Size = new System.Drawing.Size(1249, 493);
            this.dgvAccounting.TabIndex = 10;
            // 
            // frmAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 614);
            this.Controls.Add(this.dgvAccounting);
            this.Controls.Add(this.lblAccountingTitle);
            this.Name = "frmAccounting";
            this.Text = "Accounting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountingTitle;
        private System.Windows.Forms.DataGridView dgvAccounting;
    }
}