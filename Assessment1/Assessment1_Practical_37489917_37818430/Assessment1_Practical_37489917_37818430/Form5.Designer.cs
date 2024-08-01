
namespace Assessment1_Practical_37489917_37818430
{
    partial class frmSandwiches
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
            this.lblSandwichesTitle = new System.Windows.Forms.Label();
            this.lblSandwichesType = new System.Windows.Forms.Label();
            this.cmbSandwichesType = new System.Windows.Forms.ComboBox();
            this.lblSandwichesQuantity = new System.Windows.Forms.Label();
            this.nudSandwichesQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnSandwichesAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSandwichesQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSandwichesTitle
            // 
            this.lblSandwichesTitle.AutoSize = true;
            this.lblSandwichesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSandwichesTitle.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSandwichesTitle.ForeColor = System.Drawing.Color.White;
            this.lblSandwichesTitle.Location = new System.Drawing.Point(332, 46);
            this.lblSandwichesTitle.Name = "lblSandwichesTitle";
            this.lblSandwichesTitle.Size = new System.Drawing.Size(560, 87);
            this.lblSandwichesTitle.TabIndex = 3;
            this.lblSandwichesTitle.Text = "SANDWICHES";
            // 
            // lblSandwichesType
            // 
            this.lblSandwichesType.AutoSize = true;
            this.lblSandwichesType.BackColor = System.Drawing.Color.Transparent;
            this.lblSandwichesType.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSandwichesType.ForeColor = System.Drawing.Color.White;
            this.lblSandwichesType.Location = new System.Drawing.Point(150, 212);
            this.lblSandwichesType.Name = "lblSandwichesType";
            this.lblSandwichesType.Size = new System.Drawing.Size(203, 36);
            this.lblSandwichesType.TabIndex = 4;
            this.lblSandwichesType.Text = "Sandwiches:";
            // 
            // cmbSandwichesType
            // 
            this.cmbSandwichesType.FormattingEnabled = true;
            this.cmbSandwichesType.Items.AddRange(new object[] {
            "ChickenMayo",
            "Egg Sandwich",
            "Tuna Sandwich",
            "Roast Beef",
            "GrilledCheese"});
            this.cmbSandwichesType.Location = new System.Drawing.Point(387, 220);
            this.cmbSandwichesType.Name = "cmbSandwichesType";
            this.cmbSandwichesType.Size = new System.Drawing.Size(191, 28);
            this.cmbSandwichesType.TabIndex = 6;
            // 
            // lblSandwichesQuantity
            // 
            this.lblSandwichesQuantity.AutoSize = true;
            this.lblSandwichesQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblSandwichesQuantity.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSandwichesQuantity.ForeColor = System.Drawing.Color.White;
            this.lblSandwichesQuantity.Location = new System.Drawing.Point(150, 313);
            this.lblSandwichesQuantity.Name = "lblSandwichesQuantity";
            this.lblSandwichesQuantity.Size = new System.Drawing.Size(194, 36);
            this.lblSandwichesQuantity.TabIndex = 7;
            this.lblSandwichesQuantity.Text = "How many?";
            // 
            // nudSandwichesQuantity
            // 
            this.nudSandwichesQuantity.Location = new System.Drawing.Point(387, 325);
            this.nudSandwichesQuantity.Name = "nudSandwichesQuantity";
            this.nudSandwichesQuantity.Size = new System.Drawing.Size(191, 26);
            this.nudSandwichesQuantity.TabIndex = 13;
            // 
            // btnSandwichesAdd
            // 
            this.btnSandwichesAdd.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSandwichesAdd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSandwichesAdd.Location = new System.Drawing.Point(478, 489);
            this.btnSandwichesAdd.Name = "btnSandwichesAdd";
            this.btnSandwichesAdd.Size = new System.Drawing.Size(226, 73);
            this.btnSandwichesAdd.TabIndex = 14;
            this.btnSandwichesAdd.Text = "Add To Cart";
            this.btnSandwichesAdd.UseVisualStyleBackColor = true;
            this.btnSandwichesAdd.Click += new System.EventHandler(this.btnSandwichesAdd_Click);
            // 
            // frmSandwiches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assessment1_Practical_37489917_37818430.Properties.Resources.Sandwiches;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2314, 1158);
            this.Controls.Add(this.btnSandwichesAdd);
            this.Controls.Add(this.nudSandwichesQuantity);
            this.Controls.Add(this.lblSandwichesQuantity);
            this.Controls.Add(this.cmbSandwichesType);
            this.Controls.Add(this.lblSandwichesType);
            this.Controls.Add(this.lblSandwichesTitle);
            this.Name = "frmSandwiches";
            this.Text = "Sandwiches";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSandwiches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSandwichesQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSandwichesTitle;
        private System.Windows.Forms.Label lblSandwichesType;
        private System.Windows.Forms.ComboBox cmbSandwichesType;
        private System.Windows.Forms.Label lblSandwichesQuantity;
        private System.Windows.Forms.NumericUpDown nudSandwichesQuantity;
        private System.Windows.Forms.Button btnSandwichesAdd;
    }
}