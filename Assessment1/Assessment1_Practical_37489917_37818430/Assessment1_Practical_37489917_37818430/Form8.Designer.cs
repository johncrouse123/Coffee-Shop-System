
namespace Assessment1_Practical_37489917_37818430
{
    partial class frmDatabase
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.lblDatabaseTitle = new System.Windows.Forms.Label();
            this.btnInsertItems = new System.Windows.Forms.Button();
            this.lblDeleteItems = new System.Windows.Forms.Label();
            this.cmbDeleteItems = new System.Windows.Forms.ComboBox();
            this.cmbUpdateItems = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(12, 110);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 62;
            this.dgvItems.RowTemplate.Height = 28;
            this.dgvItems.Size = new System.Drawing.Size(929, 531);
            this.dgvItems.TabIndex = 0;
            // 
            // lblDatabaseTitle
            // 
            this.lblDatabaseTitle.AutoSize = true;
            this.lblDatabaseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseTitle.Location = new System.Drawing.Point(484, 9);
            this.lblDatabaseTitle.Name = "lblDatabaseTitle";
            this.lblDatabaseTitle.Size = new System.Drawing.Size(419, 82);
            this.lblDatabaseTitle.TabIndex = 8;
            this.lblDatabaseTitle.Text = "DATABASE";
            // 
            // btnInsertItems
            // 
            this.btnInsertItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertItems.Location = new System.Drawing.Point(1004, 110);
            this.btnInsertItems.Name = "btnInsertItems";
            this.btnInsertItems.Size = new System.Drawing.Size(246, 65);
            this.btnInsertItems.TabIndex = 9;
            this.btnInsertItems.Text = "Insert Items";
            this.btnInsertItems.UseVisualStyleBackColor = true;
            this.btnInsertItems.Click += new System.EventHandler(this.btnInsertItems_Click);
            // 
            // lblDeleteItems
            // 
            this.lblDeleteItems.AutoSize = true;
            this.lblDeleteItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteItems.Location = new System.Drawing.Point(997, 218);
            this.lblDeleteItems.Name = "lblDeleteItems";
            this.lblDeleteItems.Size = new System.Drawing.Size(202, 37);
            this.lblDeleteItems.TabIndex = 10;
            this.lblDeleteItems.Text = "Delete Items:";
            // 
            // cmbDeleteItems
            // 
            this.cmbDeleteItems.FormattingEnabled = true;
            this.cmbDeleteItems.Location = new System.Drawing.Point(1004, 283);
            this.cmbDeleteItems.Name = "cmbDeleteItems";
            this.cmbDeleteItems.Size = new System.Drawing.Size(246, 28);
            this.cmbDeleteItems.TabIndex = 11;
            this.cmbDeleteItems.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteItems_SelectedIndexChanged);
            // 
            // cmbUpdateItems
            // 
            this.cmbUpdateItems.FormattingEnabled = true;
            this.cmbUpdateItems.Location = new System.Drawing.Point(1004, 582);
            this.cmbUpdateItems.Name = "cmbUpdateItems";
            this.cmbUpdateItems.Size = new System.Drawing.Size(246, 28);
            this.cmbUpdateItems.TabIndex = 12;
            this.cmbUpdateItems.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateItems_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(997, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Update Items:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(1004, 467);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(246, 26);
            this.txtQuantity.TabIndex = 14;
            this.txtQuantity.Text = "0";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(999, 421);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(91, 25);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(999, 525);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(63, 25);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Type:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1004, 643);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(246, 80);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 757);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUpdateItems);
            this.Controls.Add(this.cmbDeleteItems);
            this.Controls.Add(this.lblDeleteItems);
            this.Controls.Add(this.btnInsertItems);
            this.Controls.Add(this.lblDatabaseTitle);
            this.Controls.Add(this.dgvItems);
            this.Name = "frmDatabase";
            this.Text = "Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lblDatabaseTitle;
        private System.Windows.Forms.Button btnInsertItems;
        private System.Windows.Forms.Label lblDeleteItems;
        private System.Windows.Forms.ComboBox cmbDeleteItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblType;
        public System.Windows.Forms.ComboBox cmbUpdateItems;
        public System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnUpdate;
    }
}