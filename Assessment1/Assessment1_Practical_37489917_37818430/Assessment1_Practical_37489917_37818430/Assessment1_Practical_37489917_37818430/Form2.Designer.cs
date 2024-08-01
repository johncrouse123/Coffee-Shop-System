
namespace Assessment1_Practical_37489917_37818430
{
    partial class frmCoffee
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
            this.lblCoffeeTitle = new System.Windows.Forms.Label();
            this.lblCoffeeType = new System.Windows.Forms.Label();
            this.lblCoffeeQuantity = new System.Windows.Forms.Label();
            this.cmbCoffeeType = new System.Windows.Forms.ComboBox();
            this.nudCoffeeQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblCoffeeSize = new System.Windows.Forms.Label();
            this.rdbCoffeeSmall = new System.Windows.Forms.RadioButton();
            this.rdbCoffeeMedium = new System.Windows.Forms.RadioButton();
            this.rdbCoffeeLarge = new System.Windows.Forms.RadioButton();
            this.btnCoffeeAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoffeeQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCoffeeTitle
            // 
            this.lblCoffeeTitle.AutoSize = true;
            this.lblCoffeeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCoffeeTitle.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeTitle.ForeColor = System.Drawing.Color.White;
            this.lblCoffeeTitle.Location = new System.Drawing.Point(452, 67);
            this.lblCoffeeTitle.Name = "lblCoffeeTitle";
            this.lblCoffeeTitle.Size = new System.Drawing.Size(319, 87);
            this.lblCoffeeTitle.TabIndex = 0;
            this.lblCoffeeTitle.Text = "Coffee";
            // 
            // lblCoffeeType
            // 
            this.lblCoffeeType.AutoSize = true;
            this.lblCoffeeType.BackColor = System.Drawing.Color.Transparent;
            this.lblCoffeeType.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeType.ForeColor = System.Drawing.Color.White;
            this.lblCoffeeType.Location = new System.Drawing.Point(159, 194);
            this.lblCoffeeType.Name = "lblCoffeeType";
            this.lblCoffeeType.Size = new System.Drawing.Size(128, 36);
            this.lblCoffeeType.TabIndex = 1;
            this.lblCoffeeType.Text = "Coffee:";
            // 
            // lblCoffeeQuantity
            // 
            this.lblCoffeeQuantity.AutoSize = true;
            this.lblCoffeeQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblCoffeeQuantity.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeQuantity.ForeColor = System.Drawing.Color.White;
            this.lblCoffeeQuantity.Location = new System.Drawing.Point(159, 353);
            this.lblCoffeeQuantity.Name = "lblCoffeeQuantity";
            this.lblCoffeeQuantity.Size = new System.Drawing.Size(194, 36);
            this.lblCoffeeQuantity.TabIndex = 2;
            this.lblCoffeeQuantity.Text = "How many?";
            // 
            // cmbCoffeeType
            // 
            this.cmbCoffeeType.FormattingEnabled = true;
            this.cmbCoffeeType.Items.AddRange(new object[] {
            "Latte",
            "Cappuccino",
            "Americano",
            "Espresso",
            "Mocha"});
            this.cmbCoffeeType.Location = new System.Drawing.Point(378, 205);
            this.cmbCoffeeType.Name = "cmbCoffeeType";
            this.cmbCoffeeType.Size = new System.Drawing.Size(191, 28);
            this.cmbCoffeeType.TabIndex = 3;
            // 
            // nudCoffeeQuantity
            // 
            this.nudCoffeeQuantity.Location = new System.Drawing.Point(378, 365);
            this.nudCoffeeQuantity.Name = "nudCoffeeQuantity";
            this.nudCoffeeQuantity.Size = new System.Drawing.Size(191, 26);
            this.nudCoffeeQuantity.TabIndex = 4;
            // 
            // lblCoffeeSize
            // 
            this.lblCoffeeSize.AutoSize = true;
            this.lblCoffeeSize.BackColor = System.Drawing.Color.Transparent;
            this.lblCoffeeSize.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeSize.ForeColor = System.Drawing.Color.White;
            this.lblCoffeeSize.Location = new System.Drawing.Point(159, 270);
            this.lblCoffeeSize.Name = "lblCoffeeSize";
            this.lblCoffeeSize.Size = new System.Drawing.Size(87, 36);
            this.lblCoffeeSize.TabIndex = 5;
            this.lblCoffeeSize.Text = "Size:";
            // 
            // rdbCoffeeSmall
            // 
            this.rdbCoffeeSmall.AutoSize = true;
            this.rdbCoffeeSmall.BackColor = System.Drawing.Color.Transparent;
            this.rdbCoffeeSmall.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCoffeeSmall.ForeColor = System.Drawing.Color.White;
            this.rdbCoffeeSmall.Location = new System.Drawing.Point(307, 272);
            this.rdbCoffeeSmall.Name = "rdbCoffeeSmall";
            this.rdbCoffeeSmall.Size = new System.Drawing.Size(115, 36);
            this.rdbCoffeeSmall.TabIndex = 6;
            this.rdbCoffeeSmall.TabStop = true;
            this.rdbCoffeeSmall.Text = "Small";
            this.rdbCoffeeSmall.UseVisualStyleBackColor = false;
            // 
            // rdbCoffeeMedium
            // 
            this.rdbCoffeeMedium.AutoSize = true;
            this.rdbCoffeeMedium.BackColor = System.Drawing.Color.Transparent;
            this.rdbCoffeeMedium.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCoffeeMedium.ForeColor = System.Drawing.Color.White;
            this.rdbCoffeeMedium.Location = new System.Drawing.Point(467, 272);
            this.rdbCoffeeMedium.Name = "rdbCoffeeMedium";
            this.rdbCoffeeMedium.Size = new System.Drawing.Size(149, 36);
            this.rdbCoffeeMedium.TabIndex = 7;
            this.rdbCoffeeMedium.TabStop = true;
            this.rdbCoffeeMedium.Text = "Medium";
            this.rdbCoffeeMedium.UseVisualStyleBackColor = false;
            // 
            // rdbCoffeeLarge
            // 
            this.rdbCoffeeLarge.AutoSize = true;
            this.rdbCoffeeLarge.BackColor = System.Drawing.Color.Transparent;
            this.rdbCoffeeLarge.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCoffeeLarge.ForeColor = System.Drawing.Color.White;
            this.rdbCoffeeLarge.Location = new System.Drawing.Point(658, 272);
            this.rdbCoffeeLarge.Name = "rdbCoffeeLarge";
            this.rdbCoffeeLarge.Size = new System.Drawing.Size(113, 36);
            this.rdbCoffeeLarge.TabIndex = 8;
            this.rdbCoffeeLarge.TabStop = true;
            this.rdbCoffeeLarge.Text = "Large";
            this.rdbCoffeeLarge.UseVisualStyleBackColor = false;
            // 
            // btnCoffeeAdd
            // 
            this.btnCoffeeAdd.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffeeAdd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCoffeeAdd.Location = new System.Drawing.Point(467, 484);
            this.btnCoffeeAdd.Name = "btnCoffeeAdd";
            this.btnCoffeeAdd.Size = new System.Drawing.Size(226, 73);
            this.btnCoffeeAdd.TabIndex = 9;
            this.btnCoffeeAdd.Text = "Add To Cart";
            this.btnCoffeeAdd.UseVisualStyleBackColor = true;
            this.btnCoffeeAdd.Click += new System.EventHandler(this.btnCoffeeAdd_Click);
            // 
            // frmCoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assessment1_Practical_37489917_37818430.Properties.Resources.Coffe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2292, 1158);
            this.Controls.Add(this.btnCoffeeAdd);
            this.Controls.Add(this.rdbCoffeeLarge);
            this.Controls.Add(this.rdbCoffeeMedium);
            this.Controls.Add(this.rdbCoffeeSmall);
            this.Controls.Add(this.lblCoffeeSize);
            this.Controls.Add(this.nudCoffeeQuantity);
            this.Controls.Add(this.cmbCoffeeType);
            this.Controls.Add(this.lblCoffeeQuantity);
            this.Controls.Add(this.lblCoffeeType);
            this.Controls.Add(this.lblCoffeeTitle);
            this.Name = "frmCoffee";
            this.Text = "Coffee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCoffee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCoffeeQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoffeeTitle;
        private System.Windows.Forms.Label lblCoffeeType;
        private System.Windows.Forms.Label lblCoffeeQuantity;
        private System.Windows.Forms.ComboBox cmbCoffeeType;
        private System.Windows.Forms.NumericUpDown nudCoffeeQuantity;
        private System.Windows.Forms.Label lblCoffeeSize;
        private System.Windows.Forms.RadioButton rdbCoffeeSmall;
        private System.Windows.Forms.RadioButton rdbCoffeeMedium;
        private System.Windows.Forms.RadioButton rdbCoffeeLarge;
        private System.Windows.Forms.Button btnCoffeeAdd;
    }
}