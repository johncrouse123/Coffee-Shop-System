
namespace Assessment1_Practical_37489917_37818430
{
    partial class frmPastries
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
            this.lblPastriesTitle = new System.Windows.Forms.Label();
            this.lblPastriesType = new System.Windows.Forms.Label();
            this.lblPastriesQuantity = new System.Windows.Forms.Label();
            this.cmbPastriesType = new System.Windows.Forms.ComboBox();
            this.nudPastriesQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnPastriesAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPastriesQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPastriesTitle
            // 
            this.lblPastriesTitle.AutoSize = true;
            this.lblPastriesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPastriesTitle.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastriesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblPastriesTitle.Location = new System.Drawing.Point(402, 9);
            this.lblPastriesTitle.Name = "lblPastriesTitle";
            this.lblPastriesTitle.Size = new System.Drawing.Size(386, 87);
            this.lblPastriesTitle.TabIndex = 2;
            this.lblPastriesTitle.Text = "PASTRIES";
            // 
            // lblPastriesType
            // 
            this.lblPastriesType.AutoSize = true;
            this.lblPastriesType.BackColor = System.Drawing.Color.Transparent;
            this.lblPastriesType.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastriesType.ForeColor = System.Drawing.Color.Black;
            this.lblPastriesType.Location = new System.Drawing.Point(165, 205);
            this.lblPastriesType.Name = "lblPastriesType";
            this.lblPastriesType.Size = new System.Drawing.Size(145, 36);
            this.lblPastriesType.TabIndex = 3;
            this.lblPastriesType.Text = "Pastries:";
            // 
            // lblPastriesQuantity
            // 
            this.lblPastriesQuantity.AutoSize = true;
            this.lblPastriesQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblPastriesQuantity.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastriesQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblPastriesQuantity.Location = new System.Drawing.Point(165, 315);
            this.lblPastriesQuantity.Name = "lblPastriesQuantity";
            this.lblPastriesQuantity.Size = new System.Drawing.Size(194, 36);
            this.lblPastriesQuantity.TabIndex = 4;
            this.lblPastriesQuantity.Text = "How many?";
            // 
            // cmbPastriesType
            // 
            this.cmbPastriesType.FormattingEnabled = true;
            this.cmbPastriesType.Items.AddRange(new object[] {
            "Flaky",
            "Shortcrust",
            "Puff",
            "Donut",
            "Crosant"});
            this.cmbPastriesType.Location = new System.Drawing.Point(393, 213);
            this.cmbPastriesType.Name = "cmbPastriesType";
            this.cmbPastriesType.Size = new System.Drawing.Size(191, 28);
            this.cmbPastriesType.TabIndex = 5;
            // 
            // nudPastriesQuantity
            // 
            this.nudPastriesQuantity.Location = new System.Drawing.Point(393, 325);
            this.nudPastriesQuantity.Name = "nudPastriesQuantity";
            this.nudPastriesQuantity.Size = new System.Drawing.Size(191, 26);
            this.nudPastriesQuantity.TabIndex = 12;
            // 
            // btnPastriesAdd
            // 
            this.btnPastriesAdd.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPastriesAdd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPastriesAdd.Location = new System.Drawing.Point(477, 488);
            this.btnPastriesAdd.Name = "btnPastriesAdd";
            this.btnPastriesAdd.Size = new System.Drawing.Size(226, 73);
            this.btnPastriesAdd.TabIndex = 13;
            this.btnPastriesAdd.Text = "Add To Cart";
            this.btnPastriesAdd.UseVisualStyleBackColor = true;
            this.btnPastriesAdd.Click += new System.EventHandler(this.btnPastriesAdd_Click);
            // 
            // frmPastries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assessment1_Practical_37489917_37818430.Properties.Resources.Pastries1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.btnPastriesAdd);
            this.Controls.Add(this.nudPastriesQuantity);
            this.Controls.Add(this.cmbPastriesType);
            this.Controls.Add(this.lblPastriesQuantity);
            this.Controls.Add(this.lblPastriesType);
            this.Controls.Add(this.lblPastriesTitle);
            this.Name = "frmPastries";
            this.Text = "Pastries";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPastries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPastriesQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPastriesTitle;
        private System.Windows.Forms.Label lblPastriesType;
        private System.Windows.Forms.Label lblPastriesQuantity;
        private System.Windows.Forms.ComboBox cmbPastriesType;
        private System.Windows.Forms.NumericUpDown nudPastriesQuantity;
        private System.Windows.Forms.Button btnPastriesAdd;
    }
}