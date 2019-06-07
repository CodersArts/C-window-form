namespace Ass9
{
    partial class Form1
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
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblVIN = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.chkBoxNewCar = new System.Windows.Forms.CheckBox();
            this.btnSaveInventory = new System.Windows.Forms.Button();
            this.btnCheckInventory = new System.Windows.Forms.Button();
            this.btnClearForms = new System.Windows.Forms.Button();
            this.btnDeleteInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(175, 58);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(175, 112);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 1;
            this.lblMake.Text = "Make";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(175, 163);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(175, 214);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(44, 13);
            this.lblMileage.TabIndex = 3;
            this.lblMileage.Text = "Mileage";
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Location = new System.Drawing.Point(175, 270);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(81, 13);
            this.lblVIN.TabIndex = 4;
            this.lblVIN.Text = "VIN (last 4 digit)";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(357, 58);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(141, 20);
            this.txtYear.TabIndex = 5;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(357, 112);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(141, 20);
            this.txtMake.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(357, 163);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(141, 20);
            this.txtModel.TabIndex = 7;
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(357, 214);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(141, 20);
            this.txtMileage.TabIndex = 8;
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(357, 263);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(141, 20);
            this.txtVIN.TabIndex = 9;
            // 
            // chkBoxNewCar
            // 
            this.chkBoxNewCar.AutoSize = true;
            this.chkBoxNewCar.Location = new System.Drawing.Point(660, 217);
            this.chkBoxNewCar.Name = "chkBoxNewCar";
            this.chkBoxNewCar.Size = new System.Drawing.Size(67, 17);
            this.chkBoxNewCar.TabIndex = 10;
            this.chkBoxNewCar.Text = "New Car";
            this.chkBoxNewCar.UseVisualStyleBackColor = true;
            this.chkBoxNewCar.CheckedChanged += new System.EventHandler(this.chkBoxNewCar_CheckedChanged);
            // 
            // btnSaveInventory
            // 
            this.btnSaveInventory.Location = new System.Drawing.Point(181, 345);
            this.btnSaveInventory.Name = "btnSaveInventory";
            this.btnSaveInventory.Size = new System.Drawing.Size(75, 43);
            this.btnSaveInventory.TabIndex = 11;
            this.btnSaveInventory.Text = "Save To Inventory";
            this.btnSaveInventory.UseVisualStyleBackColor = true;
            this.btnSaveInventory.Click += new System.EventHandler(this.btnSaveInventory_Click);
            // 
            // btnCheckInventory
            // 
            this.btnCheckInventory.Location = new System.Drawing.Point(357, 345);
            this.btnCheckInventory.Name = "btnCheckInventory";
            this.btnCheckInventory.Size = new System.Drawing.Size(75, 43);
            this.btnCheckInventory.TabIndex = 12;
            this.btnCheckInventory.Text = "Check Inventory";
            this.btnCheckInventory.UseVisualStyleBackColor = true;
            this.btnCheckInventory.Click += new System.EventHandler(this.btnCheckInventory_Click);
            // 
            // btnClearForms
            // 
            this.btnClearForms.Location = new System.Drawing.Point(505, 345);
            this.btnClearForms.Name = "btnClearForms";
            this.btnClearForms.Size = new System.Drawing.Size(75, 43);
            this.btnClearForms.TabIndex = 13;
            this.btnClearForms.Text = "Clear Forms";
            this.btnClearForms.UseVisualStyleBackColor = true;
            this.btnClearForms.Click += new System.EventHandler(this.btnClearForms_Click);
            // 
            // btnDeleteInventory
            // 
            this.btnDeleteInventory.Location = new System.Drawing.Point(660, 345);
            this.btnDeleteInventory.Name = "btnDeleteInventory";
            this.btnDeleteInventory.Size = new System.Drawing.Size(75, 43);
            this.btnDeleteInventory.TabIndex = 14;
            this.btnDeleteInventory.Text = "Delete From Inventory";
            this.btnDeleteInventory.UseVisualStyleBackColor = true;
            this.btnDeleteInventory.Click += new System.EventHandler(this.btnDeleteInventory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteInventory);
            this.Controls.Add(this.btnClearForms);
            this.Controls.Add(this.btnCheckInventory);
            this.Controls.Add(this.btnSaveInventory);
            this.Controls.Add(this.chkBoxNewCar);
            this.Controls.Add(this.txtVIN);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblVIN);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblYear);
            this.Name = "Form1";
            this.Text = "Vehicle Inventory System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.CheckBox chkBoxNewCar;
        private System.Windows.Forms.Button btnSaveInventory;
        private System.Windows.Forms.Button btnCheckInventory;
        private System.Windows.Forms.Button btnClearForms;
        private System.Windows.Forms.Button btnDeleteInventory;
    }
}

