
namespace Assessment1_Practical_37489917_37818430
{
    partial class frmTea
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
            this.lblTeaTitle = new System.Windows.Forms.Label();
            this.lblTeaType = new System.Windows.Forms.Label();
            this.cmbTeaType = new System.Windows.Forms.ComboBox();
            this.lblTeaSize = new System.Windows.Forms.Label();
            this.rdbTeaSmall = new System.Windows.Forms.RadioButton();
            this.rdbTeaMedium = new System.Windows.Forms.RadioButton();
            this.rdbTeaLarge = new System.Windows.Forms.RadioButton();
            this.lblTeaQuantity = new System.Windows.Forms.Label();
            this.nudTeaQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnTeaAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeaQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeaTitle
            // 
            this.lblTeaTitle.AutoSize = true;
            this.lblTeaTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTeaTitle.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeaTitle.ForeColor = System.Drawing.Color.White;
            this.lblTeaTitle.Location = new System.Drawing.Point(497, 59);
            this.lblTeaTitle.Name = "lblTeaTitle";
            this.lblTeaTitle.Size = new System.Drawing.Size(189, 87);
            this.lblTeaTitle.TabIndex = 1;
            this.lblTeaTitle.Text = "TEA";
            // 
            // lblTeaType
            // 
            this.lblTeaType.AutoSize = true;
            this.lblTeaType.BackColor = System.Drawing.Color.Transparent;
            this.lblTeaType.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeaType.ForeColor = System.Drawing.Color.White;
            this.lblTeaType.Location = new System.Drawing.Point(178, 195);
            this.lblTeaType.Name = "lblTeaType";
            this.lblTeaType.Size = new System.Drawing.Size(78, 36);
            this.lblTeaType.TabIndex = 2;
            this.lblTeaType.Text = "Tea:";
            // 
            // cmbTeaType
            // 
            this.cmbTeaType.FormattingEnabled = true;
            this.cmbTeaType.Items.AddRange(new object[] {
            "Oolong",
            "White",
            "Yellow",
            "Green",
            "Rooibos"});
            this.cmbTeaType.Location = new System.Drawing.Point(380, 206);
            this.cmbTeaType.Name = "cmbTeaType";
            this.cmbTeaType.Size = new System.Drawing.Size(191, 28);
            this.cmbTeaType.TabIndex = 4;
            // 
            // lblTeaSize
            // 
            this.lblTeaSize.AutoSize = true;
            this.lblTeaSize.BackColor = System.Drawing.Color.Transparent;
            this.lblTeaSize.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeaSize.ForeColor = System.Drawing.Color.White;
            this.lblTeaSize.Location = new System.Drawing.Point(178, 281);
            this.lblTeaSize.Name = "lblTeaSize";
            this.lblTeaSize.Size = new System.Drawing.Size(87, 36);
            this.lblTeaSize.TabIndex = 6;
            this.lblTeaSize.Text = "Size:";
            // 
            // rdbTeaSmall
            // 
            this.rdbTeaSmall.AutoSize = true;
            this.rdbTeaSmall.BackColor = System.Drawing.Color.Transparent;
            this.rdbTeaSmall.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTeaSmall.ForeColor = System.Drawing.Color.White;
            this.rdbTeaSmall.Location = new System.Drawing.Point(315, 281);
            this.rdbTeaSmall.Name = "rdbTeaSmall";
            this.rdbTeaSmall.Size = new System.Drawing.Size(115, 36);
            this.rdbTeaSmall.TabIndex = 7;
            this.rdbTeaSmall.TabStop = true;
            this.rdbTeaSmall.Text = "Small";
            this.rdbTeaSmall.UseVisualStyleBackColor = false;
            // 
            // rdbTeaMedium
            // 
            this.rdbTeaMedium.AutoSize = true;
            this.rdbTeaMedium.BackColor = System.Drawing.Color.Transparent;
            this.rdbTeaMedium.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTeaMedium.ForeColor = System.Drawing.Color.White;
            this.rdbTeaMedium.Location = new System.Drawing.Point(472, 281);
            this.rdbTeaMedium.Name = "rdbTeaMedium";
            this.rdbTeaMedium.Size = new System.Drawing.Size(149, 36);
            this.rdbTeaMedium.TabIndex = 8;
            this.rdbTeaMedium.TabStop = true;
            this.rdbTeaMedium.Text = "Medium";
            this.rdbTeaMedium.UseVisualStyleBackColor = false;
            // 
            // rdbTeaLarge
            // 
            this.rdbTeaLarge.AutoSize = true;
            this.rdbTeaLarge.BackColor = System.Drawing.Color.Transparent;
            this.rdbTeaLarge.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTeaLarge.ForeColor = System.Drawing.Color.White;
            this.rdbTeaLarge.Location = new System.Drawing.Point(661, 281);
            this.rdbTeaLarge.Name = "rdbTeaLarge";
            this.rdbTeaLarge.Size = new System.Drawing.Size(113, 36);
            this.rdbTeaLarge.TabIndex = 9;
            this.rdbTeaLarge.TabStop = true;
            this.rdbTeaLarge.Text = "Large";
            this.rdbTeaLarge.UseVisualStyleBackColor = false;
            // 
            // lblTeaQuantity
            // 
            this.lblTeaQuantity.AutoSize = true;
            this.lblTeaQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblTeaQuantity.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeaQuantity.ForeColor = System.Drawing.Color.White;
            this.lblTeaQuantity.Location = new System.Drawing.Point(178, 360);
            this.lblTeaQuantity.Name = "lblTeaQuantity";
            this.lblTeaQuantity.Size = new System.Drawing.Size(194, 36);
            this.lblTeaQuantity.TabIndex = 10;
            this.lblTeaQuantity.Text = "How many?";
            // 
            // nudTeaQuantity
            // 
            this.nudTeaQuantity.Location = new System.Drawing.Point(380, 372);
            this.nudTeaQuantity.Name = "nudTeaQuantity";
            this.nudTeaQuantity.Size = new System.Drawing.Size(191, 26);
            this.nudTeaQuantity.TabIndex = 11;
            // 
            // btnTeaAdd
            // 
            this.btnTeaAdd.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeaAdd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTeaAdd.Location = new System.Drawing.Point(472, 488);
            this.btnTeaAdd.Name = "btnTeaAdd";
            this.btnTeaAdd.Size = new System.Drawing.Size(226, 73);
            this.btnTeaAdd.TabIndex = 12;
            this.btnTeaAdd.Text = "Add To Cart";
            this.btnTeaAdd.UseVisualStyleBackColor = true;
            this.btnTeaAdd.Click += new System.EventHandler(this.btnTeaAdd_Click);
            // 
            // frmTea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assessment1_Practical_37489917_37818430.Properties.Resources.Tea;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2292, 1145);
            this.Controls.Add(this.btnTeaAdd);
            this.Controls.Add(this.nudTeaQuantity);
            this.Controls.Add(this.lblTeaQuantity);
            this.Controls.Add(this.rdbTeaLarge);
            this.Controls.Add(this.rdbTeaMedium);
            this.Controls.Add(this.rdbTeaSmall);
            this.Controls.Add(this.lblTeaSize);
            this.Controls.Add(this.cmbTeaType);
            this.Controls.Add(this.lblTeaType);
            this.Controls.Add(this.lblTeaTitle);
            this.Name = "frmTea";
            this.Text = "Tea";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTeaQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeaTitle;
        private System.Windows.Forms.Label lblTeaType;
        private System.Windows.Forms.ComboBox cmbTeaType;
        private System.Windows.Forms.Label lblTeaSize;
        private System.Windows.Forms.RadioButton rdbTeaSmall;
        private System.Windows.Forms.RadioButton rdbTeaMedium;
        private System.Windows.Forms.RadioButton rdbTeaLarge;
        private System.Windows.Forms.Label lblTeaQuantity;
        private System.Windows.Forms.NumericUpDown nudTeaQuantity;
        private System.Windows.Forms.Button btnTeaAdd;
    }
}