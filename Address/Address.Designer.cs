﻿namespace Address
{
    partial class frmAddress
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblAptNumber = new System.Windows.Forms.Label();
            this.txtAptNumber = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAddress = new System.Windows.Forms.Button();
            this.cboProvinces = new System.Windows.Forms.ComboBox();
            this.lblStreetType = new System.Windows.Forms.Label();
            this.cboStreetType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(46, 13);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(175, 16);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Input your address here:";
            // 
            // lblAptNumber
            // 
            this.lblAptNumber.AutoSize = true;
            this.lblAptNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAptNumber.Location = new System.Drawing.Point(21, 52);
            this.lblAptNumber.Name = "lblAptNumber";
            this.lblAptNumber.Size = new System.Drawing.Size(85, 16);
            this.lblAptNumber.TabIndex = 1;
            this.lblAptNumber.Text = "Apt. Number:";
            // 
            // txtAptNumber
            // 
            this.txtAptNumber.Location = new System.Drawing.Point(118, 51);
            this.txtAptNumber.Name = "txtAptNumber";
            this.txtAptNumber.Size = new System.Drawing.Size(137, 20);
            this.txtAptNumber.TabIndex = 2;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(118, 77);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(137, 20);
            this.txtStreetAddress.TabIndex = 4;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.Location = new System.Drawing.Point(12, 78);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(100, 16);
            this.lblStreetAddress.TabIndex = 3;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(118, 132);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(137, 20);
            this.txtCity.TabIndex = 6;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(45, 133);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(33, 16);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(29, 159);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(64, 16);
            this.lblProvince.TabIndex = 7;
            this.lblProvince.Text = "Province:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(118, 184);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(137, 20);
            this.txtPostalCode.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Postal Code:";
            // 
            // btnShowAddress
            // 
            this.btnShowAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAddress.Location = new System.Drawing.Point(79, 220);
            this.btnShowAddress.Name = "btnShowAddress";
            this.btnShowAddress.Size = new System.Drawing.Size(108, 27);
            this.btnShowAddress.TabIndex = 11;
            this.btnShowAddress.Text = "Show Address";
            this.btnShowAddress.UseVisualStyleBackColor = true;
            this.btnShowAddress.Click += new System.EventHandler(this.btnShowAddress_Click);
            // 
            // cboProvinces
            // 
            this.cboProvinces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvinces.FormattingEnabled = true;
            this.cboProvinces.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NS",
            "NT",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.cboProvinces.Location = new System.Drawing.Point(118, 157);
            this.cboProvinces.Name = "cboProvinces";
            this.cboProvinces.Size = new System.Drawing.Size(137, 21);
            this.cboProvinces.TabIndex = 12;
            // 
            // lblStreetType
            // 
            this.lblStreetType.AutoSize = true;
            this.lblStreetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetType.Location = new System.Drawing.Point(12, 107);
            this.lblStreetType.Name = "lblStreetType";
            this.lblStreetType.Size = new System.Drawing.Size(81, 16);
            this.lblStreetType.TabIndex = 13;
            this.lblStreetType.Text = "Street Type:";
            // 
            // cboStreetType
            // 
            this.cboStreetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStreetType.FormattingEnabled = true;
            this.cboStreetType.Items.AddRange(new object[] {
            "Dr",
            "St",
            "Ave",
            "Cres",
            "Blvd"});
            this.cboStreetType.Location = new System.Drawing.Point(118, 103);
            this.cboStreetType.Name = "cboStreetType";
            this.cboStreetType.Size = new System.Drawing.Size(137, 21);
            this.cboStreetType.TabIndex = 14;
            // 
            // frmAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 252);
            this.Controls.Add(this.cboStreetType);
            this.Controls.Add(this.lblStreetType);
            this.Controls.Add(this.cboProvinces);
            this.Controls.Add(this.btnShowAddress);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.txtAptNumber);
            this.Controls.Add(this.lblAptNumber);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmAddress";
            this.Text = "Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblAptNumber;
        private System.Windows.Forms.TextBox txtAptNumber;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAddress;
        private System.Windows.Forms.ComboBox cboProvinces;
        private System.Windows.Forms.Label lblStreetType;
        private System.Windows.Forms.ComboBox cboStreetType;
    }
}

