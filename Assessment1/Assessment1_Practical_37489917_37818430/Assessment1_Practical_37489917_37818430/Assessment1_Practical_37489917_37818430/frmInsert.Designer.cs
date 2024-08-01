
namespace Assessment1_Practical_37489917_37818430
{
    partial class frmInsert
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
            this.lblTitleItems = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rdbBest = new System.Windows.Forms.RadioButton();
            this.rdbSold = new System.Windows.Forms.RadioButton();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitleItems
            // 
            this.lblTitleItems.AutoSize = true;
            this.lblTitleItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleItems.Location = new System.Drawing.Point(150, 41);
            this.lblTitleItems.Name = "lblTitleItems";
            this.lblTitleItems.Size = new System.Drawing.Size(390, 59);
            this.lblTitleItems.TabIndex = 9;
            this.lblTitleItems.Text = "INSERT ITEMS";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(74, 125);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(96, 37);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "Type:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(281, 135);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(237, 26);
            this.txtType.TabIndex = 11;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(74, 188);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(145, 37);
            this.lblQuantity.TabIndex = 16;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(205, 388);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(270, 80);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(74, 256);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(117, 37);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status:";
            // 
            // rdbBest
            // 
            this.rdbBest.AutoSize = true;
            this.rdbBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBest.Location = new System.Drawing.Point(281, 256);
            this.rdbBest.Name = "rdbBest";
            this.rdbBest.Size = new System.Drawing.Size(167, 33);
            this.rdbBest.TabIndex = 20;
            this.rdbBest.TabStop = true;
            this.rdbBest.Text = "Best Selling";
            this.rdbBest.UseVisualStyleBackColor = true;
            // 
            // rdbSold
            // 
            this.rdbSold.AutoSize = true;
            this.rdbSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSold.Location = new System.Drawing.Point(467, 260);
            this.rdbSold.Name = "rdbSold";
            this.rdbSold.Size = new System.Drawing.Size(132, 33);
            this.rdbSold.TabIndex = 21;
            this.rdbSold.TabStop = true;
            this.rdbSold.Text = "Sold Out";
            this.rdbSold.UseVisualStyleBackColor = true;
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.lblSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecial.Location = new System.Drawing.Point(74, 325);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(130, 37);
            this.lblSpecial.TabIndex = 22;
            this.lblSpecial.Text = "Special:";
            // 
            // txtSpecial
            // 
            this.txtSpecial.Location = new System.Drawing.Point(281, 325);
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Size = new System.Drawing.Size(237, 26);
            this.txtSpecial.TabIndex = 23;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(281, 198);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(237, 26);
            this.txtQuantity.TabIndex = 24;
            // 
            // frmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 480);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtSpecial);
            this.Controls.Add(this.lblSpecial);
            this.Controls.Add(this.rdbSold);
            this.Controls.Add(this.rdbBest);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTitleItems);
            this.Name = "frmInsert";
            this.Text = "Insert Items";
            this.Load += new System.EventHandler(this.frmInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleItems;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rdbBest;
        private System.Windows.Forms.RadioButton rdbSold;
        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.TextBox txtSpecial;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}